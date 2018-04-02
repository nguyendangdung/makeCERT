namespace makeCERT
{
    partial class Main
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
            this.genCertBtn = new System.Windows.Forms.Button();
            this.hostNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.genCertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genCertBtn.Location = new System.Drawing.Point(333, 15);
            this.genCertBtn.Name = "button1";
            this.genCertBtn.Size = new System.Drawing.Size(89, 56);
            this.genCertBtn.TabIndex = 0;
            this.genCertBtn.Text = "Gen CERT";
            this.genCertBtn.UseVisualStyleBackColor = true;
            this.genCertBtn.Click += new System.EventHandler(this.genCertBtn_Click);
            // 
            // hostNameTextBox
            // 
            this.hostNameTextBox.Location = new System.Drawing.Point(15, 87);
            this.hostNameTextBox.Multiline = true;
            this.hostNameTextBox.Name = "hostNameTextBox";
            this.hostNameTextBox.Size = new System.Drawing.Size(407, 192);
            this.hostNameTextBox.TabIndex = 1;
            // 
            // textBox2
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(105, 15);
            this.emailTextBox.Name = "textBox2";
            this.emailTextBox.Size = new System.Drawing.Size(212, 23);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.Text = "example";
            this.emailTextBox.TextChanged += new System.EventHandler(this.hostNameTxt_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(105, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 23);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "webmaster@example.com";
            this.textBox3.TextChanged += new System.EventHandler(this.emailTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "HOST NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "EMAIL";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.hostNameTextBox);
            this.Controls.Add(this.genCertBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "makeCERT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button genCertBtn;
        private System.Windows.Forms.TextBox hostNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

