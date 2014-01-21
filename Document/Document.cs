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
                return (documentPart as PlainText).Text;
            }
            else if (documentPart is BoldText)
            {
                return string.Format("<b>{0}</b>", (documentPart as BoldText).Text);
            }
            else
            {
                var hyperLink = (documentPart as HyperLink);
                return string.Format("<a href='{0}'>{1}</a>", hyperLink.Url, hyperLink.Text);
            }
        }
    }
}