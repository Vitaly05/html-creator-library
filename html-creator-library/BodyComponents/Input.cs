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

    public static class InputType
    {
        public static string Text = "text";
        public static string Password = "password";
        public static string Radio = "radio";
        public static string CheckBox = "checkbox";
        public static string Submit = "submit";
        public static string Reset = "reset";
        public static string File = "file";
        public static string Color = "color";
    }
}
