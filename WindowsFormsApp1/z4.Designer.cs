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
            this.xbox = new System.Windows.Forms.TextBox();
            this.ybox = new System.Windows.Forms.TextBox();
            this.zbox = new System.Windows.Forms.TextBox();
            this.outss = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sh = new System.Windows.Forms.RadioButton();
            this.sqrr = new System.Windows.Forms.RadioButton();
            this.eee = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xbox
            // 
            this.xbox.Location = new System.Drawing.Point(80, 53);
            this.xbox.Name = "xbox";
            this.xbox.Size = new System.Drawing.Size(178, 20);
            this.xbox.TabIndex = 0;
            this.xbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ybox
            // 
            this.ybox.Location = new System.Drawing.Point(80, 93);
            this.ybox.Name = "ybox";
            this.ybox.Size = new System.Drawing.Size(178, 20);
            this.ybox.TabIndex = 1;
            this.ybox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // zbox
            // 
            this.zbox.Location = new System.Drawing.Point(80, 136);
            this.zbox.Name = "zbox";
            this.zbox.Size = new System.Drawing.Size(178, 20);
            this.zbox.TabIndex = 2;
            this.zbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // outss
            // 
            this.outss.Location = new System.Drawing.Point(12, 280);
            this.outss.Name = "outss";
            this.outss.ReadOnly = true;
            this.outss.Size = new System.Drawing.Size(395, 155);
            this.outss.TabIndex = 3;
            this.outss.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "x=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "y=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(43, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "z=";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sh
            // 
            this.sh.AutoSize = true;
            this.sh.Location = new System.Drawing.Point(76, 191);
            this.sh.Name = "sh";
            this.sh.Size = new System.Drawing.Size(47, 17);
            this.sh.TabIndex = 7;
            this.sh.TabStop = true;
            this.sh.Text = "sh(x)";
            this.sh.UseVisualStyleBackColor = true;
            this.sh.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sqrr
            // 
            this.sqrr.AutoSize = true;
            this.sqrr.Location = new System.Drawing.Point(76, 214);
            this.sqrr.Name = "sqrr";
            this.sqrr.Size = new System.Drawing.Size(42, 17);
            this.sqrr.TabIndex = 8;
            this.sqrr.TabStop = true;
            this.sqrr.Text = "x^2";
            this.sqrr.UseVisualStyleBackColor = true;
            this.sqrr.CheckedChanged += new System.EventHandler(this.sqrr_CheckedChanged);
            // 
            // eee
            // 
            this.eee.AutoSize = true;
            this.eee.Location = new System.Drawing.Point(76, 237);
            this.eee.Name = "eee";
            this.eee.Size = new System.Drawing.Size(42, 17);
            this.eee.TabIndex = 9;
            this.eee.TabStop = true;
            this.eee.Text = "e^x";
            this.eee.UseVisualStyleBackColor = true;
            this.eee.CheckedChanged += new System.EventHandler(this.eee_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // z4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 485);
            this.Controls.Add(this.outss);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eee);
            this.Controls.Add(this.sqrr);
            this.Controls.Add(this.sh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zbox);
            this.Controls.Add(this.ybox);
            this.Controls.Add(this.xbox);
            this.Name = "z4";
            this.Text = "z4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xbox;
        private System.Windows.Forms.TextBox ybox;
        private System.Windows.Forms.TextBox zbox;
        private System.Windows.Forms.RichTextBox outss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sh;
        private System.Windows.Forms.RadioButton sqrr;
        private System.Windows.Forms.RadioButton eee;
        private System.Windows.Forms.Button button1;
    }
}