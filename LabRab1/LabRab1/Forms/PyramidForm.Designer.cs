namespace GUI
{
    partial class PyramidForm
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
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(128, 38);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.Size = new System.Drawing.Size(100, 20);
            this.textBoxH.TabIndex = 12;
            // 
            // textBoxS
            // 
            this.textBoxS.Location = new System.Drawing.Point(128, 12);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.Size = new System.Drawing.Size(100, 20);
            this.textBoxS.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Площадь основания";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Высота пирамиды";
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(60, 97);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.ReadOnly = true;
            this.textBoxV.Size = new System.Drawing.Size(140, 20);
            this.textBoxV.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Объем";
            // 
            // PyramidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 134);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "PyramidForm";
            this.Text = "Pirad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label label3;

    }
}