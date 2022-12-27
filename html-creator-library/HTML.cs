using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_creator_library
{
    public class HTML
    {
        private Body body = new Body();
        private string tab = "\t";

        public void SetBody(Body body)
        {
            this.body = body;
        }

        public void SaveFile(string path = "../../../../index.html")
        {
            using (StreamWriter sw = new(new FileStream(path, FileMode.Create)))
            {
                sw.Write(getHtml());
            }
        }

        private string getHtml()
        {
            return 
                $"<!DOCTYPE html>\n" +
                $"<html>\n" +
                $"{body.GetHtml(tab)}\n" +
                $"</html>";
        }
    }
}
