namespace Document
{
    public class BoldText : DocumentPart
    {
        public BoldText(string text) : base(text)
        {
        }

        public override string Accept(HtmlParser htmlParser)
        {
            return htmlParser.VisitBoldText(this);
        }

        public override string Accept(LaTeXParser laTeXParser)
        {
            return laTeXParser.VisitBoldText(this);
        }
    }
}