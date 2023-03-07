namespace WindowsFormsApp1
{
    partial class addNewItemPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.productID_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.price_input = new System.Windows.Forms.TextBox();
            this.quantity_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // confirm_btn
            // 
            this.confirm_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(191, 206);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(175, 57);
            this.confirm_btn.TabIndex = 1;
            this.confirm_btn.Text = "ADD ITEM";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // productID_input
            // 
            this.productID_input.Font = new System.Drawing.Font("Arial", 13.8F);
            this.productID_input.Location = new System.Drawing.Point(41, 59);
            this.productID_input.Name = "productID_input";
            this.productID_input.Size = new System.Drawing.Size(198, 34);
            this.productID_input.TabIndex = 2;
            this.productID_input.TextChanged += new System.EventHandler(this.productID_input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity";
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("Arial", 13.8F);
            this.name_input.Location = new System.Drawing.Point(41, 155);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(198, 34);
            this.name_input.TabIndex = 6;
            // 
            // price_input
            // 
            this.price_input.Font = new System.Drawing.Font("Arial", 13.8F);
            this.price_input.Location = new System.Drawing.Point(332, 59);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(198, 34);
            this.price_input.TabIndex = 7;
            // 
            // quantity_input
            // 
            this.quantity_input.Font = new System.Drawing.Font("Arial", 13.8F);
            this.quantity_input.Location = new System.Drawing.Point(332, 155);
            this.quantity_input.Name = "quantity_input";
            this.quantity_input.Size = new System.Drawing.Size(198, 34);
            this.quantity_input.TabIndex = 8;
            // 
            // addNewItemPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 283);
            this.Controls.Add(this.quantity_input);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productID_input);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.label1);
            this.Name = "addNewItemPage";
            this.Text = "addNewItemPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.TextBox productID_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.TextBox quantity_input;
    }
}