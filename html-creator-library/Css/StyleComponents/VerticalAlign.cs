namespace html_creator_library.Css.StyleComponents
{
    public class VerticalAlign : StyleComponent
    {
        private string align;

        public VerticalAlign(string align)
        {
            this.align = align;
        }

        internal override string GetCss()
        {
            return $"\tvertical-align: {align};";
        }
    }

    public static class VerticalAlignType
    {
        public static string Baseline = "baseline";
        public static string Sub = "sub";
        public static string Super = "super";
        public static string TextTop = "text-top";
        public static string TextBottom = "text-bottom";
        public static string Middle = "middle";
        public static string Top = "top";
        public static string Bottom = "bottom";
    }
}
