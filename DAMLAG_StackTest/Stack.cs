namespace DAMLAG_StackTest
{
    public class Stack
    {
        protected static List<uint> elements = new List<uint>();
        private uint maxElement = 0;
        protected static double Sum =0;
        public void Push(uint number)
        {
            elements.Add(number);
            Sum += number;
            if (number > maxElement)
            {
                maxElement = number;
            }
        }

        public uint? Pop()
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
                return null;
            }

            uint poppedElement = elements.Last();
            elements.RemoveAt(elements.Count - 1);
            Sum -= poppedElement;

            if (poppedElement == maxElement && elements.Count > 0)
            {
                maxElement = elements[0];
                for (int i = 1; i < elements.Count; i++)
                {
                    if (elements[i] > maxElement)
                    {
                        maxElement = elements[i];
                    }
                }
            }
            else if (elements.Count == 0)
            {
                maxElement = 0;
            }

            return poppedElement;
        }

        public uint? Max()
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
                return null;
            }

            return maxElement;
        }
    }
}
