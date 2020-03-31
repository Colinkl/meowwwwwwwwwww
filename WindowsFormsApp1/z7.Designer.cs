namespace WindowsFormsApp1
{
    partial class z7
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
            this.InputMassList = new System.Windows.Forms.ListBox();
            this.OutMassList = new System.Windows.Forms.ListBox();
            this.randButton = new System.Windows.Forms.Button();
            this.ProccesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputMassList
            // 
            this.InputMassList.FormattingEnabled = true;
            this.InputMassList.Location = new System.Drawing.Point(29, 31);
            this.InputMassList.Name = "InputMassList";
            this.InputMassList.Size = new System.Drawing.Size(175, 368);
            this.InputMassList.TabIndex = 0;
            this.InputMassList.SelectedIndexChanged += new System.EventHandler(this.InputMassList_SelectedIndexChanged);
            // 
            // OutMassList
            // 
            this.OutMassList.FormattingEnabled = true;
            this.OutMassList.Location = new System.Drawing.Point(411, 31);
            this.OutMassList.Name = "OutMassList";
            this.OutMassList.Size = new System.Drawing.Size(207, 368);
            this.OutMassList.TabIndex = 1;
            this.OutMassList.SelectedIndexChanged += new System.EventHandler(this.OutMassList_SelectedIndexChanged);
            // 
            // randButton
            // 
            this.randButton.Location = new System.Drawing.Point(219, 42);
            this.randButton.Name = "randButton";
            this.randButton.Size = new System.Drawing.Size(186, 183);
            this.randButton.TabIndex = 2;
            this.randButton.Text = "Rand";
            this.randButton.UseVisualStyleBackColor = true;
            this.randButton.Click += new System.EventHandler(this.randButton_Click);
            // 
            // ProccesButton
            // 
            this.ProccesButton.Location = new System.Drawing.Point(220, 235);
            this.ProccesButton.Name = "ProccesButton";
            this.ProccesButton.Size = new System.Drawing.Size(184, 163);
            this.ProccesButton.TabIndex = 3;
            this.ProccesButton.Text = "Process";
            this.ProccesButton.UseVisualStyleBackColor = true;
            this.ProccesButton.Click += new System.EventHandler(this.ProccesButton_Click);
            // 
            // z7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.ProccesButton);
            this.Controls.Add(this.randButton);
            this.Controls.Add(this.OutMassList);
            this.Controls.Add(this.InputMassList);
            this.Name = "z7";
            this.Text = "z7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox InputMassList;
        private System.Windows.Forms.ListBox OutMassList;
        private System.Windows.Forms.Button randButton;
        private System.Windows.Forms.Button ProccesButton;
    }
}