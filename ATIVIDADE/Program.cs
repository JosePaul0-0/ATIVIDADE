using System.ComponentModel.Design;

string opcoes = "";

Console.WriteLine("LISTA DE EXERCÍCIOS MATÉRIA: DESENVOLVEDOR DE SISTEMAS");
Console.ReadLine();
Console.Clear();

Console.WriteLine("ESCOLHA O QUE QUER VER");
Console.ReadLine();

while (opcoes != "7") 
{
    opcoes = Menu();
    Console.Clear();
    switch (opcoes) 
    {
        case "1.1":
            MostrarExercicio11();
            Console.ReadLine();

            break;

        case "1.2":
            MostrarExercicio12();
            Console.ReadLine();
            break; 

        case "1.3":
            MostrarExercicio13();
            Console.ReadLine();
            break;
        
        case "2.1":
            MostrarExercicio21();
            Console.ReadLine();
            break;
        case "2.2":
            MostrarExercicio22();
            Console.ReadLine();
            break;
        case "3.1":
            MostrarExercicio31();
            Console.ReadLine();
            break;
        case "3.2":
            MostrarExercicio32();
            Console.ReadLine();
            break;
        case "4.1":
            MostrarExercicio41();
            Console.ReadLine();
            break;
        case "4.2":
            MostrarExercicio42();
            Console.ReadLine();
            break;
        case "5":
            MostrarExercicio5();
            Console.ReadLine();
            break;
        case "6":
            MostrarExercicio6();
            Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("TCHAU");
            break;

    }
}
static string Menu() 
{
    Console.WriteLine("LISTA DE EXERCÍCIOS");
    Console.WriteLine("========================");
    Console.WriteLine("[1.1] Programa que retorna o nome completo, idade, altura e peso");
    Console.WriteLine("[1.2] Programa que retorna uma mensagem de acordo com o horário informado");
    Console.WriteLine("[1.3] Programa que calcula a área de um quadrado");
    Console.WriteLine("[2.1] Programa que mostra a nota (média) do aluno e sua situação");
    Console.WriteLine("[2.2] Programa que lê três números inteiros e mostra o maior deles");
    Console.WriteLine("[3.1] Programa que recebe uma senha de quatro números inteiros e verifica se está correta");
    Console.WriteLine("[3.2] Programa, usando for, que pede ao usuário inserir um número N e mostra todos os números ímpares até N");
    Console.WriteLine("[4.1] Programa, usando vetor, que armazena N nomes e mostra eles na sequência que foram digitados");
    Console.WriteLine("[4.2] Programa que lê 5 valores inteiros, armazena-os em um vetor, calcula e apresenta a soma deles");
    Console.WriteLine("[5] Programa que preenche uma matriz, de acordo com uma tabela, com as colunas alinhadas");
    Console.WriteLine("[6] Programa estilo caixa eletrônico, usando métodos, que o usuário consiga ver o saldo, depositar e sacar dinheiro,");
    Console.WriteLine("[7] SAIR");
    string opcoes = Console.ReadLine();

    return opcoes;
}

