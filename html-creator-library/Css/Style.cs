namespace html_creator_library.Css
{
    public class Style
    {
        private List<StyleComponent> styleParams = new List<StyleComponent>();
        private string selector;
        private string pseudoClass;

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

        public Style Active()
        {
            pseudoClass = ":active";
            return this;
        }
        public Style Checked()
        {
            pseudoClass = ":checked";
            return this;
        }
        public Style Default()
        {
            pseudoClass = ":default";
            return this;
        }
        public Style Defined()
        {
            pseudoClass = ":defined";
            return this;
        }
        public Style Empty()
        {
            pseudoClass = ":empty";
            return this;
        }
        public Style Focus()
        {
            pseudoClass = ":focus";
            return this;
        }
        public Style Hover()
        {
            pseudoClass = ":hover";
            return this;
        }
        public Style InRange()
        {
            pseudoClass = ":in-range";
            return this;
        }
        public Style PseudoClass(string pseudoClass)
        {
            this.pseudoClass = pseudoClass;
            return this;
        }

        internal string GetCss()
        {
            string start = "{";
            string end = "}";
            return
                $"{selector}{pseudoClass} {start}\n" +
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
