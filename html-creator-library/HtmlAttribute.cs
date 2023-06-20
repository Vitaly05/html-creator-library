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
        public HtmlAttribute Name(string name)
        {
            addAttribute($"name=\"{name}\"");
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
        public HtmlAttribute Color(string color)
        {
            addAttribute($"color=\"{color}\"");
            return this;
        }
        public HtmlAttribute Size(string size)
        {
            addAttribute($"size=\"{size}\"");
            return this;
        }
        public HtmlAttribute Width(string width)
        {
            addAttribute($"width=\"{width}\"");
            return this;
        }
        public HtmlAttribute Height(string height)
        {
            addAttribute($"height=\"{height}\"");
            return this;
        }
        public HtmlAttribute For(string value)
        {
            addAttribute($"for=\"{value}\"");
            return this;
        }

        public HtmlAttribute Custom(string attribute)
        {
            addAttribute(attribute);
            return this;
        }
    }
}
