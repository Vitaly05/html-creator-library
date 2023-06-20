namespace html_creator_library.HeadComponents
{
    public class Script : HeadComponent
    {
        private string scriptHtml;

        public Script(string src)
        {
            scriptHtml = $"<script src=\"{src}\"></script>";
        }

        internal override string GetHtml(string outTab)
        {
            return $"{outTab}{scriptHtml}";
        }
    }
}
