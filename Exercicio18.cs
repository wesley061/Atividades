using System;

   class Programa{

    static void Main(string[] args)
	{ 
        int comp1, comp2, comp3;
        
        
         Console.Write("Digite um lado do triangulo: \n>> ");
         comp1 = int.Parse(Console.ReadLine());

         Console.Write("Digite o outro lado do triangulo: \n>> ");
         comp2 = int.Parse(Console.ReadLine());

         Console.Write("Digite o ultimo lado do triangulo: \n>> ");
         comp3 = int.Parse(Console.ReadLine());


         if(comp1 == comp2 && comp1 == comp3){
            Console.WriteLine(" Este triangulo e equilatero.");

            }else if(comp1 == comp2  && comp1 != comp3){
                Console.WriteLine(" Este triangulo e isoceles.");
            }else{
                Console.WriteLine("Este triangulo e escaleno.");
            }
     

         
         Console.WriteLine("Pressione Enter para sair..");
         Console.ReadLine();
    }
	}