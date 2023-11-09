namespace adodemo
{
    partial class Form1
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
            this.DeptData = new System.Windows.Forms.GroupBox();
            this.dgvDeptData = new System.Windows.Forms.DataGridView();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.DeptID = new System.Windows.Forms.TextBox();
            this.DeptName = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndisp = new System.Windows.Forms.Button();
            this.DeptData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptData)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptData
            // 
            this.DeptData.Controls.Add(this.btndisp);
            this.DeptData.Controls.Add(this.label3);
            this.DeptData.Controls.Add(this.label2);
            this.DeptData.Controls.Add(this.label1);
            this.DeptData.Controls.Add(this.Location);
            this.DeptData.Controls.Add(this.DeptName);
            this.DeptData.Controls.Add(this.DeptID);
            this.DeptData.Controls.Add(this.btndel);
            this.DeptData.Controls.Add(this.btnfind);
            this.DeptData.Controls.Add(this.btnupdate);
            this.DeptData.Controls.Add(this.btninsert);
            this.DeptData.Controls.Add(this.dgvDeptData);
            this.DeptData.Location = new System.Drawing.Point(12, 46);
            this.DeptData.Name = "DeptData";
            this.DeptData.Size = new System.Drawing.Size(1037, 550);
            this.DeptData.TabIndex = 0;
            this.DeptData.TabStop = false;
            this.DeptData.Text = "DeptData";
            this.DeptData.Enter += new System.EventHandler(this.DeptData_Enter);
            // 
            // dgvDeptData
            // 
            this.dgvDeptData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptData.Location = new System.Drawing.Point(413, 15);
            this.dgvDeptData.Name = "dgvDeptData";
            this.dgvDeptData.RowHeadersWidth = 62;
            this.dgvDeptData.RowTemplate.Height = 28;
            this.dgvDeptData.Size = new System.Drawing.Size(618, 311);
            this.dgvDeptData.TabIndex = 0;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(6, 364);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(146, 87);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.insert_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(189, 364);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(138, 87);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(382, 364);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(140, 87);
            this.btnfind.TabIndex = 3;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(589, 364);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(161, 87);
            this.btndel.TabIndex = 4;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // DeptID
            // 
            this.DeptID.Location = new System.Drawing.Point(307, 45);
            this.DeptID.Name = "DeptID";
            this.DeptID.Size = new System.Drawing.Size(100, 26);
            this.DeptID.TabIndex = 5;
            // 
            // DeptName
            // 
            this.DeptName.Location = new System.Drawing.Point(307, 114);
            this.DeptName.Name = "DeptName";
            this.DeptName.Size = new System.Drawing.Size(100, 26);
            this.DeptName.TabIndex = 6;
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(307, 178);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(100, 26);
            this.Location.TabIndex = 7;
            this.Location.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "DeptID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "DeptName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Location";
            // 
            // btndisp
            // 
            this.btndisp.Location = new System.Drawing.Point(786, 332);
            this.btndisp.Name = "btndisp";
            this.btndisp.Size = new System.Drawing.Size(230, 131);
            this.btndisp.TabIndex = 11;
            this.btndisp.Text = "displayall";
            this.btndisp.UseVisualStyleBackColor = true;
            this.btndisp.Click += new System.EventHandler(this.btndisp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 608);
            this.Controls.Add(this.DeptData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DeptData.ResumeLayout(false);
            this.DeptData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DeptData;
        private System.Windows.Forms.DataGridView dgvDeptData;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.TextBox DeptName;
        private System.Windows.Forms.TextBox DeptID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndisp;
    }
}

