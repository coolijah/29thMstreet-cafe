namespace _29thStreet_Cafe_Sales_Inventory_System
{
    partial class IngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.newBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.unitTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idTF = new System.Windows.Forms.TextBox();
            this.snTB = new System.Windows.Forms.TextBox();
            this.ohTB = new System.Windows.Forms.TextBox();
            this.rpTB = new System.Windows.Forms.TextBox();
            this.inTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ingrGV = new System.Windows.Forms.DataGridView();
            this.idcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reordcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ohcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sncol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.editBTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingrGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::_29thStreet_Cafe_Sales_Inventory_System.Properties.Resources.or;
            this.groupBox1.Controls.Add(this.saveBTN);
            this.groupBox1.Controls.Add(this.newBTN);
            this.groupBox1.Controls.Add(this.clearBTN);
            this.groupBox1.Controls.Add(this.unitTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.idTF);
            this.groupBox1.Controls.Add(this.snTB);
            this.groupBox1.Controls.Add(this.ohTB);
            this.groupBox1.Controls.Add(this.rpTB);
            this.groupBox1.Controls.Add(this.inTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ingrGV);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(35, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1266, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredient Entry";
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.Yellow;
            this.saveBTN.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.ForeColor = System.Drawing.Color.Black;
            this.saveBTN.Image = ((System.Drawing.Image)(resources.GetObject("saveBTN.Image")));
            this.saveBTN.Location = new System.Drawing.Point(227, 305);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(89, 37);
            this.saveBTN.TabIndex = 23;
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
            this.newBTN.Location = new System.Drawing.Point(140, 305);
            this.newBTN.Name = "newBTN";
            this.newBTN.Size = new System.Drawing.Size(89, 37);
            this.newBTN.TabIndex = 22;
            this.newBTN.Text = "NEW";
            this.newBTN.UseVisualStyleBackColor = false;
            this.newBTN.Click += new System.EventHandler(this.newBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.Yellow;
            this.clearBTN.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBTN.ForeColor = System.Drawing.Color.Black;
            this.clearBTN.Image = ((System.Drawing.Image)(resources.GetObject("clearBTN.Image")));
            this.clearBTN.Location = new System.Drawing.Point(53, 305);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(89, 37);
            this.clearBTN.TabIndex = 21;
            this.clearBTN.Text = "CLEAR";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click_1);
            // 
            // unitTB
            // 
            this.unitTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitTB.Location = new System.Drawing.Point(215, 222);
            this.unitTB.Name = "unitTB";
            this.unitTB.Size = new System.Drawing.Size(80, 27);
            this.unitTB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(34, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Unit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(34, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Selected ID";
            // 
            // idTF
            // 
            this.idTF.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTF.Location = new System.Drawing.Point(217, 40);
            this.idTF.Name = "idTF";
            this.idTF.Size = new System.Drawing.Size(69, 27);
            this.idTF.TabIndex = 9;
            // 
            // snTB
            // 
            this.snTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snTB.Location = new System.Drawing.Point(215, 263);
            this.snTB.Name = "snTB";
            this.snTB.Size = new System.Drawing.Size(149, 27);
            this.snTB.TabIndex = 8;
            // 
            // ohTB
            // 
            this.ohTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohTB.Location = new System.Drawing.Point(217, 180);
            this.ohTB.Name = "ohTB";
            this.ohTB.Size = new System.Drawing.Size(58, 27);
            this.ohTB.TabIndex = 7;
            // 
            // rpTB
            // 
            this.rpTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpTB.Location = new System.Drawing.Point(217, 136);
            this.rpTB.Name = "rpTB";
            this.rpTB.Size = new System.Drawing.Size(58, 27);
            this.rpTB.TabIndex = 6;
            // 
            // inTB
            // 
            this.inTB.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inTB.Location = new System.Drawing.Point(217, 91);
            this.inTB.Name = "inTB";
            this.inTB.Size = new System.Drawing.Size(149, 27);
            this.inTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(34, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 27);
            this.label4.TabIndex = 4;
            this.label4.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(36, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "On Hand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(35, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reorder Point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(35, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingredient Name";
            // 
            // ingrGV
            // 
            this.ingrGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingrGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcol,
            this.incol,
            this.reordcol,
            this.ohcol,
            this.unitcol,
            this.sncol});
            this.ingrGV.Location = new System.Drawing.Point(372, 20);
            this.ingrGV.Name = "ingrGV";
            this.ingrGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingrGV.Size = new System.Drawing.Size(885, 287);
            this.ingrGV.TabIndex = 0;
            this.ingrGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ingrGV_CellContentClick);
            // 
            // idcol
            // 
            this.idcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idcol.HeaderText = "Ingredient ID";
            this.idcol.Name = "idcol";
            // 
            // incol
            // 
            this.incol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.incol.HeaderText = "Ingredient Name";
            this.incol.Name = "incol";
            // 
            // reordcol
            // 
            this.reordcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reordcol.HeaderText = "Reorder Point";
            this.reordcol.Name = "reordcol";
            // 
            // ohcol
            // 
            this.ohcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ohcol.HeaderText = "On Hand";
            this.ohcol.Name = "ohcol";
            // 
            // unitcol
            // 
            this.unitcol.HeaderText = "Unit";
            this.unitcol.Name = "unitcol";
            // 
            // sncol
            // 
            this.sncol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sncol.HeaderText = "Supplier Name";
            this.sncol.Name = "sncol";
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addBTN.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Image = ((System.Drawing.Image)(resources.GetObject("addBTN.Image")));
            this.addBTN.Location = new System.Drawing.Point(34, 451);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(116, 50);
            this.addBTN.TabIndex = 2;
            this.addBTN.Text = "ADD";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteBTN.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Image = ((System.Drawing.Image)(resources.GetObject("deleteBTN.Image")));
            this.deleteBTN.Location = new System.Drawing.Point(147, 451);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(116, 50);
            this.deleteBTN.TabIndex = 3;
            this.deleteBTN.Text = "DELETE";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // editBTN
            // 
            this.editBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editBTN.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBTN.Image = ((System.Drawing.Image)(resources.GetObject("editBTN.Image")));
            this.editBTN.Location = new System.Drawing.Point(261, 451);
            this.editBTN.Name = "editBTN";
            this.editBTN.Size = new System.Drawing.Size(116, 50);
            this.editBTN.TabIndex = 4;
            this.editBTN.Text = "EDIT";
            this.editBTN.UseVisualStyleBackColor = false;
            this.editBTN.Click += new System.EventHandler(this.editBTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Image = global::_29thStreet_Cafe_Sales_Inventory_System.Properties.Resources.or;
            this.label5.Location = new System.Drawing.Point(36, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 45);
            this.label5.TabIndex = 5;
            this.label5.Text = "INGREDIENTS LIST";
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1305, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.editBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngredientsForm";
            this.Text = "Ingredients Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingrGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ingrGV;
        private System.Windows.Forms.TextBox snTB;
        private System.Windows.Forms.TextBox ohTB;
        private System.Windows.Forms.TextBox rpTB;
        private System.Windows.Forms.TextBox inTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idTF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unitTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn incol;
        private System.Windows.Forms.DataGridViewTextBoxColumn reordcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ohcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sncol;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button newBTN;
        private System.Windows.Forms.Button clearBTN;
    }
}