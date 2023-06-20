namespace html_creator_library.BodyComponents
{
    public class Select : BodyComponent
    {
        public Select(params BodyComponent[] components)
            : this(new HtmlAttribute(), components) { }

        public Select(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<select{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</select>";
        }
    }
}
