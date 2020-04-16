using MoneyScoop.Model.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MoneyScoop.Model
{
    public class DataSource
    {
        // Singleton
        private static readonly DataSource INSTANCE = new DataSource();
        public static DataSource Ds { get { return INSTANCE; } }

        // Variables
        private IDictionary<Type, IDataList> cache;
        private INotifyDataChanged dataListener;
        private IDataInvoker dataInvoker;

        
        private DataSource()
        {
            cache = new Dictionary<Type, IDataList>
            {
                { typeof(Invoice), new DataList<Invoice>() },
                { typeof(InvoiceLine), new DataList<InvoiceLine>() },
                { typeof(Customer), new DataList<Customer>() }
            };
        }

        public IEnumerable<Invoice> ThisYearsIncomingInvoices
        {
            get
            {
                int year = DateTime.Now.Year;
                return Invoices.Where(i => 
                    !i.OutGoing &&    
                    i.DateCreated.Year == year);
            }
        }

        public int NextInvoiceNumber
        {
            get
            {
                IEnumerable<Invoice> invoices = ThisYearsIncomingInvoices;
                if (invoices != null)
                {
                    return invoices.Count() + 1;
                }
                return 1;
            }
        }

        #region DataSource Methods

        public virtual void AttachListener(INotifyDataChanged dataListener)
        {
            this.dataListener = dataListener;
        }

        public void AttachInvoker(IDataInvoker dataInvoker)
        {
            this.dataInvoker = dataInvoker;
        }

        protected DataList<T> GetList<T>(DataList<T> dataList, Func<IEnumerable<T>> fetchMethod) where T : ISaveableObject
        {
            if (!dataList.IsFetched)
            {
                long start = Stopwatch.GetTimestamp();
                IEnumerable<T> values = fetchMethod();
                long stop = Stopwatch.GetTimestamp();

                dataList.Set(values, stop - start);
            }
            return dataList;
        }

        public IEnumerable<TObject> FetchAllFromDb<TObject>()
            where TObject : BaseObject, new()
        {
            return new List<TObject>(Context.Ctx.Db.SelectAll<TObject>());
        }

        #endregion
        
        #region Data Lists

        public DataList<Invoice> Invoices { get { return GetList(GetCachedList<Invoice>(), () => FetchAllFromDb<Invoice>()); } }
        public DataList<InvoiceLine> InvoiceLines { get { return GetList(GetCachedList<InvoiceLine>(), () => FetchAllFromDb<InvoiceLine>()); } }
        public DataList<Customer> Customers { get { return GetList(GetCachedList<Customer>(), () => FetchAllFromDb<Customer>()); } }
        
        #endregion

        #region Data Changed

        public void OnInserted<T>(T obj) where T : ISaveableObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoInsert(obj));
            }
            else
            {
                DoInsert(obj);
            }
        }

        protected void DoInsert<T>(T obj) where T : ISaveableObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Add(obj))
                {
                    dataListener?.NotifyInsert(obj);
                }
            }
            else
            {
                dataListener?.NotifyInsert(obj);
            }
        }

        public void OnUpdated<T>(T obj) where T : ISaveableObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoUpdate(obj));
            }
            else
            {
                DoUpdate(obj);
            }
        }

        protected void DoUpdate<T>(T obj) where T : ISaveableObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Update(obj))
                {
                    dataListener?.NotifyUpdate(obj);
                }
            }
            else
            {
                dataListener?.NotifyUpdate(obj);
            }
        }

        public void OnDeleted<T>(T obj) where T : ISaveableObject
        {
            if (dataInvoker != null)
            {
                dataInvoker.InvokeOnMain(() => DoDelete(obj));
            }
            else
            {
                DoDelete(obj);
            }
        }

        protected void DoDelete<T>(T obj) where T : ISaveableObject
        {
            DataList<T> list = GetCachedList<T>();
            if (list != null)
            {
                if (list.Remove(obj))
                {
                    dataListener?.NotifyDelete(obj);
                }
            }
            else
            {
                dataListener?.NotifyDelete(obj);
            }
        }

        protected DataList<T> GetCachedList<T>() where T : ISaveableObject
        {
            cache.TryGetValue(typeof(T), out IDataList list);
            return list as DataList<T>;
        }

        public bool CodeExists<T>(string code) where T : ISaveableObject, new()
        {
            DataList<T> dataList = GetCachedList<T>();
            return dataList != null && dataList.ByCode(code) != null;
        }

        public T ById<T>(long id) where T : ISaveableObject, new()
        {
            DataList<T> dataList = GetCachedList<T>();
            return dataList != null ? dataList.ById(id) : default(T);
        }

        public T ByCode<T>(string code) where T : ISaveableObject, new()
        {
            DataList<T> dataList = GetCachedList<T>();
            return dataList != null ? dataList.ByCode(code) : default(T);
        }

        #endregion
    }
}
