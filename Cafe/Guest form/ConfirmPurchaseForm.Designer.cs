
namespace Cafe.Guest_form
{
    partial class ConfirmPurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPurchaseForm));
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMakePurhcase = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxChsnDishes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPrintDishesTable = new System.Windows.Forms.Button();
            this.buttonSendDishesTable = new System.Windows.Forms.Button();
            this.buttonSaveDishesTable = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm purchase";
            // 
            // buttonMakePurhcase
            // 
            this.buttonMakePurhcase.BackColor = System.Drawing.Color.Lime;
            this.buttonMakePurhcase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMakePurhcase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMakePurhcase.Location = new System.Drawing.Point(226, 158);
            this.buttonMakePurhcase.Name = "buttonMakePurhcase";
            this.buttonMakePurhcase.Size = new System.Drawing.Size(151, 32);
            this.buttonMakePurhcase.TabIndex = 0;
            this.buttonMakePurhcase.Text = "Оплатить";
            this.buttonMakePurhcase.UseVisualStyleBackColor = false;
            this.buttonMakePurhcase.Click += new System.EventHandler(this.buttonMakePurhcase_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxChsnDishes);
            this.groupBox3.Controls.Add(this.buttonMakePurhcase);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 196);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Итого к оплате";
            // 
            // textBoxChsnDishes
            // 
            this.textBoxChsnDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxChsnDishes.Location = new System.Drawing.Point(6, 21);
            this.textBoxChsnDishes.Multiline = true;
            this.textBoxChsnDishes.Name = "textBoxChsnDishes";
            this.textBoxChsnDishes.ReadOnly = true;
            this.textBoxChsnDishes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChsnDishes.Size = new System.Drawing.Size(371, 131);
            this.textBoxChsnDishes.TabIndex = 14;
            this.textBoxChsnDishes.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPrintDishesTable);
            this.groupBox1.Controls.Add(this.buttonSendDishesTable);
            this.groupBox1.Controls.Add(this.buttonSaveDishesTable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ получения чека";
            // 
            // buttonPrintDishesTable
            // 
            this.buttonPrintDishesTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrintDishesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrintDishesTable.Location = new System.Drawing.Point(6, 89);
            this.buttonPrintDishesTable.Name = "buttonPrintDishesTable";
            this.buttonPrintDishesTable.Size = new System.Drawing.Size(69, 25);
            this.buttonPrintDishesTable.TabIndex = 3;
            this.buttonPrintDishesTable.Text = "печать";
            this.buttonPrintDishesTable.UseVisualStyleBackColor = true;
            this.buttonPrintDishesTable.Click += new System.EventHandler(this.buttonPrintDishesTable_Click);
            // 
            // buttonSendDishesTable
            // 
            this.buttonSendDishesTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendDishesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendDishesTable.Location = new System.Drawing.Point(6, 56);
            this.buttonSendDishesTable.Name = "buttonSendDishesTable";
            this.buttonSendDishesTable.Size = new System.Drawing.Size(169, 27);
            this.buttonSendDishesTable.TabIndex = 2;
            this.buttonSendDishesTable.Text = "отправить на email";
            this.buttonSendDishesTable.UseVisualStyleBackColor = true;
            this.buttonSendDishesTable.Click += new System.EventHandler(this.buttonSendDishesTable_Click);
            // 
            // buttonSaveDishesTable
            // 
            this.buttonSaveDishesTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDishesTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveDishesTable.Location = new System.Drawing.Point(6, 21);
            this.buttonSaveDishesTable.Name = "buttonSaveDishesTable";
            this.buttonSaveDishesTable.Size = new System.Drawing.Size(169, 29);
            this.buttonSaveDishesTable.TabIndex = 1;
            this.buttonSaveDishesTable.Text = "сохранить в файл";
            this.buttonSaveDishesTable.UseVisualStyleBackColor = true;
            this.buttonSaveDishesTable.Click += new System.EventHandler(this.buttonSaveDishesTable_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
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
            // ConfirmPurchaseForm
            // 
            this.AcceptButton = this.buttonMakePurhcase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(407, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfirmPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ConfirmPurchaseForm";
            this.Load += new System.EventHandler(this.ConfirmPurchaseForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMakePurhcase;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxChsnDishes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonPrintDishesTable;
        private System.Windows.Forms.Button buttonSendDishesTable;
        private System.Windows.Forms.Button buttonSaveDishesTable;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}