namespace pascals_triangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();

            if (numRows == 0)
            {
                return triangle;
            }

            triangle.Add(new List<int> { 1 });

            for (int i = 1; i < numRows; i++)
            {
                IList<int> row = new List<int>();
                IList<int> prevRow = triangle[i - 1];
                row.Add(1);
                for (int j = 1; j < i; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }
                row.Add(1);
                triangle.Add(row);
            }

            return triangle;
        }

        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int numRows = 5;

            var triangle = solution.Generate(numRows);

            Console.WriteLine("Треугольник Паскаля:");
            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
