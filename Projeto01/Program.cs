namespace Projeto01
{

    class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }

        static void Main(string[] args)
        {

            //3ºcriando loop no menu
            bool opcSair = false;
            //enquanto user nao(!) escolher sair, exiba o menu
            while (!opcSair)
            {
                //exiba menu
                //1º mostrando opcoes na tela
                Console.WriteLine("Seja bem vindo ao CALC. Qual operação você gostaria de realizar?\n");
                Console.WriteLine("1) Soma\n2) Subtracao\n3) Divisao\n4) Multiplicacao\n5) Potencia\n6) Raiz\n7) Sair");


                //2ºcaptura a opção que o USER quer (cria variavel do tipo MENU e nome opcao) + fazer conversao CAST
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                

                //4º usando switch
                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        opcSair = true;
                        break;
                    

                }
                Console.Clear();

            }
           
        }


        static void Soma()
        {
            Console.WriteLine("Soma de 2 numeros: ");

            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a + b;
            Console.WriteLine($"RESULTADO: {resultado}");
            Console.WriteLine("Pressione 'ENTER' para retornar ao MENU");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtracao de 2 numeros: ");

            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a - b;
            Console.WriteLine($"RESULTADO: {resultado}");
            Console.WriteLine("Pressione 'ENTER' para retornar ao MENU");
            Console.ReadLine();

        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de 2 numeros: ");

            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            float resultado = (float)a / (float)b;
            Console.WriteLine($"RESULTADO: {resultado}");
            Console.WriteLine("Pressione 'ENTER' para retornar ao MENU");
            Console.ReadLine();

        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de 2 numeros: ");

            Console.WriteLine("Digite o primeiro numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int b = int.Parse(Console.ReadLine());

            int resultado = a * b;
            Console.WriteLine($"RESULTADO: {resultado}");
            Console.WriteLine("Pressione 'ENTER' para retornar ao MENU");
            Console.ReadLine();

        }

        static void Potencia()
        { 
            Console.WriteLine("Potência de um numero: ");

            Console.WriteLine("Digite a base: ");
            int baseNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o expoente: ");
            int expoente = int.Parse(Console.ReadLine());

            int resultado = (int)Math.Pow(baseNumero, expoente);
            Console.WriteLine($"RESULTADO: {resultado}");
            Console.WriteLine("Pressione 'ENTER' para retornar ao MENU");
            Console.ReadLine();

        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de 2 numeros: ");

            Console.WriteLine("Digite o numero: ");
            int a = int.Parse(Console.ReadLine());

            double resultado = Math.Sqrt(a);
            Console.WriteLine($"RESULTADO: {resultado}");
            Console.WriteLine("Pressione 'ENTER' para retornar ao MENU");
            Console.ReadLine();

        }



    }
}