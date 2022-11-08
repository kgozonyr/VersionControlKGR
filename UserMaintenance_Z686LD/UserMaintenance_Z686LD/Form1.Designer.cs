
namespace UserMaintenance_Z686LD
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
            this.Add = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.Label();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.fajlbaIras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(367, 170);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(229, 43);
            this.Add.TabIndex = 0;
            this.Add.Text = "button1";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(444, 34);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(364, 34);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(46, 17);
            this.FullName.TabIndex = 3;
            this.FullName.Text = "label1";
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 16;
            this.listUsers.Location = new System.Drawing.Point(41, 34);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(272, 356);
            this.listUsers.TabIndex = 5;
            // 
            // fajlbaIras
            // 
            this.fajlbaIras.Location = new System.Drawing.Point(367, 243);
            this.fajlbaIras.Name = "fajlbaIras";
            this.fajlbaIras.Size = new System.Drawing.Size(229, 41);
            this.fajlbaIras.TabIndex = 6;
            this.fajlbaIras.Text = "button1";
            this.fajlbaIras.UseVisualStyleBackColor = true;
            this.fajlbaIras.Click += new System.EventHandler(this.fajlbaIras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fajlbaIras);
            this.Controls.Add(this.listUsers);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Button fajlbaIras;
    }
}

