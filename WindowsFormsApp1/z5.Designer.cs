namespace WindowsFormsApp1
{
    partial class z5
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
            this.typebox = new System.Windows.Forms.TextBox();
            this.xbox = new System.Windows.Forms.TextBox();
            this.ybox = new System.Windows.Forms.TextBox();
            this.creator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typebox
            // 
            this.typebox.Location = new System.Drawing.Point(53, 12);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(83, 20);
            this.typebox.TabIndex = 0;
            // 
            // xbox
            // 
            this.xbox.Location = new System.Drawing.Point(155, 12);
            this.xbox.Name = "xbox";
            this.xbox.Size = new System.Drawing.Size(87, 20);
            this.xbox.TabIndex = 1;
            this.xbox.TextChanged += new System.EventHandler(this.xbox_TextChanged);
            // 
            // ybox
            // 
            this.ybox.Location = new System.Drawing.Point(261, 12);
            this.ybox.Name = "ybox";
            this.ybox.Size = new System.Drawing.Size(91, 20);
            this.ybox.TabIndex = 2;
            // 
            // creator
            // 
            this.creator.Location = new System.Drawing.Point(53, 44);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(298, 35);
            this.creator.TabIndex = 3;
            this.creator.Text = "create";
            this.creator.UseVisualStyleBackColor = true;
            this.creator.Click += new System.EventHandler(this.creator_Click);
            // 
            // z5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.creator);
            this.Controls.Add(this.ybox);
            this.Controls.Add(this.xbox);
            this.Controls.Add(this.typebox);
            this.Name = "z5";
            this.Text = "z5";
            this.Load += new System.EventHandler(this.z5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox typebox;
        private System.Windows.Forms.TextBox xbox;
        private System.Windows.Forms.TextBox ybox;
        private System.Windows.Forms.Button creator;
    }
}