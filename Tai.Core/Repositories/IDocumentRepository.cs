using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Tai.Core.Repositories
{
    public interface IDocumentRepository
    {
        Document Get(Guid id);
        Document Add(Document document);
    }
}
