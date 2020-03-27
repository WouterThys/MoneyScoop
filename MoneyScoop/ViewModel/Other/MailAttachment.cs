using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyScoop.ViewModel.Other
{
    public class MailAttachment : IEquatable<MailAttachment>
    {
        public string AttachmentPath { get; set; }

        public MailAttachment(string attachmentPath)
        {
            AttachmentPath = attachmentPath;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MailAttachment);
        }

        public bool Equals(MailAttachment other)
        {
            return other != null &&
                   AttachmentPath == other.AttachmentPath;
        }

        public override int GetHashCode()
        {
            return 1080882295 + EqualityComparer<string>.Default.GetHashCode(AttachmentPath);
        }

        public static bool operator ==(MailAttachment attachment1, MailAttachment attachment2)
        {
            return EqualityComparer<MailAttachment>.Default.Equals(attachment1, attachment2);
        }

        public static bool operator !=(MailAttachment attachment1, MailAttachment attachment2)
        {
            return !(attachment1 == attachment2);
        }
    }
}
