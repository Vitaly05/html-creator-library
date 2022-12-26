using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library.Components
{
    public class Button : HtmlComponent
    {
        public Button(string text)
        {
            this.text = text;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Button: {text}");
        }
    }
}
