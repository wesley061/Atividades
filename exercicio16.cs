class programa{
    public static void Main(string[] args){
        double largura, comprimento, area;
        
        console.Write("Digite a largua do terreno: ");
        largura = double.Parse(Console.ReadLine());

        Console.Write("Digite o comprimento do terreno: ");
        comprimento = double.Parse(Console.ReadLine());

        area = largura*Comprimento;

        if(area < 100){
        Console.WriteLine("Terreno Popular");
        }
        else if(area > 500){
            Console>WriteLine("Terreno VIP");
        }else{
            Console.WriteLine("Terreno Master");
        }

        Console.WriteLine("Pressione enter para sair...");
        Console.ReadLine();
    }
}