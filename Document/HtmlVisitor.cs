namespace Document
{
    public class HtmlVisitor
    {
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