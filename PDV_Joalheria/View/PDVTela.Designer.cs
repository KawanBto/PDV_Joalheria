namespace PDV_Joalheria.View
{
    partial class PDVTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDVTela));
            pictureBox9 = new PictureBox();
            dataGridViewPDV = new DataGridView();
            Produt = new DataGridViewTextBoxColumn();
            Unit = new DataGridViewTextBoxColumn();
            Qtd = new DataGridViewTextBoxColumn();
            Tot = new DataGridViewTextBoxColumn();
            btn_adc = new Button();
            txt_cod = new TextBox();
            num_qtd = new NumericUpDown();
            label1 = new Label();
            lbl_total = new Label();
            btn_cancelar = new Button();
            btn_finalizar = new Button();
            btn_a1 = new Button();
            btn_a2 = new Button();
            btn_a3 = new Button();
            btn_a4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_c1 = new Button();
            btn_c4 = new Button();
            btn_c2 = new Button();
            btn_c3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPDV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_qtd).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources._2;
            pictureBox9.Location = new Point(12, 12);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(317, 165);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 8;
            pictureBox9.TabStop = false;
            // 
            // dataGridViewPDV
            // 
            dataGridViewPDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPDV.Columns.AddRange(new DataGridViewColumn[] { Produt, Unit, Qtd, Tot });
            dataGridViewPDV.Location = new Point(391, 116);
            dataGridViewPDV.Name = "dataGridViewPDV";
            dataGridViewPDV.RowHeadersVisible = false;
            dataGridViewPDV.RowTemplate.Height = 25;
            dataGridViewPDV.Size = new Size(407, 355);
            dataGridViewPDV.TabIndex = 9;
            // 
            // Produt
            // 
            Produt.HeaderText = "Produto";
            Produt.Name = "Produt";
            // 
            // Unit
            // 
            Unit.HeaderText = "Unitário";
            Unit.Name = "Unit";
            // 
            // Qtd
            // 
            Qtd.HeaderText = "Quant.";
            Qtd.Name = "Qtd";
            // 
            // Tot
            // 
            Tot.HeaderText = "Total";
            Tot.Name = "Tot";
            // 
            // btn_adc
            // 
            btn_adc.Location = new Point(694, 72);
            btn_adc.Name = "btn_adc";
            btn_adc.Size = new Size(75, 23);
            btn_adc.TabIndex = 11;
            btn_adc.Text = "Adicionar";
            btn_adc.UseVisualStyleBackColor = true;
            btn_adc.Click += btn_adc_Click;
            // 
            // txt_cod
            // 
            txt_cod.Location = new Point(420, 73);
            txt_cod.Name = "txt_cod";
            txt_cod.Size = new Size(89, 23);
            txt_cod.TabIndex = 12;
            // 
            // num_qtd
            // 
            num_qtd.Location = new Point(584, 72);
            num_qtd.Name = "num_qtd";
            num_qtd.Size = new Size(46, 23);
            num_qtd.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(391, 489);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 14;
            label1.Text = "Total";
            // 
            // lbl_total
            // 
            lbl_total.AutoSize = true;
            lbl_total.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_total.ForeColor = SystemColors.ControlLightLight;
            lbl_total.Location = new Point(713, 489);
            lbl_total.Name = "lbl_total";
            lbl_total.Size = new Size(0, 21);
            lbl_total.TabIndex = 15;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(391, 529);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 16;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_finalizar
            // 
            btn_finalizar.Location = new Point(723, 529);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(75, 23);
            btn_finalizar.TabIndex = 17;
            btn_finalizar.Text = "Finalizar";
            btn_finalizar.UseVisualStyleBackColor = true;
            btn_finalizar.Click += btn_finalizar_Click;
            // 
            // btn_a1
            // 
            btn_a1.Image = (Image)resources.GetObject("btn_a1.Image");
            btn_a1.Location = new Point(11, 28);
            btn_a1.Name = "btn_a1";
            btn_a1.Size = new Size(56, 70);
            btn_a1.TabIndex = 18;
            btn_a1.UseVisualStyleBackColor = true;
            btn_a1.Click += btn_a1_Click;
            // 
            // btn_a2
            // 
            btn_a2.Image = Properties.Resources.Anel2;
            btn_a2.Location = new Point(92, 28);
            btn_a2.Name = "btn_a2";
            btn_a2.Size = new Size(56, 70);
            btn_a2.TabIndex = 19;
            btn_a2.UseVisualStyleBackColor = true;
            btn_a2.Click += btn_a2_Click;
            // 
            // btn_a3
            // 
            btn_a3.Image = (Image)resources.GetObject("btn_a3.Image");
            btn_a3.Location = new Point(173, 28);
            btn_a3.Name = "btn_a3";
            btn_a3.Size = new Size(56, 70);
            btn_a3.TabIndex = 20;
            btn_a3.UseVisualStyleBackColor = true;
            btn_a3.Click += btn_a3_Click;
            // 
            // btn_a4
            // 
            btn_a4.Image = (Image)resources.GetObject("btn_a4.Image");
            btn_a4.Location = new Point(253, 28);
            btn_a4.Name = "btn_a4";
            btn_a4.Size = new Size(56, 70);
            btn_a4.TabIndex = 21;
            btn_a4.UseVisualStyleBackColor = true;
            btn_a4.Click += btn_a4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_a1);
            groupBox1.Controls.Add(btn_a4);
            groupBox1.Controls.Add(btn_a2);
            groupBox1.Controls.Add(btn_a3);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 108);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anel";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_c1);
            groupBox2.Controls.Add(btn_c4);
            groupBox2.Controls.Add(btn_c2);
            groupBox2.Controls.Add(btn_c3);
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(12, 383);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(317, 108);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Outros";
            // 
            // btn_c1
            // 
            btn_c1.Image = (Image)resources.GetObject("btn_c1.Image");
            btn_c1.Location = new Point(11, 28);
            btn_c1.Name = "btn_c1";
            btn_c1.Size = new Size(56, 70);
            btn_c1.TabIndex = 18;
            btn_c1.UseVisualStyleBackColor = true;
            btn_c1.Click += btn_c1_Click;
            // 
            // btn_c4
            // 
            btn_c4.Image = (Image)resources.GetObject("btn_c4.Image");
            btn_c4.Location = new Point(253, 28);
            btn_c4.Name = "btn_c4";
            btn_c4.Size = new Size(56, 70);
            btn_c4.TabIndex = 21;
            btn_c4.UseVisualStyleBackColor = true;
            btn_c4.Click += btn_c4_Click;
            // 
            // btn_c2
            // 
            btn_c2.Image = (Image)resources.GetObject("btn_c2.Image");
            btn_c2.Location = new Point(92, 28);
            btn_c2.Name = "btn_c2";
            btn_c2.Size = new Size(56, 70);
            btn_c2.TabIndex = 19;
            btn_c2.UseVisualStyleBackColor = true;
            btn_c2.Click += btn_c2_Click;
            // 
            // btn_c3
            // 
            btn_c3.Image = (Image)resources.GetObject("btn_c3.Image");
            btn_c3.Location = new Point(173, 28);
            btn_c3.Name = "btn_c3";
            btn_c3.Size = new Size(56, 70);
            btn_c3.TabIndex = 20;
            btn_c3.UseVisualStyleBackColor = true;
            btn_c3.Click += btn_c3_Click;
            // 
            // PDVTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(822, 589);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_finalizar);
            Controls.Add(btn_cancelar);
            Controls.Add(lbl_total);
            Controls.Add(label1);
            Controls.Add(num_qtd);
            Controls.Add(txt_cod);
            Controls.Add(btn_adc);
            Controls.Add(dataGridViewPDV);
            Controls.Add(pictureBox9);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PDVTela";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDVTela";
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPDV).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_qtd).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private DataGridViewTextBoxColumn Produt;
        private DataGridViewTextBoxColumn Unit;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn Tot;
        private Button btn_adc;
        private TextBox txt_cod;
        private NumericUpDown num_qtd;
        private Label label1;
        private Label lbl_total;
        private Button btn_cancelar;
        private Button btn_finalizar;
        private Button btn_a1;
        private Button btn_a2;
        private Button btn_a3;
        private Button btn_a4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_c1;
        private Button btn_c4;
        private Button btn_c2;
        private Button btn_c3;
        public DataGridView dataGridViewPDV;
    }
}