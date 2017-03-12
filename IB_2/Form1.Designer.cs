namespace IB_2
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.txtbx_bin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_test_freq = new System.Windows.Forms.Label();
            this.lbl_test_seq = new System.Windows.Forms.Label();
            this.lbl_test_deviat = new System.Windows.Forms.Label();
            this.txtbx_amount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(12, 59);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(136, 23);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Сгенерировать";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txtbx_bin
            // 
            this.txtbx_bin.Location = new System.Drawing.Point(12, 88);
            this.txtbx_bin.Multiline = true;
            this.txtbx_bin.Name = "txtbx_bin";
            this.txtbx_bin.ReadOnly = true;
            this.txtbx_bin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_bin.Size = new System.Drawing.Size(428, 75);
            this.txtbx_bin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Частотный тест:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тест на последовательность одинаковых бит:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Расширенный тест на произвольные отклонения:";
            // 
            // lbl_test_freq
            // 
            this.lbl_test_freq.AutoSize = true;
            this.lbl_test_freq.Location = new System.Drawing.Point(465, 88);
            this.lbl_test_freq.Name = "lbl_test_freq";
            this.lbl_test_freq.Size = new System.Drawing.Size(0, 13);
            this.lbl_test_freq.TabIndex = 2;
            // 
            // lbl_test_seq
            // 
            this.lbl_test_seq.AutoSize = true;
            this.lbl_test_seq.Location = new System.Drawing.Point(465, 131);
            this.lbl_test_seq.Name = "lbl_test_seq";
            this.lbl_test_seq.Size = new System.Drawing.Size(0, 13);
            this.lbl_test_seq.TabIndex = 2;
            // 
            // lbl_test_deviat
            // 
            this.lbl_test_deviat.AutoSize = true;
            this.lbl_test_deviat.Location = new System.Drawing.Point(465, 175);
            this.lbl_test_deviat.Name = "lbl_test_deviat";
            this.lbl_test_deviat.Size = new System.Drawing.Size(0, 13);
            this.lbl_test_deviat.TabIndex = 2;
            // 
            // txtbx_amount
            // 
            this.txtbx_amount.Location = new System.Drawing.Point(172, 59);
            this.txtbx_amount.Name = "txtbx_amount";
            this.txtbx_amount.Size = new System.Drawing.Size(100, 20);
            this.txtbx_amount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 242);
            this.Controls.Add(this.txtbx_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_test_deviat);
            this.Controls.Add(this.lbl_test_seq);
            this.Controls.Add(this.lbl_test_freq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_bin);
            this.Controls.Add(this.btn_generate);
            this.Name = "Form1";
            this.Text = "AnsiX9.17";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txtbx_bin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_test_freq;
        private System.Windows.Forms.Label lbl_test_seq;
        private System.Windows.Forms.Label lbl_test_deviat;
        private System.Windows.Forms.TextBox txtbx_amount;
    }
}

