using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tai.Core.Domain
{
    internal class Document : Entity
    {
        public Guid? UserId { get; protected set; }
        public DateTime? OperationTime { get; protected set; }
        public DateTime? CreatedAt { get; protected set; }
        public byte[]? File { get; protected set; }

        public Document() { }

        public Document(Guid id, Guid userId, byte[] file)
        {
            Id = id;
            UserId = userId;
            File= file;
        }
    }
}
