namespace html_creator_library.Css.StyleComponents
{
    public class Font : StyleComponent
    {
        private string fontFamily;
        private string fontSize;
        private string fontStyle;
        private string fontWeight;
        private string fontVariant;
        private string fontStretch;
        private string lineHeight;

        public Font Family(string fontFamily)
        {
            this.fontFamily = fontFamily;
            return this;
        }
        public Font Size(string fontSize)
        {
            this.fontSize = fontSize;
            return this;
        }
        public Font Style(string fontStyle)
        {
            this.fontStyle = fontStyle;
            return this;
        }
        public Font Weight(string fontWeight)
        {
            this.fontWeight = fontWeight;
            return this;
        }
        public Font Variant(string fontVariant)
        {
            this.fontVariant = fontVariant;
            return this;
        }
        public Font FontStretch(string fontStretch)
        {
            this.fontStretch = fontStretch;
            return this;
        }
        public Font LineHeight(string lineHeight)
        {
            this.lineHeight = lineHeight;
            return this;
        }

        internal override string GetCss()
        {
            string result = "";

            if (fontFamily is not null) result += $"\n\tfont-family: {fontFamily};";
            if (fontSize is not null) result += $"\n\tfont-size: {fontSize};";
            if (fontStyle is not null) result += $"\n\tfont-style: {fontStyle};";
            if (fontWeight is not null) result += $"\n\tfont-weight: {fontWeight};";
            if (fontVariant is not null) result += $"\n\tfont-variant: {fontVariant};";
            if (fontStretch is not null) result += $"\n\tfont-stretch: {fontStretch};";
            if (lineHeight is not null) result += $"\n\tline-height: {lineHeight};";

            return result;
        }
    }

    public static class FontFamily
    {
        public static string Serif = "serif";
        public static string SansSerif = "sans-serif";
        public static string Monospace = "monospace";
        public static string Cursive = "cursive";
        public static string Courier = "courier";
        public static string Arial = "Arial";
        public static string Fantasy = "fantasy";
        public static string SystemUi = "system-ui";
        public static string Math = "math";
    }

    public static class FontStyle
    {
        public static string Normal = "normal";
        public static string Italic = "italic";
        public static string Oblique = "oblique";
    }

    public static class FontVariant
    {
        public static string Normal = "normal";
        public static string SmallCaps = "small-caps";
    }

    public static class FontWeight
    {
        public static string Normal = "normal";
        public static string Bold = "bold";
        public static string Lighter = "lighter";
        public static string Bolder = "bolder";
    }
}
