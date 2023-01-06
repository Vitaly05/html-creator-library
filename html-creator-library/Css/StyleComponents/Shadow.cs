namespace html_creator_library.Css.StyleComponents
{
    public class Shadow : StyleComponent
    {
        private string shadowType;
        private string offsetX;
        private string offsetY;
        private string blur;
        private string shadowColor;

        public Shadow(string type, string offsetX, string offsetY, string blur, string color)
        {
            shadowType = type;
            this.offsetX = offsetX;
            this.offsetY = offsetY;
            this.blur = blur;
            shadowColor = color;
        }

        internal override string GetCss()
        {
            return $"\t{shadowType}-shadow: {offsetX} {offsetY} {blur} {shadowColor};";
        }
    }

    public static class ShadowType
    {
        public static string Box = "box";
        public static string Text = "text";
    }
}
