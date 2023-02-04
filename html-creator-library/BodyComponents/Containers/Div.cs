namespace html_creator_library.BodyComponents.Containers
{
    public class Div : BodyComponent
    {
        public Div(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Div(HtmlAttribute attribute)
            : base(attribute) { }

        public Div(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<div{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</div>";
        }
    }
}
