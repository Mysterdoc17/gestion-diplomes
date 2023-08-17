namespace AppliGestionDiplomes
{
    partial class fntDefaut
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnNewCertificate = new Button();
            button2 = new Button();
            btnExitApp = new Button();
            btnNewUser = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(335, 21);
            label1.Name = "label1";
            label1.Size = new Size(540, 46);
            label1.TabIndex = 0;
            label1.Text = "Accueil - Gestionnaire de diplômes";
            // 
            // btnNewCertificate
            // 
            btnNewCertificate.Location = new Point(156, 134);
            btnNewCertificate.Name = "btnNewCertificate";
            btnNewCertificate.Size = new Size(213, 29);
            btnNewCertificate.TabIndex = 1;
            btnNewCertificate.Text = "Ajouter un nouveau diplôme";
            btnNewCertificate.UseVisualStyleBackColor = true;
            btnNewCertificate.Click += btnNewCertificate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(848, 134);
            button2.Name = "button2";
            button2.Size = new Size(173, 29);
            button2.TabIndex = 2;
            button2.Text = "Visualiser les diplômes";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnExitApp
            // 
            btnExitApp.Location = new Point(531, 435);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(173, 29);
            btnExitApp.TabIndex = 3;
            btnExitApp.Text = "Quitter l'application";
            btnExitApp.UseVisualStyleBackColor = true;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // btnNewUser
            // 
            btnNewUser.Location = new Point(506, 134);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(218, 29);
            btnNewUser.TabIndex = 4;
            btnNewUser.Text = "Ajouter un nouvel utilisateur";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += BtnNewUser_Click;
            // 
            // fntDefaut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 672);
            Controls.Add(btnNewUser);
            Controls.Add(btnExitApp);
            Controls.Add(button2);
            Controls.Add(btnNewCertificate);
            Controls.Add(label1);
            Name = "fntDefaut";
            Text = "Page d'accueil - Gestionnaire de diplômes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNewCertificate;
        private Button button2;
        private Button btnExitApp;
        private Button btnNewUser;
    }
}