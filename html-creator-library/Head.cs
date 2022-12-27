namespace html_creator_library
{
    public class Head : HtmlCodeElements
    {
        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<head>\n" +
                $"{innerTab}\n" +
                $"{outTab}</head>";
        }
    }
}
