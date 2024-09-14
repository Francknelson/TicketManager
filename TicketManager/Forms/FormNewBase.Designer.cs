namespace TicketManager.Forms
{
    partial class FormNewBase
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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnClean);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(1213, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnSave.Location = new System.Drawing.Point(667, 22);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(175, 69);
            btnSave.TabIndex = 3;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            btnClean.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClean.Location = new System.Drawing.Point(849, 22);
            btnClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClean.Name = "btnClean";
            btnClean.Size = new System.Drawing.Size(175, 69);
            btnClean.TabIndex = 2;
            btnClean.Text = "Limpar";
            btnClean.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Location = new System.Drawing.Point(1031, 22);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(175, 69);
            btnClose.TabIndex = 1;
            btnClose.Text = "Voltar";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Location = new System.Drawing.Point(14, 136);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(1213, 636);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // FormNewBase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1241, 786);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormNewBase";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FomularioBase";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btnClean;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnSave;
    }
}