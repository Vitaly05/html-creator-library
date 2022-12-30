namespace html_creator_library.BodyComponents
{
    public class TextArea : BodyComponent
    {
        private string text;

        public TextArea()
            : this("", new HtmlAttribute()) { }

        public TextArea(string text)
            : this(text, new HtmlAttribute()) { }

        public TextArea(HtmlAttribute attribute)
            : this("", new HtmlAttribute()) { }
        
        public TextArea(string text, HtmlAttribute attribute)
            : base(attribute)
        {
            this.text = text;
        }

        internal override string GetHtml(string outTab)
        {
            return
                $"{outTab}<textarea{attribute.GetAttributes()}>{text}</textarea>";
        }
    }
}
