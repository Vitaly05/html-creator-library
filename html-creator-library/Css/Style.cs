namespace html_creator_library.Css
{
    public class Style
    {
        private List<StyleComponent> styles = new List<StyleComponent>();
        private string selector;

        public Style(string selector, params StyleComponent[] styles)
        {
            this.selector = selector;
            this.styles.AddRange(styles);
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

            foreach (var style in styles)
            {
                css += style.GetCss() +
                    (styles.Last() != style ? "\n" : "");
            }

            return css;
        }
    }
}
