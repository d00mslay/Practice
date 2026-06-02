namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartStack<int> stack = new SmartStack<int>(5);

            try
            {
                stack.Peek();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Contains(2));

            SmartStack<int> stack2 = new SmartStack<int>(new List<int> { 6, 7, 8, 9 });

            stack.PushRange(stack2);
            Console.WriteLine(stack.Capacity);

            stack[4] = -1;

            for (int i = 0; i < stack.Count; i++)
            {
                Console.Write($"{stack[i]} ");
            }
            Console.WriteLine();

            List<int> list = new List<int> { 10, 6, 3, 5, 4, 1, 9, 8, 2, 7 };
            var query = list
                .GroupBy(g => g % 2)
                .OrderBy(p => p.Key)
                .Select(g => new {Key = g.Key, Items = g.OrderBy(x => x)});
            foreach (var item in query)
            {
                foreach (var item1 in item.Items)
                {
                    Console.Write($"{item1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
