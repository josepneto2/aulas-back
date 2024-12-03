namespace ex5 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random();
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++) {
                numeros[i] = random.Next(1, 101);
            }
            
            Console.WriteLine("----- ORDEM INICIAL -----");
            Imprimir(numeros);

            Console.WriteLine("----- ORDENAR CRESCENTE -----");
            int[] numerosOrdenadosCrescente = OrdenarCrescente(numeros);
            Imprimir(numerosOrdenadosCrescente);
            
            Console.WriteLine("----- ORDENAR DECRESCENTE -----");
            int[] numerosOrdenadosDecrescente = OrdenarDecrescente(numeros);
            Imprimir(numerosOrdenadosDecrescente);

        }

        private static int[] OrdenarDecrescente(int[] numeros) {
            for (int i = 0; i < numeros.Length - 1; i++) {
                for (int j = i + 1; j < numeros.Length; j++) {
                    if (numeros[i] < numeros[j]) {
                        int auxiliar = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = auxiliar;
                    }
                }
            }
            return numeros;
        }

        private static int[] OrdenarCrescente(int[] numeros) {
            for (int i = 0; i < numeros.Length - 1; i++) {
                for (int j = i + 1; j < numeros.Length; j++) {
                    if (numeros[i] > numeros[j]) {
                        int auxiliar = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = auxiliar;
                    }
                }
            }
            return numeros;
        }

        private static void Imprimir(int[] numeros) {
            for (int i = 0; i < numeros.Length; i++) {
                Console.WriteLine($"{i} - {numeros[i]}");
            }
            Console.WriteLine();
        }
    }
}
