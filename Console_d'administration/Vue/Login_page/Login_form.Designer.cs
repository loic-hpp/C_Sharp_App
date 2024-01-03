namespace login_form
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Logo_panel = new Panel();
            droitApplication2 = new Label();
            droitApplication = new Label();
            nomApplication4 = new Label();
            nomApplication3 = new Label();
            nomApplication2 = new Label();
            nomApplication = new Label();
            logoTal = new PictureBox();
            main_pannel = new Panel();
            boutonConnecter = new Button();
            motDePasse = new Panel();
            champMotDePasse = new TextBox();
            logoMotDePasse = new PictureBox();
            nomUtilisateur = new Panel();
            champNomUtilisateur = new TextBox();
            logoUtilisateur = new PictureBox();
            demanderIdentifiant = new Label();
            Logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoTal).BeginInit();
            main_pannel.SuspendLayout();
            motDePasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoMotDePasse).BeginInit();
            nomUtilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoUtilisateur).BeginInit();
            SuspendLayout();
            // 
            // Logo_panel
            // 
            Logo_panel.BackColor = Color.FromArgb(40, 128, 185);
            Logo_panel.Controls.Add(droitApplication2);
            Logo_panel.Controls.Add(droitApplication);
            Logo_panel.Controls.Add(nomApplication4);
            Logo_panel.Controls.Add(nomApplication3);
            Logo_panel.Controls.Add(nomApplication2);
            Logo_panel.Controls.Add(nomApplication);
            Logo_panel.Controls.Add(logoTal);
            Logo_panel.Dock = DockStyle.Left;
            Logo_panel.Location = new Point(0, 0);
            Logo_panel.Name = "Logo_panel";
            Logo_panel.Size = new Size(250, 483);
            Logo_panel.TabIndex = 0;
            // 
            // droitApplication2
            // 
            droitApplication2.AutoSize = true;
            droitApplication2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            droitApplication2.ForeColor = Color.White;
            droitApplication2.Location = new Point(0, 457);
            droitApplication2.Name = "droitApplication2";
            droitApplication2.Size = new Size(232, 17);
            droitApplication2.TabIndex = 6;
            droitApplication2.Text = "Tribunal Administratif du Logement";
            droitApplication2.Click += label6_Click;
            // 
            // droitApplication
            // 
            droitApplication.AutoSize = true;
            droitApplication.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            droitApplication.ForeColor = Color.White;
            droitApplication.Location = new Point(0, 439);
            droitApplication.Name = "droitApplication";
            droitApplication.Size = new Size(148, 17);
            droitApplication.TabIndex = 5;
            droitApplication.Text = "Propriété exclusive du";
            droitApplication.Click += label5_Click;
            // 
            // nomApplication4
            // 
            nomApplication4.AutoSize = true;
            nomApplication4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nomApplication4.ForeColor = Color.White;
            nomApplication4.Location = new Point(12, 243);
            nomApplication4.Name = "nomApplication4";
            nomApplication4.Size = new Size(243, 34);
            nomApplication4.TabIndex = 4;
            nomApplication4.Text = "d'administrartion";
            nomApplication4.Click += label4_Click;
            // 
            // nomApplication3
            // 
            nomApplication3.AutoSize = true;
            nomApplication3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nomApplication3.ForeColor = Color.White;
            nomApplication3.Location = new Point(123, 280);
            nomApplication3.Name = "nomApplication3";
            nomApplication3.Size = new Size(104, 34);
            nomApplication3.TabIndex = 3;
            nomApplication3.Text = "du TAL";
            // 
            // nomApplication2
            // 
            nomApplication2.AutoSize = true;
            nomApplication2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nomApplication2.ForeColor = Color.White;
            nomApplication2.Location = new Point(123, 209);
            nomApplication2.Name = "nomApplication2";
            nomApplication2.Size = new Size(121, 34);
            nomApplication2.TabIndex = 2;
            nomApplication2.Text = "console";
            nomApplication2.Click += label2_Click;
            // 
            // nomApplication
            // 
            nomApplication.AutoSize = true;
            nomApplication.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nomApplication.ForeColor = Color.White;
            nomApplication.Location = new Point(3, 175);
            nomApplication.Name = "nomApplication";
            nomApplication.Size = new Size(245, 34);
            nomApplication.TabIndex = 1;
            nomApplication.Text = "Bienvenue sur la ";
            nomApplication.Click += label1_Click;
            // 
            // logoTal
            // 
            logoTal.Image = (Image)resources.GetObject("logoTal.Image");
            logoTal.Location = new Point(0, 0);
            logoTal.Name = "logoTal";
            logoTal.Size = new Size(250, 118);
            logoTal.SizeMode = PictureBoxSizeMode.StretchImage;
            logoTal.TabIndex = 0;
            logoTal.TabStop = false;
            logoTal.Click += pictureBox1_Click;
            // 
            // main_pannel
            // 
            main_pannel.BackColor = SystemColors.ButtonHighlight;
            main_pannel.Controls.Add(boutonConnecter);
            main_pannel.Controls.Add(motDePasse);
            main_pannel.Controls.Add(nomUtilisateur);
            main_pannel.Controls.Add(demanderIdentifiant);
            main_pannel.Dock = DockStyle.Fill;
            main_pannel.Location = new Point(250, 0);
            main_pannel.Name = "main_pannel";
            main_pannel.Size = new Size(482, 483);
            main_pannel.TabIndex = 1;
            main_pannel.Paint += main_pannel_Paint;
            // 
            // boutonConnecter
            // 
            boutonConnecter.BackColor = Color.FromArgb(41, 128, 185);
            boutonConnecter.FlatStyle = FlatStyle.Flat;
            boutonConnecter.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            boutonConnecter.ForeColor = Color.White;
            boutonConnecter.Location = new Point(174, 326);
            boutonConnecter.Name = "boutonConnecter";
            boutonConnecter.Size = new Size(109, 39);
            boutonConnecter.TabIndex = 5;
            boutonConnecter.Text = "Connexion";
            boutonConnecter.UseVisualStyleBackColor = false;
            boutonConnecter.Click += button1_Click;
            // 
            // motDePasse
            // 
            motDePasse.BackColor = Color.White;
            motDePasse.Controls.Add(champMotDePasse);
            motDePasse.Controls.Add(logoMotDePasse);
            motDePasse.Location = new Point(0, 250);
            motDePasse.Name = "motDePasse";
            motDePasse.Size = new Size(479, 45);
            motDePasse.TabIndex = 4;
            // 
            // champMotDePasse
            // 
            champMotDePasse.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            champMotDePasse.ForeColor = Color.FromArgb(41, 128, 185);
            champMotDePasse.Location = new Point(48, 10);
            champMotDePasse.Name = "champMotDePasse";
            champMotDePasse.Size = new Size(370, 32);
            champMotDePasse.TabIndex = 9;
            champMotDePasse.UseSystemPasswordChar = true;
            // 
            // logoMotDePasse
            // 
            logoMotDePasse.Image = (Image)resources.GetObject("logoMotDePasse.Image");
            logoMotDePasse.Location = new Point(6, 10);
            logoMotDePasse.Name = "logoMotDePasse";
            logoMotDePasse.Size = new Size(36, 32);
            logoMotDePasse.SizeMode = PictureBoxSizeMode.StretchImage;
            logoMotDePasse.TabIndex = 8;
            logoMotDePasse.TabStop = false;
            // 
            // nomUtilisateur
            // 
            nomUtilisateur.BackColor = Color.White;
            nomUtilisateur.Controls.Add(champNomUtilisateur);
            nomUtilisateur.Controls.Add(logoUtilisateur);
            nomUtilisateur.Location = new Point(0, 180);
            nomUtilisateur.Name = "nomUtilisateur";
            nomUtilisateur.Size = new Size(479, 45);
            nomUtilisateur.TabIndex = 3;
            // 
            // champNomUtilisateur
            // 
            champNomUtilisateur.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            champNomUtilisateur.ForeColor = Color.FromArgb(41, 128, 185);
            champNomUtilisateur.Location = new Point(48, 10);
            champNomUtilisateur.Name = "champNomUtilisateur";
            champNomUtilisateur.Size = new Size(370, 32);
            champNomUtilisateur.TabIndex = 8;
            // 
            // logoUtilisateur
            // 
            logoUtilisateur.Image = (Image)resources.GetObject("logoUtilisateur.Image");
            logoUtilisateur.Location = new Point(6, 10);
            logoUtilisateur.Name = "logoUtilisateur";
            logoUtilisateur.Size = new Size(36, 32);
            logoUtilisateur.SizeMode = PictureBoxSizeMode.StretchImage;
            logoUtilisateur.TabIndex = 7;
            logoUtilisateur.TabStop = false;
            // 
            // demanderIdentifiant
            // 
            demanderIdentifiant.AutoSize = true;
            demanderIdentifiant.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            demanderIdentifiant.ForeColor = Color.FromArgb(41, 128, 185);
            demanderIdentifiant.Location = new Point(3, 127);
            demanderIdentifiant.Name = "demanderIdentifiant";
            demanderIdentifiant.Size = new Size(304, 34);
            demanderIdentifiant.TabIndex = 2;
            demanderIdentifiant.Text = "Entrer vos identifiants";
            demanderIdentifiant.Click += label7_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 483);
            Controls.Add(main_pannel);
            Controls.Add(Logo_panel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            Load += LoginForm_Load;
            Logo_panel.ResumeLayout(false);
            Logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoTal).EndInit();
            main_pannel.ResumeLayout(false);
            main_pannel.PerformLayout();
            motDePasse.ResumeLayout(false);
            motDePasse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoMotDePasse).EndInit();
            nomUtilisateur.ResumeLayout(false);
            nomUtilisateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoUtilisateur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Logo_panel;
        private Panel main_pannel;
        private PictureBox logoTal;
        private Label nomApplication;
        private Label nomApplication2;
        private Label nomApplication4;
        private Label nomApplication3;
        private Label droitApplication;
        private Label droitApplication2;
        private Label demanderIdentifiant;
        private Panel nomUtilisateur;
        private Panel motDePasse;
        private PictureBox logoMotDePasse;
        private TextBox champNomUtilisateur;
        private PictureBox logoUtilisateur;
        private TextBox champMotDePasse;
        private Button boutonConnecter;
    }
}