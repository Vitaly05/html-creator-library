namespace html_creator_library
{
    public class HtmlAttribute
    {
        private string attrubutes;

        private void addAttribute(string attribute)
        {
            attrubutes += $" {attribute}";
        }

        internal string GetAttributes()
        {
            return attrubutes;
        }

        public HtmlAttribute Class(string className)
        {
            addAttribute($"class=\"{className}\"");
            return this;
        }
        public HtmlAttribute Id(string id)
        {
            addAttribute($"id=\"{id}\"");
            return this;
        }
        public HtmlAttribute AccessKey(string accessKey)
        {
            addAttribute($"accesskey=\"{accessKey}\"");
            return this;
        }
        public HtmlAttribute Data(string name, string value)
        {
            addAttribute($"data-{name}=\"{value}\"");
            return this;
        }
        public HtmlAttribute Dir(string dir)
        {
            addAttribute($"dir=\"{dir}\"");
            return this;
        }
        public HtmlAttribute Hidden(bool isHidden)
        {
            if (isHidden)
                addAttribute("hidden");

            return this;
        }
        public HtmlAttribute TabIndex(int tabIndex)
        {
            addAttribute($"tabindex=\"{tabIndex}\"");
            return this;
        }
        public HtmlAttribute Title(string title)
        {
            addAttribute($"title=\"{title}\"");
            return this;
        }
    }
}
