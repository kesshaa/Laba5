namespace ClassLibrary1
{
    public class Variant_0Base
    {
        //задание 1
        public static int Task1(double[] x)
        {
            int[] b = new int[20];
            Random random = new Random();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = random.Next(-10, 10);
            }
            for (int i = 0; i < 20; i++)
                Console.WriteLine($"b[{i + 1}]={b[i]}");
            int s = 0;
            for (int i = 1; i < b.Length; i += 2)
            {
                if (b[i] < 15)
                {
                    s += b[i];
                }
            }
        }
    }
}