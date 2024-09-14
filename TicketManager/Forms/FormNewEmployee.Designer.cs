namespace TicketManager.Forms
{
    partial class FormNewEmployee
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
            label1 = new System.Windows.Forms.Label();
            textName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textCPF = new System.Windows.Forms.MaskedTextBox();
            label3 = new System.Windows.Forms.Label();
            cbStatus = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            textID = new System.Windows.Forms.TextBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbStatus);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textCPF);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textName);
            groupBox2.Controls.Add(label1);
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnClean
            // 
            btnClean.Click += btnClean_Click;
            // 
            // btnClose
            // 
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(556, 91);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 29);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // textName
            // 
            textName.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textName.Location = new System.Drawing.Point(403, 123);
            textName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textName.Name = "textName";
            textName.Size = new System.Drawing.Size(392, 37);
            textName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(570, 163);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 29);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // textCPF
            // 
            textCPF.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textCPF.Location = new System.Drawing.Point(498, 195);
            textCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textCPF.Mask = "000.000.000-00";
            textCPF.Name = "textCPF";
            textCPF.Size = new System.Drawing.Size(204, 37);
            textCPF.TabIndex = 3;
            textCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(556, 235);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 29);
            label3.TabIndex = 5;
            label3.Text = "Status";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "A", "I" });
            cbStatus.Location = new System.Drawing.Point(540, 267);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(121, 23);
            cbStatus.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(570, 19);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 29);
            label4.TabIndex = 7;
            label4.Text = "ID";
            // 
            // textID
            // 
            textID.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textID.Location = new System.Drawing.Point(556, 51);
            textID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textID.Name = "textID";
            textID.ReadOnly = true;
            textID.Size = new System.Drawing.Size(83, 37);
            textID.TabIndex = 8;
            // 
            // FormNewEmployee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            ClientSize = new System.Drawing.Size(1241, 786);
            Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            Name = "FormNewEmployee";
            Text = "Novo Funcionario";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.MaskedTextBox textCPF;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.TextBox textID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
    }
}
