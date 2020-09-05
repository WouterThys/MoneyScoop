using Database;
using System.Data.Common;

namespace MoneyScoop.Model
{
    public class Version : BaseObject
    {
        private int major;
        private int minor;
        private int build;

        public override ObjectDefinition ObjectDefinition { get { return ObjectDefinitions.Version; } }
        //private string prop;

        public Version() : this("")
        {

        }

        public Version(string code) : base(code)
        {

        }

        #region Base Overrides
        public override IObject CreateCopy()
        {
            Version obj = new Version(Code);
            obj.CopyFrom(this);
            return obj;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is Version that)
            {
                base.CopyFrom(that);
                Major = that.Major;
                Minor = that.Minor;
                Build = that.Build;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (base.PropertiesEqual(iObject))
            {
                if (iObject is Version that)
                {
                    return
                     Major == that.Major &&
                    Minor == that.Minor &&
                    Build == that.Build
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
            Major = DatabaseAccess.RGetInt(reader, "major");
            Minor = DatabaseAccess.RGetInt(reader, "minor");
            Build = DatabaseAccess.RGetInt(reader, "build");
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "major", Major);
            DatabaseAccess.AddDbValue(command, "minor", Minor);
            DatabaseAccess.AddDbValue(command, "build", Build);
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

        public string VersionString
        {
            get => $"{Major}.{Minor}.{Build}";
        }

        #endregion

        #region Properties

        public int Major
        {
            get => major;
            set => SetProperty(ref major, value, "Major");
        }
        public int Minor
        {
            get => minor;
            set => SetProperty(ref minor, value, "Minor");
        }

        public int Build
        {
            get => build;
            set => SetProperty(ref build, value, "Build");
        }


        #endregion
    }
}
