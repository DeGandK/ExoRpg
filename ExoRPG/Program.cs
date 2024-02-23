using ExoRPG.MesClasses;

namespace ExoRPG
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            MesClasses.Guerrier Garrosh  = new Guerrier();
            
            Garrosh.GenererCarac();
            Garrosh.Nom = "Garrosh";
            Console.WriteLine(Garrosh.Force);
            Console.WriteLine(Garrosh.Nom);

            MesClasses.Pretre Velen = new Pretre();
            Velen.GenererCarac();
            Velen.Nom = "Velen";
            Console.WriteLine(Velen.Force);
            Console.WriteLine(Velen.Nom);





      


        }
    }
}
