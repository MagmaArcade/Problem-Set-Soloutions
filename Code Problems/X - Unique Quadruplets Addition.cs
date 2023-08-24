// Created By MagmaAracde
// Date: 1/1/23

namespace UniqueQuadrupletsAddition
{
    public class Func
    {
        List<int> ElementList = new List<int>();
       
        int result;
        int TargetNumber;

        public Func()
        {
            Console.WriteLine("This program is used to identify the 4 unique number that add to a target number");
            Console.WriteLine("What is your target number?");
            TargetNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("How many number would you like to enter?");
            int NumOfElements = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter each number");
            for (int a = 0; a < NumOfElements; a++)
            {
                ElementList.Add(Convert.ToInt32(Console.ReadLine()));
            }




            //the idea i have is to pop the first element everytime a sucsessful set of unique numbers were found. 
            // however that will only allow me to find most of the combinations, not all of the combinations 

            int target = TargetNumber;

            foreach (xxx)
                {
                foreach (var Element in ElementList.Select((value, pos) => new { pos, value }))
                {
                    if ((target - Element) >= 0)
                    {
                        target = target - Element;
                        validSet.add(Element);
                    }

                }
                //Pop first number "myList.RemoveAt(0);"
                validgroups.add(validSet)
            }
        }











        public void Print()
        {
            // print: most frequent element
            Console.WriteLine("input: nums = [" + string.Join(", ", ElementList) + "]" + ", target = " + TargetNumber);
            
            // to print i will need a loop to open all sets and the join code above to organise it
            Console.WriteLine("output: " + result);
        }
    }
}
