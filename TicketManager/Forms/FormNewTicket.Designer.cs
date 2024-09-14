namespace TicketManager.Forms
{
    partial class FormNewTicket
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnSave = new System.Windows.Forms.Button();
            btnClean = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cbEmployees = new System.Windows.Forms.ComboBox();
            dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            textQuantity = new System.Windows.Forms.TextBox();
            textID = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            cbStatus = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnClean);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(1213, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Location = new System.Drawing.Point(660, 22);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(175, 69);
            btnSave.TabIndex = 6;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClean
            // 
            btnClean.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClean.Location = new System.Drawing.Point(842, 22);
            btnClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(175, 69);
            btnClean.TabIndex = 5;
            btnClean.Text = "Limpar";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Location = new System.Drawing.Point(1024, 22);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(175, 69);
            btnClose.TabIndex = 4;
            btnClose.Text = "Voltar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbEmployees);
            groupBox2.Controls.Add(dtpDeliveryDate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textQuantity);
            groupBox2.Controls.Add(textID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cbStatus);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(12, 133);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1213, 636);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // cbEmployees
            // 
            cbEmployees.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new System.Drawing.Point(447, 123);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new System.Drawing.Size(317, 26);
            cbEmployees.TabIndex = 20;
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpDeliveryDate.Location = new System.Drawing.Point(442, 276);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new System.Drawing.Size(317, 27);
            dtpDeliveryDate.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(493, 244);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(206, 29);
            label5.TabIndex = 18;
            label5.Text = "Data de Entrega";
            // 
            // textQuantity
            // 
            textQuantity.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textQuantity.Location = new System.Drawing.Point(524, 195);
            textQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new System.Drawing.Size(151, 37);
            textQuantity.TabIndex = 17;
            // 
            // textID
            // 
            textID.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textID.Location = new System.Drawing.Point(555, 51);
            textID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textID.Name = "textID";
            textID.ReadOnly = true;
            textID.Size = new System.Drawing.Size(83, 37);
            textID.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(569, 19);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 29);
            label4.TabIndex = 15;
            label4.Text = "ID";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "A", "I" });
            cbStatus.Location = new System.Drawing.Point(539, 350);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new System.Drawing.Size(121, 23);
            cbStatus.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(555, 318);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 29);
            label3.TabIndex = 13;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(526, 163);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(149, 29);
            label2.TabIndex = 11;
            label2.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(524, 91);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(151, 29);
            label1.TabIndex = 9;
            label1.Text = "Funcionario";
            // 
            // FormNewTicket
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1241, 786);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormNewTicket";
            Text = "Novo Ticket";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textID;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textQuantity;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnClean;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        public System.Windows.Forms.ComboBox cbEmployees;
    }
}