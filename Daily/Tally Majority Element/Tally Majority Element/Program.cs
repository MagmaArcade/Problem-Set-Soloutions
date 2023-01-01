// Created By MagmaAracde
// Date: 1/1/23

// Note this was developed with number in mind. Thus, int has been used. Changes could allow work with strings as well.
namespace TallyMajorityElement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is used to identify the number that occurs most frequent");
            Console.WriteLine("How many number would you like to enter?");
            int NumOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter each number");
            Func myFunc;
            myFunc = new Func(NumOfElements);

            myFunc.Print();
        }
    }
}