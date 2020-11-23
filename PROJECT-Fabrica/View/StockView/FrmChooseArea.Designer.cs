namespace PROJECT_Fabrica.View.StockView
{
    partial class FrmChooseArea
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
            this.CBArea = new System.Windows.Forms.ComboBox();
            this.LBDepart = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBAlmacen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBArea
            // 
            this.CBArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBArea.FormattingEnabled = true;
            this.CBArea.Location = new System.Drawing.Point(30, 160);
            this.CBArea.Name = "CBArea";
            this.CBArea.Size = new System.Drawing.Size(163, 21);
            this.CBArea.TabIndex = 182;
            // 
            // LBDepart
            // 
            this.LBDepart.AutoSize = true;
            this.LBDepart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBDepart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBDepart.Location = new System.Drawing.Point(28, 140);
            this.LBDepart.Name = "LBDepart";
            this.LBDepart.Size = new System.Drawing.Size(36, 17);
            this.LBDepart.TabIndex = 183;
            this.LBDepart.Text = "Area";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancelar.Location = new System.Drawing.Point(163, 198);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(112, 39);
            this.BtnCancelar.TabIndex = 186;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAceptar.ForeColor = System.Drawing.Color.White;
            this.BtnAceptar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAceptar.Location = new System.Drawing.Point(31, 198);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(112, 39);
            this.BtnAceptar.TabIndex = 187;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 189;
            this.label1.Text = "Almacen";
            // 
            // CBAlmacen
            // 
            this.CBAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAlmacen.FormattingEnabled = true;
            this.CBAlmacen.Location = new System.Drawing.Point(31, 116);
            this.CBAlmacen.Name = "CBAlmacen";
            this.CBAlmacen.Size = new System.Drawing.Size(163, 21);
            this.CBAlmacen.TabIndex = 188;
            this.CBAlmacen.SelectedIndexChanged += new System.EventHandler(this.CBAlmacen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(25, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 56);
            this.label2.TabIndex = 190;
            this.label2.Text = "Seleccione el almacen donde \r\nse guardaron los royos";
            // 
            // FrmChooseArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 273);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBAlmacen);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LBDepart);
            this.Controls.Add(this.CBArea);
            this.Name = "FrmChooseArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Almacen";
            this.Load += new System.EventHandler(this.FrmChooseArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CBArea;
        private System.Windows.Forms.Label LBDepart;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBAlmacen;
        private System.Windows.Forms.Label label2;
    }
}