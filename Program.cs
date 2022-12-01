namespace SerachInsert_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();
            int[] arr = { 1, 3, 4, 5 };
            var x = p.SearchInsert(arr, 4);
            Console.WriteLine(x);
        }

        //return the actual index or possible index of the element
        int SearchInsert(int[] nums, int target)
        {
            
            foreach (int x in nums)
            {
                if (x == target)
                {
                    return Array.IndexOf(nums, x);
                }
                else
                {
                    if (x > target)
                    {
                        return (Array.IndexOf(nums, x));
                    }
                    else if(x < target && Array.IndexOf(nums,x)==nums.Length-1)
                    {
                        return (Array.IndexOf(nums, x)) + 1;
                    }
                }
            }
            return 0;
        }
    }

   
}