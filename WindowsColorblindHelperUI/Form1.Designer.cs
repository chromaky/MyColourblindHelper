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
            this.Protan = new System.Windows.Forms.Button();
            this.Grayscale = new System.Windows.Forms.Button();
            this.ToggleFilter = new System.Windows.Forms.Button();
            this.titlebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.Orange;
            this.titlebar.Controls.Add(this.minbutton);
            this.titlebar.Controls.Add(this.closebutton);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(4, 4);
            this.titlebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(201, 27);
            this.titlebar.TabIndex = 1;
            // 
            // minbutton
            // 
            this.minbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minbutton.FlatAppearance.BorderSize = 0;
            this.minbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minbutton.Image = global::WindowsColorblindHelperUI.Properties.Resources.app_min;
            this.minbutton.Location = new System.Drawing.Point(148, 0);
            this.minbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minbutton.Name = "minbutton";
            this.minbutton.Size = new System.Drawing.Size(27, 27);
            this.minbutton.TabIndex = 1;
            this.minbutton.UseVisualStyleBackColor = true;
            this.minbutton.Click += new System.EventHandler(this.minbutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.ForeColor = System.Drawing.Color.White;
            this.closebutton.Image = global::WindowsColorblindHelperUI.Properties.Resources.app_x;
            this.closebutton.Location = new System.Drawing.Point(175, 0);
            this.closebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(27, 27);
            this.closebutton.TabIndex = 0;
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Protan);
            this.panel1.Controls.Add(this.Grayscale);
            this.panel1.Controls.Add(this.ToggleFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 72);
            this.panel1.TabIndex = 2;
            // 
            // Protan
            // 
            this.Protan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Protan.Image = global::WindowsColorblindHelperUI.Properties.Resources.off;
            this.Protan.Location = new System.Drawing.Point(137, 5);
            this.Protan.Name = "Protan";
            this.Protan.Size = new System.Drawing.Size(60, 60);
            this.Protan.TabIndex = 2;
            this.Protan.UseVisualStyleBackColor = true;
            this.Protan.Click += new System.EventHandler(this.Protan_Click);
            // 
            // Grayscale
            // 
            this.Grayscale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grayscale.Image = global::WindowsColorblindHelperUI.Properties.Resources.off;
            this.Grayscale.Location = new System.Drawing.Point(71, 5);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(60, 60);
            this.Grayscale.TabIndex = 1;
            this.Grayscale.UseVisualStyleBackColor = true;
            this.Grayscale.Click += new System.EventHandler(this.Grayscale_Click);
            // 
            // ToggleFilter
            // 
            this.ToggleFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToggleFilter.Image = global::WindowsColorblindHelperUI.Properties.Resources.off;
            this.ToggleFilter.Location = new System.Drawing.Point(5, 5);
            this.ToggleFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToggleFilter.Name = "ToggleFilter";
            this.ToggleFilter.Size = new System.Drawing.Size(60, 60);
            this.ToggleFilter.TabIndex = 0;
            this.ToggleFilter.UseVisualStyleBackColor = true;
            this.ToggleFilter.Click += new System.EventHandler(this.ToggleFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(209, 107);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text = "Form1";
            this.TopMost = true;
            this.titlebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button ToggleFilter;
        private System.Windows.Forms.Button Grayscale;
        private System.Windows.Forms.Button Protan;
    }
}

