namespace html_creator_library.BodyComponents.Containers
{
    public class Header : BodyComponent
    {
        public Header(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Header(HtmlAttribute attribute)
            : base(attribute) { }

        public Header(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<header{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</header>";
        }
    }
}
