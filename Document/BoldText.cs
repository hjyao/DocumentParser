namespace Document
{
    public class BoldText : DocumentPart
    {
        public BoldText(string text) : base(text)
        {
        }

        public string Accept(Document document)
        {
            return document.VisitBoldText(this);
        }
    }
}