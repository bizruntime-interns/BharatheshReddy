using System;
namespace Program
{
    class csharp
    {
        public void Age()
        {
        NotEligible:
            Console.WriteLine("notEligible");

            Console.WriteLine("enter the age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
            {
                goto NotEligible;
            }
            else
            {
                Console.WriteLine("Eligible");
            }
        }

        public void While()
        {
            int i = 1;
            do
            {
                int j = 1;

                do
                {
                    Console.WriteLine(i + " " + j);
                    j++;
                } while (j <= 3);
                i++;
            } while (i <= 3);
        }

        public void For()
        {
            for (int a = 1; a <= 10; a++)
            {
                if (a == 5)
                {
                    break;
                }
                Console.WriteLine(a);
            }
        }
        public void Message(string message)
        {
            Console.WriteLine("HellO" + message);
        }

        public void outputer(out int val1)
        {
            int square = 5;
            val1 = square;
            val1 *= val1;
        }


    }

    namespace Functions
    {
        class function
        {
            public void Show(int val)
            {
                val *= val;
                Console.WriteLine("value is" + val);

            }

            class callByReference {
                public void reference(ref int value)
                {
                    value += value;
                    Console.WriteLine("intial value   " + value);
                }
                public static void Main(string[] args)
                {
                    csharp c = new csharp();
                    c.Age();
                    c.For();
                    c.While();
                    c.Message("World");

                    int val = 50;
                    Console.WriteLine("before calling the function   " + val);
                    function f = new function();
                    f.Show(val);
                    Console.WriteLine("After calling the function   " + val + '\n');

                    Console.WriteLine("enter the reference function value:    ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("before calling the reference function   " + value);
                    callByReference reference = new callByReference();
                    reference.reference(ref value);
                    Console.WriteLine("After calling the reference function   " + value + '\n');

                    int val1 = 50;
                    csharp program = new csharp();
                    Console.WriteLine("Value before passing out variable " + val1);
                    program.outputer(out val1);
                    Console.WriteLine("Value after recieving the out variable " + val1 + '\n');

                    Arrays.Array1d array1D = new Arrays.Array1d();
                    array1D.array();


                }
            }

        }
    }
    namespace Arrays
    {
        class Array1d
        {
            public void array()
            {
                int[] arr = new int[5];
                arr[0] = 10;
                arr[1] = 20;
                arr[2] = 30;

                for (int i = 0; i < arr.Length; i++)
                {              
                    Console.WriteLine("the array elements are"+arr[i]);
                }
            }


           
        }
       

    }
}