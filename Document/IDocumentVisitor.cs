namespace Document
{
    public interface IDocumentVisitor
    {
        string VisitPlainText(PlainText plainText);
        string VisitBoldText(BoldText boldText);
        string VisitHyperLink(HyperLink hyperLink);
    }
}