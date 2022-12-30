using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library.BodyComponents
{
    public class LineBreak : BodyComponent
    {
        public LineBreak()
            : base(new HtmlAttribute()) {}

        internal override string GetHtml(string outTab)
        {
            return $"{outTab}<br>";
        }
    }
}
