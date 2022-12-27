namespace html_creator_library
{
    public class Body : HtmlComponent
    {
        public void SetContext(params HtmlComponent[] components)
        {
            innerHtmlComponents.AddRange(components);
        }
        
        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return 
                $"{outTab}<body>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</body>";
        }
    }
}
