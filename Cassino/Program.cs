

namespace Cassino {
    internal class Program {
        static Random random = new Random();
        static string nome = "";
        static int saldo = 100;

        static void Main(string[] args) {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();


            int opcao = 1;
            while (opcao != 0) {
                Console.Clear();
                Console.WriteLine($"Bem-vindo, {nome}! Saldo: R${saldo}");
                Console.WriteLine("Escolha uma da seguintes opções:");
                Console.WriteLine("1 - Loteria");
                Console.WriteLine("2 - Raspadinhas");
                Console.WriteLine("3 - Saldo");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao) {
                    case 0:
                        Console.WriteLine("Fim do programa");
                        break;
                    case 1:
                        Loteria();
                        break;
                    case 2:
                        Raspadinha();
                        break;
                    case 3:
                        Saldo();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void Saldo() {
            int opcao = 1;
            while (opcao != 0) {
                Console.Clear();
                Console.WriteLine($"Saldo disponível: R${saldo}");
                Console.WriteLine("Escolha uma das seguintes opções:");
                Console.WriteLine("1 - Saque");
                Console.WriteLine("2 - Depósito");
                Console.WriteLine("0 - Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao) {
                    case 0: break;
                    case 1:
                        Saque();
                        break;
                    case 2:
                        Deposito();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void Saque() {
            Console.Clear();

            Console.WriteLine($"Saldo atual: R${saldo}");
            Console.Write($"Digite o valor do saque: R$");
            int valor = int.Parse(Console.ReadLine());

            if ((saldo - valor) < 0) {
                Console.WriteLine("Saldo insuficiente");
            } else {
                saldo -= valor;

                Console.WriteLine($"Saque realizado com sucesso! Novo saldo: R${saldo}");
            }
            Console.ReadKey();
        }

        private static void Deposito() {
            Console.Clear();

            Console.WriteLine($"Saldo atual: R${saldo}");
            Console.Write($"Digite o valor do depósito: R$");
            int valor = int.Parse(Console.ReadLine());

            saldo += valor;

            Console.WriteLine($"Depósito realizado com sucesso! Novo saldo: R${saldo}");

            Console.ReadKey();
        }

        private static void Raspadinha() {
            int opcao = 1;
            while (opcao != 0) {
                Console.Clear();

                Console.WriteLine("Menu RASPADINHAS");
                Console.WriteLine("1 - Raspadinha A");
                Console.WriteLine("2 - Raspadinha B");
                Console.WriteLine("0 - Voltar");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 0:
                        break;
                    case 1:
                        RaspadinhaA();
                        break;
                    case 2:
                        RaspadinhaB();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void RaspadinhaA() {
            Console.Clear();

            if ((saldo - 2) < 0) {
                Console.WriteLine("Saldo insuficiente! Realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }
            saldo -= 2;

            int numPrincipal = random.Next(1, 11);
            int num1 = random.Next(1, 11);
            int num2 = random.Next(1, 11);
            int num3 = random.Next(1, 11);
            int num4 = random.Next(1, 11);
            int num5 = random.Next(1, 11);
            int premio1 = random.Next(1, 101);
            int premio2 = random.Next(1, 101);
            int premio3 = random.Next(1, 101);
            int premio4 = random.Next(1, 101);
            int premio5 = random.Next(1, 101);

            Console.WriteLine($"Número principal: {numPrincipal}");
            Console.WriteLine($"1º número: {num1} (R${premio1})");
            Console.WriteLine($"2º número: {num2} (R${premio2})");
            Console.WriteLine($"3º número: {num3} (R${premio3})");
            Console.WriteLine($"4º número: {num4} (R${premio4})");
            Console.WriteLine($"5º número: {num5} (R${premio5})");

            int premio = 0;

            if (num1 == numPrincipal) premio += premio1;
            if (num2 == numPrincipal) premio += premio2;
            if (num3 == numPrincipal) premio += premio3;
            if (num4 == numPrincipal) premio += premio4;
            if (num5 == numPrincipal) premio += premio5;

            Console.WriteLine($"Prêmio: R${premio}");
            saldo += premio;

            Console.ReadKey();
        }

        private static void RaspadinhaB() {
            Console.Clear();
            
            if ((saldo - 2) < 0) {
                Console.WriteLine("Saldo insuficiente! Realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }
            saldo -= 2;

            int numPrincipal = random.Next(1, 11);
            int premio = random.Next(1, 101);

            int num1 = random.Next(1, 11);
            int num2 = random.Next(1, 11);
            int num3 = random.Next(1, 11);
            int num4 = random.Next(1, 11);
            int num5 = random.Next(1, 11);
            int num6 = random.Next(1, 11);
            int num7 = random.Next(1, 11);
            int num8 = random.Next(1, 11);
            int num9 = random.Next(1, 11);

            int contador = 0;
            if(numPrincipal == num1) contador++;
            if(numPrincipal == num2) contador++;
            if(numPrincipal == num3) contador++;
            if(numPrincipal == num4) contador++;
            if(numPrincipal == num5) contador++;
            if(numPrincipal == num6) contador++;
            if(numPrincipal == num7) contador++;
            if(numPrincipal == num8) contador++;
            if(numPrincipal == num9) contador++;

            Console.WriteLine($"Número principal: {numPrincipal} - Prêmio: R${premio}");
            Console.WriteLine($"{num1} - {num2} - {num3}");
            Console.WriteLine($"{num4} - {num5} - {num6}");
            Console.WriteLine($"{num7} - {num8} - {num9}");

            if(contador >= 3) {
                Console.WriteLine("Parabéns, você GANHOUUUUU!");
                saldo += premio;
            } else {
                Console.WriteLine("Você perdeu!");
            }

            Console.ReadLine();
        }

        private static void Loteria() {
            Console.Clear();

            if ((saldo - 5) < 0) {
                Console.WriteLine("Saldo insuficiente! Realize um depósito antes de jogar");
                Console.ReadKey();
                return;
            }
            saldo -= 5;

            int numPremiado = random.Next(1000, 10000);

            int numJogador = 0;

            while (numJogador < 1000 || numJogador > 10000) {
                Console.Write("Qual o número você quer jogar na loteria? ");
                numJogador = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Número sorteado:{numPremiado}");

            if (numPremiado == numJogador) {
                Console.WriteLine("Parabéns, você GANHOUUUUU o primeiro prêmio!");
                saldo += 10000;
            } else if (numPremiado % 1000 == numJogador % 1000) {
                Console.WriteLine("Parabéns, você GANHOU o segundo prêmio!");
                saldo += 1000;

            } else if (numPremiado % 100 == numJogador % 100) {
                Console.WriteLine("Parabéns, você GANHOU o terceiro prêmio!");
                saldo += 100;
            } else {
                Console.WriteLine("Você não ganhou!");
            }

            Console.ReadKey();
        }
    }
}
