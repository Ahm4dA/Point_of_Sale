namespace WindowsFormsApp1
{
    partial class manageStock
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
            this.edit_price_btn = new System.Windows.Forms.Button();
            this.add_stock_btn = new System.Windows.Forms.Button();
            this.remove_stock_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productID_Input = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.labelToChange = new System.Windows.Forms.Label();
            this.inputData = new System.Windows.Forms.TextBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edit_price_btn
            // 
            this.edit_price_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit_price_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_price_btn.Location = new System.Drawing.Point(410, 263);
            this.edit_price_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edit_price_btn.Name = "edit_price_btn";
            this.edit_price_btn.Size = new System.Drawing.Size(140, 45);
            this.edit_price_btn.TabIndex = 0;
            this.edit_price_btn.Text = "Edit Price";
            this.edit_price_btn.UseVisualStyleBackColor = true;
            this.edit_price_btn.Click += new System.EventHandler(this.edit_price_btn_Click);
            // 
            // add_stock_btn
            // 
            this.add_stock_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_stock_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_stock_btn.Location = new System.Drawing.Point(45, 263);
            this.add_stock_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_stock_btn.Name = "add_stock_btn";
            this.add_stock_btn.Size = new System.Drawing.Size(140, 45);
            this.add_stock_btn.TabIndex = 1;
            this.add_stock_btn.Text = "Add Stock";
            this.add_stock_btn.UseVisualStyleBackColor = true;
            this.add_stock_btn.Click += new System.EventHandler(this.add_stock_btn_Click);
            // 
            // remove_stock_btn
            // 
            this.remove_stock_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remove_stock_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_stock_btn.Location = new System.Drawing.Point(203, 263);
            this.remove_stock_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remove_stock_btn.Name = "remove_stock_btn";
            this.remove_stock_btn.Size = new System.Drawing.Size(182, 45);
            this.remove_stock_btn.TabIndex = 3;
            this.remove_stock_btn.Text = "Remove Stock";
            this.remove_stock_btn.UseVisualStyleBackColor = true;
            this.remove_stock_btn.Click += new System.EventHandler(this.remove_stock_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product ID";
            // 
            // productID_Input
            // 
            this.productID_Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productID_Input.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productID_Input.Location = new System.Drawing.Point(45, 84);
            this.productID_Input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productID_Input.Name = "productID_Input";
            this.productID_Input.Size = new System.Drawing.Size(183, 29);
            this.productID_Input.TabIndex = 5;
            // 
            // search_btn
            // 
            this.search_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.search_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(262, 74);
            this.search_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(128, 42);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(492, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // price_label
            // 
            this.price_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.price_label.Location = new System.Drawing.Point(301, 193);
            this.price_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(54, 22);
            this.price_label.TabIndex = 12;
            this.price_label.Text = "Price";
            // 
            // quantity_label
            // 
            this.quantity_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantity_label.AutoSize = true;
            this.quantity_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantity_label.Location = new System.Drawing.Point(492, 193);
            this.quantity_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(78, 22);
            this.quantity_label.TabIndex = 11;
            this.quantity_label.Text = "Quantity";
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name_label.Location = new System.Drawing.Point(52, 193);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(60, 22);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "Name";
            // 
            // labelToChange
            // 
            this.labelToChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelToChange.AutoSize = true;
            this.labelToChange.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToChange.Location = new System.Drawing.Point(40, 370);
            this.labelToChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(188, 26);
            this.labelToChange.TabIndex = 13;
            this.labelToChange.Text = "Enter New Price";
            // 
            // inputData
            // 
            this.inputData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputData.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputData.Location = new System.Drawing.Point(45, 410);
            this.inputData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(183, 29);
            this.inputData.TabIndex = 14;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(45, 465);
            this.confirm_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(128, 42);
            this.confirm_btn.TabIndex = 15;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // manageStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.productID_Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remove_stock_btn);
            this.Controls.Add(this.add_stock_btn);
            this.Controls.Add(this.edit_price_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "manageStock";
            this.Text = "Manage Stock";
            this.Load += new System.EventHandler(this.manageStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit_price_btn;
        private System.Windows.Forms.Button add_stock_btn;
        private System.Windows.Forms.Button remove_stock_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productID_Input;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label labelToChange;
        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.Button confirm_btn;
    }
}