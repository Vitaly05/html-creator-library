using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library
{
    public class HTML
    {
        private List<HtmlComponent> htmlComponents = new();

        public void SetContext(params HtmlComponent[] components)
        {
            foreach(var component in components)
            {
                htmlComponents.Add(component);
            }
        }

        public void PrintComponentsInfo()
        {
            foreach (var component in htmlComponents)
            {
                component.GetInfo();
            }
        }
    }
}
