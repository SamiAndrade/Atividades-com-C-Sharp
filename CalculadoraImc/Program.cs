using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("**** Calculadora de IMC ****\n");

        string Nome = ObterNome();
        double Peso = ObterNumero("Digite seu peso (em kg): ");
        double Altura = ObterNumero("Digite sua altura (em metros): ");

        double Imc = CalcularImc(Peso, Altura);
        string Classificacao = ClassificarImc(Imc);


        Console.WriteLine($"O seu nome é: {Nome}, possui o peso de {Peso} kilos e uma altura de {Altura} metros. \n Seu IMC é de: {Imc:F2}");
        Console.WriteLine($"Classificação: {Classificacao}");

    }

    static string ObterNome() {
        Console.WriteLine("Digite seu nome: ");
        return Console.ReadLine();
    }

    static double ObterNumero(string mensagem) {
        double numero;
        Console.WriteLine(mensagem);
        while (!double.TryParse(Console.ReadLine().Replace(",", "."), NumberStyles.Number, CultureInfo.InvariantCulture, out numero) || numero <= 0)
        {
            Console.Write("Valor inválido. Tente novamente: ");
        }

        return numero;
    }

    static double CalcularImc(double peso, double altura) {
        return peso / (altura * altura);
    }

    static string ClassificarImc(double imc) {
        if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc < 25)
            return "Peso normal";
        else if (imc < 30)
            return "Sobrepeso";
        else if (imc < 35)
            return "Obesidade grau I";
        else if (imc < 40)
            return "Obesidade grau II";
        else
            return "Obesidade grau III (mórbida)";
    }
}