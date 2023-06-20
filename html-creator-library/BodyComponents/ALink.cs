namespace html_creator_library.BodyComponents
{
    public class ALink : BodyComponent
    {
        private string href;

        public ALink(string href)
            : this(href, new HtmlAttribute()) { }

        public ALink(string href, HtmlAttribute attribute)
            : base(attribute)
        {
            this.href = href;
        }
        public ALink(string href, params BodyComponent[] components)
            : base(new HtmlAttribute())
        {
            this.href = href;
            innerHtmlComponents.AddRange(components);
        }
        public ALink(string href, HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            this.href = href;
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<a href=\"{href}\"{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</a>";
        }
    }
}
