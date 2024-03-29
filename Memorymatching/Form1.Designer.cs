namespace Memorymatching
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTaoForm = new System.Windows.Forms.Button();
            this.txtSodong = new System.Windows.Forms.TextBox();
            this.txtSocot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số dòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số cột";
            // 
            // btnTaoForm
            // 
            this.btnTaoForm.Location = new System.Drawing.Point(300, 52);
            this.btnTaoForm.Name = "btnTaoForm";
            this.btnTaoForm.Size = new System.Drawing.Size(109, 49);
            this.btnTaoForm.TabIndex = 2;
            this.btnTaoForm.Text = "Tạo Form";
            this.btnTaoForm.UseVisualStyleBackColor = true;
            this.btnTaoForm.Click += new System.EventHandler(this.btnTaoForm_Click);
            // 
            // txtSodong
            // 
            this.txtSodong.Location = new System.Drawing.Point(124, 41);
            this.txtSodong.Name = "txtSodong";
            this.txtSodong.Size = new System.Drawing.Size(143, 22);
            this.txtSodong.TabIndex = 3;
            // 
            // txtSocot
            // 
            this.txtSocot.Location = new System.Drawing.Point(124, 90);
            this.txtSocot.Name = "txtSocot";
            this.txtSocot.Size = new System.Drawing.Size(143, 22);
            this.txtSocot.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 158);
            this.Controls.Add(this.txtSocot);
            this.Controls.Add(this.txtSodong);
            this.Controls.Add(this.btnTaoForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nhập liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTaoForm;
        private System.Windows.Forms.TextBox txtSodong;
        private System.Windows.Forms.TextBox txtSocot;
    }
}

