namespace Document
{
    public class BoldText : DocumentPart
    {
        public BoldText(string text) : base(text)
        {
        }

        public override string Accept(HtmlVisitor document)
        {
            return document.VisitBoldText(this);
        }
    }
}