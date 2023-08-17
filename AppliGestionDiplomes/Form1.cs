namespace AppliGestionDiplomes
{
    public partial class fntDefaut : Form
    {
        public fntDefaut()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            // Bouton pour ajouter un utilisateur
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            // bouton pour quitter l'application
            Application.Exit();
        }

        private void btnNewCertificate_Click(object sender, EventArgs e)
        {
            // bouton pour créer un nouveau diplôme
            Form2 ajouterUtilisateur = new Form2();
            ajouterUtilisateur.ShowDialog();
        }
    }
}