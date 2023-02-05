namespace html_creator_library.Css.StyleComponents
{
    public class Gradient
    {
        private string gradientType;
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

        public override string ToString()
        {
            return $"{gradientType}({colors})";
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
