namespace html_creator_library.BodyComponents.Containers
{
    public class Main : BodyComponent
    {
        public Main(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Main(HtmlAttribute attribute)
            : base(attribute) { }

        public Main(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<main{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</main>";
        }
    }
}
