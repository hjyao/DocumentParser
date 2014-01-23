namespace Document
{
    public class HyperLink : DocumentPart
    {
        public HyperLink(string text, string url) : base(text)
        {
            Url = url;
        }

        public string Url { get; private set; }

        public override string Accept(HtmlParser htmlParser)
        {
            return htmlParser.VisitHyperLink(this);
        }

        public override string Accept(LaTeXParser laTeXParser)
        {
            return laTeXParser.VisitHyperLink(this);
        }
    }
}