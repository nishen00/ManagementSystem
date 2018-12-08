namespace MultiFaceRec
{
    partial class registationEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registationEmp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvempreg = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtempname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtempnic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddrees = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpempbirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbemptype = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbempquali = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpempjoin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlfullname = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnempdelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblcansle = new System.Windows.Forms.Label();
            this.pnlAddress = new System.Windows.Forms.Panel();
            this.pnlgender = new System.Windows.Forms.Panel();
            this.pnlqualification = new System.Windows.Forms.Panel();
            this.pnlemptype = new System.Windows.Forms.Panel();
            this.pnlphoneno = new System.Windows.Forms.Panel();
            this.pnlAge = new System.Windows.Forms.Panel();
            this.pnlNic = new System.Windows.Forms.Panel();
            this.btnempreg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempreg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.dgvempreg);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pnlfullname);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnempdelete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblcansle);
            this.panel1.Controls.Add(this.pnlAddress);
            this.panel1.Controls.Add(this.pnlgender);
            this.panel1.Controls.Add(this.pnlqualification);
            this.panel1.Controls.Add(this.pnlemptype);
            this.panel1.Controls.Add(this.pnlphoneno);
            this.panel1.Controls.Add(this.pnlAge);
            this.panel1.Controls.Add(this.pnlNic);
            this.panel1.Controls.Add(this.btnempreg);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 646);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgvempreg
            // 
            this.dgvempreg.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvempreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempreg.Location = new System.Drawing.Point(491, 286);
            this.dgvempreg.Name = "dgvempreg";
            this.dgvempreg.Size = new System.Drawing.Size(721, 231);
            this.dgvempreg.TabIndex = 42;
            this.dgvempreg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempreg_CellClick);
            this.dgvempreg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempreg_CellContentClick);
            this.dgvempreg.Leave += new System.EventHandler(this.dgvempreg_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtempname);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtempnic);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtaddrees);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtpempbirth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtage);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbemptype);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbempquali);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpempjoin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.rdoFemale);
            this.groupBox2.Controls.Add(this.rdoMale);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(178, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 577);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Registation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name";
            // 
            // txtempname
            // 
            this.txtempname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.txtempname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtempname.Location = new System.Drawing.Point(15, 53);
            this.txtempname.Name = "txtempname";
            this.txtempname.Size = new System.Drawing.Size(235, 22);
            this.txtempname.TabIndex = 12;
            this.txtempname.Leave += new System.EventHandler(this.txtempname_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIC ";
            // 
            // txtempnic
            // 
            this.txtempnic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.txtempnic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtempnic.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempnic.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtempnic.Location = new System.Drawing.Point(15, 102);
            this.txtempnic.Name = "txtempnic";
            this.txtempnic.Size = new System.Drawing.Size(235, 22);
            this.txtempnic.TabIndex = 13;
            this.txtempnic.Leave += new System.EventHandler(this.txtempnic_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // txtaddrees
            // 
            this.txtaddrees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.txtaddrees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaddrees.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddrees.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtaddrees.Location = new System.Drawing.Point(15, 154);
            this.txtaddrees.Multiline = true;
            this.txtaddrees.Name = "txtaddrees";
            this.txtaddrees.Size = new System.Drawing.Size(235, 41);
            this.txtaddrees.TabIndex = 14;
            this.txtaddrees.Leave += new System.EventHandler(this.txtaddrees_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(15, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Birth Day";
            // 
            // dtpempbirth
            // 
            this.dtpempbirth.CustomFormat = "yyyy/mm/dd";
            this.dtpempbirth.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpempbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpempbirth.Location = new System.Drawing.Point(15, 223);
            this.dtpempbirth.Name = "dtpempbirth";
            this.dtpempbirth.Size = new System.Drawing.Size(235, 22);
            this.dtpempbirth.TabIndex = 15;
            this.dtpempbirth.DragOver += new System.Windows.Forms.DragEventHandler(this.dtpempbirth_DragOver);
            this.dtpempbirth.DragLeave += new System.EventHandler(this.dtpempbirth_DragLeave);
            this.dtpempbirth.Leave += new System.EventHandler(this.dtpempbirth_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(16, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtage.Location = new System.Drawing.Point(15, 289);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(235, 22);
            this.txtage.TabIndex = 16;
            this.txtage.Leave += new System.EventHandler(this.txtage_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(16, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Employee Type";
            // 
            // cmbemptype
            // 
            this.cmbemptype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.cmbemptype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbemptype.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbemptype.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbemptype.FormattingEnabled = true;
            this.cmbemptype.Location = new System.Drawing.Point(15, 349);
            this.cmbemptype.Name = "cmbemptype";
            this.cmbemptype.Size = new System.Drawing.Size(235, 24);
            this.cmbemptype.TabIndex = 20;
            this.cmbemptype.SelectedIndexChanged += new System.EventHandler(this.cmbemptype_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(16, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Qualification";
            // 
            // cmbempquali
            // 
            this.cmbempquali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.cmbempquali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbempquali.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbempquali.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbempquali.FormattingEnabled = true;
            this.cmbempquali.Location = new System.Drawing.Point(15, 398);
            this.cmbempquali.Name = "cmbempquali";
            this.cmbempquali.Size = new System.Drawing.Size(235, 24);
            this.cmbempquali.TabIndex = 23;
            this.cmbempquali.SelectedIndexChanged += new System.EventHandler(this.cmbempquali_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(16, 425);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Join Date";
            // 
            // dtpempjoin
            // 
            this.dtpempjoin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpempjoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpempjoin.Location = new System.Drawing.Point(15, 444);
            this.dtpempjoin.Name = "dtpempjoin";
            this.dtpempjoin.Size = new System.Drawing.Size(235, 22);
            this.dtpempjoin.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(15, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gender";
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtphone.Location = new System.Drawing.Point(16, 533);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(234, 22);
            this.txtphone.TabIndex = 17;
            this.txtphone.Leave += new System.EventHandler(this.txtphone_Leave);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdoFemale.Location = new System.Drawing.Point(176, 463);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(64, 19);
            this.rdoFemale.TabIndex = 19;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            this.rdoFemale.Click += new System.EventHandler(this.rdoFemale_Click);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdoMale.Location = new System.Drawing.Point(100, 463);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(52, 19);
            this.rdoMale.TabIndex = 18;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            this.rdoMale.Click += new System.EventHandler(this.rdoMale_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(15, 514);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(482, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 270);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // pnlfullname
            // 
            this.pnlfullname.BackColor = System.Drawing.Color.IndianRed;
            this.pnlfullname.Location = new System.Drawing.Point(453, 117);
            this.pnlfullname.Name = "pnlfullname";
            this.pnlfullname.Size = new System.Drawing.Size(12, 12);
            this.pnlfullname.TabIndex = 27;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnupdate.Location = new System.Drawing.Point(698, 574);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(145, 45);
            this.btnupdate.TabIndex = 44;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnempdelete
            // 
            this.btnempdelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnempdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempdelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempdelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnempdelete.Location = new System.Drawing.Point(528, 574);
            this.btnempdelete.Name = "btnempdelete";
            this.btnempdelete.Size = new System.Drawing.Size(145, 45);
            this.btnempdelete.TabIndex = 43;
            this.btnempdelete.Text = "Delete";
            this.btnempdelete.UseVisualStyleBackColor = false;
            this.btnempdelete.Click += new System.EventHandler(this.btnempdelete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(858, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 45);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(173, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 40);
            this.panel3.TabIndex = 40;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(662, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Registation";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 646);
            this.panel2.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(12, 539);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 51);
            this.label13.TabIndex = 5;
            this.label13.Text = " Moving towards a drug \r\nabuse free Sri Lanka \r\nby year 2020.";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::MultiFaceRec.Properties.Resources.cash_register__1_;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(12, 57);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(138, 142);
            this.panel8.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(57)))));
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Location = new System.Drawing.Point(0, 605);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 38);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(117, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(26, 30);
            this.panel5.TabIndex = 44;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::MultiFaceRec.Properties.Resources.twitter;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel7.Location = new System.Drawing.Point(25, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(26, 30);
            this.panel7.TabIndex = 42;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel4.Location = new System.Drawing.Point(71, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 30);
            this.panel4.TabIndex = 43;
            // 
            // lblcansle
            // 
            this.lblcansle.AutoSize = true;
            this.lblcansle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcansle.ForeColor = System.Drawing.Color.IndianRed;
            this.lblcansle.Location = new System.Drawing.Point(593, 520);
            this.lblcansle.Name = "lblcansle";
            this.lblcansle.Size = new System.Drawing.Size(0, 19);
            this.lblcansle.TabIndex = 7;
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.IndianRed;
            this.pnlAddress.Location = new System.Drawing.Point(453, 231);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(12, 12);
            this.pnlAddress.TabIndex = 34;
            // 
            // pnlgender
            // 
            this.pnlgender.BackColor = System.Drawing.Color.IndianRed;
            this.pnlgender.Location = new System.Drawing.Point(453, 535);
            this.pnlgender.Name = "pnlgender";
            this.pnlgender.Size = new System.Drawing.Size(12, 12);
            this.pnlgender.TabIndex = 33;
            // 
            // pnlqualification
            // 
            this.pnlqualification.BackColor = System.Drawing.Color.IndianRed;
            this.pnlqualification.Location = new System.Drawing.Point(452, 465);
            this.pnlqualification.Name = "pnlqualification";
            this.pnlqualification.Size = new System.Drawing.Size(12, 12);
            this.pnlqualification.TabIndex = 32;
            // 
            // pnlemptype
            // 
            this.pnlemptype.BackColor = System.Drawing.Color.IndianRed;
            this.pnlemptype.Location = new System.Drawing.Point(452, 415);
            this.pnlemptype.Name = "pnlemptype";
            this.pnlemptype.Size = new System.Drawing.Size(12, 12);
            this.pnlemptype.TabIndex = 31;
            // 
            // pnlphoneno
            // 
            this.pnlphoneno.BackColor = System.Drawing.Color.IndianRed;
            this.pnlphoneno.Location = new System.Drawing.Point(454, 594);
            this.pnlphoneno.Name = "pnlphoneno";
            this.pnlphoneno.Size = new System.Drawing.Size(12, 12);
            this.pnlphoneno.TabIndex = 30;
            // 
            // pnlAge
            // 
            this.pnlAge.BackColor = System.Drawing.Color.IndianRed;
            this.pnlAge.Location = new System.Drawing.Point(453, 362);
            this.pnlAge.Name = "pnlAge";
            this.pnlAge.Size = new System.Drawing.Size(12, 12);
            this.pnlAge.TabIndex = 29;
            // 
            // pnlNic
            // 
            this.pnlNic.BackColor = System.Drawing.Color.IndianRed;
            this.pnlNic.Location = new System.Drawing.Point(453, 165);
            this.pnlNic.Name = "pnlNic";
            this.pnlNic.Size = new System.Drawing.Size(12, 12);
            this.pnlNic.TabIndex = 28;
            // 
            // btnempreg
            // 
            this.btnempreg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnempreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempreg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempreg.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnempreg.Location = new System.Drawing.Point(1025, 574);
            this.btnempreg.Name = "btnempreg";
            this.btnempreg.Size = new System.Drawing.Size(145, 45);
            this.btnempreg.TabIndex = 22;
            this.btnempreg.Text = "Insert";
            this.btnempreg.UseVisualStyleBackColor = false;
            this.btnempreg.Click += new System.EventHandler(this.btnempreg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(480, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // registationEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources.black_background_00313351;
            this.ClientSize = new System.Drawing.Size(1230, 646);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registationEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registationEmp";
            this.Load += new System.EventHandler(this.registationEmp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempreg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcansle;
        private System.Windows.Forms.Panel pnlAddress;
        private System.Windows.Forms.Panel pnlgender;
        private System.Windows.Forms.Panel pnlqualification;
        private System.Windows.Forms.Panel pnlemptype;
        private System.Windows.Forms.Panel pnlphoneno;
        private System.Windows.Forms.Panel pnlAge;
        private System.Windows.Forms.Panel pnlNic;
        private System.Windows.Forms.Panel pnlfullname;
        private System.Windows.Forms.DateTimePicker dtpempjoin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbempquali;
        private System.Windows.Forms.Button btnempreg;
        private System.Windows.Forms.ComboBox cmbemptype;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.DateTimePicker dtpempbirth;
        private System.Windows.Forms.TextBox txtaddrees;
        private System.Windows.Forms.TextBox txtempnic;
        private System.Windows.Forms.TextBox txtempname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvempreg;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnempdelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}