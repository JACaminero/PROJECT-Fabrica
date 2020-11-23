namespace PROJECT_Fabrica.View.AdminView
{
    partial class UCRegistrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtQueryID = new System.Windows.Forms.TextBox();
            this.LBUser = new System.Windows.Forms.Label();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CBDepart = new System.Windows.Forms.ComboBox();
            this.LBDepart = new System.Windows.Forms.Label();
            this.LBConfirm = new System.Windows.Forms.Label();
            this.TxtConfirmar = new System.Windows.Forms.MaskedTextBox();
            this.LbContra = new System.Windows.Forms.Label();
            this.TxtContrasena = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RBTrabajador = new System.Windows.Forms.RadioButton();
            this.RBSuperv = new System.Windows.Forms.RadioButton();
            this.RBAdmin = new System.Windows.Forms.RadioButton();
            this.BtnModif = new System.Windows.Forms.Button();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.lbRol = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpia = new System.Windows.Forms.Button();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.BtnShowAll = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtQueryNombre = new System.Windows.Forms.TextBox();
            this.BtnQueryNombre = new System.Windows.Forms.Button();
            this.BtnQueryID = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DataGVTrabajador = new System.Windows.Forms.DataGridView();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MTxtCedula = new System.Windows.Forms.MaskedTextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTrabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtQueryID
            // 
            this.TxtQueryID.Font = new System.Drawing.Font("Century", 9.75F);
            this.TxtQueryID.Location = new System.Drawing.Point(13, 29);
            this.TxtQueryID.Name = "TxtQueryID";
            this.TxtQueryID.Size = new System.Drawing.Size(121, 23);
            this.TxtQueryID.TabIndex = 186;
            this.TxtQueryID.TextChanged += new System.EventHandler(this.TxtQueryID_TextChanged);
            // 
            // LBUser
            // 
            this.LBUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBUser.AutoSize = true;
            this.LBUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBUser.Location = new System.Drawing.Point(746, 267);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(54, 17);
            this.LBUser.TabIndex = 185;
            this.LBUser.Text = "Usuario";
            this.LBUser.Visible = false;
            // 
            // TxtUser
            // 
            this.TxtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUser.Location = new System.Drawing.Point(746, 287);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(163, 20);
            this.TxtUser.TabIndex = 184;
            this.TxtUser.Visible = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(557, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 17);
            this.label15.TabIndex = 183;
            this.label15.Text = "Nombre";
            // 
            // CBDepart
            // 
            this.CBDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDepart.FormattingEnabled = true;
            this.CBDepart.Location = new System.Drawing.Point(559, 356);
            this.CBDepart.Name = "CBDepart";
            this.CBDepart.Size = new System.Drawing.Size(163, 21);
            this.CBDepart.TabIndex = 181;
            this.CBDepart.Visible = false;
            // 
            // LBDepart
            // 
            this.LBDepart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBDepart.AutoSize = true;
            this.LBDepart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBDepart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBDepart.Location = new System.Drawing.Point(559, 336);
            this.LBDepart.Name = "LBDepart";
            this.LBDepart.Size = new System.Drawing.Size(96, 17);
            this.LBDepart.TabIndex = 182;
            this.LBDepart.Text = "Departamento";
            this.LBDepart.Visible = false;
            // 
            // LBConfirm
            // 
            this.LBConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBConfirm.AutoSize = true;
            this.LBConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LBConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBConfirm.Location = new System.Drawing.Point(746, 363);
            this.LBConfirm.Name = "LBConfirm";
            this.LBConfirm.Size = new System.Drawing.Size(141, 17);
            this.LBConfirm.TabIndex = 180;
            this.LBConfirm.Text = "Confirmar Contraseña";
            this.LBConfirm.Visible = false;
            // 
            // TxtConfirmar
            // 
            this.TxtConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtConfirmar.Location = new System.Drawing.Point(746, 383);
            this.TxtConfirmar.Name = "TxtConfirmar";
            this.TxtConfirmar.PasswordChar = '*';
            this.TxtConfirmar.Size = new System.Drawing.Size(163, 20);
            this.TxtConfirmar.TabIndex = 179;
            this.TxtConfirmar.Visible = false;
            // 
            // LbContra
            // 
            this.LbContra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbContra.AutoSize = true;
            this.LbContra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LbContra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LbContra.Location = new System.Drawing.Point(746, 313);
            this.LbContra.Name = "LbContra";
            this.LbContra.Size = new System.Drawing.Size(77, 17);
            this.LbContra.TabIndex = 178;
            this.LbContra.Text = "Contraseña";
            this.LbContra.Visible = false;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtContrasena.Location = new System.Drawing.Point(746, 333);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.PasswordChar = '*';
            this.TxtContrasena.Size = new System.Drawing.Size(163, 20);
            this.TxtContrasena.TabIndex = 177;
            this.TxtContrasena.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(743, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 176;
            this.label7.Text = "Cargo";
            // 
            // RBTrabajador
            // 
            this.RBTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTrabajador.AutoSize = true;
            this.RBTrabajador.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.RBTrabajador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RBTrabajador.Location = new System.Drawing.Point(746, 238);
            this.RBTrabajador.Name = "RBTrabajador";
            this.RBTrabajador.Size = new System.Drawing.Size(80, 17);
            this.RBTrabajador.TabIndex = 175;
            this.RBTrabajador.TabStop = true;
            this.RBTrabajador.Text = "Trabajador";
            this.RBTrabajador.UseVisualStyleBackColor = true;
            this.RBTrabajador.CheckedChanged += new System.EventHandler(this.RBTrabajador_CheckedChanged);
            // 
            // RBSuperv
            // 
            this.RBSuperv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBSuperv.AutoSize = true;
            this.RBSuperv.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.RBSuperv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RBSuperv.Location = new System.Drawing.Point(746, 202);
            this.RBSuperv.Name = "RBSuperv";
            this.RBSuperv.Size = new System.Drawing.Size(79, 17);
            this.RBSuperv.TabIndex = 174;
            this.RBSuperv.TabStop = true;
            this.RBSuperv.Text = "Supervisor";
            this.RBSuperv.UseVisualStyleBackColor = true;
            this.RBSuperv.CheckedChanged += new System.EventHandler(this.RBSuperv_CheckedChanged);
            // 
            // RBAdmin
            // 
            this.RBAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBAdmin.AutoSize = true;
            this.RBAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.RBAdmin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RBAdmin.Location = new System.Drawing.Point(746, 169);
            this.RBAdmin.Name = "RBAdmin";
            this.RBAdmin.Size = new System.Drawing.Size(98, 17);
            this.RBAdmin.TabIndex = 173;
            this.RBAdmin.TabStop = true;
            this.RBAdmin.Text = "Administrador";
            this.RBAdmin.UseVisualStyleBackColor = true;
            this.RBAdmin.CheckedChanged += new System.EventHandler(this.RBAdmin_CheckedChanged);
            // 
            // BtnModif
            // 
            this.BtnModif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModif.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnModif.ForeColor = System.Drawing.Color.White;
            this.BtnModif.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnModif.Location = new System.Drawing.Point(557, 500);
            this.BtnModif.Name = "BtnModif";
            this.BtnModif.Size = new System.Drawing.Size(158, 57);
            this.BtnModif.TabIndex = 172;
            this.BtnModif.Text = "Modificar";
            this.BtnModif.UseVisualStyleBackColor = false;
            this.BtnModif.Click += new System.EventHandler(this.BtnModif_Click);
            // 
            // CBRol
            // 
            this.CBRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(559, 401);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(163, 21);
            this.CBRol.TabIndex = 155;
            this.CBRol.Visible = false;
            // 
            // lbRol
            // 
            this.lbRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRol.AutoSize = true;
            this.lbRol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbRol.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbRol.Location = new System.Drawing.Point(557, 381);
            this.lbRol.Name = "lbRol";
            this.lbRol.Size = new System.Drawing.Size(56, 17);
            this.lbRol.TabIndex = 171;
            this.lbRol.Text = "Funcion";
            this.lbRol.Visible = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(559, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 170;
            this.label13.Text = "Codigo";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCodigo.Location = new System.Drawing.Point(559, 119);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(110, 20);
            this.TxtCodigo.TabIndex = 169;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEliminar.Location = new System.Drawing.Point(749, 437);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(158, 57);
            this.BtnEliminar.TabIndex = 157;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnLimpia
            // 
            this.BtnLimpia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnLimpia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpia.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnLimpia.ForeColor = System.Drawing.Color.White;
            this.BtnLimpia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnLimpia.Location = new System.Drawing.Point(749, 500);
            this.BtnLimpia.Name = "BtnLimpia";
            this.BtnLimpia.Size = new System.Drawing.Size(158, 57);
            this.BtnLimpia.TabIndex = 158;
            this.BtnLimpia.Text = "Limpiar";
            this.BtnLimpia.UseVisualStyleBackColor = false;
            this.BtnLimpia.Click += new System.EventHandler(this.BtnLimpia_Click);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTelefono.Location = new System.Drawing.Point(559, 262);
            this.TxtTelefono.Mask = "(000)000-0000";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(124, 20);
            this.TxtTelefono.TabIndex = 153;
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnShowAll.ForeColor = System.Drawing.Color.White;
            this.BtnShowAll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnShowAll.Location = new System.Drawing.Point(405, 30);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(98, 69);
            this.BtnShowAll.TabIndex = 162;
            this.BtnShowAll.Text = "Mostrar Todos los Registros";
            this.BtnShowAll.UseVisualStyleBackColor = false;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(170, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 19);
            this.label10.TabIndex = 168;
            this.label10.Text = "Filtrar por Nombre y Apellido";
            // 
            // TxtQueryNombre
            // 
            this.TxtQueryNombre.Font = new System.Drawing.Font("Century", 9.75F);
            this.TxtQueryNombre.Location = new System.Drawing.Point(173, 30);
            this.TxtQueryNombre.Name = "TxtQueryNombre";
            this.TxtQueryNombre.Size = new System.Drawing.Size(211, 23);
            this.TxtQueryNombre.TabIndex = 160;
            this.TxtQueryNombre.TextChanged += new System.EventHandler(this.TxtQueryNombre_TextChanged);
            // 
            // BtnQueryNombre
            // 
            this.BtnQueryNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnQueryNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQueryNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnQueryNombre.ForeColor = System.Drawing.Color.White;
            this.BtnQueryNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnQueryNombre.Location = new System.Drawing.Point(174, 59);
            this.BtnQueryNombre.Name = "BtnQueryNombre";
            this.BtnQueryNombre.Size = new System.Drawing.Size(83, 40);
            this.BtnQueryNombre.TabIndex = 161;
            this.BtnQueryNombre.Text = "Buscar";
            this.BtnQueryNombre.UseVisualStyleBackColor = false;
            this.BtnQueryNombre.Click += new System.EventHandler(this.BtnQueryNombre_Click);
            // 
            // BtnQueryID
            // 
            this.BtnQueryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnQueryID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQueryID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnQueryID.ForeColor = System.Drawing.Color.White;
            this.BtnQueryID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnQueryID.Location = new System.Drawing.Point(13, 59);
            this.BtnQueryID.Name = "BtnQueryID";
            this.BtnQueryID.Size = new System.Drawing.Size(83, 40);
            this.BtnQueryID.TabIndex = 159;
            this.BtnQueryID.Text = "Buscar";
            this.BtnQueryID.UseVisualStyleBackColor = false;
            this.BtnQueryID.Click += new System.EventHandler(this.BtnQueryID_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(10, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 19);
            this.label11.TabIndex = 167;
            this.label11.Text = "Filtrar por Codigo ";
            // 
            // DataGVTrabajador
            // 
            this.DataGVTrabajador.AllowUserToAddRows = false;
            this.DataGVTrabajador.AllowUserToDeleteRows = false;
            this.DataGVTrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGVTrabajador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataGVTrabajador.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DataGVTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGVTrabajador.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVTrabajador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGVTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGVTrabajador.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGVTrabajador.GridColor = System.Drawing.Color.Honeydew;
            this.DataGVTrabajador.Location = new System.Drawing.Point(13, 105);
            this.DataGVTrabajador.MultiSelect = false;
            this.DataGVTrabajador.Name = "DataGVTrabajador";
            this.DataGVTrabajador.ReadOnly = true;
            this.DataGVTrabajador.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGVTrabajador.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGVTrabajador.RowHeadersVisible = false;
            this.DataGVTrabajador.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGVTrabajador.Size = new System.Drawing.Size(528, 399);
            this.DataGVTrabajador.TabIndex = 166;
            this.DataGVTrabajador.DataSourceChanged += new System.EventHandler(this.DataGVTrabajador_DataSourceChanged);
            this.DataGVTrabajador.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVTrabajador_CellClick);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(22)))), ((int)(((byte)(163)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnGuardar.Location = new System.Drawing.Point(557, 437);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(158, 57);
            this.BtnGuardar.TabIndex = 156;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(559, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 165;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(559, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 164;
            this.label5.Text = "Cedula";
            // 
            // MTxtCedula
            // 
            this.MTxtCedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MTxtCedula.Location = new System.Drawing.Point(559, 310);
            this.MTxtCedula.Mask = "000-0000000-0";
            this.MTxtCedula.Name = "MTxtCedula";
            this.MTxtCedula.Size = new System.Drawing.Size(163, 20);
            this.MTxtCedula.TabIndex = 154;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellido.Location = new System.Drawing.Point(559, 214);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(163, 20);
            this.TxtApellido.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(558, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 163;
            this.label3.Text = "Apellidos";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombre.Location = new System.Drawing.Point(559, 165);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(163, 20);
            this.TxtNombre.TabIndex = 151;
            // 
            // UCRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtQueryID);
            this.Controls.Add(this.LBUser);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CBDepart);
            this.Controls.Add(this.LBDepart);
            this.Controls.Add(this.LBConfirm);
            this.Controls.Add(this.TxtConfirmar);
            this.Controls.Add(this.LbContra);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RBTrabajador);
            this.Controls.Add(this.RBSuperv);
            this.Controls.Add(this.RBAdmin);
            this.Controls.Add(this.BtnModif);
            this.Controls.Add(this.CBRol);
            this.Controls.Add(this.lbRol);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnLimpia);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.BtnShowAll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtQueryNombre);
            this.Controls.Add(this.BtnQueryNombre);
            this.Controls.Add(this.BtnQueryID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DataGVTrabajador);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MTxtCedula);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Name = "UCRegistrar";
            this.Size = new System.Drawing.Size(992, 512);
            this.Load += new System.EventHandler(this.UCRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVTrabajador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtQueryID;
        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CBDepart;
        private System.Windows.Forms.Label LBDepart;
        private System.Windows.Forms.Label LBConfirm;
        private System.Windows.Forms.MaskedTextBox TxtConfirmar;
        private System.Windows.Forms.Label LbContra;
        private System.Windows.Forms.MaskedTextBox TxtContrasena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton RBTrabajador;
        private System.Windows.Forms.RadioButton RBSuperv;
        private System.Windows.Forms.RadioButton RBAdmin;
        private System.Windows.Forms.Button BtnModif;
        private System.Windows.Forms.ComboBox CBRol;
        private System.Windows.Forms.Label lbRol;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpia;
        private System.Windows.Forms.MaskedTextBox TxtTelefono;
        private System.Windows.Forms.Button BtnShowAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtQueryNombre;
        private System.Windows.Forms.Button BtnQueryNombre;
        private System.Windows.Forms.Button BtnQueryID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DataGVTrabajador;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MTxtCedula;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
    }
}
