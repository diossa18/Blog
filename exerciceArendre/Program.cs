using System;

class Program
{
    static void Main()
    {
        // Demander à l'utilisateur de saisir le montant des dommages
        Console.Write("Veuillez saisir le montant des dommages : ");

        // Essayer de convertir l'entrée de l'utilisateur en un nombre décimal
        if (decimal.TryParse(Console.ReadLine(), out decimal montantDommages))
        {
            // Calculer le montant remboursé en appelant la fonction
            decimal montantRembourse = CalculerMontantRembourse(montantDommages);

            // Afficher les résultats
            Console.WriteLine($"Montant remboursé : {montantRembourse:C}");
            Console.WriteLine($"Franchise : {CalculerFranchise(montantDommages):C}");
        }
        else
        {
            Console.WriteLine("Veuillez saisir un montant valide.");
        }

        
        Console.ReadKey();
    }

    // Fonction pour calculer le montant remboursé
    static decimal CalculerMontantRembourse(decimal montantDommages)
    {
        decimal tauxFranchise = 10;
        decimal franchiseMaximale = 4000;

        // Calculer la franchise (10% du montant des dommages, plafonné à 4000 euros)
        decimal franchise = Math.Min(montantDommages * tauxFranchise, franchiseMaximale);

        // Calculer le montant remboursé (montant des dommages moins la franchise)
        decimal montantRembourse = montantDommages - franchise;

        // Assurer que le montant remboursé n'est pas négatif
        montantRembourse = Math.Max(montantRembourse, 0);

        return montantRembourse;
    }

    // Fonction pour calculer la franchise
    static decimal CalculerFranchise(decimal montantDommages)
    {
        decimal tauxFranchise = 10 ;
        decimal franchiseMaximale = 4000;

        // Calculer la franchise (10% du montant des dommages, plafonné à 4000 euros)
        decimal franchise = Math.Min(montantDommages * tauxFranchise, franchiseMaximale);

        return franchise;
    }
}
