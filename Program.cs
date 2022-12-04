namespace exo_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compte compte1 = new Compte("david",2500,500);
            Compte compte2 = new Compte("jack", 35000, 1500);
            Compte compte3 = new Compte("marco", 250, 50);
            Compte compte4 = new Compte("polo", 2700, 500);

            Banque banque1 = new Banque("maSuperBanque", "Mulhouse");
            Banque banque2 = new Banque("maSuperBanquerout", "Colmar");

            banque1.AjouterCompte(compte1);
            banque1.AjouterCompte(compte2);
            banque1.AjouterCompte(4000,"donald",500);
            
            banque2.AjouterCompte(compte4);
            banque2.AjouterCompte(compte3);

            /* Console.WriteLine(banque1.ToString());
             Console.WriteLine(banque2.ToString());

             banque1.ComptesClients[1].Transferer(5000, banque1.ComptesClients[0]);
             banque1.ComptesClients[1].Transferer(5000, banque2.ComptesClients[0]);*/

            banque1.ComptesClients[0].Transferer(3550, banque2.ComptesClients[1]);

            Console.WriteLine(banque1.ToString());
            Console.WriteLine(banque2.ToString());

            





        }
    }
}