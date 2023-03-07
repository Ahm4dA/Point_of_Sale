namespace WindowsFormsApp1
{
    partial class mainPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_employee_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.view_stock_btn = new System.Windows.Forms.Button();
            this.handle_stock_btn = new System.Windows.Forms.Button();
            this.add_new_product_btn = new System.Windows.Forms.Button();
            this.change_pass_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Input = new System.Windows.Forms.TextBox();
            this.pay_btn = new System.Windows.Forms.Button();
            this.clear_bill_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.total_label = new System.Windows.Forms.Label();
            this.receiptssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiptssBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptssBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptssBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // add_employee_btn
            // 
            this.add_employee_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_employee_btn.Location = new System.Drawing.Point(1096, 130);
            this.add_employee_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_employee_btn.Name = "add_employee_btn";
            this.add_employee_btn.Size = new System.Drawing.Size(135, 51);
            this.add_employee_btn.TabIndex = 2;
            this.add_employee_btn.Text = "Add Employee";
            this.add_employee_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_employee_btn.UseVisualStyleBackColor = true;
            this.add_employee_btn.Click += new System.EventHandler(this.add_employee_btn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(1163, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_stock_btn
            // 
            this.view_stock_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_stock_btn.Location = new System.Drawing.Point(1096, 366);
            this.view_stock_btn.Margin = new System.Windows.Forms.Padding(2);
            this.view_stock_btn.Name = "view_stock_btn";
            this.view_stock_btn.Size = new System.Drawing.Size(135, 51);
            this.view_stock_btn.TabIndex = 5;
            this.view_stock_btn.Text = "View Stock";
            this.view_stock_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.view_stock_btn.UseVisualStyleBackColor = true;
            this.view_stock_btn.Click += new System.EventHandler(this.view_stock_btn_Click);
            // 
            // handle_stock_btn
            // 
            this.handle_stock_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handle_stock_btn.Location = new System.Drawing.Point(1096, 286);
            this.handle_stock_btn.Margin = new System.Windows.Forms.Padding(2);
            this.handle_stock_btn.Name = "handle_stock_btn";
            this.handle_stock_btn.Size = new System.Drawing.Size(135, 51);
            this.handle_stock_btn.TabIndex = 4;
            this.handle_stock_btn.Text = "Manage Stock";
            this.handle_stock_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.handle_stock_btn.UseVisualStyleBackColor = true;
            this.handle_stock_btn.Click += new System.EventHandler(this.handle_stock_btn_Click);
            // 
            // add_new_product_btn
            // 
            this.add_new_product_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_product_btn.Location = new System.Drawing.Point(1096, 445);
            this.add_new_product_btn.Margin = new System.Windows.Forms.Padding(2);
            this.add_new_product_btn.Name = "add_new_product_btn";
            this.add_new_product_btn.Size = new System.Drawing.Size(135, 51);
            this.add_new_product_btn.TabIndex = 6;
            this.add_new_product_btn.Text = "Add New Product";
            this.add_new_product_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_new_product_btn.UseVisualStyleBackColor = true;
            this.add_new_product_btn.Click += new System.EventHandler(this.add_new_product_btn_Click);
            // 
            // change_pass_btn
            // 
            this.change_pass_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_pass_btn.Location = new System.Drawing.Point(1096, 211);
            this.change_pass_btn.Margin = new System.Windows.Forms.Padding(2);
            this.change_pass_btn.Name = "change_pass_btn";
            this.change_pass_btn.Size = new System.Drawing.Size(135, 51);
            this.change_pass_btn.TabIndex = 3;
            this.change_pass_btn.Text = "Change Password";
            this.change_pass_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.change_pass_btn.UseVisualStyleBackColor = true;
            this.change_pass_btn.Click += new System.EventHandler(this.change_pass_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNumber,
            this.productID,
            this.productName,
            this.productQuantity,
            this.productPrice,
            this.discount,
            this.totalPrice});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 15F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(9, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 450);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_KeyDown);
            // 
            // serialNumber
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.serialNumber.HeaderText = "Sr. No.";
            this.serialNumber.MinimumWidth = 6;
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Width = 40;
            // 
            // productID
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID.DefaultCellStyle = dataGridViewCellStyle2;
            this.productID.HeaderText = "ID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.Width = 125;
            // 
            // productName
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.DefaultCellStyle = dataGridViewCellStyle3;
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 180;
            // 
            // productQuantity
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.MinimumWidth = 6;
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Width = 65;
            // 
            // productPrice
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            this.productPrice.Width = 125;
            // 
            // discount
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.DefaultCellStyle = dataGridViewCellStyle6;
            this.discount.HeaderText = "Discount";
            this.discount.MinimumWidth = 6;
            this.discount.Name = "discount";
            this.discount.Width = 125;
            // 
            // totalPrice
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.totalPrice.HeaderText = "Total";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Width = 125;
            // 
            // ID_Input
            // 
            this.ID_Input.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Input.Location = new System.Drawing.Point(23, 18);
            this.ID_Input.Margin = new System.Windows.Forms.Padding(2);
            this.ID_Input.Name = "ID_Input";
            this.ID_Input.Size = new System.Drawing.Size(163, 26);
            this.ID_Input.TabIndex = 0;
            this.ID_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ID_Input_KeyDown);
            // 
            // pay_btn
            // 
            this.pay_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_btn.Location = new System.Drawing.Point(266, 598);
            this.pay_btn.Margin = new System.Windows.Forms.Padding(2);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(110, 49);
            this.pay_btn.TabIndex = 8;
            this.pay_btn.Text = "PAY";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // clear_bill_btn
            // 
            this.clear_bill_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_bill_btn.Location = new System.Drawing.Point(266, 536);
            this.clear_bill_btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_bill_btn.Name = "clear_bill_btn";
            this.clear_bill_btn.Size = new System.Drawing.Size(110, 49);
            this.clear_bill_btn.TabIndex = 9;
            this.clear_bill_btn.Text = "Clear Bill";
            this.clear_bill_btn.UseVisualStyleBackColor = true;
            this.clear_bill_btn.Click += new System.EventHandler(this.clear_bill_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total";
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(747, 561);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(0, 24);
            this.total_label.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1096, 524);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 51);
            this.button2.TabIndex = 15;
            this.button2.Text = "View Transactions";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1147, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "F1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1147, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "F2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1147, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "F3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1147, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "F4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1147, 472);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "F6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1147, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "F7";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear_bill_btn);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.ID_Input);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.change_pass_btn);
            this.Controls.Add(this.add_new_product_btn);
            this.Controls.Add(this.handle_stock_btn);
            this.Controls.Add(this.view_stock_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_employee_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainPage";
            this.Text = "POS Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptssBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_employee_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button view_stock_btn;
        private System.Windows.Forms.Button handle_stock_btn;
        private System.Windows.Forms.Button add_new_product_btn;
        private System.Windows.Forms.Button change_pass_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ID_Input;
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Button clear_bill_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private System.Windows.Forms.BindingSource receiptssBindingSource;
        private System.Windows.Forms.BindingSource receiptssBindingSource1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}