static void MostrarExercicio11() 
{
    Console.WriteLine("informe seu nome completo");
    string nome = Console.ReadLine();

    Console.WriteLine("informe sua idade");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("informe sua altura");
    double altura = double.Parse(Console.ReadLine());

    Console.WriteLine("informe seu peso");
    double peso = double.Parse(Console.ReadLine());

    Console.WriteLine("Seu nome completo é " + nome + ", você tem " + idade + " anos, " + altura + " de altura e pesa " + peso + " Kg .");
}
static void MostrarExercicio12()
{
    Console.WriteLine("Informe a hora");
    double hora = double.Parse(Console.ReadLine());

    if (hora > 6 && hora < 12)
        Console.WriteLine("Bom dia");
    else if (hora >= 12 && hora < 18)
        Console.WriteLine("Boa tarde");
    else
        Console.WriteLine("Boa noite");
}
static void MostrarExercicio13()
{
    Console.WriteLine("digite o valor de b");
    double b = double.Parse(Console.ReadLine());

    Console.WriteLine("digite o valor de h");
    double h = double.Parse(Console.ReadLine());

    double area = b * h;

    Console.WriteLine($"A área é de {area}");
}
static void MostrarExercicio21()
{
    Console.WriteLine("Informe a nota1");
    double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe a nota2");
    double nota2 = double.Parse(Console.ReadLine());

    double notaFinal = (nota1 + nota2) / 2;

    if (notaFinal >= 6)
        Console.WriteLine("NOTA FINAL " + notaFinal + " - ALUNO APROVADO");
    else
        Console.WriteLine("NOTA FINAL " + notaFinal + " - ALUNO REPROVADO");
}
static void MostrarExercicio22()
{
    Console.WriteLine("Informe o numero1");
    int numero1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o numero2");
    int numero2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o numero3");
    int numero3 = int.Parse(Console.ReadLine());

    if (numero1 > numero2)
    {
        if (numero1 > numero3)
            Console.WriteLine(numero1);
    }
    else if (numero2 > numero1)
    {
        if (numero2 > numero3)
            Console.WriteLine(numero2);
    }
    else _ = (numero3 > numero1);
    {
        if (numero3 > numero2)
            Console.WriteLine(numero3);
    }
}
static void MostrarExercicio31()
{
    int senha1;
    int senha2;

    Console.WriteLine("Digite uma senha de 4 numeros inteiros");
    senha1 = int.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine("Digite sua senha novamente");
    senha2 = int.Parse(Console.ReadLine());
    Console.Clear();

    while (senha2 != senha1)
    {
        Console.WriteLine("SENHA INCORRETA");


        Console.WriteLine("digite sua senha novamente");
        senha2 = int.Parse(Console.ReadLine());
        Console.Clear();
    }
    Console.WriteLine("SENHA CORRETA");
}
static void MostrarExercicio32()
{
    Console.WriteLine("digite um numero inteiro impar");
    int n1 = int.Parse(Console.ReadLine());

    Console.Clear();

    for (int i = 1; i <= n1; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}
static void MostrarExercicio41()
{
    int n;
    String[] vet;

    Console.WriteLine("digite o número de nomes");
    n = int.Parse(Console.ReadLine());
    vet = new string[n];
    Console.Clear();

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Digite o {0}° nome ", i + 1);
        vet[i] = Console.ReadLine();
    }
    Console.Clear();
    Console.WriteLine("\nNomes digitados");

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("{0}- {1}", i + 1, vet[i]);
    }
}
static void MostrarExercicio42()
{
    int[] valor = new int[5];
    int soma = 0;

    for (int i = 0; i < valor.Length; i++)
    {
        Console.WriteLine($"informe o {i + 1}º numero");
        valor[i] = int.Parse(Console.ReadLine());

        soma = soma + valor[i];
    }
    Console.WriteLine("total = " + soma);
}
static void MostrarExercicio5()
{
    int[,] A = new int[4, 4];
    A[0, 0] = 1; A[0, 1] = 2; A[0, 2] = 3; A[0, 3] = 4;
    A[1, 0] = 10; A[1, 1] = 20; A[1, 2] = 30; A[1, 3] = 40;
    A[2, 0] = 12; A[2, 1] = 22; A[2, 2] = 32; A[2, 3] = 42;
    A[3, 0] = 15; A[3, 1] = 25; A[3, 2] = 35; A[3, 3] = 45;

    int max = 0;
    for (int linha = 0; linha < 4; linha++)
    {
        for (int coluna = 0; coluna < 4; coluna++)
        {
            int length = A[linha, coluna].ToString().Length;
            if (length > max)
            {
                max = length;
            }
        }
    }

    for (int linha = 0; linha < 4; linha++)
    {
        for (int coluna = 0; coluna < 4; coluna++)
        {
            Console.Write($" {A[linha, coluna].ToString().PadLeft(max)} ");
        }
        Console.WriteLine();
    }
}
static void MostrarExercicio6()
{
    Console.WriteLine("INFORME SEU SALDO");
    double saldo = double.Parse(Console.ReadLine());
    Console.Clear();

    Console.WriteLine($"SEU SALDO É {saldo.ToString("F")} R$");
    Console.ReadLine();


    int opcoes = 0;

    while (opcoes != 3)
    {
        opcoes = Menu();
        Console.Clear();
        switch (opcoes)
        {
            case 1:
                saldo = MostrarSaque(saldo);
                Console.WriteLine($"SEU SALDO É {saldo.ToString("F")} R$");

                break;
            case 2:
                saldo = MostrarDepósito(saldo);
                Console.WriteLine($"SEU SALDO É {saldo.ToString("F")} R$");
                break;

            case 3:
                Console.WriteLine($"SEU SALDO É {saldo.ToString("F")} R$");
                break;

        }

    }
    Console.WriteLine("PRESSIONE QUALQUER TECLA PARA ENCERRAR");
    Console.ReadKey();
    static int Menu()
    {

        Console.WriteLine("MENU DE OPÇÕES");
        Console.WriteLine("===================");
        Console.WriteLine("[1] SACAR");
        Console.WriteLine("[2] DEPOSITAR");
        Console.WriteLine("[3] Sair");
        int opcoes = int.Parse(Console.ReadLine());

        return opcoes;
    }

    static double MostrarSaque(double saldo)
    {
        Console.WriteLine("DIGITE O VALOR");
        double valor = double.Parse(Console.ReadLine());

        if (valor <= saldo)
        {
            saldo -= valor;
            Console.WriteLine("SAQUE BEM SUCEDIDO");
        }
        else
        {
            Console.WriteLine("LIMITE EXCEDIDO, TENTE NOVAMENTE");
        }
        Console.ReadLine();
        return saldo;
    }
    static double MostrarDepósito(double saldo)
    {
        Console.WriteLine("DIGITE O VALOR");
        double valor = double.Parse(Console.ReadLine());

        if (valor != 0)
        {
            saldo += valor;
            Console.WriteLine("DEPÓSITO BEM SUCEDIDO");
        }
        else
        {
            Console.WriteLine("DEPÓSITO INVÁLIDO, TENTE NOVAMENTE");
        }
        Console.ReadLine();
        return saldo;
    }
    Console.ReadLine();
}