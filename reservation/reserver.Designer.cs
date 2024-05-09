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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNbreJrs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbreservatonDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_reservatonDataSet = new reservation.db_reservatonDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dbreservatonDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtsexe = new System.Windows.Forms.TextBox();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNumChbre = new System.Windows.Forms.TextBox();
            this.txtCategorieChbre = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.label6.Location = new System.Drawing.Point(36, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(550, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type chambre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(551, 388);
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
            this.txtTypeChambre.Location = new System.Drawing.Point(693, 269);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(27, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNbreJrs
            // 
            this.txtNbreJrs.Location = new System.Drawing.Point(692, 329);
            this.txtNbreJrs.Name = "txtNbreJrs";
            this.txtNbreJrs.Size = new System.Drawing.Size(312, 26);
            this.txtNbreJrs.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(41, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Catégorie ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView1.Size = new System.Drawing.Size(972, 281);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.panel1.Size = new System.Drawing.Size(1072, 40);
            this.panel1.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(403, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 26);
            this.label10.TabIndex = 11;
            this.label10.Text = "Informations Personnelles";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 38);
            this.panel2.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(451, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 26);
            this.label11.TabIndex = 11;
            this.label11.Text = "Autres Informations";
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
            // txtsexe
            // 
            this.txtsexe.Location = new System.Drawing.Point(679, 111);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.Size = new System.Drawing.Size(312, 26);
            this.txtsexe.TabIndex = 2;
            // 
            // colNom
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.colNom.DefaultCellStyle = dataGridViewCellStyle2;
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(560, 330);
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
            this.txtCategorieChbre.Location = new System.Drawing.Point(178, 329);
            this.txtCategorieChbre.Name = "txtCategorieChbre";
            this.txtCategorieChbre.Size = new System.Drawing.Size(312, 28);
            this.txtCategorieChbre.TabIndex = 5;
            this.txtCategorieChbre.SelectedIndexChanged += new System.EventHandler(this.txtTypeChambre_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(392, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(312, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(729, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(312, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // reserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 679);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCategorieChbre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTypeChambre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtmontant);
            this.Controls.Add(this.txtNumChbre);
            this.Controls.Add(this.txtNbreJrs);
            this.Controls.Add(this.txtsexe);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNbreJrs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbreservatonDataSetBindingSource;
        private db_reservatonDataSet db_reservatonDataSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource dbreservatonDataSetBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsexe;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}