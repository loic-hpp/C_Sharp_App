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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            logoTal = new PictureBox();
            main_pannel = new Panel();
            Logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoTal).BeginInit();
            SuspendLayout();
            // 
            // Logo_panel
            // 
            Logo_panel.BackColor = Color.FromArgb(40, 128, 185);
            Logo_panel.Controls.Add(label6);
            Logo_panel.Controls.Add(label5);
            Logo_panel.Controls.Add(label4);
            Logo_panel.Controls.Add(label3);
            Logo_panel.Controls.Add(label2);
            Logo_panel.Controls.Add(label1);
            Logo_panel.Controls.Add(logoTal);
            Logo_panel.Dock = DockStyle.Left;
            Logo_panel.Location = new Point(0, 0);
            Logo_panel.Name = "Logo_panel";
            Logo_panel.Size = new Size(250, 483);
            Logo_panel.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(0, 457);
            label6.Name = "label6";
            label6.Size = new Size(232, 17);
            label6.TabIndex = 6;
            label6.Text = "Tribunal Administratif du Logement";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 439);
            label5.Name = "label5";
            label5.Size = new Size(148, 17);
            label5.TabIndex = 5;
            label5.Text = "Propriété exclusive du";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(243, 34);
            label4.TabIndex = 4;
            label4.Text = "d'administrartion";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(123, 280);
            label3.Name = "label3";
            label3.Size = new Size(104, 34);
            label3.TabIndex = 3;
            label3.Text = "du TAL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(123, 209);
            label2.Name = "label2";
            label2.Size = new Size(121, 34);
            label2.TabIndex = 2;
            label2.Text = "console";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 175);
            label1.Name = "label1";
            label1.Size = new Size(245, 34);
            label1.TabIndex = 1;
            label1.Text = "Bienvenue sur la ";
            label1.Click += label1_Click;
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
            main_pannel.Dock = DockStyle.Fill;
            main_pannel.Location = new Point(250, 0);
            main_pannel.Name = "main_pannel";
            main_pannel.Size = new Size(482, 483);
            main_pannel.TabIndex = 1;
            main_pannel.Paint += main_pannel_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 483);
            Controls.Add(main_pannel);
            Controls.Add(Logo_panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_window";
            Load += LoginForm_Load;
            Logo_panel.ResumeLayout(false);
            Logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoTal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Logo_panel;
        private Panel main_pannel;
        private PictureBox logoTal;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
    }
}