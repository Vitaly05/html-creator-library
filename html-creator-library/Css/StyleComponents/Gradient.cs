namespace html_creator_library.Css.StyleComponents
{
    public class Gradient
    {
        private string gradientType;
        private string angle;
        private string colors = "";

        public Gradient(string gradientType, params string[] colors)
        {
            this.gradientType = gradientType;
            for (int iii = 0; iii < colors.Length; iii++)
            {
                this.colors += colors[iii];
                if (iii != colors.Length - 1) this.colors += ", ";
            }
        }
        public Gradient(string gradientType, string angle, params string[] colors)
            : this(gradientType, colors)
        {
            this.angle = angle;
        }

        public override string ToString()
        {
            string result = $"{gradientType}(";
            if (angle is not null) result += $"{angle}, ";
            result += $"{colors})";

            return result;
        }
    }

    public static class GradientType
    {
        public static string LinearGradient = "linear-gradient";
        public static string RadialGradient = "radial-gradient";
        public static string RepeatingLinearGradient = "repeating-linear-gradient";
        public static string RepeatingRadialGradient = "repeating-radial-gradient";
        public static string ConicGradient = "conic-gradient";
    }
}
