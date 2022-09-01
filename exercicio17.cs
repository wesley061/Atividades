using System;

class programa{
    public static void Main(string[] args){
        string nome;
        double anosEmpresa, salario;
        
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o seu salario: ");
        salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o tempo de empresa: ");
        anosEmpresa = double.Parse(Console.ReadLine());
    

        if(anosEmpresa <= 3){
            salario = salario * 1.03;
            Console.WriteLine("Seu novo salario e" + salario);
        }
        else if(anosEmpresa <= 10 ){
            salario = salario * 1.25;
            Console.WriteLine("Seu novo salario e" + salario);
        }else if(anosEmpresa > 10 ){
            salario = salario * 1.20;
            Console.WriteLine("Seu novo salario e " + salario);
        }

        Console.WriteLine("Pressione enter para sair...");
        Console.ReadLine();
    }
}