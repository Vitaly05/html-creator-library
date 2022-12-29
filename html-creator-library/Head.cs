namespace html_creator_library
{
    public class Head : HtmlComponent
    {
        public void SetContext(params HeadComponent[] components)
        {
            innerHtmlComponents.AddRange(components);
        }
        
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
