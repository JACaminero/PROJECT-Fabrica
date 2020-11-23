namespace PROJECT_Fabrica.View
{
    partial class UCSalidaStock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBAlmacen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVStock = new System.Windows.Forms.DataGridView();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.CBArea = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBArea = new System.Windows.Forms.Label();
            this.LBAlmacen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtExistencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRef = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LBDepart = new System.Windows.Forms.Label();
            this.BtnLote = new System.Windows.Forms.Button();
            this.TxtRoyoCant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRoyoCant)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtLote
            // 
            this.TxtLote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLote.Location = new System.Drawing.Point(14, 230);
            this.TxtLote.Name = "TxtLote";
            this.TxtLote.ReadOnly = true;
            this.TxtLote.Size = new System.Drawing.Size(129, 20);
            this.TxtLote.TabIndex = 185;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(14, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 186;
            this.label3.Text = "Lote #";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 188;
            this.label1.Text = "Referencias";
            // 
            // CBAlmacen
            // 
            this.CBAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAlmacen.FormattingEnabled = true;
            this.CBAlmacen.Location = new System.Drawing.Point(444, 26);
            this.CBAlmacen.Name = "CBAlmacen";
            this.CBAlmacen.Size = new System.Drawing.Size(175, 21);
            this.CBAlmacen.TabIndex = 188;
            this.CBAlmacen.SelectedIndexChanged += new System.EventHandler(this.CBAlmacen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(441, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 189;
            this.label2.Text = "Seleccione Almacen";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(441, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 190;
            this.label4.Text = "Seleccione Area";
            // 
            // DGVStock
            // 
            this.DGVStock.AllowUserToAddRows = false;
            this.DGVStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStock.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVStock.ColumnHeadersHeight = 50;
            this.DGVStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVStock.DefaultCellStyle = dataGridViewCellStyle7;
            this.DGVStock.EnableHeadersVisualStyles = false;
            this.DGVStock.GridColor = System.Drawing.Color.White;
            this.DGVStock.Location = new System.Drawing.Point(3, 37);
            this.DGVStock.MultiSelect = false;
            this.DGVStock.Name = "DGVStock";
            this.DGVStock.ReadOnly = true;
            this.DGVStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGVStock.RowHeadersVisible = false;
            this.DGVStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStock.Size = new System.Drawing.Size(419, 386);
            this.DGVStock.TabIndex = 191;
            this.DGVStock.TabStop = false;
            this.DGVStock.Visible = false;
            this.DGVStock.DataSourceChanged += new System.EventHandler(this.DGVStock_DataSourceChanged);
            this.DGVStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellClick);
            this.DGVStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStock_CellContentClick);
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnShowAll.ForeColor = System.Drawing.Color.White;
            this.BtnShowAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnShowAll.Location = new System.Drawing.Point(662, 42);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(142, 55);
            this.BtnShowAll.TabIndex = 192;
            this.BtnShowAll.Text = "Mostrar Todas las Referencias";
            this.BtnShowAll.UseVisualStyleBackColor = false;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // CBArea
            // 
            this.CBArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArea.FormattingEnabled = true;
            this.CBArea.Location = new System.Drawing.Point(444, 76);
            this.CBArea.Name = "CBArea";
            this.CBArea.Size = new System.Drawing.Size(175, 21);
            this.CBArea.TabIndex = 193;
            this.CBArea.SelectedValueChanged += new System.EventHandler(this.CBArea_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(227)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.TxtRoyoCant);
            this.panel1.Controls.Add(this.LBArea);
            this.panel1.Controls.Add(this.BtnLote);
            this.panel1.Controls.Add(this.LBDepart);
            this.panel1.Controls.Add(this.LBAlmacen);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtLote);
            this.panel1.Controls.Add(this.TxtDescrip);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtExistencia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtRef);
            this.panel1.Controls.Add(this.label6);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(444, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 311);
            this.panel1.TabIndex = 190;
            // 
            // LBArea
            // 
            this.LBArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBArea.AutoSize = true;
            this.LBArea.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBArea.ForeColor = System.Drawing.Color.Black;
            this.LBArea.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBArea.Location = new System.Drawing.Point(194, 54);
            this.LBArea.Name = "LBArea";
            this.LBArea.Size = new System.Drawing.Size(39, 17);
            this.LBArea.TabIndex = 193;
            this.LBArea.Text = "Area:";
            // 
            // LBAlmacen
            // 
            this.LBAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBAlmacen.AutoSize = true;
            this.LBAlmacen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBAlmacen.ForeColor = System.Drawing.Color.Black;
            this.LBAlmacen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBAlmacen.Location = new System.Drawing.Point(194, 28);
            this.LBAlmacen.Name = "LBAlmacen";
            this.LBAlmacen.Size = new System.Drawing.Size(63, 17);
            this.LBAlmacen.TabIndex = 192;
            this.LBAlmacen.Text = "Almacen:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(194, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 191;
            this.label8.Text = "Localizacion";
            // 
            // TxtDescrip
            // 
            this.TxtDescrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescrip.Location = new System.Drawing.Point(12, 136);
            this.TxtDescrip.Multiline = true;
            this.TxtDescrip.Name = "TxtDescrip";
            this.TxtDescrip.ReadOnly = true;
            this.TxtDescrip.Size = new System.Drawing.Size(139, 45);
            this.TxtDescrip.TabIndex = 190;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(12, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 189;
            this.label7.Text = "Descripcion";
            // 
            // TxtExistencia
            // 
            this.TxtExistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtExistencia.Location = new System.Drawing.Point(12, 77);
            this.TxtExistencia.Name = "TxtExistencia";
            this.TxtExistencia.ReadOnly = true;
            this.TxtExistencia.Size = new System.Drawing.Size(77, 30);
            this.TxtExistencia.TabIndex = 188;
            this.TxtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 184;
            this.label5.Text = "Existencia Actual";
            // 
            // TxtRef
            // 
            this.TxtRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtRef.Location = new System.Drawing.Point(12, 28);
            this.TxtRef.Name = "TxtRef";
            this.TxtRef.ReadOnly = true;
            this.TxtRef.Size = new System.Drawing.Size(83, 20);
            this.TxtRef.TabIndex = 184;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 187;
            this.label6.Text = "Referencia";
            // 
            // LBDepart
            // 
            this.LBDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBDepart.AutoSize = true;
            this.LBDepart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBDepart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBDepart.Location = new System.Drawing.Point(14, 259);
            this.LBDepart.Name = "LBDepart";
            this.LBDepart.Size = new System.Drawing.Size(116, 17);
            this.LBDepart.TabIndex = 184;
            this.LBDepart.Text = "Cantidad Retirada";
            // 
            // BtnLote
            // 
            this.BtnLote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLote.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnLote.ForeColor = System.Drawing.Color.White;
            this.BtnLote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLote.Location = new System.Drawing.Point(167, 254);
            this.BtnLote.Name = "BtnLote";
            this.BtnLote.Size = new System.Drawing.Size(142, 45);
            this.BtnLote.TabIndex = 189;
            this.BtnLote.Text = "Sacar Lote";
            this.BtnLote.UseVisualStyleBackColor = false;
            this.BtnLote.Click += new System.EventHandler(this.BtnLote_Click);
            // 
            // TxtRoyoCant
            // 
            this.TxtRoyoCant.Location = new System.Drawing.Point(14, 279);
            this.TxtRoyoCant.Name = "TxtRoyoCant";
            this.TxtRoyoCant.Size = new System.Drawing.Size(120, 20);
            this.TxtRoyoCant.TabIndex = 194;
            // 
            // UCSalidaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.CBArea);
            this.Controls.Add(this.BtnShowAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBAlmacen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVStock);
            this.Controls.Add(this.panel1);
            this.Name = "UCSalidaStock";
            this.Size = new System.Drawing.Size(854, 437);
            this.Load += new System.EventHandler(this.UCSalidaStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRoyoCant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBAlmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGVStock;
        private System.Windows.Forms.Button BtnShowAll;
        private System.Windows.Forms.ComboBox CBArea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBArea;
        private System.Windows.Forms.Label LBAlmacen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtExistencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtRef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBDepart;
        private System.Windows.Forms.Button BtnLote;
        private System.Windows.Forms.NumericUpDown TxtRoyoCant;
    }
}
