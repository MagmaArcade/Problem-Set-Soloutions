// Created By MagmaAracde
// Date: 1/1/23

namespace TallyMajorityElement
{
    public class Func
    {
        List<int> ElementList = new List<int>();
        List<int> IdentifiedElements = new List<int>();
        List<int> IdentifiedElementsCounter = new List<int>();
        int result;

        public Func(int input)
        {
             // this loop i used to enter all of the elements into the array
            for (int a = 0; a < input; a++)
            {
                ElementList.Add(Convert.ToInt32(Console.ReadLine()));
            }


            // calculations: tally
            // this module compares list of given numbers against a new list 
            // if the number is found the corrosponding position in the counter list will increment
            // if the number cannot be found then the element will be added to the list and the corrosponding position will be incremented
            // this loop will end once all elements are identified
            foreach (int Element in ElementList)
            {
                bool ElementFound = false;
                foreach (var IdentifiedElement in IdentifiedElements.Select((value, pos) => new { pos, value }))
                {
                    if (Element == IdentifiedElement.value)
                    {
                        IdentifiedElementsCounter[IdentifiedElement.pos] += 1;
                        ElementFound = true;
                    }
                }
                if (ElementFound == false)
                {
                    IdentifiedElements.Add(Element);
                    IdentifiedElementsCounter.Add(1);
                }
            }

            int maxVal = 0;
            // calculations: output
            // used to identify which number has the highest frequency
            foreach (var ElementCounter in IdentifiedElementsCounter.Select((value, pos) => new { pos, value }))
            {
                if (ElementCounter.value > maxVal)
                {
                    maxVal = ElementCounter.value;
                    result = IdentifiedElements[ElementCounter.pos];
                }
            }
        }

        public void Print()
        {
        // print: most frequent element
        Console.WriteLine("input: [" + string.Join(", ", ElementList) + "]");
        Console.WriteLine("output: " + result);
        }
    }
}
