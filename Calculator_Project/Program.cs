namespace CalProject
{
   
    public class Project
    {  
        int number1 = 0;
        int number2 = 0;
        int total = 0;

        public static void Main()
        {

            Console.WriteLine("Enter Option:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Option:");
            int number2 = int.Parse(Console.ReadLine());


            Console.WriteLine("ENTER AN OPTION");
            Console.WriteLine("+ , Addition");
            Console.WriteLine("- , Subtraction");
            Console.WriteLine("* ,Multiplication");
            Console.WriteLine("/ , Division");

            switch (Console.ReadLine())
            {

                case "+":
                    int total = (number1 + number2);
                    Console.WriteLine("your Addition is {0}: ", total);
                    break;


                case "-":
                    total = (number1 - number2);
                    Console.WriteLine("your Subtraction is {0}: ", total);
                    break;


                case "*":
                    total = (number1 + number2);
                    Console.WriteLine("your Multiplication is {0}: ", total);
                    break;


                case "/":
                    total = (number1 / number2);
                    Console.WriteLine("your Division is {0}: ", total);
                    break;

                default:
                    Console.WriteLine("your input is invalid");
                    break;

            }







        }
    }
}