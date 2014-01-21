namespace Document
{
    public class BoldText : DocumentPart
    {
        public BoldText(string text) : base(text)
        {
        }

        public override string Accept(IDocumentVisitor htmlParser)
        {
            return htmlParser.VisitBoldText(this);
        }
    }
}