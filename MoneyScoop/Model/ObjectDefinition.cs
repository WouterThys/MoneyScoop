using System;
using System.Collections.Generic;
using System.Linq;

namespace MoneyScoop.Model
{
    public class ObjectDefinition : IEquatable<ObjectDefinition>
    {
        public Type ClassType { get; }
        public string TableName { get; }
        public string ObjectName { get => ClassType?.Name; }
        public int IconId { get; }

        internal ObjectDefinition(Type classType, string tableName, int iconId)
        {
            ClassType = classType;
            TableName = tableName;
            IconId = iconId;
        }

        public override string ToString()
        {
            return "Table: " + TableName + ", Name: " + ObjectName;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ObjectDefinition);
        }

        public bool Equals(ObjectDefinition other)
        {
            return other != null &&
                   TableName == other.TableName;
        }

        public override int GetHashCode()
        {
            return 1720130748 + EqualityComparer<string>.Default.GetHashCode(TableName);
        }

        public static bool operator ==(ObjectDefinition definition1, ObjectDefinition definition2)
        {
            return EqualityComparer<ObjectDefinition>.Default.Equals(definition1, definition2);
        }

        public static bool operator !=(ObjectDefinition definition1, ObjectDefinition definition2)
        {
            return !(definition1 == definition2);
        }
    }

    public static class ObjectDefinitions
    {
        public static readonly ObjectDefinition DummyDef = new ObjectDefinition(typeof(object), "", 0);

        public static readonly ObjectDefinition Invoice = new ObjectDefinition(typeof(Invoice), "invoices", 10);
        public static readonly ObjectDefinition InvoiceLine = new ObjectDefinition(typeof(InvoiceLine), "invoicelines", 10);
        public static readonly ObjectDefinition Customer = new ObjectDefinition(typeof(Customer), "customers", 10);
        public static readonly ObjectDefinition BookKeeper = new ObjectDefinition(typeof(BookKeeper), "", 24);

        public static readonly ObjectDefinition Project = new ObjectDefinition(typeof(Project), "projects", 36);
        public static readonly ObjectDefinition Version = new ObjectDefinition(typeof(Version), "versions", 37);
        public static readonly ObjectDefinition Ticket = new ObjectDefinition(typeof(Ticket), "tickets", 39);

        public static readonly ObjectDefinition LogItem = new ObjectDefinition(typeof(LogItem), "logitems", 36);

        public static List<ObjectDefinition> Definitions = new List<ObjectDefinition>()
        {
            Invoice,
            InvoiceLine,
            Customer,
            Project,
            Version,
            Ticket,
            LogItem
        };

        public static ObjectDefinition GetDefinition<T>() where T : IObject
        {
            Type t = typeof(T);
            return Definitions.FirstOrDefault(d => d.ClassType == t);
        }

        public static string GetTableName<T>() where T : IObject
        {
            return GetDefinition<T>()?.TableName;
        }

        public static string GetLogTableName<T>() where T : IObject
        {
            string tableName = GetTableName<T>();
            return tableName != null ? (tableName + "log") : null;
        }
    }
}
