using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library
{
    public abstract class HtmlCodeElements
    {
        protected string innerTab;

        internal abstract string GetHtml(string outTab);
    }
}
