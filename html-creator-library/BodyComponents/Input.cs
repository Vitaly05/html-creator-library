namespace html_creator_library.BodyComponents
{
    public class Input : BodyComponent
    {
        private string inputType;

        public Input(string inputType)
            : this(inputType, new HtmlAttribute()) { }

        public Input(string inputType, HtmlAttribute attribute)
            : base(attribute)
        {
            this.inputType = inputType;
        }

        internal override string GetHtml(string outTab)
        {
            return $"{outTab}<input type=\"{inputType}\"{attribute.GetAttributes()}>";
        }
    }
}
