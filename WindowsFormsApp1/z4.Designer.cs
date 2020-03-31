namespace WindowsFormsApp1
{
    partial class z4
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
            this.x0 = new System.Windows.Forms.TextBox();
            this.xk = new System.Windows.Forms.TextBox();
            this.dxx = new System.Windows.Forms.TextBox();
            this.bx = new System.Windows.Forms.TextBox();
            this.OutBoxx = new System.Windows.Forms.RichTextBox();
            this.calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x0
            // 
            this.x0.Location = new System.Drawing.Point(113, 47);
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(100, 20);
            this.x0.TabIndex = 0;
            this.x0.TextChanged += new System.EventHandler(this.x0_TextChanged);
            // 
            // xk
            // 
            this.xk.Location = new System.Drawing.Point(113, 88);
            this.xk.Name = "xk";
            this.xk.Size = new System.Drawing.Size(100, 20);
            this.xk.TabIndex = 1;
            this.xk.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dxx
            // 
            this.dxx.Location = new System.Drawing.Point(113, 138);
            this.dxx.Name = "dxx";
            this.dxx.Size = new System.Drawing.Size(100, 20);
            this.dxx.TabIndex = 2;
            // 
            // bx
            // 
            this.bx.Location = new System.Drawing.Point(113, 190);
            this.bx.Name = "bx";
            this.bx.Size = new System.Drawing.Size(100, 20);
            this.bx.TabIndex = 3;
            // 
            // OutBoxx
            // 
            this.OutBoxx.Location = new System.Drawing.Point(54, 236);
            this.OutBoxx.Name = "OutBoxx";
            this.OutBoxx.Size = new System.Drawing.Size(337, 182);
            this.OutBoxx.TabIndex = 4;
            this.OutBoxx.Text = "";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(233, 37);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(158, 173);
            this.calc.TabIndex = 5;
            this.calc.Text = "calc";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X0=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Xk=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dx=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "b =";
            // 
            // zz4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.OutBoxx);
            this.Controls.Add(this.bx);
            this.Controls.Add(this.dxx);
            this.Controls.Add(this.xk);
            this.Controls.Add(this.x0);
            this.Name = "zz4";
            this.Text = "zz4";
            this.Load += new System.EventHandler(this.zz4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x0;
        private System.Windows.Forms.TextBox xk;
        private System.Windows.Forms.TextBox dxx;
        private System.Windows.Forms.TextBox bx;
        private System.Windows.Forms.RichTextBox OutBoxx;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}