using System.Collections.Generic;
using System.Linq;

namespace Document
{
    public class LaTeXParser : IDocumentVisitor
    {
        public List<DocumentPart> DocumentParts { get; set; }

        public LaTeXParser(params DocumentPart[] documentParts)
        {
            DocumentParts = documentParts.ToList();
        }

        public string ToLaTeX()
        {
            string output = "";
            DocumentParts.ForEach(p => { output += GetLaTeX(p); });
            return output;
        }

        private string GetLaTeX(DocumentPart documentPart)
        {
            return documentPart.Accept(this);
        }

        public string VisitPlainText(PlainText plainText)
        {
            return plainText.Text;
        }

        public string VisitBoldText(BoldText boldText)
        {
            return string.Format("**{0}**", boldText.Text);
        }

        public string VisitHyperLink(HyperLink hyperLink)
        {
            return string.Format("\\href{{{0}}}{{{1}}}", hyperLink.Url, hyperLink.Text);
        }
    }
}