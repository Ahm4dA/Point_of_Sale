namespace WindowsFormsApp1
{
    partial class payPage
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
            this.price_total_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.change_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // price_total_label
            // 
            this.price_total_label.AutoSize = true;
            this.price_total_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_total_label.Location = new System.Drawing.Point(246, 70);
            this.price_total_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price_total_label.Name = "price_total_label";
            this.price_total_label.Size = new System.Drawing.Size(94, 32);
            this.price_total_label.TabIndex = 1;
            this.price_total_label.Text = "heheh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount";
            // 
            // amountInput
            // 
            this.amountInput.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInput.Location = new System.Drawing.Point(250, 131);
            this.amountInput.Margin = new System.Windows.Forms.Padding(2);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(192, 38);
            this.amountInput.TabIndex = 3;
            this.amountInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amountInput_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Change";
            // 
            // change_label
            // 
            this.change_label.AutoSize = true;
            this.change_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_label.Location = new System.Drawing.Point(246, 198);
            this.change_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.change_label.Name = "change_label";
            this.change_label.Size = new System.Drawing.Size(94, 32);
            this.change_label.TabIndex = 5;
            this.change_label.Text = "heheh";
            this.change_label.Click += new System.EventHandler(this.change_label_Click);
            // 
            // payPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.change_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price_total_label);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "payPage";
            this.Text = "Confirm Pay";
            this.Load += new System.EventHandler(this.payPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label price_total_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label change_label;
    }
}