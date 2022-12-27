namespace html_creator_library
{
    public class Head : HtmlComponent
    {
        
        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<head>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</head>";
        }
    }
}
