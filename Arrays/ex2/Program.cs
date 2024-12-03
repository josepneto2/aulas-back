namespace ex2 {
    internal class Program {
        static void Main(string[] args) {
            string[] nomes = new string[3];

            for (int i = 0; i < nomes.Length; i++) {
                Console.Write($"Digite o nome do aluno {i+1}: ");
                nomes[i] = Console.ReadLine();
            }

            Console.Write("Digite o número do aluno que quer ver: ");
            int numero = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine(nomes[numero]);
        }
    }
}
