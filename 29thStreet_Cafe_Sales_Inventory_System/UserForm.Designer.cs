namespace _29thStreet_Cafe_Sales_Inventory_System
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.userGV = new System.Windows.Forms.DataGridView();
            this.idcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fncol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lncol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uncol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnLBL = new System.Windows.Forms.Label();
            this.lnLBL = new System.Windows.Forms.Label();
            this.typeLBL = new System.Windows.Forms.Label();
            this.unLBL = new System.Windows.Forms.Label();
            this.pwLBL = new System.Windows.Forms.Label();
            this.fnTB = new System.Windows.Forms.TextBox();
            this.lnTB = new System.Windows.Forms.TextBox();
            this.unTB = new System.Windows.Forms.TextBox();
            this.pwTB = new System.Windows.Forms.TextBox();
            this.ownerRB = new System.Windows.Forms.RadioButton();
            this.staffRB = new System.Windows.Forms.RadioButton();
            this.addBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.newBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBTN = new System.Windows.Forms.Button();
            this.idTB = new System.Windows.Forms.TextBox();
            this.editBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // userGV
            // 
            this.userGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcol,
            this.fncol,
            this.lncol,
            this.typecol,
            this.uncol,
            this.pwcol});
            this.userGV.Location = new System.Drawing.Point(358, 61);
            this.userGV.Name = "userGV";
            this.userGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGV.Size = new System.Drawing.Size(913, 353);
            this.userGV.TabIndex = 0;
            this.userGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGV_CellContentClick);
            // 
            // idcol
            // 
            this.idcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idcol.HeaderText = "User ID";
            this.idcol.Name = "idcol";
            // 
            // fncol
            // 
            this.fncol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fncol.HeaderText = "Firstname";
            this.fncol.Name = "fncol";
            // 
            // lncol
            // 
            this.lncol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lncol.HeaderText = "Lastname";
            this.lncol.Name = "lncol";
            // 
            // typecol
            // 
            this.typecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typecol.HeaderText = "Type";
            this.typecol.Name = "typecol";
            // 
            // uncol
            // 
            this.uncol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uncol.HeaderText = "Username";
            this.uncol.Name = "uncol";
            // 
            // pwcol
            // 
            this.pwcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pwcol.HeaderText = "Password";
            this.pwcol.Name = "pwcol";
            // 
            // fnLBL
            // 
            this.fnLBL.AutoSize = true;
            this.fnLBL.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnLBL.ForeColor = System.Drawing.Color.White;
            this.fnLBL.Image = ((System.Drawing.Image)(resources.GetObject("fnLBL.Image")));
            this.fnLBL.Location = new System.Drawing.Point(36, 116);
            this.fnLBL.Name = "fnLBL";
            this.fnLBL.Size = new System.Drawing.Size(103, 27);
            this.fnLBL.TabIndex = 1;
            this.fnLBL.Text = "Firstname";
            // 
            // lnLBL
            // 
            this.lnLBL.AutoSize = true;
            this.lnLBL.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnLBL.ForeColor = System.Drawing.Color.White;
            this.lnLBL.Image = ((System.Drawing.Image)(resources.GetObject("lnLBL.Image")));
            this.lnLBL.Location = new System.Drawing.Point(35, 163);
            this.lnLBL.Name = "lnLBL";
            this.lnLBL.Size = new System.Drawing.Size(98, 27);
            this.lnLBL.TabIndex = 2;
            this.lnLBL.Text = "Lastname";
            // 
            // typeLBL
            // 
            this.typeLBL.AutoSize = true;
            this.typeLBL.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLBL.ForeColor = System.Drawing.Color.White;
            this.typeLBL.Image = ((System.Drawing.Image)(resources.GetObject("typeLBL.Image")));
            this.typeLBL.Location = new System.Drawing.Point(35, 211);
            this.typeLBL.Name = "typeLBL";
            this.typeLBL.Size = new System.Drawing.Size(57, 27);
            this.typeLBL.TabIndex = 3;
            this.typeLBL.Text = "Type";
            // 
            // unLBL
            // 
            this.unLBL.AutoSize = true;
            this.unLBL.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unLBL.ForeColor = System.Drawing.Color.White;
            this.unLBL.Image = ((System.Drawing.Image)(resources.GetObject("unLBL.Image")));
            this.unLBL.Location = new System.Drawing.Point(36, 276);
            this.unLBL.Name = "unLBL";
            this.unLBL.Size = new System.Drawing.Size(102, 27);
            this.unLBL.TabIndex = 4;
            this.unLBL.Text = "Username";
            // 
            // pwLBL
            // 
            this.pwLBL.AutoSize = true;
            this.pwLBL.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLBL.ForeColor = System.Drawing.Color.White;
            this.pwLBL.Image = ((System.Drawing.Image)(resources.GetObject("pwLBL.Image")));
            this.pwLBL.Location = new System.Drawing.Point(37, 323);
            this.pwLBL.Name = "pwLBL";
            this.pwLBL.Size = new System.Drawing.Size(94, 27);
            this.pwLBL.TabIndex = 5;
            this.pwLBL.Text = "Password";
            // 
            // fnTB
            // 
            this.fnTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnTB.ForeColor = System.Drawing.Color.DarkRed;
            this.fnTB.Location = new System.Drawing.Point(202, 115);
            this.fnTB.Name = "fnTB";
            this.fnTB.Size = new System.Drawing.Size(141, 27);
            this.fnTB.TabIndex = 6;
            // 
            // lnTB
            // 
            this.lnTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnTB.ForeColor = System.Drawing.Color.DarkRed;
            this.lnTB.Location = new System.Drawing.Point(202, 162);
            this.lnTB.Name = "lnTB";
            this.lnTB.Size = new System.Drawing.Size(141, 27);
            this.lnTB.TabIndex = 7;
            // 
            // unTB
            // 
            this.unTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unTB.ForeColor = System.Drawing.Color.DarkRed;
            this.unTB.Location = new System.Drawing.Point(202, 275);
            this.unTB.Name = "unTB";
            this.unTB.Size = new System.Drawing.Size(141, 27);
            this.unTB.TabIndex = 8;
            // 
            // pwTB
            // 
            this.pwTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwTB.ForeColor = System.Drawing.Color.DarkRed;
            this.pwTB.Location = new System.Drawing.Point(202, 322);
            this.pwTB.Name = "pwTB";
            this.pwTB.Size = new System.Drawing.Size(141, 27);
            this.pwTB.TabIndex = 9;
            // 
            // ownerRB
            // 
            this.ownerRB.AutoSize = true;
            this.ownerRB.BackColor = System.Drawing.Color.Transparent;
            this.ownerRB.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerRB.ForeColor = System.Drawing.Color.White;
            this.ownerRB.Location = new System.Drawing.Point(202, 208);
            this.ownerRB.Name = "ownerRB";
            this.ownerRB.Size = new System.Drawing.Size(92, 26);
            this.ownerRB.TabIndex = 10;
            this.ownerRB.Text = "Owner";
            this.ownerRB.UseVisualStyleBackColor = false;
            // 
            // staffRB
            // 
            this.staffRB.AutoSize = true;
            this.staffRB.BackColor = System.Drawing.Color.Transparent;
            this.staffRB.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffRB.ForeColor = System.Drawing.Color.White;
            this.staffRB.Location = new System.Drawing.Point(202, 238);
            this.staffRB.Name = "staffRB";
            this.staffRB.Size = new System.Drawing.Size(68, 26);
            this.staffRB.TabIndex = 11;
            this.staffRB.Text = "Staff";
            this.staffRB.UseVisualStyleBackColor = false;
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.LimeGreen;
            this.addBTN.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.ForeColor = System.Drawing.Color.Black;
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.Location = new System.Drawing.Point(27, 513);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(116, 50);
            this.addBTN.TabIndex = 12;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.Red;
            this.deleteBTN.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.ForeColor = System.Drawing.Color.Black;
            this.deleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.Image")));
            this.deleteBTN.Location = new System.Drawing.Point(141, 513);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(116, 50);
            this.deleteBTN.TabIndex = 13;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::_29thStreet_Cafe_Sales_Inventory_System.Properties.Resources.or;
            this.groupBox1.Controls.Add(this.searchTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.saveBTN);
            this.groupBox1.Controls.Add(this.newBTN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clearBTN);
            this.groupBox1.Controls.Add(this.idTB);
            this.groupBox1.Controls.Add(this.userGV);
            this.groupBox1.Controls.Add(this.fnTB);
            this.groupBox1.Controls.Add(this.fnLBL);
            this.groupBox1.Controls.Add(this.staffRB);
            this.groupBox1.Controls.Add(this.lnLBL);
            this.groupBox1.Controls.Add(this.ownerRB);
            this.groupBox1.Controls.Add(this.typeLBL);
            this.groupBox1.Controls.Add(this.pwTB);
            this.groupBox1.Controls.Add(this.unLBL);
            this.groupBox1.Controls.Add(this.unTB);
            this.groupBox1.Controls.Add(this.pwLBL);
            this.groupBox1.Controls.Add(this.lnTB);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(29, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1290, 432);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Entry";
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(608, 25);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(150, 30);
            this.searchTB.TabIndex = 23;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(358, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 27);
            this.label3.TabIndex = 22;
            this.label3.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "User ID",
            "Lastname",
            "Firstname",
            "Username",
            "Type",
            "Password"});
            this.comboBox1.Location = new System.Drawing.Point(442, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 31);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Lastname";
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.Yellow;
            this.saveBTN.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.ForeColor = System.Drawing.Color.Black;
            this.saveBTN.Image = ((System.Drawing.Image)(resources.GetObject("saveBTN.Image")));
            this.saveBTN.Location = new System.Drawing.Point(227, 369);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(89, 37);
            this.saveBTN.TabIndex = 20;
            this.saveBTN.Text = "SAVE";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // newBTN
            // 
            this.newBTN.BackColor = System.Drawing.Color.Yellow;
            this.newBTN.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBTN.ForeColor = System.Drawing.Color.Black;
            this.newBTN.Image = ((System.Drawing.Image)(resources.GetObject("newBTN.Image")));
            this.newBTN.Location = new System.Drawing.Point(140, 369);
            this.newBTN.Name = "newBTN";
            this.newBTN.Size = new System.Drawing.Size(89, 37);
            this.newBTN.TabIndex = 19;
            this.newBTN.Text = "NEW";
            this.newBTN.UseVisualStyleBackColor = false;
            this.newBTN.Click += new System.EventHandler(this.newBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(36, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Selected >>";
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.Yellow;
            this.clearBTN.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Image = ((System.Drawing.Image)(resources.GetObject("clearBTN.Image")));
            this.clearBTN.Location = new System.Drawing.Point(53, 369);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(89, 37);
            this.clearBTN.TabIndex = 16;
            this.clearBTN.Text = "CLEAR";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // idTB
            // 
            this.idTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTB.ForeColor = System.Drawing.Color.DarkRed;
            this.idTB.Location = new System.Drawing.Point(202, 60);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(61, 27);
            this.idTB.TabIndex = 1;
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.editBTN.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBTN.ForeColor = System.Drawing.Color.Black;
            this.editBTN.Image = ((System.Drawing.Image)(resources.GetObject("editBTN.Image")));
            this.editBTN.Location = new System.Drawing.Point(255, 513);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(116, 50);
            this.editBTN.TabIndex = 17;
            this.editBTN.Text = "EDIT";
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label2.Image = global::_29thStreet_Cafe_Sales_Inventory_System.Properties.Resources.or;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 45);
            this.label2.TabIndex = 18;
            this.label2.Text = " USERS LIST";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1321, 618);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserForm";
            this.Text = "USERS RECORD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userGV;
        private System.Windows.Forms.Label fnLBL;
        private System.Windows.Forms.Label lnLBL;
        private System.Windows.Forms.Label typeLBL;
        private System.Windows.Forms.Label unLBL;
        private System.Windows.Forms.Label pwLBL;
        private System.Windows.Forms.TextBox fnTB;
        private System.Windows.Forms.TextBox lnTB;
        private System.Windows.Forms.TextBox unTB;
        private System.Windows.Forms.TextBox pwTB;
        private System.Windows.Forms.RadioButton ownerRB;
        private System.Windows.Forms.RadioButton staffRB;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn fncol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lncol;
        private System.Windows.Forms.DataGridViewTextBoxColumn typecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn uncol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwcol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button newBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}