namespace html_creator_library.BodyComponents
{
    public class Text : BodyComponent
    {
        private string textType;
        private string text;

        public Text(string text)
            : this(text, null) { }

        public Text(string text, string textType)
            : this(text, textType, new HtmlAttribute()) { }

        public Text(string text, string textType, HtmlAttribute attribute)
            : base(attribute)
        {
            this.textType = textType ?? TextType.Default;
            this.text = text;
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";

            if (textType == TextType.Default)
                return $"{outTab}{text}";

            return
                $"{outTab}" +
                $"<{textType}{attribute.GetAttributes()}>" +
                $"{text}" +
                $"</{textType}>";
        }
    }
    
    public static class TextType
    {
        public static string Default = "";
        public static string H1 = "h1";
        public static string H2 = "h2";
        public static string H3 = "h3";
        public static string H4 = "h4";
        public static string H5 = "h5";
        public static string H6 = "h6";
        public static string P = "p";
        public static string B = "b";
        public static string I = "i";
        public static string U = "u";
        public static string Q = "q";
        public static string Em = "em";
        public static string Strong = "strong";
        public static string Del = "del";
        public static string Abbr = "abbr";
        public static string Address = "address";
        public static string Blockquote = "blockquote";
        public static string Code = "code";
        public static string Dfn = "dfn";
        public static string Ins = "ins";
        public static string Small = "small";
        public static string Sup = "sup";
        public static string Sub = "sub";
        public static string Font = "font";
    }
}
