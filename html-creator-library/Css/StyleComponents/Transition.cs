namespace html_creator_library.Css.StyleComponents
{
    public class Transition : StyleComponent
    {
        private string property;
        private string duration;
        private string timingFunction;
        private string delay;

        public Transition(string property)
        {
            this.property = property;
        }

        public Transition SetDuration(string duration)
        {
            this.duration = duration;
            return this;
        }
        public Transition SetTimingFunction(string timingFunction)
        {
            this.timingFunction = timingFunction;
            return this;
        }
        public Transition SetDelay(string delay)
        {
            this.delay = delay;
            return this;
        }

        internal override string GetCss()
        {
            string result = $"\ttransition-property: {property};";

            if (duration is not null) result += $"\n\ttransition-duration: {duration};";
            if (timingFunction is not null) result += $"\n\ttransition-timing-function: {timingFunction};";
            if (delay is not null) result += $"\n\ttransition-delay: {delay};";

            return result;
        }
    }

    public static class DefaultProperty
    {
        public static string Background = "background";
        public static string Border = "border";
        public static string Shadow = "shadow";
        public static string Color = "color";
        public static string Height = "height";
        public static string Width = "width";
        public static string Opacity = "opacity";
    }

    public static class TimingFunction
    {
        public static string Ease = "ease";
        public static string EaseIn = "ease-in";
        public static string EaseOut = "ease-out";
        public static string EaseInOut = "ease-in-out";
        public static string Linear = "linear";
        public static string StepStart = "step-start";
        public static string StepEnd = "step-end";
    }
}
