namespace html_creator_library.Css.StyleComponents
{
    public class MaxSize : Size
    {
        public MaxSize(string width, string height)
            : base(width, height) { }

        internal override string GetCss()
        {
            string result = "";

            if (width is not null)
                result += $"\tmax-width: {width};";
            if (height is not null)
                result += $"\n\tmax-height: {height};";

            return result;
        }
    }
}
