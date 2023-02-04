namespace html_creator_library.BodyComponents.Containers
{
    public class UnorderedList : BodyComponent
    {
        public UnorderedList(params ListItem[] items)
            : this(new HtmlAttribute(), items) { }

        public UnorderedList(HtmlAttribute attribute, params ListItem[] items)
            : base(attribute)
        {
            innerHtmlComponents.AddRange(items);
        }
        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";

            return
                $"{outTab}<ul{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</ul>";
        }
    }
}
