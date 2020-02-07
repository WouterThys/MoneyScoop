using System;

namespace MoneyScoop.Model.Data
{
    public interface IDataInvoker
    {
        void InvokeOnMain(Action action);
    }

    public interface IDataList
    {
        string Name { get; }
        bool IsFetched { get; }
        long FetchTime { get; }
        DateTime FetchDate { get; }
        int Count { get; }
        void Clear();
    }

    public interface INotifyDataChanged
    {
        void NotifyInsert<T>(T item) where T : ISaveableObject;
        void NotifyUpdate<T>(T item) where T : ISaveableObject;
        void NotifyDelete<T>(T item) where T : ISaveableObject;
    }

    public interface IDataChanged<T> where T : ISaveableObject
    {
        void OnInserted(T inserted);
        void OnUpdated(T updated);
        void OnDeleted(T deleted);
    }
}
