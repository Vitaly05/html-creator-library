namespace html_creator_library.BodyComponents
{
    public class Form : BodyComponent
    {
        public Form(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Form(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<form{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</form>";
        }
    }
}
