using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library.HeadComponents
{
    public class Title : HeadComponent
    {
        private string title;
        public Title(string title)
        {
            this.title = title;
        }

        internal override string GetHtml(string outTab)
        {
            return
                $"{outTab}<title>{title}</title>";
        }
    }
}
