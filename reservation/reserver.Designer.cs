namespace reservation
{
    partial class reserver
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reserver));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtpostnom = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTypeChambre = new System.Windows.Forms.ComboBox();
            this.txtmontant = new System.Windows.Forms.TextBox();
            this.txtNbreJrs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPostNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNbreJrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTypeChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategorieChbre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbreservatonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_reservatonDataSet = new reservation.db_reservatonDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dbreservatonDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumChbre = new System.Windows.Forms.TextBox();
            this.txtCategorieChbre = new System.Windows.Forms.ComboBox();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.modifier = new DevExpress.XtraEditors.SimpleButton();
            this.supprimer = new DevExpress.XtraEditors.SimpleButton();
            this.txtsexe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbreservatonDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_reservatonDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbreservatonDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Post-Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(542, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Phone";
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(178, 59);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(312, 26);
            this.txtnom.TabIndex = 2;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(178, 164);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(312, 26);
            this.txtprenom.TabIndex = 2;
            // 
            // txtpostnom
            // 
            this.txtpostnom.Location = new System.Drawing.Point(178, 111);
            this.txtpostnom.Name = "txtpostnom";
            this.txtpostnom.Size = new System.Drawing.Size(312, 26);
            this.txtpostnom.TabIndex = 2;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(679, 59);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(312, 26);
            this.txtphone.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type chambre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(556, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Montant";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 385);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(312, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtTypeChambre
            // 
            this.txtTypeChambre.FormattingEnabled = true;
            this.txtTypeChambre.Items.AddRange(new object[] {
            "Chambre à lit simple",
            "Chambre à lit double"});
            this.txtTypeChambre.Location = new System.Drawing.Point(693, 325);
            this.txtTypeChambre.Name = "txtTypeChambre";
            this.txtTypeChambre.Size = new System.Drawing.Size(312, 28);
            this.txtTypeChambre.TabIndex = 5;
            this.txtTypeChambre.SelectedIndexChanged += new System.EventHandler(this.txtTypeChambre_SelectedIndexChanged);
            // 
            // txtmontant
            // 
            this.txtmontant.Location = new System.Drawing.Point(693, 387);
            this.txtmontant.Name = "txtmontant";
            this.txtmontant.Size = new System.Drawing.Size(312, 26);
            this.txtmontant.TabIndex = 2;
            // 
            // txtNbreJrs
            // 
            this.txtNbreJrs.Location = new System.Drawing.Point(178, 327);
            this.txtNbreJrs.Name = "txtNbreJrs";
            this.txtNbreJrs.Size = new System.Drawing.Size(312, 26);
            this.txtNbreJrs.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Catégorie ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNom,
            this.colPostNom,
            this.colPrenom,
            this.ColSexe,
            this.ColPhone,
            this.ColDate,
            this.ColNbreJrs,
            this.ColTypeChambre,
            this.ColCategorieChbre,
            this.NumChambre,
            this.ColMontant});
            this.dataGridView1.Location = new System.Drawing.Point(45, 515);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 281);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colNom
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.colNom.DefaultCellStyle = dataGridViewCellStyle6;
            this.colNom.HeaderText = "Nom";
            this.colNom.Name = "colNom";
            // 
            // colPostNom
            // 
            this.colPostNom.HeaderText = "Post-Nom";
            this.colPostNom.Name = "colPostNom";
            // 
            // colPrenom
            // 
            this.colPrenom.HeaderText = "Prénom";
            this.colPrenom.Name = "colPrenom";
            // 
            // ColSexe
            // 
            this.ColSexe.HeaderText = "Sexe";
            this.ColSexe.Name = "ColSexe";
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Phone";
            this.ColPhone.Name = "ColPhone";
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            // 
            // ColNbreJrs
            // 
            this.ColNbreJrs.HeaderText = "Nombre de Jours";
            this.ColNbreJrs.Name = "ColNbreJrs";
            // 
            // ColTypeChambre
            // 
            this.ColTypeChambre.HeaderText = "Type de Chambre";
            this.ColTypeChambre.Name = "ColTypeChambre";
            // 
            // ColCategorieChbre
            // 
            this.ColCategorieChbre.HeaderText = "Catégorie de chambre";
            this.ColCategorieChbre.Name = "ColCategorieChbre";
            // 
            // NumChambre
            // 
            this.NumChambre.HeaderText = "N° ";
            this.NumChambre.Name = "NumChambre";
            // 
            // ColMontant
            // 
            this.ColMontant.HeaderText = "Montant";
            this.ColMontant.Name = "ColMontant";
            // 
            // dbreservatonDataSetBindingSource
            // 
            this.dbreservatonDataSetBindingSource.DataSource = this.db_reservatonDataSet;
            this.dbreservatonDataSetBindingSource.Position = 0;
            // 
            // db_reservatonDataSet
            // 
            this.db_reservatonDataSet.DataSetName = "db_reservatonDataSet";
            this.db_reservatonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1452, 40);
            this.panel1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(546, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Informations Personnelles";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(3, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1452, 38);
            this.panel2.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(580, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 26);
            this.label14.TabIndex = 11;
            this.label14.Text = "Autres Informations";
            // 
            // dbreservatonDataSetBindingSource1
            // 
            this.dbreservatonDataSetBindingSource1.DataSource = this.db_reservatonDataSet;
            this.dbreservatonDataSetBindingSource1.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sexe";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 23);
            this.label12.TabIndex = 1;
            this.label12.Text = "Nbre de Jour";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 23);
            this.label13.TabIndex = 1;
            this.label13.Text = "N° Chambre";
            // 
            // txtNumChbre
            // 
            this.txtNumChbre.Location = new System.Drawing.Point(178, 274);
            this.txtNumChbre.Name = "txtNumChbre";
            this.txtNumChbre.Size = new System.Drawing.Size(312, 26);
            this.txtNumChbre.TabIndex = 2;
            // 
            // txtCategorieChbre
            // 
            this.txtCategorieChbre.FormattingEnabled = true;
            this.txtCategorieChbre.Items.AddRange(new object[] {
            "VIP",
            "Standard"});
            this.txtCategorieChbre.Location = new System.Drawing.Point(693, 277);
            this.txtCategorieChbre.Name = "txtCategorieChbre";
            this.txtCategorieChbre.Size = new System.Drawing.Size(312, 28);
            this.txtCategorieChbre.TabIndex = 5;
            this.txtCategorieChbre.SelectedIndexChanged += new System.EventHandler(this.txtTypeChambre_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.button1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.button1.Appearance.Options.UseBackColor = true;
            this.button1.Appearance.Options.UseBorderColor = true;
            this.button1.Appearance.Options.UseFont = true;
            this.button1.Appearance.Options.UseForeColor = true;
            this.button1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.button1.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.button1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.button1.Location = new System.Drawing.Point(1136, 259);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(284, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "Valider";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // modifier
            // 
            this.modifier.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.modifier.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.modifier.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.modifier.Appearance.ForeColor = System.Drawing.Color.Red;
            this.modifier.Appearance.Options.UseBackColor = true;
            this.modifier.Appearance.Options.UseBorderColor = true;
            this.modifier.Appearance.Options.UseFont = true;
            this.modifier.Appearance.Options.UseForeColor = true;
            this.modifier.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.modifier.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.modifier.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.modifier.Location = new System.Drawing.Point(1136, 357);
            this.modifier.Name = "modifier";
            this.modifier.Padding = new System.Windows.Forms.Padding(10);
            this.modifier.Size = new System.Drawing.Size(284, 54);
            this.modifier.TabIndex = 10;
            this.modifier.Text = "Modifier";
            // 
            // supprimer
            // 
            this.supprimer.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.supprimer.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.supprimer.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.supprimer.Appearance.ForeColor = System.Drawing.Color.Red;
            this.supprimer.Appearance.Options.UseBackColor = true;
            this.supprimer.Appearance.Options.UseBorderColor = true;
            this.supprimer.Appearance.Options.UseFont = true;
            this.supprimer.Appearance.Options.UseForeColor = true;
            this.supprimer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.supprimer.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.supprimer.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.supprimer.Location = new System.Drawing.Point(1136, 441);
            this.supprimer.Name = "supprimer";
            this.supprimer.Padding = new System.Windows.Forms.Padding(10);
            this.supprimer.Size = new System.Drawing.Size(284, 54);
            this.supprimer.TabIndex = 10;
            this.supprimer.Text = "Supprimer";
            // 
            // txtsexe
            // 
            this.txtsexe.FormattingEnabled = true;
            this.txtsexe.Items.AddRange(new object[] {
            "Masculin",
            "Féminin "});
            this.txtsexe.Location = new System.Drawing.Point(679, 111);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.Size = new System.Drawing.Size(312, 28);
            this.txtsexe.TabIndex = 11;
            // 
            // reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1449, 710);
            this.Controls.Add(this.txtsexe);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCategorieChbre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTypeChambre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.txtNumChbre);
            this.Controls.Add(this.txtNbreJrs);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtpostnom);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1471, 766);
            this.Name = "reserver";
            this.Text = "reserver";
            this.Load += new System.EventHandler(this.reserver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbreservatonDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_reservatonDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbreservatonDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtpostnom;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox txtTypeChambre;
        private System.Windows.Forms.TextBox txtmontant;
        private System.Windows.Forms.TextBox txtNbreJrs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbreservatonDataSetBindingSource;
        private db_reservatonDataSet db_reservatonDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource dbreservatonDataSetBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPostNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNbreJrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTypeChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategorieChbre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMontant;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNumChbre;
        private System.Windows.Forms.ComboBox txtCategorieChbre;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.SimpleButton modifier;
        private DevExpress.XtraEditors.SimpleButton supprimer;
        private System.Windows.Forms.ComboBox txtsexe;
    }
}