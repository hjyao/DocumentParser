namespace Document
{
    public class PlainText : DocumentPart
    {
        public PlainText(string text) : base(text)
        {
        }

        public string Accept(Document document)
        {
            return document.VisitPlainText(this);
        }
    }
}