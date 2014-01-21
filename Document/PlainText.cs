namespace Document
{
    public class PlainText : DocumentPart
    {
        public PlainText(string text) : base(text)
        {
        }

        public override string Accept(Document document)
        {
            return document.VisitPlainText(this);
        }
    }
}