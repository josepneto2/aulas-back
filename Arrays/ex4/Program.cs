namespace ex4 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[] numeros = new int[50];
            int total = 0;

            Console.WriteLine("Adicionando números...");
            for (int i = 0; i < numeros.Length; i++) { 
                int numero = random.Next(1, 101);
                numeros[i] = numero;
                total += numero;
                Console.WriteLine($"{i + 1}: {numeros[i]}");
            }
            Console.WriteLine($"Total: {total}");
            
            double media = total / numeros.Length;
            Console.WriteLine($"Média: {media}");

            Console.WriteLine($"Números menores que a média: {media}");
            foreach (int numero in numeros) {
                if (numero < media) {
                    Console.Write($"{numero} ");
                }
            }
        }
    }
}
