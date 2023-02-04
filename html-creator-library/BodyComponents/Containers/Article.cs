namespace html_creator_library.BodyComponents.Containers
{
    public class Article : BodyComponent
    {
        public Article(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Article(HtmlAttribute attribute)
            : base(attribute) { }

        public Article(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<article{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</article>";
        }
    }
}
