namespace THA_W6_THEO_F_WOORDLE
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "WORDLE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Set How Much You Can Guess!";
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(154, 128);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(115, 20);
            this.txtinput.TabIndex = 2;
            this.txtinput.TextChanged += new System.EventHandler(this.txtinput_TextChanged);
            this.txtinput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput_KeyPress);
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(177, 154);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 23);
            this.btnenter.TabIndex = 3;
            this.btnenter.Text = "ENTER";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 226);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnenter;
    }
}

