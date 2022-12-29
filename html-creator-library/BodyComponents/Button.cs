namespace html_creator_library.BodyComponents
{
    public class Button : BodyComponent
    {      
        public Button(params HtmlComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Button(HtmlAttribute attribute, params HtmlComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return 
                $"{outTab}<button{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</button>";
        }
    }
}
