using MoneyScoop.Model;
using MoneyScoop.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.Services
{
    public interface IDataChangedService : INotifyDataChanged
    {
        void AddListener<T>(IDataChanged<T> dataChanged) where T : ISaveableObject;
        void RemoveListener<T>(IDataChanged<T> dataChanged) where T : ISaveableObject;
        IEnumerable<IDataChanged<T>> GetListeners<T>() where T : ISaveableObject;
    }

    public class DataChangedService : IDataChangedService
    {
        private readonly object locker = new object();
        private readonly IDictionary<Type, List<object>> listeners = new Dictionary<Type, List<object>>();

        public void AddListener<T>(IDataChanged<T> dataChanged) where T : ISaveableObject
        {
            if (dataChanged != null)
            {
                Type t = typeof(T);
                lock (locker)
                {
                    if (!listeners.ContainsKey(t))
                    {
                        listeners.Add(t, new List<object>());
                    }
                    if (!listeners[t].Contains(dataChanged))
                    {
                        listeners[t].Add(dataChanged);
                    }
                }
            }
        }

        public void RemoveListener<T>(IDataChanged<T> dataChanged) where T : ISaveableObject
        {
            if (dataChanged != null)
            {
                Type t = typeof(T);
                lock (locker)
                {
                    if (listeners.ContainsKey(t))
                    {
                        listeners[t].Remove(dataChanged);
                    }
                }
            }
        }

        private IEnumerable<IDataChanged<T>> GetListeners<T>() where T : ISaveableObject
        {
            CleanUpListeners();
            Type t = typeof(T);
            lock (locker)
            {
                return listeners.ContainsKey(t) ?
                    listeners[t].ConvertAll((x) => (IDataChanged<T>)x) :
                    new List<IDataChanged<T>>();
            }
        }

        private void CleanUpListeners()
        {
            lock (locker)
            {
                try
                {
                    foreach (Type t in listeners.Keys)
                    {
                        listeners[t].RemoveAll(o => o == null);
                    }
                }
                catch { }
            }
        }

        public void NotifyInsert<T>(T item) where T : ISaveableObject
        {
            foreach (IDataChanged<T> listener in GetListeners<T>())
            {
                listener.OnInserted(item);
            }
        }

        public void NotifyUpdate<T>(T item) where T : ISaveableObject
        {
            foreach (IDataChanged<T> listener in GetListeners<T>())
            {
                listener.OnUpdated(item);
            }
        }

        public void NotifyDelete<T>(T item) where T : ISaveableObject
        {
            foreach (IDataChanged<T> listener in GetListeners<T>())
            {
                listener.OnDeleted(item);
            }
        }

        IEnumerable<IDataChanged<T>> IDataChangedService.GetListeners<T>()
        {
            return new List<IDataChanged<T>>(GetListeners<T>());
        }
    }
}
