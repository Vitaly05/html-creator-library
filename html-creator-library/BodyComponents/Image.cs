namespace html_creator_library.BodyComponents
{
    public class Image : BodyComponent
    {
        private string src;
        private string altText;


        public Image(string src) 
            : this(src, null, new HtmlAttribute()) { }

        public Image(string src, string altText) 
            : this(src, altText, new HtmlAttribute()) { }

        public Image(string src, HtmlAttribute attribute)
            : this(src, null, attribute) { }

        public Image(string src, string altText, HtmlAttribute attribute) 
            : base(attribute)
        {
            this.src = src;
            this.altText = altText;
        }


        internal override string GetHtml(string outTab)
        {
            string result = $"{outTab}<img src=\"{src}\"";
            if (altText is not null) result += $" alt=\"{altText}\"";
            result += $"{attribute.GetAttributes()} >";

            return result;
        }
    }
}
