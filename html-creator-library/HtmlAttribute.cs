namespace html_creator_library
{
    public class HtmlAttribute
    {
        private string attrubutes;

        private void addAttrubute(string attribute)
        {
            attrubutes += $" {attribute}";
        }

        internal string GetAttributes()
        {
            return attrubutes;
        }

        public HtmlAttribute Class(string className)
        {
            addAttrubute($"class=\"{className}\"");
            return this;
        }
        public HtmlAttribute Id(string id)
        {
            addAttrubute($"id=\"{id}\"");
            return this;
        }
    }
}
