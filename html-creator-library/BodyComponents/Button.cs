namespace html_creator_library.BodyComponents
{
    public class Button : BodyComponent
    {      
        public Button(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Button(HtmlAttribute attribute, params BodyComponent[] components)
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
