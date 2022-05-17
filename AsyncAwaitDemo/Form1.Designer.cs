
namespace AsyncAwaitDemo
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
            this.btnCallFunction = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCallFunction
            // 
            this.btnCallFunction.Location = new System.Drawing.Point(256, 212);
            this.btnCallFunction.Name = "btnCallFunction";
            this.btnCallFunction.Size = new System.Drawing.Size(255, 49);
            this.btnCallFunction.TabIndex = 0;
            this.btnCallFunction.Text = "Call Function";
            this.btnCallFunction.UseVisualStyleBackColor = true;
            this.btnCallFunction.Click += new System.EventHandler(this.btnCallFunction_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(347, 59);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(12, 17);
            this.lblText.TabIndex = 1;
            this.lblText.Text = " ";
            this.lblText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnCallFunction);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallFunction;
        private System.Windows.Forms.Label lblText;
    }
}

