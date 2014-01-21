using Document;
using Xunit;

namespace DocumentTest
{
    public class DocumentTest
    {
        [Fact]
        public void should_output_html_for_document_with_plain_text_part()
        {
            var plainText = new PlainText("I am plain text");
            var document = new HtmlParser(plainText);

            string html = document.ToHtml();

            Assert.Equal("I am plain text", html);
        }

        [Fact]
        public void should_output_html_for_document_with_bold_text_part()
        {
            var boldText = new BoldText("I am bold text");
            var document = new HtmlParser(boldText);

            string html = document.ToHtml();

            Assert.Equal("<b>I am bold text</b>", html);
        }

        [Fact]
        public void should_output_html_for_document_with_hyperlink_part()
        {
            var hyperLink = new HyperLink("I am hyperlink", "http://www.visitor.com");
            var document = new HtmlParser(hyperLink);

            string html = document.ToHtml();

            Assert.Equal("<a href='http://www.visitor.com'>I am hyperlink</a>", html);
        }

        [Fact]
        public void should_output_LaTeX_format_for_document_with_plain_text_part()
        {
            var plainText = new PlainText("I am plain text");
            var document = new LaTeXParser(plainText);

            string html = document.ToLaTeX();

            Assert.Equal("I am plain text", html);
        }

        [Fact]
        public void should_output_LaTeX_format_for_document_with_bold_text_part()
        {
            var boldText = new BoldText("I am bold text");
            var document = new LaTeXParser(boldText);

            string html = document.ToLaTeX();

            Assert.Equal("**I am bold text**", html);
        }

        [Fact]
        public void should_output_LaTeX_format_for_document_with_hyperlink_part()
        {
            var hyperLink = new HyperLink("I am hyperlink", "http://www.visitor.com");
            var document = new LaTeXParser(hyperLink);

            string html = document.ToLaTeX();

            Assert.Equal("\\href{http://www.visitor.com}{I am hyperlink}", html);
        }
    }
}