namespace html_creator_library.Css.StyleComponents
{
    public class Size : StyleComponent
    {
        protected string width;
        protected string height;

        public Size(string width, string height)
        {
            if (width is not null)
                this.width = width;
            if (height is not null)
                this.height = height;
        }

        internal override string GetCss()
        {
            string result = "";

            if (width is not null)
                result += $"\n\twidth: {width};";
            if (height is not null)
                result += $"\n\theight: {height};";

            return result;
        }
    }
}
