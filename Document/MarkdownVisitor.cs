namespace Document
{
    public class MarkdownVisitor : IVisitor
    {
        public string VisitPlainText(PlainText plainText)
        {
            throw new System.NotImplementedException();
        }

        public string VisitBoldText(BoldText boldText)
        {
            return string.Format("_{0}_", boldText.Text);
        }

        public string VisitHyperLink(HyperLink hyperLink)
        {
            throw new System.NotImplementedException();
        }
    }
}