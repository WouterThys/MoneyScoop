using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Database
{
    public class DbUnitOfWork
    {
        public IDbInstance Instance { get; set; }
        public ActionType ActionType { get; set; }
        public Action Action { get; set; }
        public DbUnitOfWork(IDbInstance instance, ActionType actionType)
        {
            Instance = instance;
            ActionType = actionType;
        }
        public DbUnitOfWork(Action action)
        {
            Instance = null;
            Action = action;
        }

        public override string ToString()
        {
            return ActionType.ToString() + " " + Instance;
        }
    }

    public class DbWorkLoad
    {
        private const string TAG = "WL";

        private readonly Queue<DbUnitOfWork> queue = new Queue<DbUnitOfWork>();
        private readonly Func<DbConnection> _GetConnection;
        private readonly Action<IDbInstance, ActionType, DbConnection> _HandleObject;

        internal DbWorkLoad(
            Func<DbConnection> getConnection,
            Action<IDbInstance, ActionType, DbConnection> handleObject
            )
        {
            _GetConnection = getConnection;
            _HandleObject = handleObject;
        }

        public void Execute()
        {
            int count = 0;
            if (HasMoreWork)
            {
                using (DbConnection connection = _GetConnection())
                {
                    connection.Open();
                    using (DbTransaction transaction = connection.BeginTransaction())
                    {
                        while (HasMoreWork)
                        {
                            var unitOfWork = Pop();
                            if (unitOfWork.Action == null)
                            {
                                _HandleObject(unitOfWork.Instance, unitOfWork.ActionType, connection);
                            }
                            else
                            {
                                unitOfWork.Action();
                            }
                            count++;
                        }
                        transaction.Commit();
                    }
                }
            }
        }

        public DbUnitOfWork Pop()
        {
            return queue.Dequeue();
        }

        public bool HasMoreWork => queue.Count > 0;

        #region Fill Queue

        public DbWorkLoad Save(IDbInstance instance)
        {
            if (instance.Id > 1)
            {
                return Update(instance);
            }
            else
            {
                return Insert(instance);
            }
        }

        public DbWorkLoad Insert(IDbInstance instance)
        {
            return Add(instance, ActionType.Insert);
        }

        public DbWorkLoad Update(IDbInstance instance)
        {
            return Add(instance, ActionType.Update);
        }

        public DbWorkLoad Delete(IDbInstance instance)
        {
            return Add(instance, ActionType.Delete);
        }

        public DbWorkLoad Action(Action action)
        {
            return Add(action);
        }

        private DbWorkLoad Add(IDbInstance instance, ActionType actionType)
        {
            if (instance != null)
            {
                queue.Enqueue(new DbUnitOfWork(instance, actionType));
            }
            return this;
        }

        private DbWorkLoad Add(Action action)
        {
            if (action != null)
            {
                queue.Enqueue(new DbUnitOfWork(action));
            }
            return this;
        }

        #endregion
    }
}
