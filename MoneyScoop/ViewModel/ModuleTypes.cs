using MoneyScoop.Model;
using System;

namespace MoneyScoop.ViewModel
{
    public abstract class BaseModuleType : IModuleType
    {
        public long Id { get; }
        public ObjectDefinition ObjectDefinition { get; }
        public string ViewName { get; }
        public virtual string TranslateSection { get; }

        protected string titleCode;

        protected BaseModuleType(int id, ObjectDefinition objectDefinition, string viewName, string translateSection, string titleCode)
        {
            Id = id;
            ObjectDefinition = objectDefinition;
            ViewName = viewName;
            TranslateSection = translateSection;
            this.titleCode = titleCode;
        }

        public override string ToString()
        {
            return "Module " + "(" + Id + "): " + ViewName;
        }

        public abstract Guid GetGuid(long id);

        public override bool Equals(object obj)
        {
            return obj is BaseModuleType type && Id == type.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public string ViewTitle
        {
            get
            {
                return titleCode;
            }
        }
    }

    public class SimpleModuleType : BaseModuleType
    {
        private Guid guid;
        public SimpleModuleType(int id, ObjectDefinition objectDefinition, string name, string titleCode) : base(id, objectDefinition, name, "", titleCode)
        {
            guid = Guid.NewGuid();
        }

        public override Guid GetGuid(long id)
        {
            return guid;
        }
    }

    public class DataListModuleType : BaseModuleType
    {
        private Guid guid;
        public DataListModuleType(int id, ObjectDefinition objectDefinition, string objectName) : base(id, objectDefinition, objectName + "ListView", objectName, objectName + "s")
        {
            guid = Guid.NewGuid();
        }

        public override Guid GetGuid(long id)
        {
            return guid;
        }
    }

    public class AddEditDataModule : BaseModuleType
    {
        public AddEditDataModule(int id, ObjectDefinition objectDefinition, string objectName) : base(id, objectDefinition, objectName + "EditView", objectName, objectName + "s")
        {

        }

        public override Guid GetGuid(long id)
        {
            if (id > 0)
            {
                short s = (short)Id;
                return new Guid((int)id, s, 0, new byte[8]);
            }
            else
            {
                return Guid.NewGuid();
            }
        }
    }

    public static class ModuleTypes
    {
        public readonly static SimpleModuleType MainViewModule = new SimpleModuleType(-4, ObjectDefinitions.DummyDef, "MainView", "Control center");

        public readonly static DataListModuleType IncomingInvoiceListModule = new DataListModuleType(-200, ObjectDefinitions.Invoice,"IncomingInvoice");
        public readonly static AddEditDataModule IncomingInvoiceEditModule = new AddEditDataModule(-201, ObjectDefinitions.Invoice,"IncomingInvoice");
        public readonly static SimpleModuleType IncomingInvoiceDetailsModule = new SimpleModuleType(-202, ObjectDefinitions.Invoice,"IncomingInvoiceDetailView", "Details");
        
        public readonly static DataListModuleType OutgoingInvoiceListModule = new DataListModuleType(-250, ObjectDefinitions.Invoice,"OutgoingInvoice");
        public readonly static AddEditDataModule OutgoingInvoiceEditModule = new AddEditDataModule(-251, ObjectDefinitions.Invoice,"OutgoingInvoice");
        public readonly static SimpleModuleType OutgoingInvoiceDetailsModule = new SimpleModuleType(-252, ObjectDefinitions.Invoice,"OutgoingInvoiceDetailView", "Details");

        public readonly static DataListModuleType InvoiceLineListModule = new DataListModuleType(-300, ObjectDefinitions.InvoiceLine,"InvoiceLine");
        public readonly static AddEditDataModule InvoiceLineEditModule = new AddEditDataModule(-301, ObjectDefinitions.InvoiceLine, "InvoiceLine");
        
        public readonly static DataListModuleType CustomerListModule = new DataListModuleType(-400, ObjectDefinitions.Customer, "Customer");
        public readonly static AddEditDataModule CustomerEditModule = new AddEditDataModule(-401, ObjectDefinitions.Customer, "Customer");
        public readonly static SimpleModuleType CustomerDetailsModule = new SimpleModuleType(-402, ObjectDefinitions.Customer, "CustomerDetailView", "Details");

        public readonly static DataListModuleType BookKeeperListModule = new DataListModuleType(-500, ObjectDefinitions.BookKeeper, "BookKeeper");
        public readonly static SimpleModuleType BookKeeperOverviewModule = new SimpleModuleType(-501, ObjectDefinitions.BookKeeper, "BookKeeperOverviewView", "Overview");

        public readonly static SimpleModuleType SendMailModule = new SimpleModuleType(-1000, ObjectDefinitions.DummyDef, "SendMailView", "Send mail");
    }
}
