
namespace SuperMarket_AD0631
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblwel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnform4 = new System.Windows.Forms.Button();
            this.btnform1 = new System.Windows.Forms.Button();
            this.btnform3 = new System.Windows.Forms.Button();
            this.btnform2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblwel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 83);
            this.panel1.TabIndex = 0;
            // 
            // lblwel
            // 
            this.lblwel.AutoSize = true;
            this.lblwel.Location = new System.Drawing.Point(25, 26);
            this.lblwel.Name = "lblwel";
            this.lblwel.Size = new System.Drawing.Size(38, 15);
            this.lblwel.TabIndex = 0;
            this.lblwel.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.btnform4);
            this.panel3.Controls.Add(this.btnform1);
            this.panel3.Controls.Add(this.btnform3);
            this.panel3.Controls.Add(this.btnform2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 265);
            this.panel3.TabIndex = 2;
            // 
            // btnform4
            // 
            this.btnform4.Location = new System.Drawing.Point(25, 117);
            this.btnform4.Name = "btnform4";
            this.btnform4.Size = new System.Drawing.Size(91, 49);
            this.btnform4.TabIndex = 3;
            this.btnform4.Text = "food";
            this.btnform4.UseVisualStyleBackColor = true;
            this.btnform4.Click += new System.EventHandler(this.btnform4_Click);
            // 
            // btnform1
            // 
            this.btnform1.Location = new System.Drawing.Point(25, 17);
            this.btnform1.Name = "btnform1";
            this.btnform1.Size = new System.Drawing.Size(91, 48);
            this.btnform1.TabIndex = 0;
            this.btnform1.Text = "milk";
            this.btnform1.UseVisualStyleBackColor = true;
            this.btnform1.Click += new System.EventHandler(this.btnform1_Click_1);
            // 
            // btnform3
            // 
            this.btnform3.Location = new System.Drawing.Point(206, 117);
            this.btnform3.Name = "btnform3";
            this.btnform3.Size = new System.Drawing.Size(111, 49);
            this.btnform3.TabIndex = 2;
            this.btnform3.Text = "juice";
            this.btnform3.UseVisualStyleBackColor = true;
            this.btnform3.Click += new System.EventHandler(this.btnform3_Click_1);
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(206, 17);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(111, 48);
            this.btnform2.TabIndex = 1;
            this.btnform2.Text = "rice";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 348);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblwel;
        private System.Windows.Forms.Button btnform4;
        private System.Windows.Forms.Button btnform1;
        private System.Windows.Forms.Button btnform3;
        private System.Windows.Forms.Button btnform2;
    }
}