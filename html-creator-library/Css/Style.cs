namespace html_creator_library.Css
{
    public class Style
    {
        private List<StyleComponent> styleParams = new List<StyleComponent>();
        private string selector;

        public Style(params StyleComponent[] styleParams)
        {
            this.styleParams.AddRange(styleParams);
        }

        public Style Class(string className)
        {
            selector = $".{className}";
            return this;
        }
        public Style Id(string id)
        {
            selector = $"#{id}";
            return this;
        }
        public Style Selector(string selector)
        {
            this.selector = selector;
            return this;
        }

        internal string GetCss()
        {
            string start = "{";
            string end = "}";
            return
                $"{selector} {start}\n" +
                $"{getInnerComponentsCss()}\n" +
                $"{end}";
        }

        private string getInnerComponentsCss()
        {
            string css = "";

            foreach (var param in styleParams)
            {
                css += param.GetCss() +
                    (styleParams.Last() != param ? "\n" : "");
            }

            return css;
        }
    }
}
