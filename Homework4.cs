namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        //Q1
    {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            int largest_number = largest(a, b);
            Console.WriteLine("The largest number is: " + largest_number);
        }
        static int largest(int a, int b) {
            if (a >= b)
                return a;
            else
                return b;
        }
    }
    }
// I don't know how to do Q2

    
    

    
   
    



