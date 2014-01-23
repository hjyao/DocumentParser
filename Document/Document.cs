using System.Collections.Generic;
using System.Linq;

namespace Document
{
    public class Document
    {
        public Document(params DocumentPart[] documentParts)
        {
            DocumentParts = documentParts.ToList();
        }

        public List<DocumentPart> DocumentParts { get; set; }

        public string Accept(IVisitor visitor)
        {
            string output = "";
            DocumentParts.ForEach(p => { output += p.Accept(visitor); });
            return output;
        }
    }
}