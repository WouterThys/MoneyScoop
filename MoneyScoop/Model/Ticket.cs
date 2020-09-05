using Database;
using System.Data.Common;

namespace MoneyScoop.Model
{
    public enum TicketState
    {
        Pending = 0,
        Busy,
        Ready,
        Done,
    }

    public enum TicketType
    {
        Unknown = 0,
        Bug,
        Task,
    }

    public class Ticket : BaseObject
    {
        public override ObjectDefinition ObjectDefinition { get { return ObjectDefinitions.Ticket; } }

        private long projectId;
        private TicketType type;
        private TicketState state;
        private long originVersionId;
        private long fixedInVersionId;

        private Project project;
        private Version originVersion;
        private Version fixedInVersion;

        public Ticket() : this("")
        {

        }

        public Ticket(string code) : base(code)
        {

        }

        #region Base Overrides
        public override IObject CreateCopy()
        {
            Ticket obj = new Ticket(Code);
            obj.CopyFrom(this);
            return obj;
        }

        public override void CopyFrom(IObject toCopy)
        {
            if (toCopy is Ticket that)
            {
                base.CopyFrom(that);
                ProjectId = that.ProjectId;
                State = that.State;
                Type = that.Type;
                OriginVersionId = that.OriginVersionId;
                FixedInVersionId = that.FixedInVersionId;
            }
        }

        public override bool PropertiesEqual(IObject iObject)
        {
            if (base.PropertiesEqual(iObject))
            {
                if (iObject is Ticket that)
                {
                    return
                        ProjectId == that.ProjectId &&
                        State == that.State &&
                        Type == that.Type &&
                        OriginVersionId == that.OriginVersionId &&
                        FixedInVersionId == that.FixedInVersionId
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
            ProjectId = DatabaseAccess.RGetLong(reader, "projectId");
            Type = (TicketType)DatabaseAccess.RGetInt(reader, "type");
            State = (TicketState)DatabaseAccess.RGetInt(reader, "state");
            OriginVersionId = DatabaseAccess.RGetLong(reader, "originVersionId");
            FixedInVersionId = DatabaseAccess.RGetLong(reader, "fixedInVersionId");
        }

        public override void AddSqlParameters(DbCommand command)
        {
            base.AddSqlParameters(command);
            DatabaseAccess.AddDbValue(command, "projectId", ProjectId);
            DatabaseAccess.AddDbValue(command, "type", Type);
            DatabaseAccess.AddDbValue(command, "state", State);
            DatabaseAccess.AddDbValue(command, "originVersionId", OriginVersionId);
            DatabaseAccess.AddDbValue(command, "fixedInVersionId", FixedInVersionId);
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

        public long ProjectId
        {
            get => projectId > UNKNOWN_ID ? projectId : UNKNOWN_ID;
            set => SetProperty(ref projectId, value, "ProjectId", (o, n) =>
            {
                if (project != null && project.Id != n)
                {
                    project = null;
                }
            });
        }

        public TicketType Type
        {
            get => type;
            set => SetProperty(ref type, value, "Type");
        }

        public TicketState State
        {
            get => state;
            set => SetProperty(ref state, value, "State");
        }

        public long OriginVersionId
        {
            get => originVersionId > UNKNOWN_ID ? originVersionId : UNKNOWN_ID;
            set => SetProperty(ref originVersionId, value, "OriginVersionId", (o, n) =>
            {
                if (originVersion != null && originVersion.Id != n)
                {
                    originVersion = null;
                }
            });
        }

        public long FixedInVersionId
        {
            get => fixedInVersionId > UNKNOWN_ID ? fixedInVersionId : UNKNOWN_ID;
            set => SetProperty(ref fixedInVersionId, value, "FixedInVersionId", (o, n) =>
            {
                if (fixedInVersion != null && fixedInVersion.Id != n)
                {
                    fixedInVersion = null;
                }
            });
        }

        #endregion
    }
}
