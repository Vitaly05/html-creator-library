namespace html_creator_library.HeadComponents
{
    public class Link : HeadComponent
    {
        private string linkHtml;

        public Link(string href, string rel)
        {
            linkHtml = $"<link href=\"{href}\" rel=\"{rel}\" >";
        }

        internal override string GetHtml(string outTab)
        {
            return $"{outTab}{linkHtml}";
        }
    }

    public static class Relation
    {
        public static string Stylesheet = "stylesheet";
    }
}
