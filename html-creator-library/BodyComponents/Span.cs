namespace html_creator_library.BodyComponents
{
    public class Span : BodyComponent
    {
        private string text;

        public Span(string text)
            : this(text, new HtmlAttribute()) { }

        public Span(string text, HtmlAttribute attribute)
            : base(attribute)
        {
            this.text = text;
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return
                $"{outTab}<span{attribute.GetAttributes()}>{text}</span>";
        }
    }
}
