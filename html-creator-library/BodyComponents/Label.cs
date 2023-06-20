namespace html_creator_library.BodyComponents
{
    public class Label : BodyComponent
    {
        public Label(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Label(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<label{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</label>";        
        }
    }
}
