namespace html_creator_library
{
    public abstract class BodyComponent : HtmlComponent
    {
        protected HtmlAttribute attribute;

        protected BodyComponent(HtmlAttribute attribute)
        {
            this.attribute = attribute;
        }
    }
}
