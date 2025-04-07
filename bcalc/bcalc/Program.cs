class Program { 

    public static void Main(string[] args)
    {
        if(!Int32.TryParse(Console.ReadLine(), out var a))
        {
            Convert.ToString(a, 2);
            Console.WriteLine("Wrong sign, try of 10 Sys of Numbs");
            return;
        }

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Convert.ToString(b, 2);
            Console.WriteLine("Wrong sign, try of 10 Sys of Numbs");
            return;
        }

        string c = Console.ReadLine();
        if (c.Length == 0 || c.Length > 1)

        {
            Console.WriteLine("Incorect char");
            return;
        }

        switch (c) {

            case "|":
                var d = Convert.ToString(a | b, 2);
                var e = Convert.ToString(a | b, 10);
                var f = Convert.ToString(a | b, 16);
                Console.WriteLine("Result of {0} | {1} = {2} (2)",a, b, d);
                Console.WriteLine("Result of {0} | {1} = {2} (10)", a, b, e);
                Console.WriteLine("Result of {0} | {1} = {2} (16)", a, b, f);
                break;
            case "&":
                var d1 = Convert.ToString(a & b, 2);
                var e1 = Convert.ToString(a & b, 10);
                var f1 = Convert.ToString(a & b, 16);
                Console.WriteLine("Result of {0} | {1} = {2} (2)", a, b, d1);
                Console.WriteLine("Result of {0} | {1} = {2} (10)", a, b, e1);
                Console.WriteLine("Result of {0} | {1} = {2} (16)", a, b, f1);
                break;
            case "^":
                var d2 = Convert.ToString(a ^ b, 2);
                var e2 = Convert.ToString(a ^ b, 10);
                var f2 = Convert.ToString(a ^ b, 16);
                Console.WriteLine("Result of {0} | {1} = {2} (2)", a, b, d2);
                Console.WriteLine("Result of {0} | {1} = {2} (10)", a, b, e2);
                Console.WriteLine("Result of {0} | {1} = {2} (16)", a, b, f2);
                break;
            default:
                Console.WriteLine("Incorect char, try 0bOperator (&,|,^), soon(! or ~)");
                break;
        }
    }
}