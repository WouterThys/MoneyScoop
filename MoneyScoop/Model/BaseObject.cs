using Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MoneyScoop.Model
{
    public abstract class BaseObject : IBaseObject, IDbObject, INotifyPropertyChanged
    {
        public static readonly long UNKNOWN_ID = 1;
        private static int insertId = -10000;
        public static int InsertId { get { return --insertId; } }

        // Base properties
        public event PropertyChangedEventHandler PropertyChanged;
        public abstract ObjectDefinition ObjectDefinition { get; }

        protected long id = -1;
        protected string code = "";
        protected string description = "";
        protected string info = "";
        protected DateTime lastModified;

        public BaseObject(string code)
        {
            this.code = code;
            Id = InsertId;
            lastModified = DateTime.MinValue.AddYears(10);
        }

        public abstract IObject CreateCopy();

        #region Interface Methods

        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public virtual void CopyFrom(IObject toCopy)
        {
            if (toCopy != null)
            {
                Id = toCopy.Id;
                Code = toCopy.Code;
                if (toCopy is BaseObject abo)
                {
                    Description = abo.Description;
                    Info = abo.Info;
                    LastModified = abo.LastModified;
                }
            }
        }

        public virtual bool PropertiesEqual(IObject iObject)
        {
            if (iObject is BaseObject abo)
            {
                return // Don't compare Id and Key!!
                    Code == abo.Code &&
                    Description == abo.Description &&
                    Info == abo.Info
                    ;
            }
            return false;
        }
        
        public virtual bool IsUnknown()
        {
            return Id == UNKNOWN_ID;
        }

        public virtual bool IsValid()
        {
            return IsSaved;
        }

        public virtual bool CanBeAdded => !IsUnknown();

        public virtual bool CanBeEdited => !IsUnknown();

        public virtual bool CanBeDeleted => !IsUnknown();

        public virtual bool IsSaved
        {
            get { return Id > UNKNOWN_ID; }
        }

        #endregion

        #region Database

        public string TableName { get => ObjectDefinition.TableName; }
        public virtual bool LogAud { get => true; }

        public string GetScript(ActionType actionType)
        {
            string script = "";
            switch (actionType)
            {
                case ActionType.Delete:
                case ActionType.Insert:
                case ActionType.Update:
                case ActionType.SelectAll:
                    script = ObjectDefinition.TableName + actionType.ToString();
                    break;

                case ActionType.SelectById:
                    script = "object" + actionType.ToString();
                    break;
                default:
                    break;
            }
            return script;
        }

        public virtual void AddSqlParameters(DbCommand command)
        {
            // Id is set in DB
            DatabaseAccess.AddDbValue(command, "code", Code);
            DatabaseAccess.AddDbValue(command, "info", Info);
            DatabaseAccess.AddDbValue(command, "description", Description);
            DatabaseAccess.AddDbValue(command, "lastModified", LastModified);
        }

        public virtual void InitFromReader(DbDataReader reader)
        {
            Id = DatabaseAccess.RGetLong(reader, "id");
            Code = DatabaseAccess.RGetString(reader, "code");
            Info = DatabaseAccess.RGetString(reader, "info");
            Description = DatabaseAccess.RGetString(reader, "description");
            LastModified = DatabaseAccess.RGetDateTime(reader, "lastModified");
        }

        public void OnFailed(global::Database.DbException exception)
        {
            
        }

        public virtual Task Save()
        {
            if (Id <= 0)
            {
                return Task.Factory.StartNew(() =>
                {
                    Context.Ctx.Db.Insert(this);
                    OnDbActionDone(ActionType.Insert);
                });
            }
            else
            {
                return Task.Factory.StartNew(() =>
                {
                    Context.Ctx.Db.Update(this);
                    OnDbActionDone(ActionType.Update);
                });
            }
        }

        public virtual Task Delete()
        {
            if (Id > UNKNOWN_ID)
            {
                return Task.Factory.StartNew(() =>
                {
                    Context.Ctx.Db.Delete(this);
                    OnDbActionDone(ActionType.Delete);
                });
            }
            return null;
        }

        protected virtual void OnDbActionDone(ActionType action)
        {
            switch (action)
            {
                case ActionType.Insert:
                    DataSource.Ds.OnInserted(this);
                    break;
                case ActionType.Update:
                    DataSource.Ds.OnUpdated(this);
                    break;
                case ActionType.Delete:
                    DataSource.Ds.OnDeleted(this);
                    break;
            }
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            if (Id == 0 || Id == -1) return Code + "*";
            if (Id == UNKNOWN_ID) return "";
            return Code;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BaseObject);
        }

        public bool Equals(BaseObject other)
        {
            return other != null &&
                   ObjectDefinition == other.ObjectDefinition &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            var hashCode = -1653615172;
            hashCode = hashCode * -1521134295 + ObjectDefinition.GetHashCode();
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(BaseObject object1, BaseObject object2)
        {
            return EqualityComparer<BaseObject>.Default.Equals(object1, object2);
        }

        public static bool operator !=(BaseObject object1, BaseObject object2)
        {
            return !(object1 == object2);
        }

        #endregion

        #region Properties

        public virtual long Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public virtual string Code
        {
            get
            {
                if (IsUnknown()) return "";
                return code ?? "";
            }
            set
            {
                code = value;
                OnPropertyChanged("Code");
            }
        }
        
        public virtual string Description
        {
            get
            {
                return description ?? "";
            }
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }
        
        public virtual string Info
        {
            get
            {
                return info ?? "";
            }
            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }
        
        public DateTime LastModified
        {
            get { return lastModified; }
            set
            {
                lastModified = value;
                OnPropertyChanged("LastModified");
            }
        }
        
        public string LogTableName
        {
            get { return ObjectDefinition.TableName + "Log"; }
        }

        #endregion
    }
}
