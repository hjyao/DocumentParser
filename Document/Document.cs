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

        public string ToHtml()
        {
            string output = "";
            DocumentParts.ForEach(p => { output += GetHtml(p); });
            return output;
        }

        private string GetHtml(DocumentPart documentPart)
        {
            if (documentPart is PlainText)
            {
                return (documentPart as PlainText).Accept(this);
            }
            else if (documentPart is BoldText)
            {
                return (documentPart as BoldText).Accept(this);
            }
            else
            {
                return (documentPart as HyperLink).Accept(this);
            }
        }

        public string VisitPlainText(PlainText plainText)
        {
            return plainText.Text;
        }

        public string VisitBoldText(BoldText boldText)
        {
            return string.Format("<b>{0}</b>", boldText.Text);
        }

        public string VisitHyperLink(HyperLink hyperLink)
        {
            return string.Format("<a href='{0}'>{1}</a>", hyperLink.Url, hyperLink.Text);
        }
    }
}