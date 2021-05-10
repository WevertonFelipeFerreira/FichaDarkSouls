
namespace FichaDS
{
    partial class DiceRoller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRoller));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.btnRolar = new System.Windows.Forms.Button();
            this.txtRolagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTentativas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira a quantide de dados: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira a quantidade de lados: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLados);
            this.groupBox1.Controls.Add(this.txtDados);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do dado";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::FichaDS.Properties.Resources.Certo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(268, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 29);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(216, 22);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 27);
            this.txtId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Insira seu ID de ficha: ";
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(216, 87);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(46, 27);
            this.txtLados.TabIndex = 4;
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(216, 55);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(46, 27);
            this.txtDados.TabIndex = 3;
            // 
            // btnRolar
            // 
            this.btnRolar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRolar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRolar.Location = new System.Drawing.Point(6, 31);
            this.btnRolar.Name = "btnRolar";
            this.btnRolar.Size = new System.Drawing.Size(79, 51);
            this.btnRolar.TabIndex = 2;
            this.btnRolar.Text = "Rolar";
            this.btnRolar.UseVisualStyleBackColor = true;
            this.btnRolar.Click += new System.EventHandler(this.btnRolar_Click);
            // 
            // txtRolagem
            // 
            this.txtRolagem.Location = new System.Drawing.Point(5, 88);
            this.txtRolagem.Multiline = true;
            this.txtRolagem.Name = "txtRolagem";
            this.txtRolagem.ReadOnly = true;
            this.txtRolagem.Size = new System.Drawing.Size(270, 74);
            this.txtRolagem.TabIndex = 3;
            this.txtRolagem.TextChanged += new System.EventHandler(this.txtRolagem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(4, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(54, 176);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(107, 27);
            this.txtTotal.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAtualiza);
            this.groupBox2.Controls.Add(this.txtHistorico);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(317, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 142);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ultima rolagem";
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.BackgroundImage = global::FichaDS.Properties.Resources.reload;
            this.btnAtualiza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualiza.Location = new System.Drawing.Point(290, 23);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(29, 29);
            this.btnAtualiza.TabIndex = 1;
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // txtHistorico
            // 
            this.txtHistorico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHistorico.Location = new System.Drawing.Point(6, 22);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.ReadOnly = true;
            this.txtHistorico.Size = new System.Drawing.Size(279, 106);
            this.txtHistorico.TabIndex = 0;
            this.txtHistorico.TextChanged += new System.EventHandler(this.txtHistorico_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::FichaDS.Properties.Resources.Gifzada;
            this.pictureBox1.Location = new System.Drawing.Point(293, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::FichaDS.Properties.Resources.BORRACHA;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.Location = new System.Drawing.Point(91, 31);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(54, 49);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTentativas);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtRolagem);
            this.groupBox3.Controls.Add(this.btnLimpar);
            this.groupBox3.Controls.Add(this.btnRolar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 225);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acões";
            // 
            // txtTentativas
            // 
            this.txtTentativas.AutoSize = true;
            this.txtTentativas.Location = new System.Drawing.Point(244, 63);
            this.txtTentativas.Name = "txtTentativas";
            this.txtTentativas.Size = new System.Drawing.Size(17, 20);
            this.txtTentativas.TabIndex = 9;
            this.txtTentativas.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(158, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tentativas:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DiceRoller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(646, 473);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DiceRoller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rolar Dados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLados;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Button btnRolar;
        private System.Windows.Forms.TextBox txtRolagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtTentativas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}