using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library
{
    public abstract class HtmlComponent
    {
        protected string text;

        abstract public void GetInfo();
    }
}
