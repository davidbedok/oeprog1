namespace Calculator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            System.Console.WriteLine("Calculator Demo");
            int opLeft; // escape char --> -1
            int opRight;
            char op;
            int result;
            int resultCalc;
            int numberOfQuestion = 0;
            int numberOfGoodAnswer = 0;
            do {
                System.Console.Write("opLeft? (int. exit: -1) ");
                opLeft = System.Convert.ToInt32(System.Console.ReadLine());
                if (opLeft != -1)
                {
                    numberOfQuestion++;
                    do {
                        System.Console.Write("Op? (+, -, *) ");
                        // op = char.Parse(System.Console.ReadLine());
                        op = System.Char.Parse(System.Console.ReadLine());
                        // op = System.Convert.ToChar(System.Console.ReadLine());
                    } while ( (op != '+') && (op != '-') && (op != '*'));
                    
                    System.Console.Write("opRight? (int) ");
                    opRight = System.Int32.Parse(System.Console.ReadLine());
                    resultCalc = 0;
                    switch (op)
                    {
                        case '+':
                            resultCalc = opLeft + opRight;
                            break;
                        case '-':
                            resultCalc = opLeft - opRight;
                            break;
                        case '*':
                            resultCalc = opLeft * opRight;
                            break;
                    }
                    System.Console.Write(opLeft + " " + op + " " + opRight + " = ");
                    result = System.Int32.Parse(System.Console.ReadLine());
                    if (result == resultCalc)
                    {
                        numberOfGoodAnswer++;
                    }
                }
            } while (opLeft != -1);
            System.Console.WriteLine("Statistics....");
            System.Console.WriteLine("Number of question: " + numberOfQuestion);
            System.Console.WriteLine("Number of good answer: " + numberOfGoodAnswer);
            System.Console.WriteLine("Number of wrong answer: " + (numberOfQuestion - numberOfGoodAnswer));
            System.Console.WriteLine("Percent: " + ((double)numberOfGoodAnswer / numberOfQuestion * 100) + "%");
            System.Console.ReadKey();
        }
    }
}
