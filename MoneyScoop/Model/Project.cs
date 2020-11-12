using Database;
using System.Data.Common;

namespace MoneyScoop.Model
{
    public class Project : BaseObject
    {
        public override ObjectDefinition ObjectDefinition { get { return ObjectDefinitions.Project; } }
        //private string prop;

        public Project() : this("")
        {

        }

        public Project(string code) : base(code)
        {

        }

        #region Base Overrides
        public override IObject CreateCopy()
        {
            Project obj = new Project(Code);
            obj.CopyFrom(this);
            return obj;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is Project that)
            {
                base.CopyFrom(that);
                // Prop = that.Prop;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (base.PropertiesEqual(iObject))
            {
                if (iObject is Project that)
                {
                    // return
                    // Prop == that.Prop
                    ;
                }
            }
            return false;
        }
        #endregion

        #region Database Overrides

        public override void InitFromReader(DbDataReader reader)
        {
            base.InitFromReader(reader);
            // Prop = DatabaseAccess.RGetString(reader, "prop");
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            //DatabaseAccess.AddDbValue(command, "prop", Prop);
        }

        protected override void OnDbActionDone(ActionType action)
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

        #region Methods & Calculated Fields


        #endregion

        #region Properties
        //public string Prop
        //{
        //    get => prop ?? "";
        //    set
        //    {
        //        prop = value;
        //        OnPropertyChanged("Prop");
        //    }
        //}

        #endregion
    }
}
