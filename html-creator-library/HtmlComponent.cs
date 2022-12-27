using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library
{
    public abstract class HtmlComponent
    {
        protected string innerTab;

        protected List<HtmlComponent> innerHtmlComponents = new();

        internal abstract string GetHtml(string outTab);

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
