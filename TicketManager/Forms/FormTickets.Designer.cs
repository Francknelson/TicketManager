namespace TicketManager.Forms
{
    partial class FormTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTickets));
            groupBox2 = new System.Windows.Forms.GroupBox();
            dtTickets = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            bntRefresh = new System.Windows.Forms.Button();
            imageList1 = new System.Windows.Forms.ImageList(components);
            btnSearch = new System.Windows.Forms.Button();
            textSearch = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtTickets).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtTickets);
            groupBox2.Location = new System.Drawing.Point(14, 135);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(1037, 533);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // dtTickets
            // 
            dtTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtTickets.Location = new System.Drawing.Point(18, 22);
            dtTickets.Name = "dtTickets";
            dtTickets.Size = new System.Drawing.Size(1012, 505);
            dtTickets.TabIndex = 0;
            dtTickets.CellContentDoubleClick += dtTickets_CellContentDoubleClick;
            dtTickets.CellDoubleClick += dtTickets_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(bntRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(textSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Location = new System.Drawing.Point(14, 13);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(1037, 115);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // bntRefresh
            // 
            bntRefresh.FlatAppearance.BorderSize = 0;
            bntRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bntRefresh.ImageKey = "recarregar.png";
            bntRefresh.ImageList = imageList1;
            bntRefresh.Location = new System.Drawing.Point(524, 34);
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
            btnSearch.Location = new System.Drawing.Point(417, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(101, 52);
            btnSearch.TabIndex = 4;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textSearch
            // 
            textSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            textSearch.Location = new System.Drawing.Point(131, 47);
            textSearch.Name = "textSearch";
            textSearch.Size = new System.Drawing.Size(280, 27);
            textSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(19, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(101, 18);
            label1.TabIndex = 2;
            label1.Text = "Funcionario";
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
            // FormTickets
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1064, 681);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormTickets";
            Text = "FormTickets";
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtTickets).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtTickets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button bntRefresh;
    }
}