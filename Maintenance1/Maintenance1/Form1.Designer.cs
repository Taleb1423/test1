namespace Maintenance1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login_but = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_but
            // 
            this.Login_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_but.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Login_but.Location = new System.Drawing.Point(178, 199);
            this.Login_but.Name = "Login_but";
            this.Login_but.Size = new System.Drawing.Size(155, 37);
            this.Login_but.TabIndex = 0;
            this.Login_but.Text = "Login";
            this.Login_but.UseVisualStyleBackColor = true;
            this.Login_but.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.user);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Login_but);
            this.panel1.Location = new System.Drawing.Point(124, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 318);
            this.panel1.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(123, 149);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(266, 22);
            this.pass.TabIndex = 6;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(123, 79);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(274, 22);
            this.user.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Login_but;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
    }
}

