namespace Document
{
    public class PlainText : DocumentPart
    {
        public PlainText(string text) : base(text)
        {
        }

        public override string Accept(IVisitor document)
        {
            return document.VisitPlainText(this);
        }
    }
}