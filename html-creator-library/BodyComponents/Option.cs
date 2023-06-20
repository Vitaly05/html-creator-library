namespace html_creator_library.BodyComponents
{
    public class Option : BodyComponent
    {
        private string value;
        private bool selected;

        public Option(string value, bool selected, params BodyComponent[] components)
            : this (value, selected, new HtmlAttribute(), components) { }

        public Option(string value, bool selected, HtmlAttribute attribute, params BodyComponent[] components)
            : base(attribute)
        {
            this.value = value;
            this.selected = selected;
            innerHtmlComponents.AddRange(components);
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<option value=\"{value}\" {(selected ? "selected" : "")}{attribute.GetAttributes()}>\n" +
                $"{getInnerComponentsHtml()}\n" +
                $"{outTab}</option>";
        }
    }
}
