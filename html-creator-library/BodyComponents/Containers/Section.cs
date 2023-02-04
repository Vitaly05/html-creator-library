namespace html_creator_library.BodyComponents.Containers
{
    public class Section : BodyComponent
    {
        public Section(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Section(HtmlAttribute attribute)
            : base(attribute) { }

        public Section(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<section{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</section>";
        }
    }
}
