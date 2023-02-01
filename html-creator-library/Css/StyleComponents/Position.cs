namespace html_creator_library.Css.StyleComponents
{
    public class Position : StyleComponent
    {
        private string position;
        private string top;
        private string right;
        private string bottom;
        private string left;

        public Position(string position)
        {
            this.position = position;
        }

        public Position Top(string top)
        {
            this.top = top;
            return this;
        }
        public Position Right(string right)
        {
            this.right = right;
            return this;
        }
        public Position Bottom(string bottom)
        {
            this.bottom = bottom;
            return this;
        }
        public Position Left(string left)
        {
            this.left = left;
            return this;
        }

        internal override string GetCss()
        {
            string result = $"\tposition: {position};";

            if (top is not null) result += $"\n\ttop: {top};";
            if (right is not null) result += $"\n\tright: {right};";
            if (bottom is not null) result += $"\n\tbottom: {bottom};";
            if (left is not null) result += $"\n\tleft: {left};";

            return result;
        }
    }

    public static class PositionType
    {
        public static string Static = "static";
        public static string Relative = "relative";
        public static string Absolute = "absolute";
        public static string Fixed = "fixed";
        public static string Sticky = "sticky";
    }
}
