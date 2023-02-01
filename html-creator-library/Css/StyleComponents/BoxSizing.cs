namespace html_creator_library.Css.StyleComponents
{
    public class BoxSizing : StyleComponent
    {
        private string boxSizing;

        public BoxSizing(string boxSizing)
        {
            this.boxSizing = boxSizing;
        }

        internal override string GetCss()
        {
            return $"\tbox-sizing: {boxSizing};";
        }
    }

    public static class BoxSizingType
    {
        public static string BorderBox = "border-box";
        public static string ContentBox = "content-box";
    }
}
