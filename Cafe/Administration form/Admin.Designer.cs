
namespace Cafe
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.doBacklabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelErrorWorkrSearch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWorkrSearch = new System.Windows.Forms.TextBox();
            this.comboBoxWorkrSearchBy = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonShowWorkr = new System.Windows.Forms.Button();
            this.buttonPrintWorkrTable = new System.Windows.Forms.Button();
            this.buttonSendWorkrTable = new System.Windows.Forms.Button();
            this.buttonAddWorkr = new System.Windows.Forms.Button();
            this.buttonDelWorkr = new System.Windows.Forms.Button();
            this.buttonSaveWrkrTable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDishesSearchError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDishesSearch = new System.Windows.Forms.TextBox();
            this.comboBoxDishesSearchBy = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonPrintDishesTable = new System.Windows.Forms.Button();
            this.buttonSendDishesTable = new System.Windows.Forms.Button();
            this.buttonLoadDishes = new System.Windows.Forms.Button();
            this.buttonAddDishes = new System.Windows.Forms.Button();
            this.buttonSaveDishesTable = new System.Windows.Forms.Button();
            this.buttonDelDishes = new System.Windows.Forms.Button();
            this.buttonShowAccounts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.doBacklabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 644);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 555);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(80, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // doBacklabel
            // 
            this.doBacklabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doBacklabel.Image = global::Cafe.Properties.Resources.iconfinder__svg_2093657;
            this.doBacklabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.doBacklabel.Location = new System.Drawing.Point(2, 1);
            this.doBacklabel.Name = "doBacklabel";
            this.doBacklabel.Size = new System.Drawing.Size(67, 69);
            this.doBacklabel.TabIndex = 3;
            this.doBacklabel.Click += new System.EventHandler(this.doBacklabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonSales);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.buttonShowAccounts);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(780, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 644);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // buttonSales
            // 
            this.buttonSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSales.BackColor = System.Drawing.Color.Lime;
            this.buttonSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSales.Location = new System.Drawing.Point(200, 480);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(173, 30);
            this.buttonSales.TabIndex = 15;
            this.buttonSales.Text = "Продажи";
            this.buttonSales.UseVisualStyleBackColor = false;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.buttonShowWorkr);
            this.groupBox1.Controls.Add(this.buttonPrintWorkrTable);
            this.groupBox1.Controls.Add(this.buttonSendWorkrTable);
            this.groupBox1.Controls.Add(this.buttonAddWorkr);
            this.groupBox1.Controls.Add(this.buttonDelWorkr);
            this.groupBox1.Controls.Add(this.buttonSaveWrkrTable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(21, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 224);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Workers";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelErrorWorkrSearch);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxWorkrSearch);
            this.groupBox4.Controls.Add(this.comboBoxWorkrSearchBy);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(266, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 114);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поиск";
            // 
            // labelErrorWorkrSearch
            // 
            this.labelErrorWorkrSearch.AutoSize = true;
            this.labelErrorWorkrSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorWorkrSearch.ForeColor = System.Drawing.Color.Red;
            this.labelErrorWorkrSearch.Location = new System.Drawing.Point(11, 87);
            this.labelErrorWorkrSearch.Name = "labelErrorWorkrSearch";
            this.labelErrorWorkrSearch.Size = new System.Drawing.Size(0, 13);
            this.labelErrorWorkrSearch.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Значение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Поиск по";
            // 
            // textBoxWorkrSearch
            // 
            this.textBoxWorkrSearch.Enabled = false;
            this.textBoxWorkrSearch.Location = new System.Drawing.Point(79, 61);
            this.textBoxWorkrSearch.Name = "textBoxWorkrSearch";
            this.textBoxWorkrSearch.Size = new System.Drawing.Size(159, 22);
            this.textBoxWorkrSearch.TabIndex = 11;
            this.textBoxWorkrSearch.TextChanged += new System.EventHandler(this.textBoxWorkrSearch_TextChanged);
            // 
            // comboBoxWorkrSearchBy
            // 
            this.comboBoxWorkrSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkrSearchBy.Enabled = false;
            this.comboBoxWorkrSearchBy.FormattingEnabled = true;
            this.comboBoxWorkrSearchBy.Items.AddRange(new object[] {
            "Должность",
            "ФИО",
            "Возраст",
            "Зарплата"});
            this.comboBoxWorkrSearchBy.Location = new System.Drawing.Point(79, 19);
            this.comboBoxWorkrSearchBy.Name = "comboBoxWorkrSearchBy";
            this.comboBoxWorkrSearchBy.Size = new System.Drawing.Size(159, 24);
            this.comboBoxWorkrSearchBy.TabIndex = 10;
            this.comboBoxWorkrSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkrSearchBy_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Cafe.Properties.Resources.iconfinder_Manager_131484;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // buttonShowWorkr
            // 
            this.buttonShowWorkr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowWorkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowWorkr.Location = new System.Drawing.Point(69, 53);
            this.buttonShowWorkr.Name = "buttonShowWorkr";
            this.buttonShowWorkr.Size = new System.Drawing.Size(99, 30);
            this.buttonShowWorkr.TabIndex = 6;
            this.buttonShowWorkr.Text = "работники";
            this.buttonShowWorkr.UseVisualStyleBackColor = true;
            this.buttonShowWorkr.Click += new System.EventHandler(this.buttonShowWorkr_Click);
            // 
            // buttonPrintWorkrTable
            // 
            this.buttonPrintWorkrTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrintWorkrTable.Enabled = false;
            this.buttonPrintWorkrTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintWorkrTable.Location = new System.Drawing.Point(6, 172);
            this.buttonPrintWorkrTable.Name = "buttonPrintWorkrTable";
            this.buttonPrintWorkrTable.Size = new System.Drawing.Size(69, 25);
            this.buttonPrintWorkrTable.TabIndex = 6;
            this.buttonPrintWorkrTable.Text = "печать";
            this.buttonPrintWorkrTable.UseVisualStyleBackColor = true;
            this.buttonPrintWorkrTable.Click += new System.EventHandler(this.buttonPrintDishesTable_Click);
            // 
            // buttonSendWorkrTable
            // 
            this.buttonSendWorkrTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendWorkrTable.Enabled = false;
            this.buttonSendWorkrTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendWorkrTable.Location = new System.Drawing.Point(6, 139);
            this.buttonSendWorkrTable.Name = "buttonSendWorkrTable";
            this.buttonSendWorkrTable.Size = new System.Drawing.Size(169, 27);
            this.buttonSendWorkrTable.TabIndex = 6;
            this.buttonSendWorkrTable.Text = "отправить на email";
            this.buttonSendWorkrTable.UseVisualStyleBackColor = true;
            this.buttonSendWorkrTable.Click += new System.EventHandler(this.buttonSendDishesTable_Click);
            // 
            // buttonAddWorkr
            // 
            this.buttonAddWorkr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddWorkr.Enabled = false;
            this.buttonAddWorkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddWorkr.Location = new System.Drawing.Point(251, 19);
            this.buttonAddWorkr.Name = "buttonAddWorkr";
            this.buttonAddWorkr.Size = new System.Drawing.Size(197, 28);
            this.buttonAddWorkr.TabIndex = 6;
            this.buttonAddWorkr.Text = "добавить работника";
            this.buttonAddWorkr.UseVisualStyleBackColor = true;
            this.buttonAddWorkr.Click += new System.EventHandler(this.buttonAddWorkr_Click);
            // 
            // buttonDelWorkr
            // 
            this.buttonDelWorkr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelWorkr.Enabled = false;
            this.buttonDelWorkr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelWorkr.Location = new System.Drawing.Point(69, 19);
            this.buttonDelWorkr.Name = "buttonDelWorkr";
            this.buttonDelWorkr.Size = new System.Drawing.Size(176, 28);
            this.buttonDelWorkr.TabIndex = 6;
            this.buttonDelWorkr.Text = "удалить работника";
            this.buttonDelWorkr.UseVisualStyleBackColor = true;
            this.buttonDelWorkr.Click += new System.EventHandler(this.buttonDelDishes_Click);
            // 
            // buttonSaveWrkrTable
            // 
            this.buttonSaveWrkrTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveWrkrTable.Enabled = false;
            this.buttonSaveWrkrTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveWrkrTable.Location = new System.Drawing.Point(6, 104);
            this.buttonSaveWrkrTable.Name = "buttonSaveWrkrTable";
            this.buttonSaveWrkrTable.Size = new System.Drawing.Size(169, 29);
            this.buttonSaveWrkrTable.TabIndex = 6;
            this.buttonSaveWrkrTable.Text = "сохранить в word";
            this.buttonSaveWrkrTable.UseVisualStyleBackColor = true;
            this.buttonSaveWrkrTable.Click += new System.EventHandler(this.buttonSaveWrkrTable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.buttonPrintDishesTable);
            this.groupBox2.Controls.Add(this.buttonSendDishesTable);
            this.groupBox2.Controls.Add(this.buttonLoadDishes);
            this.groupBox2.Controls.Add(this.buttonAddDishes);
            this.groupBox2.Controls.Add(this.buttonSaveDishesTable);
            this.groupBox2.Controls.Add(this.buttonDelDishes);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(21, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 184);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDishesSearchError);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxDishesSearch);
            this.groupBox3.Controls.Add(this.comboBoxDishesSearchBy);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(266, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 108);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск";
            // 
            // labelDishesSearchError
            // 
            this.labelDishesSearchError.AutoSize = true;
            this.labelDishesSearchError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDishesSearchError.ForeColor = System.Drawing.Color.Red;
            this.labelDishesSearchError.Location = new System.Drawing.Point(11, 88);
            this.labelDishesSearchError.Name = "labelDishesSearchError";
            this.labelDishesSearchError.Size = new System.Drawing.Size(0, 13);
            this.labelDishesSearchError.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Значение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Поиск по";
            // 
            // textBoxDishesSearch
            // 
            this.textBoxDishesSearch.Enabled = false;
            this.textBoxDishesSearch.Location = new System.Drawing.Point(79, 61);
            this.textBoxDishesSearch.Name = "textBoxDishesSearch";
            this.textBoxDishesSearch.Size = new System.Drawing.Size(159, 22);
            this.textBoxDishesSearch.TabIndex = 11;
            this.textBoxDishesSearch.TextChanged += new System.EventHandler(this.textBoxDishesSearch_TextChanged);
            // 
            // comboBoxDishesSearchBy
            // 
            this.comboBoxDishesSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDishesSearchBy.Enabled = false;
            this.comboBoxDishesSearchBy.FormattingEnabled = true;
            this.comboBoxDishesSearchBy.Items.AddRange(new object[] {
            "Цена",
            "Тип",
            "Время приготовления",
            "Название"});
            this.comboBoxDishesSearchBy.Location = new System.Drawing.Point(79, 19);
            this.comboBoxDishesSearchBy.Name = "comboBoxDishesSearchBy";
            this.comboBoxDishesSearchBy.Size = new System.Drawing.Size(159, 24);
            this.comboBoxDishesSearchBy.TabIndex = 10;
            this.comboBoxDishesSearchBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxDishesSearchBy_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = global::Cafe.Properties.Resources.iconfinder_Food_bag_6457554__1_;
            this.pictureBox3.Location = new System.Drawing.Point(6, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // buttonPrintDishesTable
            // 
            this.buttonPrintDishesTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrintDishesTable.Enabled = false;
            this.buttonPrintDishesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintDishesTable.Location = new System.Drawing.Point(6, 149);
            this.buttonPrintDishesTable.Name = "buttonPrintDishesTable";
            this.buttonPrintDishesTable.Size = new System.Drawing.Size(69, 25);
            this.buttonPrintDishesTable.TabIndex = 6;
            this.buttonPrintDishesTable.Text = "печать";
            this.buttonPrintDishesTable.UseVisualStyleBackColor = true;
            this.buttonPrintDishesTable.Click += new System.EventHandler(this.buttonPrintDishesTable_Click);
            // 
            // buttonSendDishesTable
            // 
            this.buttonSendDishesTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendDishesTable.Enabled = false;
            this.buttonSendDishesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendDishesTable.Location = new System.Drawing.Point(6, 116);
            this.buttonSendDishesTable.Name = "buttonSendDishesTable";
            this.buttonSendDishesTable.Size = new System.Drawing.Size(169, 27);
            this.buttonSendDishesTable.TabIndex = 6;
            this.buttonSendDishesTable.Text = "отправить на email";
            this.buttonSendDishesTable.UseVisualStyleBackColor = true;
            this.buttonSendDishesTable.Click += new System.EventHandler(this.buttonSendDishesTable_Click);
            // 
            // buttonLoadDishes
            // 
            this.buttonLoadDishes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadDishes.Location = new System.Drawing.Point(69, 19);
            this.buttonLoadDishes.Name = "buttonLoadDishes";
            this.buttonLoadDishes.Size = new System.Drawing.Size(142, 32);
            this.buttonLoadDishes.TabIndex = 6;
            this.buttonLoadDishes.Text = "просмотр блюд";
            this.buttonLoadDishes.UseVisualStyleBackColor = true;
            this.buttonLoadDishes.Click += new System.EventHandler(this.buttonLoadDishes_Click);
            // 
            // buttonAddDishes
            // 
            this.buttonAddDishes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddDishes.Enabled = false;
            this.buttonAddDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDishes.Location = new System.Drawing.Point(217, 19);
            this.buttonAddDishes.Name = "buttonAddDishes";
            this.buttonAddDishes.Size = new System.Drawing.Size(151, 32);
            this.buttonAddDishes.TabIndex = 6;
            this.buttonAddDishes.Text = "добавить блюдо";
            this.buttonAddDishes.UseVisualStyleBackColor = true;
            this.buttonAddDishes.Click += new System.EventHandler(this.buttonAddDishes_Click);
            // 
            // buttonSaveDishesTable
            // 
            this.buttonSaveDishesTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDishesTable.Enabled = false;
            this.buttonSaveDishesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveDishesTable.Location = new System.Drawing.Point(6, 81);
            this.buttonSaveDishesTable.Name = "buttonSaveDishesTable";
            this.buttonSaveDishesTable.Size = new System.Drawing.Size(169, 29);
            this.buttonSaveDishesTable.TabIndex = 6;
            this.buttonSaveDishesTable.Text = "сохранить в word";
            this.buttonSaveDishesTable.UseVisualStyleBackColor = true;
            this.buttonSaveDishesTable.Click += new System.EventHandler(this.buttonSaveDishesTable_Click);
            // 
            // buttonDelDishes
            // 
            this.buttonDelDishes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelDishes.Enabled = false;
            this.buttonDelDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelDishes.Location = new System.Drawing.Point(374, 19);
            this.buttonDelDishes.Name = "buttonDelDishes";
            this.buttonDelDishes.Size = new System.Drawing.Size(137, 32);
            this.buttonDelDishes.TabIndex = 6;
            this.buttonDelDishes.Text = "удалить блюдо";
            this.buttonDelDishes.UseVisualStyleBackColor = true;
            this.buttonDelDishes.Click += new System.EventHandler(this.buttonDelDishes_Click);
            // 
            // buttonShowAccounts
            // 
            this.buttonShowAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowAccounts.BackColor = System.Drawing.Color.Lime;
            this.buttonShowAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAccounts.Location = new System.Drawing.Point(21, 480);
            this.buttonShowAccounts.Name = "buttonShowAccounts";
            this.buttonShowAccounts.Size = new System.Drawing.Size(173, 30);
            this.buttonShowAccounts.TabIndex = 9;
            this.buttonShowAccounts.Text = "учётная запись";
            this.buttonShowAccounts.UseVisualStyleBackColor = false;
            this.buttonShowAccounts.Click += new System.EventHandler(this.buttonShowAccounts_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(216, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Функционал";
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Image = global::Cafe.Properties.Resources.iconfinder_gtk_close_28414;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(528, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label doBacklabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDelWorkr;
        private System.Windows.Forms.Button buttonAddWorkr;
        private System.Windows.Forms.Button buttonShowWorkr;
        private System.Windows.Forms.Button buttonShowAccounts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDishesSearch;
        private System.Windows.Forms.ComboBox comboBoxDishesSearchBy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonPrintDishesTable;
        private System.Windows.Forms.Button buttonSendDishesTable;
        private System.Windows.Forms.Button buttonLoadDishes;
        private System.Windows.Forms.Button buttonAddDishes;
        private System.Windows.Forms.Button buttonSaveDishesTable;
        private System.Windows.Forms.Button buttonDelDishes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWorkrSearch;
        private System.Windows.Forms.ComboBox comboBoxWorkrSearchBy;
        private System.Windows.Forms.Button buttonPrintWorkrTable;
        private System.Windows.Forms.Button buttonSendWorkrTable;
        private System.Windows.Forms.Button buttonSaveWrkrTable;
        private System.Windows.Forms.Label labelDishesSearchError;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label labelErrorWorkrSearch;
        private System.Windows.Forms.Button buttonSales;
    }
}