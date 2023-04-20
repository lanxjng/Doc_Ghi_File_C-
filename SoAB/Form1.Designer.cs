namespace SoAB
{
    partial class FormBai2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên File";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(423, 41);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(147, 22);
            this.txtSoa.TabIndex = 3;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(423, 121);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(147, 22);
            this.txtSob.TabIndex = 4;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(423, 205);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(147, 22);
            this.txtFilename.TabIndex = 5;
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(124, 295);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(148, 71);
            this.btnGhi.TabIndex = 6;
            this.btnGhi.Text = "Ghi USCLN";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(447, 295);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(168, 71);
            this.btnDoc.TabIndex = 7;
            this.btnDoc.Text = "Đọc File";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 461);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoa;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnDoc;
    }
}

