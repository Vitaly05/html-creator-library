namespace html_creator_library.Css.StyleComponents
{
    public class Overflow : StyleComponent
    {
        private string overflow;
        private string overflowX;
        private string overflowY;

        public Overflow() { }
        public Overflow(string overflow)
        {
            this.overflow = overflow;
        }

        public Overflow X(string overflowX)
        {
            this.overflowX = overflowX;
            return this;
        }
        public Overflow Y(string overflowY)
        {
            this.overflowY = overflowY;
            return this;
        }

        internal override string GetCss()
        {
            string result = "";

            if (overflow is not null)
            {
                result = $"\toverflow: {overflow};";
                return result;
            }
            if (overflowX is not null) result += $"\n\toverflow-x: {overflowX};";
            if (overflowY is not null) result += $"\n\toverflow-y: {overflowY};";

            return result;
        }
    }

    public static class OverflowType
    {
        public static string Visible = "visible";
        public static string Hidden = "hidden";
        public static string Clip = "clip";
        public static string Scroll = "scroll";
        public static string Auto = "auto";
    }
}
