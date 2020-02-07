using System.Data.Common;
using System.Threading.Tasks;

namespace Database
{
    public enum ActionType
    {
        CacheCleared = -2,
        Unknown = -1,
        Insert = 0,
        Update = 1,
        Delete = 2,
        SelectAll = 3,
        SelectById = 4,
        SaveCustomValue = 5,
        LoadStoredProcedure = 6,
        Custom = 10,
        InsertObjectLog = 20
    }

    public enum LoggingLevel
    {
        None,
        Some,
        Insane
    }
    
    public enum DbState
    {
        InTheVoid = 0,
        Initializing,
        Initialized,
        Updating,
        Updated,
        Running,
        Error
    }

    public interface IDbObject : IDbInstance
    {
        string Code { get; set; }
    }

    public interface IDbLink : IDbInstance
    {
        IDbInstance PrimaryKey { get; }
        IDbInstance ForeignKey { get; }

        string PrimaryKeyName { get; }
        string ForeignKeyName { get; }
    }

    public interface IDbObjectLogger
    {
        string GetLogScript(ActionType actionType);
        void AddLogParameters(DbCommand command);
    }

    public interface IDbInstance : IScripting, IDbSavable
    {
        long Id { get; set; }
        string TableName { get; }
        bool LogAud { get; }
    }

    public interface IAction
    {
        ActionType ActionType { get; }
        long ActionBy { get; }
        long ActionOn { get; }
    }

    public interface IScripting
    {
        string GetScript(ActionType actionType);
        void AddSqlParameters(DbCommand command);
        void InitFromReader(DbDataReader reader);
    }

    public interface IDbSavable
    {
        Task Save();
        Task Delete();
        void OnFailed(DbException exception);
    }

    public interface IDatabaseAccess
    {
        void DbLogBackState(DbState dbState);
        void DbQueryFailed(DbException dbException);
        void DbLogInfo(string message);
    }

    public interface IDatabaseUpdateCallback
    {
        void DbUpdateCallback(string message);
    }
}
