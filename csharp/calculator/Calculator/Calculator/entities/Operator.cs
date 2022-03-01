namespace Calculator.entities
{
    public class Operator
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public Operator()
        {
        }

        public Operator(int numberOne, int numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
        }

        public int Addition(int numberOne, int numberTwo)
        {
            return (numberOne + numberTwo);
        }

        public string Subtraction(int numberOne, int numberTwo)
        {
            return "(Addition) The result is: " + (numberOne - numberTwo) + " .";
        }

        public string Multiplication(int numberOne, int numberTwo)
        {
            return "(Multiplication) The result is: " + (numberOne * numberTwo);
        }

        public string Division(int numberOne, int numberTwo)
        {
            return "(Division) The result is: " + (numberOne / numberTwo);
        }



    }
}
