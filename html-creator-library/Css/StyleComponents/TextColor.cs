namespace html_creator_library.Css.StyleComponents
{
    public class TextColor : StyleComponent
    {
        private string color;

        public TextColor(string color)
        {
            this.color = color;
        }

        internal override string GetCss()
        {
            return $"\tcolor: {color};";
        }
    }
}
