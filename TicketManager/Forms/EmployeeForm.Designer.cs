namespace TicketManager.Forms
{
    partial class EmployeeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            groupBox1 = new System.Windows.Forms.GroupBox();
            bntRefresh = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            btnSearch = new System.Windows.Forms.Button();
            textSearch = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            dtEmployees = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtEmployees).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bntRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(textSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(1037, 115);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // bntRefresh
            // 
            bntRefresh.FlatAppearance.BorderSize = 0;
            bntRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntRefresh.ImageKey = "recarregar.png";
            bntRefresh.ImageList = imageList1;
            bntRefresh.Location = new System.Drawing.Point(468, 31);
            bntRefresh.Name = "bntRefresh";
            bntRefresh.Size = new System.Drawing.Size(101, 52);
            bntRefresh.TabIndex = 5;
            bntRefresh.UseVisualStyleBackColor = true;
            bntRefresh.Click += bntRefresh_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "lupa (1).png");
            imageList1.Images.SetKeyName(1, "recarregar.png");
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.ImageKey = "lupa (1).png";
            btnSearch.ImageList = imageList1;
            btnSearch.Location = new System.Drawing.Point(365, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(101, 52);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textSearch
            // 
            textSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textSearch.Location = new System.Drawing.Point(79, 47);
            textSearch.Name = "textSearch";
            textSearch.Size = new System.Drawing.Size(280, 27);
            textSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(18, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 18);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // btnClose
            // 
            btnClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnClose.Location = new System.Drawing.Point(854, 25);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(175, 69);
            btnClose.TabIndex = 1;
            btnClose.Text = "Voltar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnNew.Location = new System.Drawing.Point(671, 25);
            btnNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(175, 69);
            btnNew.TabIndex = 0;
            btnNew.Text = "Novo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtEmployees);
            groupBox2.Location = new System.Drawing.Point(14, 136);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(1037, 533);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dtEmployees
            // 
            dtEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEmployees.Location = new System.Drawing.Point(18, 22);
            dtEmployees.Name = "dtEmployees";
            dtEmployees.Size = new System.Drawing.Size(1012, 505);
            dtEmployees.TabIndex = 0;
            dtEmployees.CellDoubleClick += dtEmployees_CellDoubleClick;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1064, 681);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EmployeeForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Funcionarios";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.DataGridView dtEmployees;
        private System.Windows.Forms.Button bntRefresh;
    }
}