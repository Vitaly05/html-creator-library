namespace html_creator_library
{
    public class Body : HtmlCodeElements
    {
        private List<HtmlComponent> htmlComponents = new();

        public void SetContext(params HtmlComponent[] components)
        {
            foreach (var component in components)
            {
                htmlComponents.Add(component);
            }
        }
        
        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return 
                $"{outTab}<body>\n" +
                $"{getComponentsHtml()}\n" +
                $"{outTab}</body>";
        }

        private string getComponentsHtml()
        {
            string componentsHtml = "\n";
            foreach (var component in htmlComponents)
            {
                componentsHtml += component.GetHtml(innerTab) + "\n";
            }
            return componentsHtml;
        }
    }
}
