namespace Document
{
    public interface IVisitor
    {
        string VisitPlainText(PlainText plainText);
        string VisitBoldText(BoldText boldText);
        string VisitHyperLink(HyperLink hyperLink);
    }
}