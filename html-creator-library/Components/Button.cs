namespace html_creator_library.Components
{
    public class Button : BodyComponent
    {      
        public Button(params HtmlComponent[] components)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return 
                $"{outTab}<button>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</button>";
        }
    }
}
