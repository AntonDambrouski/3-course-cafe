
namespace Cafe
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doBacklabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDishesSearchError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDishesSearch = new System.Windows.Forms.TextBox();
            this.comboBoxDishesSearchBy = new System.Windows.Forms.ComboBox();
            this.buttonShowBasket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.buttonMakePurchase = new System.Windows.Forms.Button();
            this.buttonRemoveFromBasket = new System.Windows.Forms.Button();
            this.buttonAddToBasket = new System.Windows.Forms.Button();
            this.buttonShowDishes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.doBacklabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 640);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 526);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(80, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "График работы кафе: пн - пт (8:00-24:00); сб - вс (8:00-21:00)";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.label1.Font = new System.Drawing.Font("Mistral", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(80, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в наше кафe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.doBacklabel.TabIndex = 7;
            this.doBacklabel.Click += new System.EventHandler(this.doBacklabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.buttonShowBasket);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.buttonMakePurchase);
            this.panel1.Controls.Add(this.buttonRemoveFromBasket);
            this.panel1.Controls.Add(this.buttonAddToBasket);
            this.panel1.Controls.Add(this.buttonShowDishes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(780, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 640);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDishesSearchError);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxDishesSearch);
            this.groupBox3.Controls.Add(this.comboBoxDishesSearchBy);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(120, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 108);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск блюда";
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
            this.textBoxDishesSearch.TabIndex = 2;
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
            this.comboBoxDishesSearchBy.TabIndex = 1;
            // 
            // buttonShowBasket
            // 
            this.buttonShowBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowBasket.Location = new System.Drawing.Point(89, 222);
            this.buttonShowBasket.Name = "buttonShowBasket";
            this.buttonShowBasket.Size = new System.Drawing.Size(185, 42);
            this.buttonShowBasket.TabIndex = 3;
            this.buttonShowBasket.Text = "показать корзину";
            this.buttonShowBasket.UseVisualStyleBackColor = true;
            this.buttonShowBasket.Click += new System.EventHandler(this.buttonShowBasket_Click);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Image = global::Cafe.Properties.Resources.iconfinder_gtk_close_28414;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(352, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 30);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Image = global::Cafe.Properties.Resources.iconfinder_gtk_close_28414;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Location = new System.Drawing.Point(737, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // buttonMakePurchase
            // 
            this.buttonMakePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMakePurchase.Enabled = false;
            this.buttonMakePurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakePurchase.Location = new System.Drawing.Point(89, 366);
            this.buttonMakePurchase.Name = "buttonMakePurchase";
            this.buttonMakePurchase.Size = new System.Drawing.Size(185, 42);
            this.buttonMakePurchase.TabIndex = 6;
            this.buttonMakePurchase.Text = "заказать";
            this.buttonMakePurchase.UseVisualStyleBackColor = true;
            this.buttonMakePurchase.Click += new System.EventHandler(this.buttonMakePurchase_Click);
            // 
            // buttonRemoveFromBasket
            // 
            this.buttonRemoveFromBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveFromBasket.Enabled = false;
            this.buttonRemoveFromBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveFromBasket.Location = new System.Drawing.Point(89, 318);
            this.buttonRemoveFromBasket.Name = "buttonRemoveFromBasket";
            this.buttonRemoveFromBasket.Size = new System.Drawing.Size(185, 42);
            this.buttonRemoveFromBasket.TabIndex = 5;
            this.buttonRemoveFromBasket.Text = "убрать из корзины";
            this.buttonRemoveFromBasket.UseVisualStyleBackColor = true;
            this.buttonRemoveFromBasket.Click += new System.EventHandler(this.buttonRemoveFromBasket_Click);
            // 
            // buttonAddToBasket
            // 
            this.buttonAddToBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddToBasket.Enabled = false;
            this.buttonAddToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToBasket.Location = new System.Drawing.Point(89, 270);
            this.buttonAddToBasket.Name = "buttonAddToBasket";
            this.buttonAddToBasket.Size = new System.Drawing.Size(185, 42);
            this.buttonAddToBasket.TabIndex = 4;
            this.buttonAddToBasket.Text = "добавить в корзину";
            this.buttonAddToBasket.UseVisualStyleBackColor = true;
            this.buttonAddToBasket.Click += new System.EventHandler(this.buttonAddToBasket_Click);
            // 
            // buttonShowDishes
            // 
            this.buttonShowDishes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowDishes.Location = new System.Drawing.Point(120, 42);
            this.buttonShowDishes.Name = "buttonShowDishes";
            this.buttonShowDishes.Size = new System.Drawing.Size(154, 42);
            this.buttonShowDishes.TabIndex = 0;
            this.buttonShowDishes.Text = "просмотр блюд";
            this.buttonShowDishes.UseVisualStyleBackColor = true;
            this.buttonShowDishes.Click += new System.EventHandler(this.buttonShowDishes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Cafe.Properties.Resources.iconfinder_shopping_cart_2561279__2_;
            this.pictureBox1.Location = new System.Drawing.Point(14, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::Cafe.Properties.Resources.iconfinder_Food_bag_6457554__1_;
            this.pictureBox2.Location = new System.Drawing.Point(8, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label doBacklabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShowDishes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMakePurchase;
        private System.Windows.Forms.Button buttonRemoveFromBasket;
        private System.Windows.Forms.Button buttonAddToBasket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonShowBasket;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDishesSearchError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDishesSearch;
        private System.Windows.Forms.ComboBox comboBoxDishesSearchBy;
    }
}