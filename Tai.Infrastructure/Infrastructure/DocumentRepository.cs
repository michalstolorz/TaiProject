using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Tai.Core.Repositories;

namespace Tai.Infrastructure.Infrastructure
{
    internal class DocumentRepository : IDocumentRepository
    {
        private static readonly ISet<Document> _documents = new HashSet<Document>();

        public Document Add(Document document)
        {
            throw new NotImplementedException();
        }

        public Document Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
