namespace WindowsFormsApp1
{
    partial class loginPage
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
            this.unLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.unInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unLabel
            // 
            this.unLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unLabel.AutoSize = true;
            this.unLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unLabel.Location = new System.Drawing.Point(420, 255);
            this.unLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(103, 22);
            this.unLabel.TabIndex = 0;
            this.unLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(420, 298);
            this.passLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(100, 22);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password";
            // 
            // unInput
            // 
            this.unInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.unInput.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unInput.Location = new System.Drawing.Point(558, 259);
            this.unInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.unInput.Name = "unInput";
            this.unInput.Size = new System.Drawing.Size(156, 23);
            this.unInput.TabIndex = 2;
            // 
            // passInput
            // 
            this.passInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passInput.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.Location = new System.Drawing.Point(558, 298);
            this.passInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passInput.Name = "passInput";
            this.passInput.PasswordChar = '*';
            this.passInput.Size = new System.Drawing.Size(156, 23);
            this.passInput.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(571, 344);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(128, 37);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.unInput);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.unLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loginPage";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox unInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Button loginButton;
    }
}

