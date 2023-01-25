namespace html_creator_library.Css.StyleComponents
{
    public class MinSize : Size
    {
        public MinSize(string width, string height)
            : base(width, height) { }

        internal override string GetCss()
        {
            string result = "";

            if (width is not null)
                result += $"\tmin-width: {width};";
            if (height is not null)
                result += $"\n\tmin-height: {height};";

            return result;
        }
    }
}
