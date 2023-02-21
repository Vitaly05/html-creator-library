namespace html_creator_library.HeadComponents
{
    public class Meta : HeadComponent
    {
        private string html;

        internal override string GetHtml(string outTab)
        {
            return $"{outTab}{html}";
        }

        public Meta() { }
        public Meta(string charset)
        {
            html = $"<meta charset=\"{charset}\" >";
        }

        public Meta HttpEquiv(string httpEquiv, string content)
        {
            html = $"<meta http-equiv=\"{httpEquiv}\" content=\"{content}\" >";
            return this;
        }
        public Meta Name(string name, string content)
        {
            html = $"<meta name=\"{name}\" content=\"{content}\" >";
            return this;
        }
    }
}
