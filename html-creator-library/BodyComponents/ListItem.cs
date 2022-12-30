namespace html_creator_library.BodyComponents
{
    public class ListItem : BodyComponent
    {
        public ListItem(params BodyComponent[] components)
            : this (new HtmlAttribute(), components) { }

        public ListItem(HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";

            return
                $"{outTab}<li{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</li>";
        }
    }
}
