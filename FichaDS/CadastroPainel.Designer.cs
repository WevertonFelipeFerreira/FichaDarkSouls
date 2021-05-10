
namespace FichaDS
{
    partial class CadastroPainel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPainel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricaoItem = new System.Windows.Forms.TextBox();
            this.comboItemSepulcro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricaoClasse = new System.Windows.Forms.TextBox();
            this.comboClasse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeroi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJogador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSorte = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFe = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInteligencia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDestreza = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtForca = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVitalidade = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFortitude = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtConhecimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVigor = new System.Windows.Forms.TextBox();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDescricaoItem);
            this.groupBox1.Controls.Add(this.comboItemSepulcro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescricaoClasse);
            this.groupBox1.Controls.Add(this.comboClasse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHeroi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtJogador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Unziale", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 591);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Unziale", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(142, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descrição do item";
            // 
            // txtDescricaoItem
            // 
            this.txtDescricaoItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDescricaoItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescricaoItem.Location = new System.Drawing.Point(84, 425);
            this.txtDescricaoItem.Multiline = true;
            this.txtDescricaoItem.Name = "txtDescricaoItem";
            this.txtDescricaoItem.ReadOnly = true;
            this.txtDescricaoItem.Size = new System.Drawing.Size(327, 154);
            this.txtDescricaoItem.TabIndex = 10;
            this.txtDescricaoItem.TextChanged += new System.EventHandler(this.txtDescricaoItem_TextChanged);
            // 
            // comboItemSepulcro
            // 
            this.comboItemSepulcro.AutoCompleteCustomSource.AddRange(new string[] {
            "Nenhum",
            "Anel da vida",
            "Benção Divina",
            "Benção oculta",
            "Bomba Incendiária Negra",
            "Joia de Fogo",
            "Alma sem soberano",
            "Moeda de Ouro Enferrujada",
            "Galho Branco Jovem"});
            this.comboItemSepulcro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboItemSepulcro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboItemSepulcro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboItemSepulcro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboItemSepulcro.FormattingEnabled = true;
            this.comboItemSepulcro.Items.AddRange(new object[] {
            "Nenhum",
            "Anel da vida",
            "Benção Divina",
            "Benção oculta",
            "Bomba Incendiária Negra",
            "Joia de Fogo",
            "Alma sem soberano",
            "Moeda de Ouro Enferrujada",
            "Galho Branco Jovem"});
            this.comboItemSepulcro.Location = new System.Drawing.Point(158, 364);
            this.comboItemSepulcro.Name = "comboItemSepulcro";
            this.comboItemSepulcro.Size = new System.Drawing.Size(253, 28);
            this.comboItemSepulcro.TabIndex = 9;
            this.comboItemSepulcro.SelectedIndexChanged += new System.EventHandler(this.comboItemSepulcro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(18, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Item de sepulcro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Unziale", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(127, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Descrição da classe";
            // 
            // txtDescricaoClasse
            // 
            this.txtDescricaoClasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricaoClasse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDescricaoClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescricaoClasse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDescricaoClasse.Location = new System.Drawing.Point(84, 182);
            this.txtDescricaoClasse.Multiline = true;
            this.txtDescricaoClasse.Name = "txtDescricaoClasse";
            this.txtDescricaoClasse.ReadOnly = true;
            this.txtDescricaoClasse.Size = new System.Drawing.Size(327, 154);
            this.txtDescricaoClasse.TabIndex = 6;
            this.txtDescricaoClasse.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboClasse
            // 
            this.comboClasse.AutoCompleteCustomSource.AddRange(new string[] {
            "Cavaleiro",
            "Mercenário",
            "Guerreiro",
            "Arauto",
            "Ladrão",
            "Assasino",
            "Feiticeiro",
            "Piromante",
            "Clérigo",
            "Despojado"});
            this.comboClasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboClasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboClasse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboClasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboClasse.FormattingEnabled = true;
            this.comboClasse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboClasse.Items.AddRange(new object[] {
            "Cavaleiro",
            "Mercenário",
            "Guerreiro",
            "Arauto",
            "Ladrão",
            "Assasino",
            "Feiticeiro",
            "Piromante",
            "Clérigo",
            "Despojado"});
            this.comboClasse.Location = new System.Drawing.Point(158, 119);
            this.comboClasse.Name = "comboClasse";
            this.comboClasse.Size = new System.Drawing.Size(253, 28);
            this.comboClasse.TabIndex = 5;
            this.comboClasse.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(95, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Classe";
            // 
            // txtHeroi
            // 
            this.txtHeroi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHeroi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHeroi.Location = new System.Drawing.Point(158, 77);
            this.txtHeroi.Name = "txtHeroi";
            this.txtHeroi.Size = new System.Drawing.Size(253, 27);
            this.txtHeroi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do herói";
            // 
            // txtJogador
            // 
            this.txtJogador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtJogador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtJogador.Location = new System.Drawing.Point(158, 36);
            this.txtJogador.Name = "txtJogador";
            this.txtJogador.Size = new System.Drawing.Size(253, 27);
            this.txtJogador.TabIndex = 1;
            this.txtJogador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do jogador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unziale", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(100, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(502, 38);
            this.label4.TabIndex = 1;
            this.label4.Text = "Painel de cadastro de ficha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSorte);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtFe);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtInteligencia);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtDestreza);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtForca);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtVitalidade);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtFortitude);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtConhecimento);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtVigor);
            this.groupBox2.Controls.Add(this.txtNivel);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Unziale", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(460, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 329);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // txtSorte
            // 
            this.txtSorte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSorte.Location = new System.Drawing.Point(173, 289);
            this.txtSorte.Multiline = true;
            this.txtSorte.Name = "txtSorte";
            this.txtSorte.ReadOnly = true;
            this.txtSorte.Size = new System.Drawing.Size(60, 22);
            this.txtSorte.TabIndex = 19;
            this.txtSorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(99, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 25);
            this.label17.TabIndex = 18;
            this.label17.Text = "SORTE";
            // 
            // txtFe
            // 
            this.txtFe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFe.Location = new System.Drawing.Point(173, 261);
            this.txtFe.Multiline = true;
            this.txtFe.Name = "txtFe";
            this.txtFe.ReadOnly = true;
            this.txtFe.Size = new System.Drawing.Size(60, 22);
            this.txtFe.TabIndex = 17;
            this.txtFe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(135, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 25);
            this.label16.TabIndex = 16;
            this.label16.Text = "FÉ";
            // 
            // txtInteligencia
            // 
            this.txtInteligencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInteligencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInteligencia.Location = new System.Drawing.Point(173, 233);
            this.txtInteligencia.Multiline = true;
            this.txtInteligencia.Name = "txtInteligencia";
            this.txtInteligencia.ReadOnly = true;
            this.txtInteligencia.Size = new System.Drawing.Size(60, 22);
            this.txtInteligencia.TabIndex = 15;
            this.txtInteligencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(30, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "INTELIGÊNCIA";
            // 
            // txtDestreza
            // 
            this.txtDestreza.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDestreza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDestreza.Location = new System.Drawing.Point(173, 205);
            this.txtDestreza.Multiline = true;
            this.txtDestreza.Name = "txtDestreza";
            this.txtDestreza.ReadOnly = true;
            this.txtDestreza.Size = new System.Drawing.Size(60, 22);
            this.txtDestreza.TabIndex = 13;
            this.txtDestreza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(65, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "DESTREZA";
            // 
            // txtForca
            // 
            this.txtForca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtForca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtForca.Location = new System.Drawing.Point(173, 177);
            this.txtForca.Multiline = true;
            this.txtForca.Name = "txtForca";
            this.txtForca.ReadOnly = true;
            this.txtForca.Size = new System.Drawing.Size(60, 22);
            this.txtForca.TabIndex = 11;
            this.txtForca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(94, 178);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "FORÇA";
            // 
            // txtVitalidade
            // 
            this.txtVitalidade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtVitalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVitalidade.Location = new System.Drawing.Point(173, 149);
            this.txtVitalidade.Multiline = true;
            this.txtVitalidade.Name = "txtVitalidade";
            this.txtVitalidade.ReadOnly = true;
            this.txtVitalidade.Size = new System.Drawing.Size(60, 22);
            this.txtVitalidade.TabIndex = 9;
            this.txtVitalidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(49, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "VITALIDADE";
            // 
            // txtFortitude
            // 
            this.txtFortitude.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFortitude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFortitude.Location = new System.Drawing.Point(173, 121);
            this.txtFortitude.Multiline = true;
            this.txtFortitude.Name = "txtFortitude";
            this.txtFortitude.ReadOnly = true;
            this.txtFortitude.Size = new System.Drawing.Size(60, 22);
            this.txtFortitude.TabIndex = 7;
            this.txtFortitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(56, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "FORTITUDE";
            // 
            // txtConhecimento
            // 
            this.txtConhecimento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConhecimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConhecimento.Location = new System.Drawing.Point(173, 93);
            this.txtConhecimento.Multiline = true;
            this.txtConhecimento.Name = "txtConhecimento";
            this.txtConhecimento.ReadOnly = true;
            this.txtConhecimento.Size = new System.Drawing.Size(60, 22);
            this.txtConhecimento.TabIndex = 5;
            this.txtConhecimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConhecimento.TextChanged += new System.EventHandler(this.txtConhecimento_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(5, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "CONHECIMENTO";
            // 
            // txtVigor
            // 
            this.txtVigor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtVigor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVigor.Location = new System.Drawing.Point(173, 65);
            this.txtVigor.Multiline = true;
            this.txtVigor.Name = "txtVigor";
            this.txtVigor.ReadOnly = true;
            this.txtVigor.Size = new System.Drawing.Size(60, 22);
            this.txtVigor.TabIndex = 3;
            this.txtVigor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNivel
            // 
            this.txtNivel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNivel.ForeColor = System.Drawing.Color.Maroon;
            this.txtNivel.Location = new System.Drawing.Point(173, 38);
            this.txtNivel.Multiline = true;
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.ReadOnly = true;
            this.txtNivel.Size = new System.Drawing.Size(60, 22);
            this.txtNivel.TabIndex = 2;
            this.txtNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(98, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "VIGOR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(103, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "NIVEL";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = global::FichaDS.Properties.Resources.cadastrar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(478, 389);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(108, 51);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::FichaDS.Properties.Resources.teste_2;
            this.pictureBox1.Location = new System.Drawing.Point(469, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::FichaDS.Properties.Resources.sair;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(614, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroPainel";
            this.Text = "CadastroPainel";
            this.Load += new System.EventHandler(this.CadastroPainel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboClasse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeroi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricaoClasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricaoItem;
        private System.Windows.Forms.ComboBox comboItemSepulcro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSorte;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtInteligencia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDestreza;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtForca;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVitalidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFortitude;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtConhecimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVigor;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}