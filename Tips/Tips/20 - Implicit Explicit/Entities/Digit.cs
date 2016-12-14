namespace Tips.Entities
{
    public class Digit
    {
        public Digit(double d) { val = d; }
        public double val;


        // User-defined conversion from Digit to double
        public static implicit operator double(Digit d) => d.val;
        //  User-defined conversion from double to Digit
        public static implicit operator Digit(double d) => new Digit(d);

    }
}