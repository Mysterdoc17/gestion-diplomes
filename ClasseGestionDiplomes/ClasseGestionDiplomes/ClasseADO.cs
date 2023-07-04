using System.Data.SqlClient;

namespace ClasseGestionDiplomes;

public class ClasseADO
{
    public ClasseADO()
    {
        // rien dans le constructeur
    }

    public SqlConnection ConnexionBase()
    {
        // Connexion à la base de données
        string ChConnexion = "Server = localhost; Database = nope; User Id = ; Password = ";

        SqlConnection connexion = new SqlConnection(ChConnexion);
        connexion.Open();

        return connexion;
    }
}