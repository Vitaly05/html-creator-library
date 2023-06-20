namespace html_creator_library.BodyComponents
{
    public class BodyScript : BodyComponent
    {
        private string scriptHtml;

        public BodyScript(string src)
            : base(new HtmlAttribute())
        {
            scriptHtml = $"<script src=\"{src}\"></script>";
        }

        internal override string GetHtml(string outTab)
        {
            return $"{outTab}{scriptHtml}";
        }
    }
}
