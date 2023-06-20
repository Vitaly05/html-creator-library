namespace html_creator_library
{
    using Css;
    public class HTML
    {
        private Body body;
        private Head head;
        private List<Style> styles = new();

        public HTML(Body body = null, Head head = null)
        {
            this.body = body ?? new Body();
            this.head = head ?? new Head();
        }

        public void SetStyles(params Style[] styles)
        {
            this.styles.AddRange(styles);
        }

        public void SaveFile(string path = "../../../../", string htmlName = null, string cssName = null)
        {
            if (styles.Count > 0)
                saveCss(path, cssName ?? "style.css");
            saveHtml(path, htmlName ??"index.html");
        }

        public string GetStringHtml()
        {
            return getHtml();
        }

        private void saveHtml(string path, string name)
        {
            using (StreamWriter sw = new(new FileStream(path + name, FileMode.Create)))
            {
                sw.Write(getHtml());
            }
        }
        private void saveCss(string path, string name)
        {
            head.AddStyle(name);

            using (StreamWriter sw = new(new FileStream(path + name, FileMode.Create)))
            {
                foreach (Style style in styles)
                {
                    sw.Write(style.GetCss() +
                        (styles.Last() != style ? "\n\n" : ""));
                }
            }
        }

        private string getHtml()
        {
            return 
                $"<!DOCTYPE html>\n" +
                $"<html>\n" +
                $"{head.GetHtml("\t")}\n" +
                $"{body.GetHtml("\t")}\n" +
                $"</html>";
        }
    }
}
