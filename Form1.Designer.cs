namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.C_TX = new System.Windows.Forms.TextBox();
            this.S_BTN = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // pB1
            // 
            this.pB1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pB1.Location = new System.Drawing.Point(223, 161);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(341, 217);
            this.pB1.TabIndex = 3;
            this.pB1.TabStop = false;
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.l3.Font = new System.Drawing.Font("Adobe Hebrew", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l3.Location = new System.Drawing.Point(321, 211);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(154, 29);
            this.l3.TabIndex = 5;
            this.l3.Text = "Enter the class:";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.l4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l4.Font = new System.Drawing.Font("Adobe Hebrew", 20.25F);
            this.l4.Location = new System.Drawing.Point(232, 37);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(314, 36);
            this.l4.TabIndex = 4;
            this.l4.Text = "Welcome to Class Checker";
            // 
            // C_TX
            // 
            this.C_TX.Location = new System.Drawing.Point(326, 269);
            this.C_TX.Name = "C_TX";
            this.C_TX.Size = new System.Drawing.Size(137, 20);
            this.C_TX.TabIndex = 7;
            // 
            // S_BTN
            // 
            this.S_BTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.S_BTN.Font = new System.Drawing.Font("Adobe Hebrew", 11.25F);
            this.S_BTN.Location = new System.Drawing.Point(358, 313);
            this.S_BTN.Name = "S_BTN";
            this.S_BTN.Size = new System.Drawing.Size(75, 28);
            this.S_BTN.TabIndex = 8;
            this.S_BTN.Text = "Submit";
            this.S_BTN.UseVisualStyleBackColor = false;
            this.S_BTN.Click += new System.EventHandler(this.S_BTN_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.l1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l1.Font = new System.Drawing.Font("Adobe Hebrew", 16.25F);
            this.l1.Location = new System.Drawing.Point(161, 83);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(478, 30);
            this.l1.TabIndex = 9;
            this.l1.Text = "USF Computer Science Program: Year 1 and Year 2";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(323, 292);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(167, 13);
            this.l2.TabIndex = 10;
            this.l2.Text = "*enter course label and then code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.S_BTN);
            this.Controls.Add(this.C_TX);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.pB1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.TextBox C_TX;
        private System.Windows.Forms.Button S_BTN;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
    }
}

