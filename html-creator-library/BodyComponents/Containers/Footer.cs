namespace html_creator_library.BodyComponents.Containers
{
    public class Footer : BodyComponent
    {
        public Footer(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Footer(HtmlAttribute attribute)
            : base(attribute) { }

        public Footer(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<footer{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</footer>";
        }
    }
}
