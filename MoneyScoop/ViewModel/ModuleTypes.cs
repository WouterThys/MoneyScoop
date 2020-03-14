using MoneyScoop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel
{
    public abstract class BaseModuleType : IModuleType
    {
        public long Id { get; }
        public ObjectDefinition ObjectDefinition { get; }
        public int ImageId { get; }
        public string ViewName { get; }
        public virtual string TranslateSection { get; }

        protected string titleCode;

        protected BaseModuleType(int id, ObjectDefinition objectDefinition, int imageId, string viewName, string translateSection, string titleCode)
        {
            Id = id;
            ObjectDefinition = objectDefinition;
            ImageId = imageId;
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
        public SimpleModuleType(int id, ObjectDefinition objectDefinition, int imageId, string name, string titleCode) : base(id, objectDefinition, imageId, name, "", titleCode)
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
        public DataListModuleType(int id, ObjectDefinition objectDefinition, int imageId, string objectName) : base(id, objectDefinition, imageId, objectName + "ListView", objectName, objectName + "s")
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
        public AddEditDataModule(int id, ObjectDefinition objectDefinition, int imageId, string objectName) : base(id, objectDefinition, imageId, objectName + "EditView", objectName, objectName + "s")
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
        public readonly static SimpleModuleType MainViewModule = new SimpleModuleType(-4, ObjectDefinitions.DummyDef, -1, "MainView", "Control center");

        public readonly static DataListModuleType IncomingInvoiceListModule = new DataListModuleType(-200, ObjectDefinitions.Invoice, 20, "IncomingInvoice");
        public readonly static DataListModuleType OutgoingInvoiceListModule = new DataListModuleType(-201, ObjectDefinitions.Invoice, 20, "OutgoingInvoice");
        public readonly static AddEditDataModule IncomingInvoiceEditModule = new AddEditDataModule(-202, ObjectDefinitions.Invoice, 20, "IncomingInvoice");
        public readonly static AddEditDataModule OutgoingInvoiceEditModule = new AddEditDataModule(-203, ObjectDefinitions.Invoice, 20, "IncomingInvoice");

        public readonly static DataListModuleType InvoiceLineListModule = new DataListModuleType(-300, ObjectDefinitions.InvoiceLine, 20, "InvoiceLine");
        public readonly static AddEditDataModule InvoiceLineEditModule = new AddEditDataModule(-302, ObjectDefinitions.InvoiceLine, 20, "InvoiceLine");

        public readonly static DataListModuleType CustomerListModule = new DataListModuleType(-400, ObjectDefinitions.Customer, 20, "Customer");
        public readonly static AddEditDataModule CustomerEditModule = new AddEditDataModule(-402, ObjectDefinitions.Customer, 20, "Customer");
    }
}
