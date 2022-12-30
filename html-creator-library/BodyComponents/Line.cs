using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library.BodyComponents
{
    public class Line : BodyComponent
    {
        public Line()
            : this(new HtmlAttribute()) { }

        public Line(HtmlAttribute attribute)
            : base(attribute) { }

        internal override string GetHtml(string outTab)
        {
            return $"{outTab}<hr{attribute.GetAttributes()}>";
        }
    }
}
