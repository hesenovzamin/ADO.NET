namespace Adonet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Teachername = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.StudentCount = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Label();
            this.Teachern = new System.Windows.Forms.TextBox();
            this.AddCategory = new System.Windows.Forms.Button();
            this.AddClass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TECcombobox = new System.Windows.Forms.ComboBox();
            this.ShowTABLE = new System.Windows.Forms.TextBox();
            this.ShowCat = new System.Windows.Forms.Button();
            this.ShowPro = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Teachername.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowPro);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.TECcombobox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AddClass);
            this.panel1.Controls.Add(this.StudentCount);
            this.panel1.Controls.Add(this.S);
            this.panel1.Controls.Add(this.ClassName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 450);
            this.panel1.TabIndex = 0;
            // 
            // Teachername
            // 
            this.Teachername.Controls.Add(this.label3);
            this.Teachername.Controls.Add(this.ShowCat);
            this.Teachername.Controls.Add(this.ShowTABLE);
            this.Teachername.Controls.Add(this.AddCategory);
            this.Teachername.Controls.Add(this.Teachern);
            this.Teachername.Location = new System.Drawing.Point(414, 12);
            this.Teachername.Name = "Teachername";
            this.Teachername.Size = new System.Drawing.Size(402, 450);
            this.Teachername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ClassName";
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(118, 17);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(206, 20);
            this.ClassName.TabIndex = 1;
            // 
            // StudentCount
            // 
            this.StudentCount.Location = new System.Drawing.Point(118, 58);
            this.StudentCount.Name = "StudentCount";
            this.StudentCount.Size = new System.Drawing.Size(206, 20);
            this.StudentCount.TabIndex = 3;
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(19, 61);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(72, 13);
            this.S.TabIndex = 2;
            this.S.Text = "StudentCount";
            // 
            // Teachern
            // 
            this.Teachern.Location = new System.Drawing.Point(175, 17);
            this.Teachern.Name = "Teachern";
            this.Teachern.Size = new System.Drawing.Size(206, 20);
            this.Teachern.TabIndex = 3;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(306, 56);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(75, 23);
            this.AddCategory.TabIndex = 4;
            this.AddCategory.Text = "AddCategory";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // AddClass
            // 
            this.AddClass.Location = new System.Drawing.Point(249, 136);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(75, 23);
            this.AddClass.TabIndex = 5;
            this.AddClass.Text = "AddProduct";
            this.AddClass.UseVisualStyleBackColor = true;
            this.AddClass.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teacher";
            // 
            // TECcombobox
            // 
            this.TECcombobox.FormattingEnabled = true;
            this.TECcombobox.Location = new System.Drawing.Point(118, 97);
            this.TECcombobox.Name = "TECcombobox";
            this.TECcombobox.Size = new System.Drawing.Size(206, 21);
            this.TECcombobox.TabIndex = 7;
            // 
            // ShowTABLE
            // 
            this.ShowTABLE.Location = new System.Drawing.Point(25, 136);
            this.ShowTABLE.Multiline = true;
            this.ShowTABLE.Name = "ShowTABLE";
            this.ShowTABLE.Size = new System.Drawing.Size(356, 131);
            this.ShowTABLE.TabIndex = 8;
            this.ShowTABLE.TextChanged += new System.EventHandler(this.ShowTABLE_TextChanged);
            // 
            // ShowCat
            // 
            this.ShowCat.Location = new System.Drawing.Point(25, 94);
            this.ShowCat.Name = "ShowCat";
            this.ShowCat.Size = new System.Drawing.Size(110, 24);
            this.ShowCat.TabIndex = 9;
            this.ShowCat.Text = "ShowCat";
            this.ShowCat.UseVisualStyleBackColor = true;
            this.ShowCat.Click += new System.EventHandler(this.ShowCat_Click);
            // 
            // ShowPro
            // 
            this.ShowPro.Location = new System.Drawing.Point(13, 177);
            this.ShowPro.Name = "ShowPro";
            this.ShowPro.Size = new System.Drawing.Size(110, 24);
            this.ShowPro.TabIndex = 11;
            this.ShowPro.Text = "ShowPro";
            this.ShowPro.UseVisualStyleBackColor = true;
            this.ShowPro.Click += new System.EventHandler(this.ShowPro_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 219);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(356, 131);
            this.textBox2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Teachername";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 474);
            this.Controls.Add(this.Teachername);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Teachername.ResumeLayout(false);
            this.Teachername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TECcombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddClass;
        private System.Windows.Forms.TextBox StudentCount;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Teachername;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.TextBox Teachern;
        private System.Windows.Forms.Button ShowCat;
        private System.Windows.Forms.TextBox ShowTABLE;
        private System.Windows.Forms.Button ShowPro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}

