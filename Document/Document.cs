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
                return Accept(documentPart as PlainText);
            }
            else if (documentPart is BoldText)
            {
                return Accept(documentPart as BoldText);
            }
            else
            {
                return Accept(documentPart as HyperLink);
            }
        }

        private static string Accept(HyperLink hyperLink)
        {
            return string.Format("<a href='{0}'>{1}</a>", hyperLink.Url, hyperLink.Text);
        }

        private static string Accept(BoldText boldText)
        {
            return string.Format("<b>{0}</b>", boldText.Text);
        }

        private static string Accept(PlainText plainText)
        {
            return plainText.Text;
        }
    }
}