namespace Document
{
    public class PlainText : DocumentPart
    {
        public PlainText(string text) : base(text)
        {
        }

        public override string Accept(HtmlParser htmlParser)
        {
            return htmlParser.VisitPlainText(this);
        }

        public override string Accept(LaTeXParser laTeXParser)
        {
            return laTeXParser.VisitPlainText(this);
        }
    }
}