namespace ex3 {
    internal class Program {
        static void Main(string[] args) {
            int[] valores = new int[] { 32, 12, 1, 77, 71, 90, 3, 10, 47, 28, 2 };

            Console.WriteLine("Ordem correta: ");
            for (int i = 0; i < valores.Length; i++) {
                Console.WriteLine(valores[i]);
            }
            
            Console.WriteLine("Ordem inversa: ");
            for (int i = (valores.Length - 1); i >= 0; i--) {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
