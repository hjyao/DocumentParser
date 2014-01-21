namespace Document
{
    public class PlainText : DocumentPart
    {
        public PlainText(string text) : base(text)
        {
        }

        public override string Accept(IDocumentVisitor htmlParser)
        {
            return htmlParser.VisitPlainText(this);
        }
    }
}