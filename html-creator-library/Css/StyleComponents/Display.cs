namespace html_creator_library.Css.StyleComponents
{
    public class Display : StyleComponent
    {
        private string displayType;
        private string justifyContent;

        public Display(string displayType)
        {
            this.displayType = displayType;
        }
        public Display(string displayType, string justifyContent) : this(displayType)
        {
            this.justifyContent = justifyContent;
        }

        internal override string GetCss()
        {
            string result = $"\tdisplay: {displayType};";
            if (justifyContent is not null)
            {
                result += $"\n\tjustify-content: {justifyContent};";
            }

            return result;
        }
    }

    public static class DisplayType
    {
        public static string Block = "block";
        public static string Inline = "inline";
        public static string InlineBlock = "inline-block";
        public static string Flex = "flex";
        public static string InlineFlex = "inline-flex";
        public static string Grid = "grid";
        public static string InlineGrid = "inline-grid;";
        public static string FlowRoot = "flow-root";
    }

    public static class JustifyContent
    {
        public static string Center = "center";
        public static string Start = "start";
        public static string End = "end";
        public static string FlexStart = "flex-start";
        public static string FlexEnd = "flex-end";
        public static string Left = "left";
        public static string Right = "right";
        public static string Normal = "normal";
        public static string SpaceBetween = "space-between";
        public static string SpaceAround = "space-around";
        public static string SpaceEvenly = "space-evenly";
        public static string Stretch = "stretch";
    }
}
