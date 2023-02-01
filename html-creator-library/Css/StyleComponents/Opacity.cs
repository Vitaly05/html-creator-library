namespace html_creator_library.Css.StyleComponents
{
    public class Opacity : StyleComponent
    {
        private string opacity;

        public Opacity(string opacity)
        {
            this.opacity = opacity;
        }

        internal override string GetCss()
        {
            return $"\topacity: {opacity};";
        }
    }
}
