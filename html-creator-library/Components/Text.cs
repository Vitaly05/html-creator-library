using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library.Components
{
    public class Text : HtmlComponent
    {
        private string textType;
        private string text;

        public Text(string textType, string text)
        {
            this.textType = textType;
            this.text = text;
        }

        internal override string GetHtml(string outTab)
        {
            innerTab = outTab + "\t";

            if (textType == TextType.Default)
                return $"{outTab}{text}";

            return
                $"{outTab}" +
                $"<{textType}>" +
                $"{text}" +
                $"</{textType}>";
        }
    }

    public static class TextType
    {
        public static string H1 = "h1";
        public static string P = "p";
        public static string Default = "";
    }
}
