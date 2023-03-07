namespace WindowsFormsApp1
{
    partial class addEmployeePage
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
            this.unInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.admin_radio_btn = new System.Windows.Forms.RadioButton();
            this.employee_radio_btn = new System.Windows.Forms.RadioButton();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // unInput
            // 
            this.unInput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unInput.Location = new System.Drawing.Point(414, 176);
            this.unInput.Name = "unInput";
            this.unInput.Size = new System.Drawing.Size(224, 30);
            this.unInput.TabIndex = 1;
            // 
            // passInput
            // 
            this.passInput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.Location = new System.Drawing.Point(416, 226);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(224, 30);
            this.passInput.TabIndex = 3;
            this.passInput.TextChanged += new System.EventHandler(this.passInput_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Type";
            // 
            // admin_radio_btn
            // 
            this.admin_radio_btn.AutoSize = true;
            this.admin_radio_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_radio_btn.Location = new System.Drawing.Point(543, 279);
            this.admin_radio_btn.Name = "admin_radio_btn";
            this.admin_radio_btn.Size = new System.Drawing.Size(80, 28);
            this.admin_radio_btn.TabIndex = 6;
            this.admin_radio_btn.TabStop = true;
            this.admin_radio_btn.Text = "Admin";
            this.admin_radio_btn.UseVisualStyleBackColor = true;
            this.admin_radio_btn.CheckedChanged += new System.EventHandler(this.admin_radio_btn_CheckedChanged);
            // 
            // employee_radio_btn
            // 
            this.employee_radio_btn.AutoSize = true;
            this.employee_radio_btn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_radio_btn.Location = new System.Drawing.Point(414, 279);
            this.employee_radio_btn.Name = "employee_radio_btn";
            this.employee_radio_btn.Size = new System.Drawing.Size(107, 28);
            this.employee_radio_btn.TabIndex = 4;
            this.employee_radio_btn.TabStop = true;
            this.employee_radio_btn.Text = "Employee";
            this.employee_radio_btn.UseVisualStyleBackColor = true;
            this.employee_radio_btn.CheckedChanged += new System.EventHandler(this.employee_radio_btn_CheckedChanged);
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(343, 329);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(125, 59);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // addEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.admin_radio_btn);
            this.Controls.Add(this.employee_radio_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unInput);
            this.Controls.Add(this.label1);
            this.Name = "addEmployeePage";
            this.Text = "Add Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton admin_radio_btn;
        private System.Windows.Forms.RadioButton employee_radio_btn;
        private System.Windows.Forms.Button add_btn;
    }
}