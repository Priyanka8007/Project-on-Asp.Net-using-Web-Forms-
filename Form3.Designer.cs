namespace WindowsFormsApp2
{
    partial class Form3
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
            this.click_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // click_button1
            // 
            this.click_button1.BackColor = System.Drawing.Color.DarkViolet;
            this.click_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_button1.ForeColor = System.Drawing.Color.Coral;
            this.click_button1.Location = new System.Drawing.Point(107, 171);
            this.click_button1.Name = "click_button1";
            this.click_button1.Size = new System.Drawing.Size(528, 107);
            this.click_button1.TabIndex = 0;
            this.click_button1.Text = "Connect";
            this.click_button1.UseVisualStyleBackColor = false;
            this.click_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.click_button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button click_button1;
    }
}