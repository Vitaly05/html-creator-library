namespace html_creator_library.BodyComponents
{
    public class OrderedList : BodyComponent
    {
        public OrderedList(params ListItem[] items)
            : this(new HtmlAttribute(), items) { }

        public OrderedList(HtmlAttribute attribute, params ListItem[] items)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(items);
        }
        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";

            return
                $"{outTab}<ol{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</ol>";
        }
    }
}
