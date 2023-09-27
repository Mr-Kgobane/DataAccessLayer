namespace Exercise_3
{
    partial class Delete
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
            this.txtdelete = new System.Windows.Forms.TextBox();
            this.btndel = new System.Windows.Forms.Button();
            this.btnex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "student number";
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(277, 140);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(100, 22);
            this.txtdelete.TabIndex = 1;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(83, 225);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 2;
            this.btndel.Text = "delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnex
            // 
            this.btnex.Location = new System.Drawing.Point(341, 225);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(75, 23);
            this.btnex.TabIndex = 3;
            this.btnex.Text = "exit";
            this.btnex.UseVisualStyleBackColor = true;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdelete;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnex;
    }
}