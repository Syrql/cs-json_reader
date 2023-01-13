using System.Text.Json;

namespace ConsoleApp8
{
    class Program
    {

        static List<CompteBancaire> accounts = new List<CompteBancaire>();
        static void Main(string[] args)
        {

            CompteManager manager = new CompteManager();
            manager.read(accounts);

            if (accounts.Count > 0)
            {
                foreach (CompteBancaire bancaire in accounts)
                {
                    Console.WriteLine(bancaire.titulaire);
                }
            }

            Random rand = new Random();
            double money = rand.Next();
            String name = "Rolland-" + money;
            String devise = "€";

            CompteBancaire compte = new CompteBancaire(name, money, devise);
            
            Console.WriteLine(compte.printAccount());
            manager.save(compte);

        }
    }
}