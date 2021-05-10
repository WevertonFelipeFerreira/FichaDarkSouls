
namespace FichaDS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAttGrid = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDiceRoller = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.labelPausado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fichas cadastradas no sistema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(649, 252);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Abrir Ficha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(303, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Excluir Ficha";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(156, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar Ficha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAttGrid
            // 
            this.btnAttGrid.BackColor = System.Drawing.Color.Silver;
            this.btnAttGrid.BackgroundImage = global::FichaDS.Properties.Resources.reload;
            this.btnAttGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAttGrid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttGrid.Location = new System.Drawing.Point(617, 142);
            this.btnAttGrid.Name = "btnAttGrid";
            this.btnAttGrid.Size = new System.Drawing.Size(42, 39);
            this.btnAttGrid.TabIndex = 7;
            this.btnAttGrid.UseVisualStyleBackColor = false;
            this.btnAttGrid.Click += new System.EventHandler(this.btnAttGrid_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(105, 120);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 27);
            this.txtId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite o ID:";
            // 
            // btnDiceRoller
            // 
            this.btnDiceRoller.BackgroundImage = global::FichaDS.Properties.Resources.Dado;
            this.btnDiceRoller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiceRoller.Location = new System.Drawing.Point(447, 5);
            this.btnDiceRoller.Name = "btnDiceRoller";
            this.btnDiceRoller.Size = new System.Drawing.Size(70, 63);
            this.btnDiceRoller.TabIndex = 10;
            this.btnDiceRoller.UseVisualStyleBackColor = true;
            this.btnDiceRoller.Click += new System.EventHandler(this.btnDiceRoller_Click);
            // 
            // btnMute
            // 
            this.btnMute.BackgroundImage = global::FichaDS.Properties.Resources._1024px_Mute_Icon_svg;
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMute.Location = new System.Drawing.Point(617, 5);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(42, 36);
            this.btnMute.TabIndex = 11;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // labelPausado
            // 
            this.labelPausado.AutoSize = true;
            this.labelPausado.ForeColor = System.Drawing.Color.DarkRed;
            this.labelPausado.Location = new System.Drawing.Point(597, 43);
            this.labelPausado.Name = "labelPausado";
            this.labelPausado.Size = new System.Drawing.Size(64, 20);
            this.labelPausado.TabIndex = 12;
            this.labelPausado.Text = "Pausado";
            this.labelPausado.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(673, 478);
            this.Controls.Add(this.labelPausado);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnDiceRoller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnAttGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha Dark Souls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAttGrid;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDiceRoller;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Label labelPausado;
    }
}

