namespace html_creator_library
{
    public class HTML
    {
        private Body body = new Body();
        private Head head = new Head();

        public HTML(Body body = null, Head head = null)
        {
            this.body = body ?? new Body();
            this.head = head ?? new Head();
        }

        public void SaveFile(string path = "../../../../index.html")
        {
            using (StreamWriter sw = new(new FileStream(path, FileMode.Create)))
            {
                sw.Write(getHtml());
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
