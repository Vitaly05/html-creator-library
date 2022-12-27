using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library
{
    public class Body
    {
        private List<HtmlComponent> htmlComponents = new();

        private string innerTab;

        public void SetContext(params HtmlComponent[] components)
        {
            foreach (var component in components)
            {
                htmlComponents.Add(component);
            }
        }
        
        internal string GetHtml(string outTab)
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
