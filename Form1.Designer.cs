
namespace Inheritance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefill = new System.Windows.Forms.Button();
            this.textInfo = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textOut = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(29, 19);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(496, 55);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Предложить другой!";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // textInfo
            // 
            this.textInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInfo.Location = new System.Drawing.Point(29, 95);
            this.textInfo.Name = "textInfo";
            this.textInfo.ReadOnly = true;
            this.textInfo.Size = new System.Drawing.Size(496, 120);
            this.textInfo.TabIndex = 1;
            this.textInfo.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 126);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выбрать фильм";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textOut
            // 
            this.textOut.Location = new System.Drawing.Point(31, 221);
            this.textOut.Name = "textOut";
            this.textOut.Size = new System.Drawing.Size(336, 125);
            this.textOut.TabIndex = 3;
            this.textOut.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 365);
            this.Controls.Add(this.textOut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.btnRefill);
            this.Name = "Form1";
            this.Text = "Выбрать фильм!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.RichTextBox textInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox textOut;
    }
}

