namespace html_creator_library.Css.StyleComponents
{
    public class Background : StyleComponent
    {
        private string color;

        public Background(string color)
        {
            this.color = color;
        }
    
        internal override string GetCss()
        {
            return
                $"\tbackground: {color};";
        }
    }
}
