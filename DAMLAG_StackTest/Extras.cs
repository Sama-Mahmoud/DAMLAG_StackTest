namespace DAMLAG_StackTest
{
    public class Extras : Stack
    {
        public double? Mean()
        {
            if (elements.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
                return null;
            }

            return (Sum / elements.Count);
        }
    }
}
