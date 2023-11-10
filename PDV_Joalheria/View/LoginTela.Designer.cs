namespace PDV_Joalheria.View
{
    partial class LoginTela
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            lbl_usuario = new Label();
            txt_usuario = new TextBox();
            btn_acessar = new Button();
            lbl_senha = new Label();
            txt_senha = new TextBox();
            pictureBox1 = new PictureBox();
            btn_sair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuario.ForeColor = SystemColors.ControlLightLight;
            lbl_usuario.Location = new Point(314, 86);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(69, 21);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuario";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(314, 121);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(230, 23);
            txt_usuario.TabIndex = 1;
            // 
            // btn_acessar
            // 
            btn_acessar.BackColor = Color.Black;
            btn_acessar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_acessar.ForeColor = SystemColors.ControlLightLight;
            btn_acessar.Location = new Point(382, 278);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(87, 30);
            btn_acessar.TabIndex = 2;
            btn_acessar.Text = "Acessar";
            btn_acessar.UseVisualStyleBackColor = false;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.ForeColor = SystemColors.ControlLightLight;
            lbl_senha.Location = new Point(314, 191);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(57, 21);
            lbl_senha.TabIndex = 3;
            lbl_senha.Text = "Senha";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(314, 225);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(230, 23);
            txt_senha.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._2;
            pictureBox1.Location = new Point(21, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.Black;
            btn_sair.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sair.ForeColor = SystemColors.ControlLightLight;
            btn_sair.Location = new Point(21, 344);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(51, 28);
            btn_sair.TabIndex = 6;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // LoginTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(593, 384);
            Controls.Add(btn_sair);
            Controls.Add(pictureBox1);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(btn_acessar);
            Controls.Add(txt_usuario);
            Controls.Add(lbl_usuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginTela";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private TextBox txt_usuario;
        private Button btn_acessar;
        private Label lbl_senha;
        private TextBox txt_senha;
        private PictureBox pictureBox1;
        private Button btn_sair;
    }
}