namespace html_creator_library
{
    public abstract class HtmlComponent
    {
        protected string innerTab;

        protected List<HtmlComponent> innerHtmlComponents = new();

        internal abstract string GetHtml(string outTab);

        public string GetStringHtml()
        {
            return GetHtml("");
        }

        protected string getInnerComponentsHtml()
        {
            if (innerHtmlComponents.Count == 0)
                return "";

            string componentsHtml = "";
            foreach (var component in innerHtmlComponents)
            {
                componentsHtml += component.GetHtml(innerTab) +
                    (innerHtmlComponents.Last() != component ? "\n" : "");
            }
            return componentsHtml;
        }
    }
}
