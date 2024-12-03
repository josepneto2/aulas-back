namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[3];
            double total = 0;

            for (int i = 0; i < 3; i++) {
                Console.Write($"Digite o valor da nota {i + 1}: ");
                double nota = double.Parse(Console.ReadLine());
                notas[i] = nota;
                total += nota;
            }

            double media = total / notas.Length;
            Console.WriteLine($"Média: {media}");
        }
    }
}
