namespace html_creator_library.Css.StyleComponents
{
    public class Border : StyleComponent
    {
        private string width;
        private string color;
        private string radius;
        private string style;

        internal override string GetCss()
        {
            string css = "";

            if (width is not null)
                css = String.Concat(css, $"\tborder-width: {width};\n");
            if (color is not null)
                css = String.Concat(css, $"\tborder-color: {color};\n");
            if (radius is not null)
                css = String.Concat(css, $"\tborder-radius: {radius};\n");
            if (style is not null)
                css = String.Concat(css, $"\tborder-style: {style};\n");

            return css;
        }

        public Border Width(string width)
        {
            this.width = width;
            return this;
        }
        public Border Width(string vertical, string horizontal)
        {
            width = $"{vertical} {horizontal}";
            return this;
        }
        public Border Width(string top, string horizontal, string bottom)
        {
            width = $"{top} {horizontal} {bottom}";
            return this;
        }
        public Border Width(string top, string right, string bottom, string left)
        {
            width = $"{top} {right} {bottom} {left}";
            return this;
        }

        public Border Color(string color)
        {
            this.color = color;
            return this;
        }
        public Border Color(string vertical, string horizontal)
        {
            color = $"{vertical} {horizontal}";
            return this;
        }
        public Border Color(string top, string horizontal, string bottom)
        {
            color = $"{top} {horizontal} {bottom}";
            return this;
        }
        public Border Color(string top, string right, string bottom, string left)
        {
            color = $"{top} {right} {bottom} {left}";
            return this;
        }

        public Border Radius(string radius)
        {
            this.radius = radius;
            return this;
        }
        public Border Radius(string ltrDiagonal, string rtlDiagonal)
        {
            radius = $"{ltrDiagonal} {rtlDiagonal}";
            return this;
        }
        public Border Radius(string topLeft, string rtlDiagonal, string bottomRight)
        {
            radius = $"{topLeft} {rtlDiagonal} {bottomRight}";
            return this;
        }
        public Border Radius(string topLeft, string topRight, string bottomRight, string bottomLeft)
        {
            radius = $"{topLeft} {topRight} {bottomRight} {bottomLeft}";
            return this;
        }

        public Border Style(string borderStyle)
        {
            style = borderStyle;
            return this;
        }
        public Border Style(string vertical, string horizontal)
        {
            style = $"{vertical} {horizontal}";
            return this;
        }
        public Border Style(string top, string horizontal, string bottom)
        {
            style = $"{top} {horizontal} {bottom}";
            return this;
        }
        public Border Style(string top, string right, string bottom, string left)
        {
            style = $"{top} {right} {bottom} {left}";
            return this;
        }
    }

    public static class BorderStyle
    {
        public static string Dotted = "dotted";
        public static string Dashed = "dashed";
        public static string Solid = "solid";
        public static string Double = "double";
        public static string Groove = "groove";
        public static string Ridge = "ridge";
        public static string Inset = "inset";
        public static string Outset = "outset";
    }
}
