using System;
using System.Threading.Tasks;

namespace MoneyScoop.Model
{
    public interface IId
    {
        long Id { get; set; }
    }

    public interface IObject : IId
    {
        ObjectDefinition ObjectDefinition { get; }
        string Code { get; set; }

        IObject CreateCopy();
        void CopyFrom(IObject iObject);
        bool PropertiesEqual(IObject iObject);
    }

    public interface ISave
    {
        Task Save();
        Task Delete();
    }

    public interface ISaveableObject : IObject, ISave
    {
        bool CanBeAdded { get; }
        bool CanBeEdited { get; }
        bool CanBeDeleted { get; }
        DateTime LastModified { get; set; }
    }

    public interface IBaseObject : ISaveableObject
    {
        string Description { get; set; }
        string Info { get; set; }

        // Methods
        bool IsUnknown();
        bool IsValid();
    }
}
