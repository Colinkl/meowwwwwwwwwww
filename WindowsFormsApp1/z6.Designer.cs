namespace WindowsFormsApp1
{
    partial class z6
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
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutTextBox = new System.Windows.Forms.RichTextBox();
            this.Plusify = new System.Windows.Forms.Button();
            this.AutoPlusFlag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(66, 64);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(441, 150);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "";
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // OutTextBox
            // 
            this.OutTextBox.Enabled = false;
            this.OutTextBox.Location = new System.Drawing.Point(66, 250);
            this.OutTextBox.Name = "OutTextBox";
            this.OutTextBox.Size = new System.Drawing.Size(441, 156);
            this.OutTextBox.TabIndex = 1;
            this.OutTextBox.Text = "";
            this.OutTextBox.TextChanged += new System.EventHandler(this.OutTextBox_TextChanged);
            // 
            // Plusify
            // 
            this.Plusify.Location = new System.Drawing.Point(528, 61);
            this.Plusify.Name = "Plusify";
            this.Plusify.Size = new System.Drawing.Size(243, 153);
            this.Plusify.TabIndex = 2;
            this.Plusify.Text = "Make text Plus again!";
            this.Plusify.UseVisualStyleBackColor = true;
            this.Plusify.Click += new System.EventHandler(this.Plusify_Click);
            // 
            // AutoPlusFlag
            // 
            this.AutoPlusFlag.AutoSize = true;
            this.AutoPlusFlag.Location = new System.Drawing.Point(528, 235);
            this.AutoPlusFlag.Name = "AutoPlusFlag";
            this.AutoPlusFlag.Size = new System.Drawing.Size(68, 17);
            this.AutoPlusFlag.TabIndex = 3;
            this.AutoPlusFlag.Text = "AutoPlus";
            this.AutoPlusFlag.UseVisualStyleBackColor = true;
            this.AutoPlusFlag.CheckedChanged += new System.EventHandler(this.AutoPlusFlag_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Out";
            // 
            // z6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoPlusFlag);
            this.Controls.Add(this.Plusify);
            this.Controls.Add(this.OutTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Name = "z6";
            this.Text = "z6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.RichTextBox OutTextBox;
        private System.Windows.Forms.Button Plusify;
        private System.Windows.Forms.CheckBox AutoPlusFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}