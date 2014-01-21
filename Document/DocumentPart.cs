namespace Document
{
    public abstract class DocumentPart
    {
        protected DocumentPart(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
        public abstract string Accept(HtmlParser htmlParser);
        public abstract string Accept(LaTeXParser laTeXParser);
    }
}
