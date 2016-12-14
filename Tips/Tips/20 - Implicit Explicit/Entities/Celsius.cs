namespace Tips.Entities
{

    public class Celsius
    {
        public Celsius(float temp)
        {
            _degrees = temp;
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((9.0f / 5.0f) * c._degrees + 32);
        }
        public float Degrees => _degrees;
        private readonly float _degrees;
    }

    public class Fahrenheit
    {
        public Fahrenheit(float temp)
        {
            _degrees = temp;
        }

        public static explicit operator Celsius(Fahrenheit fahr)
        {
            return new Celsius((5.0f / 9.0f) * (fahr._degrees - 32));
        }
        public float Degrees => _degrees;
        private readonly float _degrees;
    }
}
