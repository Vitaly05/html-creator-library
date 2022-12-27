using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library.Components
{
    public class Button : HtmlComponent
    {
        private string innerTab;

        public Button(string text)
        {
            this.text = text;
        }

        public override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";
            return 
                $"{outTab}<button>\n" +
                $"{innerTab}{text}\n" +
                $"{outTab}</button>";
        }
    }
}
