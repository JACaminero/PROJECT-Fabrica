namespace PROJECT_Fabrica.View
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.BtnEntrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCloseSession = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnSalida = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LBHeader = new System.Windows.Forms.Label();
            this.ucEntradaStock1 = new PROJECT_Fabrica.View.StockView.UCEntradaStock();
            this.ucSalidaStock1 = new PROJECT_Fabrica.View.UCSalidaStock();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEntrada
            // 
            this.BtnEntrada.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntrada.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnEntrada, "BtnEntrada");
            this.BtnEntrada.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnEntrada.Name = "BtnEntrada";
            this.BtnEntrada.UseVisualStyleBackColor = false;
            this.BtnEntrada.Click += new System.EventHandler(this.BtnEntrada_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // TxtUsuario
            // 
            resources.ApplyResources(this.TxtUsuario, "TxtUsuario");
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.BtnCloseSession);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnSalida);
            this.panel1.Controls.Add(this.BtnEntrada);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // BtnCloseSession
            // 
            this.BtnCloseSession.BackColor = System.Drawing.Color.Transparent;
            this.BtnCloseSession.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnCloseSession, "BtnCloseSession");
            this.BtnCloseSession.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCloseSession.Name = "BtnCloseSession";
            this.BtnCloseSession.UseVisualStyleBackColor = false;
            this.BtnCloseSession.Click += new System.EventHandler(this.BtnCloseSession_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // BtnSalida
            // 
            this.BtnSalida.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalida.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnSalida, "BtnSalida");
            this.BtnSalida.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSalida.Name = "BtnSalida";
            this.BtnSalida.UseVisualStyleBackColor = false;
            this.BtnSalida.Click += new System.EventHandler(this.BtnSalida_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.LBHeader);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LBHeader
            // 
            resources.ApplyResources(this.LBHeader, "LBHeader");
            this.LBHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(87)))));
            this.LBHeader.ForeColor = System.Drawing.Color.White;
            this.LBHeader.Name = "LBHeader";
            // 
            // ucEntradaStock1
            // 
            this.ucEntradaStock1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucEntradaStock1, "ucEntradaStock1");
            this.ucEntradaStock1.Name = "ucEntradaStock1";
            // 
            // ucSalidaStock1
            // 
            this.ucSalidaStock1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.ucSalidaStock1, "ucSalidaStock1");
            this.ucSalidaStock1.Name = "ucSalidaStock1";
            // 
            // FrmStock
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucSalidaStock1);
            this.Controls.Add(this.ucEntradaStock1);
            this.Name = "FrmStock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEntrada;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCloseSession;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnSalida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LBHeader;
        private StockView.UCEntradaStock ucEntradaStock1;
        private UCSalidaStock ucSalidaStock1;
    }
}