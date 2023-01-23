namespace html_creator_library.Css.StyleComponents
{
    public class Indent : StyleComponent
    {
        private string indentType;
        private string indents;

        public Indent(string indentType, string indent)
        {
            this.indentType = indentType;
            this.indents = indent;
        }
        public Indent(string indentType, string verticalIndent, string horizontalIndent)
        {
            this.indentType = indentType;
            this.indents = $"{verticalIndent} {horizontalIndent}";
        }
        public Indent(string indentType, string topIndent, 
            string horizontalIndent, string bottomIndent)
        {
            this.indentType = indentType;
            this.indents = $"{topIndent} {horizontalIndent} {bottomIndent}";
        }
        public Indent(string indentType, string topIndent, 
            string rightIndent, string bottomIndent, string leftIndent)
        {
            this.indentType = indentType;
            this.indents = $"{topIndent} {rightIndent} {bottomIndent} {leftIndent}";
        }

        internal override string GetCss()
        {
            return $"\t{indentType}: {indents};";
        }
    }

    public static class IndentType
    {
        public static string Margin = "margin";
        public static string Padding = "padding";
    }
}
