namespace pz_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной N, N > 0");
            string S = "some text";
            int N;
            N = Convert.ToInt32(Console.ReadLine());

            if (S.Length > N)
            {
                Console.WriteLine(S.Remove(0, S.Length - N));
            }
            else if (S.Length < N)
            {
                Console.WriteLine(S.PadLeft(N - S.Length, '.'));
            }
        }
    }
}