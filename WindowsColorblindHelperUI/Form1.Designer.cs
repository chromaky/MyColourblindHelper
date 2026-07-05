namespace WindowsColorblindHelperUI
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
            this.titlebar = new System.Windows.Forms.Panel();
            this.minbutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.Orange;
            this.titlebar.Controls.Add(this.minbutton);
            this.titlebar.Controls.Add(this.closebutton);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(5, 5);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(269, 33);
            this.titlebar.TabIndex = 1;
            // 
            // minbutton
            // 
            this.minbutton.Location = new System.Drawing.Point(170, 4);
            this.minbutton.Name = "minbutton";
            this.minbutton.Size = new System.Drawing.Size(36, 23);
            this.minbutton.TabIndex = 1;
            this.minbutton.Text = "button1";
            this.minbutton.UseVisualStyleBackColor = true;
            this.minbutton.Click += new System.EventHandler(this.minbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(220, 4);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(38, 23);
            this.closebutton.TabIndex = 0;
            this.closebutton.Text = "button1";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 89);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(279, 132);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.TopMost = true;
            this.titlebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minbutton;
        private System.Windows.Forms.Button closebutton;
    }
}

