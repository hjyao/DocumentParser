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
            var document = new Document.Document(plainText);

            string html = document.ToHtml();

            Assert.Equal("I am plain text", html);
        }

        [Fact]
        public void should_output_html_for_document_with_bold_text_part()
        {
            var boldText = new BoldText("I am bold text");
            var document = new Document.Document(boldText);

            string html = document.ToHtml();

            Assert.Equal("<b>I am bold text</b>", html);
        }

        [Fact]
        public void should_output_html_for_document_with_hyperlink_part()
        {
            var hyperLink = new HyperLink("I am hyperlink", "http://www.visitor.com");
            var document = new Document.Document(hyperLink);

            string html = document.ToHtml();

            Assert.Equal("<a href='http://www.visitor.com'>I am hyperlink</a>", html);
        }
    }
}