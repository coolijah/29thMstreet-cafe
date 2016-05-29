namespace _29thStreet_Cafe_Sales_Inventory_System
{
    partial class LoginForm
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
            this.unTB = new System.Windows.Forms.TextBox();
            this.pwTB = new System.Windows.Forms.TextBox();
            this.clearBTN = new System.Windows.Forms.Button();
            this.loginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unTB
            // 
            this.unTB.Location = new System.Drawing.Point(223, 59);
            this.unTB.Name = "unTB";
            this.unTB.Size = new System.Drawing.Size(100, 20);
            this.unTB.TabIndex = 0;
            // 
            // pwTB
            // 
            this.pwTB.Location = new System.Drawing.Point(223, 107);
            this.pwTB.Name = "pwTB";
            this.pwTB.Size = new System.Drawing.Size(100, 20);
            this.pwTB.TabIndex = 1;
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(105, 187);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(75, 23);
            this.clearBTN.TabIndex = 2;
            this.clearBTN.Text = "CLEAR";
            this.clearBTN.UseVisualStyleBackColor = true;
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(216, 187);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(75, 23);
            this.loginBTN.TabIndex = 3;
            this.loginBTN.Text = "LOG IN";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.pwTB);
            this.Controls.Add(this.unTB);
            this.Name = "LoginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox unTB;
        private System.Windows.Forms.TextBox pwTB;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}