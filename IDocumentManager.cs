

using System.Collections.Generic;

namespace ProtectionProxy
{
    public interface IDocumentManager
    {
        List<string> GetDocumentList();

        string GetDocument(string documentName);
    }
}
