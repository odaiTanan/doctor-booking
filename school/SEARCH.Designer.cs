namespace school
{
    partial class SEARCH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEARCH));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sr = new System.Windows.Forms.Button();
            this.dvg = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.q = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(553, 44);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(409, 24);
            this.txtsearch.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(436, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sr
            // 
            this.sr.BackColor = System.Drawing.Color.Black;
            this.sr.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sr.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.sr.Location = new System.Drawing.Point(677, 88);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(157, 47);
            this.sr.TabIndex = 9;
            this.sr.Text = "Search";
            this.sr.UseVisualStyleBackColor = false;
            this.sr.Click += new System.EventHandler(this.sr_Click);
            // 
            // dvg
            // 
            this.dvg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            this.dvg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvg.GridColor = System.Drawing.Color.Gray;
            this.dvg.Location = new System.Drawing.Point(0, 164);
            this.dvg.Name = "dvg";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvg.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg.RowTemplate.Height = 26;
            this.dvg.Size = new System.Drawing.Size(1501, 614);
            this.dvg.TabIndex = 10;
            this.dvg.Visible = false;
            // 
            // c1
            // 
            this.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.c1.HeaderText = "Name";
            this.c1.Name = "c1";
            this.c1.ToolTipText = "person name";
            // 
            // c2
            // 
            this.c2.HeaderText = "Date";
            this.c2.Name = "c2";
            this.c2.Width = 200;
            // 
            // c3
            // 
            this.c3.HeaderText = "Time";
            this.c3.Name = "c3";
            this.c3.Width = 200;
            // 
            // c4
            // 
            this.c4.HeaderText = "Note";
            this.c4.Name = "c4";
            this.c4.Width = 400;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 614);
            this.panel1.TabIndex = 11;
            // 
            // q
            // 
            this.q.BackColor = System.Drawing.Color.Black;
            this.q.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.q.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.q.Location = new System.Drawing.Point(0, -2);
            this.q.Name = "q";
            this.q.Size = new System.Drawing.Size(98, 36);
            this.q.TabIndex = 12;
            this.q.Text = "BACK";
            this.q.UseVisualStyleBackColor = false;
            this.q.Click += new System.EventHandler(this.q_Click);
            // 
            // SEARCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1501, 778);
            this.Controls.Add(this.q);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dvg);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label3);
            this.Name = "SEARCH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEARCH";
            this.Load += new System.EventHandler(this.SEARCH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sr;
        private System.Windows.Forms.DataGridView dvg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.Button q;
    }
}