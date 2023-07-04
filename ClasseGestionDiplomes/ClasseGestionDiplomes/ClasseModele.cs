using System.Data;
using System.Data.SqlClient;

namespace ClasseGestionDiplomes;

public class ClasseModele
{
    // instanciation de la classe d'accès aux données
    ClasseADO BdGestionDiplomes = new ClasseADO();
    
    // contructeur de la classe
    public ClasseModele()
    {
        // rien ici
    }
    
    // méthode pour récupérer les données pour le datatable
    public DataTable SQLModeles()
    {
        // requête pour récupérer les données
        SqlCommand SqlCmd = new SqlCommand("", BdGestionDiplomes.ConnexionBase());
            
        // Création d'un objet de type DataTable et remplissage avec les données de la table
        DataTable DtModeles = new DataTable();
        DtModeles.Load(SqlCmd.ExecuteReader());
            
        // on renvoie le datatable
        return DtModeles;
    }
}