namespace Exercise_3
{
    partial class Student
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stID = new System.Windows.Forms.TextBox();
            this.FN = new System.Windows.Forms.TextBox();
            this.LN = new System.Windows.Forms.TextBox();
            this.CID = new System.Windows.Forms.TextBox();
            this.REg = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "StudentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CouseID";
            // 
            // stID
            // 
            this.stID.Location = new System.Drawing.Point(173, 50);
            this.stID.Name = "stID";
            this.stID.Size = new System.Drawing.Size(100, 22);
            this.stID.TabIndex = 4;
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(173, 103);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(100, 22);
            this.FN.TabIndex = 5;
            // 
            // LN
            // 
            this.LN.Location = new System.Drawing.Point(173, 160);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(100, 22);
            this.LN.TabIndex = 6;
            // 
            // CID
            // 
            this.CID.Location = new System.Drawing.Point(173, 213);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(100, 22);
            this.CID.TabIndex = 7;
            // 
            // REg
            // 
            this.REg.Location = new System.Drawing.Point(35, 276);
            this.REg.Name = "REg";
            this.REg.Size = new System.Drawing.Size(97, 30);
            this.REg.TabIndex = 8;
            this.REg.Text = "register";
            this.REg.UseVisualStyleBackColor = true;
            this.REg.Click += new System.EventHandler(this.REg_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(197, 282);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 9;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(330, 282);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 10;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(129, 344);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 11;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(296, 343);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(462, 57);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(443, 275);
            this.dgvStudents.TabIndex = 13;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.REg);
            this.Controls.Add(this.CID);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.stID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Student";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stID;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.TextBox LN;
        private System.Windows.Forms.TextBox CID;
        private System.Windows.Forms.Button REg;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}

