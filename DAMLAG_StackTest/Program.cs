namespace DAMLAG_StackTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Extras extras = new Extras();
            bool IsContinued = true;

            while (IsContinued)
            {
                Console.WriteLine("1-Push  ,  2-Pop   ,3-Mean   ,4-Max   ,5-exit");
                int.TryParse(Console.ReadLine(),out int choice);
                switch (choice)
                {
                    case 1:  
                        Console.WriteLine("write number to push");
                        uint.TryParse(Console.ReadLine(), out uint num);
                        stack.Push(num);
                        break;
                    case 2: 
                        Console.WriteLine("Popped: " + stack.Pop());
                        break;
                    case 3:
                        Console.WriteLine("Mean: " + extras.Mean());
                        break;
                    case 4:
                        Console.WriteLine("Max: " + stack.Max());
                        break;
                    default:
                        IsContinued = false;
                        break;
                }
            }


            Console.WriteLine("Prove why is your solution considered fast(er)?\r\n " );
            Console.WriteLine("-----------------------------------------------" );

            Console.WriteLine("Constant Time Complexity for Max:\r\n\r\n" +
                "The Max method in the Stack class returns the maximum value in constant time,O(1) " +
                " This is because the maximum value is updated and stored during each Push operation.\r\n\r\n\r\n\r\n");
            Console.WriteLine("Efficient Push Method:\r\n\r\n" +
                "The Push method has a time complexity of O(1) for adding an element to the stack." +
                " Additionally, it updates the maximum value if the new element is greater than the current maximum." +
                "and the sum value after pop and push methods . "+
                " This ensures that the Max and main method remains efficient.\r\n\r\n\r\n\r\n");

            Console.WriteLine("Optimized Pop Method: \r\n\r\n" +
                "The Pop method removes the last element in O(1) time. and recaculate the sum value ," +
                " If the popped element is the current maximum," +
                " it recalculates the maximum by iterating through the remaining elements. " +
                "This recalculation only occurs when necessary, ensuring that the Pop method is generally efficient.\r\n\r\n\r\n\r\n"
                );


        }
    }
}
