namespace html_creator_library.BodyComponents.Containers
{
    public class Menu : BodyComponent
    {
        public Menu(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Menu(HtmlAttribute attribute)
            : base(attribute) { }

        public Menu(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<menu{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</menu>";
        }
    }
}
