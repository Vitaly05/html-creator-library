namespace html_creator_library.Css.StyleComponents
{
    public class Background : StyleComponent
    {
        private string color;
        private string imageUrl;
        private Gradient gradient;
        private string attachment;
        private string repeat;

        public Background SetColor(string color)
        {
            this.color = color;
            return this;
        }
        public Background SetImage(string imageUrl)
        {
            this.imageUrl = $"url({imageUrl})";
            return this;
        }
        public Background SetGradient(Gradient gradient)
        {
            this.gradient = gradient;
            return this;
        }
        public Background SetAttachment(string attachment)
        {
            this.attachment = attachment;
            return this;
        }
        public Background SetRepeat(string repeat)
        {
            this.repeat = repeat;
            return this;
        }
        public Background SetRepeat(string horizontal, string vertical)
        {
            return this.SetRepeat($"{horizontal} {vertical}");
        }

        internal override string GetCss()
        {
            string result = "";

            if (color is not null) result += $"\n\tbackground-color: {color};";
            if (imageUrl is not null) result += $"\n\tbackground-image: {imageUrl};";
            if (gradient is not null) result += $"\n\tbackground-image: {gradient};";
            if (attachment is not null) result += $"\n\tbackground-attachment: {attachment};";
            if (repeat is not null) result += $"\n\tbackground-repeat: {repeat};";

            return result;
        }
    }

    public static class AttachmentType
    {
        public static string Scroll = "scroll";
        public static string Fixed = "fixed";
        public static string Local = "local";
    }

    public static class RepeatType
    {
        public static string RepeatX = "repeat-x";
        public static string RepeatY = "repeat-y";
        public static string Repeat = "repeat";
        public static string Space = "space";
        public static string Round = "round";
        public static string NoRepeat = "no-repeat";
    }
}
