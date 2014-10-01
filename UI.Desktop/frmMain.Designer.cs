namespace UI.Desktop
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sttMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstPacientes = new System.Windows.Forms.ListView();
            this.colIdPaciente = new System.Windows.Forms.ColumnHeader();
            this.colTipoNumDoc = new System.Windows.Forms.ColumnHeader();
            this.colApellido = new System.Windows.Forms.ColumnHeader();
            this.colNombre = new System.Windows.Forms.ColumnHeader();
            this.colObraSocial = new System.Windows.Forms.ColumnHeader();
            this.colUltimaVisita = new System.Windows.Forms.ColumnHeader();
            this.colTelefono = new System.Windows.Forms.ColumnHeader();
            this.colDireccion = new System.Windows.Forms.ColumnHeader();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabListadoPacientes = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.txtBuscarPractica = new System.Windows.Forms.TabPage();
            this.grpPaciente = new System.Windows.Forms.GroupBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.lblCodigoPostal = new System.Windows.Forms.Label();
            this.lblDepto = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.btnEliminarObraSocial = new System.Windows.Forms.Button();
            this.btnAgregarObrasSociales = new System.Windows.Forms.Button();
            this.lstObrasSocialesPaciente = new System.Windows.Forms.ListBox();
            this.btnGuardarPaciente = new System.Windows.Forms.Button();
            this.btnDescartarPaciente = new System.Windows.Forms.Button();
            this.cbxFactorSanguineo = new System.Windows.Forms.ComboBox();
            this.lblFactorSanguineo = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cbxTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.cbxGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.grpHistoriaClinica = new System.Windows.Forms.GroupBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtProblemas = new System.Windows.Forms.TextBox();
            this.lblProblemas = new System.Windows.Forms.Label();
            this.grpConsultas = new System.Windows.Forms.GroupBox();
            this.tabConsultas = new System.Windows.Forms.TabControl();
            this.tabListadoConsultas = new System.Windows.Forms.TabPage();
            this.lstConsultas = new System.Windows.Forms.ListView();
            this.colIdConsulta = new System.Windows.Forms.ColumnHeader();
            this.colFecha = new System.Windows.Forms.ColumnHeader();
            this.colPractica = new System.Windows.Forms.ColumnHeader();
            this.colDiagnostico = new System.Windows.Forms.ColumnHeader();
            this.colDetalle = new System.Windows.Forms.ColumnHeader();
            this.btnEliminarConsulta = new System.Windows.Forms.Button();
            this.btnEditarConsulta = new System.Windows.Forms.Button();
            this.btnNuevaConsulta = new System.Windows.Forms.Button();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.grpDatosConsulta = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarDiagnostico = new System.Windows.Forms.Button();
            this.lstPracticaConsulta = new System.Windows.Forms.ListBox();
            this.lblPrestacion2 = new System.Windows.Forms.Label();
            this.btnGuardarConsulta = new System.Windows.Forms.Button();
            this.btnDescartarConsulta = new System.Windows.Forms.Button();
            this.lstDiagnosticoConsulta = new System.Windows.Forms.ListBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblPractica = new System.Windows.Forms.Label();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.txtDetalleConsulta = new System.Windows.Forms.TextBox();
            this.lblDetalleConsulta = new System.Windows.Forms.Label();
            this.lblFechaConsulta = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.tabDiagnostico = new System.Windows.Forms.TabPage();
            this.txtBuscarDiagnostico = new System.Windows.Forms.TextBox();
            this.lstDiagnosticos = new System.Windows.Forms.ListBox();
            this.btnVerTodosLosDiagnosticos = new System.Windows.Forms.Button();
            this.btnAgregarDiagnosticoSecundario = new System.Windows.Forms.Button();
            this.btnAgregarDiagnosticoPrinicpal = new System.Windows.Forms.Button();
            this.tabPractica = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbxModulo = new System.Windows.Forms.ComboBox();
            this.txtCantidadPracticas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerTodasLasPracticas = new System.Windows.Forms.Button();
            this.btnAgregarPracticaSolicitada = new System.Windows.Forms.Button();
            this.btnAgregarPracticaRealizada = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lstPracticas = new System.Windows.Forms.ListBox();
            this.tabReceta = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblNotaReceta = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblDosisReceta = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.gbxConcentracionMedicamento = new System.Windows.Forms.GroupBox();
            this.txtBuscarConcentracionMedicamento = new System.Windows.Forms.TextBox();
            this.lstConcentracionesMedicamento = new System.Windows.Forms.ListBox();
            this.gbxPresentacionMedicamento = new System.Windows.Forms.GroupBox();
            this.txtBuscarPresentacionMedicamento = new System.Windows.Forms.TextBox();
            this.lstPresentacionesMedicamento = new System.Windows.Forms.ListBox();
            this.gbxMedicamento = new System.Windows.Forms.GroupBox();
            this.txtBuscarMedicamento = new System.Windows.Forms.TextBox();
            this.lstMedicamentos = new System.Windows.Forms.ListBox();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.grpPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.rdbTodas = new System.Windows.Forms.RadioButton();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.rdbUltimoMes = new System.Windows.Forms.RadioButton();
            this.practicasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obrasSocialesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.obrasSocialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practicasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.cbxIdDiagnostico = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTemaRequerido = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtDiagnostico_borrar = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblIdDiagnostico_borrar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDiagnostico_borrar = new System.Windows.Forms.Label();
            this.obrasSocialesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.obraSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obrasSocialesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.sttMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabListadoPacientes.SuspendLayout();
            this.txtBuscarPractica.SuspendLayout();
            this.grpPaciente.SuspendLayout();
            this.grpHistoriaClinica.SuspendLayout();
            this.grpConsultas.SuspendLayout();
            this.tabConsultas.SuspendLayout();
            this.tabListadoConsultas.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.grpDatosConsulta.SuspendLayout();
            this.tabDiagnostico.SuspendLayout();
            this.tabPractica.SuspendLayout();
            this.tabReceta.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxConcentracionMedicamento.SuspendLayout();
            this.gbxPresentacionMedicamento.SuspendLayout();
            this.gbxMedicamento.SuspendLayout();
            this.grpBusqueda.SuspendLayout();
            this.grpPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasSocialesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasSocialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasSocialesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraSocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasSocialesBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sttMain
            // 
            this.sttMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sttMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusBar});
            this.sttMain.Location = new System.Drawing.Point(0, 601);
            this.sttMain.Name = "sttMain";
            this.sttMain.Size = new System.Drawing.Size(924, 22);
            this.sttMain.SizingGrip = false;
            this.sttMain.TabIndex = 1;
            this.sttMain.Text = "sttMain";
            // 
            // lblStatusBar
            // 
            this.lblStatusBar.Name = "lblStatusBar";
            this.lblStatusBar.Size = new System.Drawing.Size(230, 17);
            this.lblStatusBar.Text = "Consultorio - Administracion de Pacientes";
            // 
            // lstPacientes
            // 
            this.lstPacientes.BackColor = System.Drawing.Color.Lavender;
            this.lstPacientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPacientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdPaciente,
            this.colTipoNumDoc,
            this.colApellido,
            this.colNombre,
            this.colObraSocial,
            this.colUltimaVisita,
            this.colTelefono,
            this.colDireccion});
            this.lstPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPacientes.FullRowSelect = true;
            this.lstPacientes.HideSelection = false;
            this.lstPacientes.Location = new System.Drawing.Point(-81, -5);
            this.lstPacientes.MinimumSize = new System.Drawing.Size(823, 578);
            this.lstPacientes.MultiSelect = false;
            this.lstPacientes.Name = "lstPacientes";
            this.lstPacientes.ShowItemToolTips = true;
            this.lstPacientes.Size = new System.Drawing.Size(907, 578);
            this.lstPacientes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstPacientes.TabIndex = 0;
            this.lstPacientes.TileSize = new System.Drawing.Size(168, 30);
            this.lstPacientes.UseCompatibleStateImageBehavior = false;
            this.lstPacientes.View = System.Windows.Forms.View.Details;
            this.lstPacientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPacientes_MouseDoubleClick);
            // 
            // colIdPaciente
            // 
            this.colIdPaciente.Text = "Id";
            this.colIdPaciente.Width = 0;
            // 
            // colTipoNumDoc
            // 
            this.colTipoNumDoc.Text = "Nº Doc.";
            this.colTipoNumDoc.Width = 74;
            // 
            // colApellido
            // 
            this.colApellido.Text = "Apellido";
            this.colApellido.Width = 128;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 132;
            // 
            // colObraSocial
            // 
            this.colObraSocial.Text = "Obras Sociales";
            this.colObraSocial.Width = 150;
            // 
            // colUltimaVisita
            // 
            this.colUltimaVisita.Text = "Ultima Visita";
            this.colUltimaVisita.Width = 75;
            // 
            // colTelefono
            // 
            this.colTelefono.Text = "Telefono";
            this.colTelefono.Width = 77;
            // 
            // colDireccion
            // 
            this.colDireccion.Text = "Dirección";
            this.colDireccion.Width = 170;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabListadoPacientes);
            this.tabMain.Controls.Add(this.txtBuscarPractica);
            this.tabMain.Location = new System.Drawing.Point(0, -2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(928, 605);
            this.tabMain.TabIndex = 1;
            this.tabMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabMain_MouseClick);
            // 
            // tabListadoPacientes
            // 
            this.tabListadoPacientes.Controls.Add(this.lstPacientes);
            this.tabListadoPacientes.Controls.Add(this.btnImprimir);
            this.tabListadoPacientes.Controls.Add(this.btnInformes);
            this.tabListadoPacientes.Controls.Add(this.btnEliminarPaciente);
            this.tabListadoPacientes.Controls.Add(this.btnEditarPaciente);
            this.tabListadoPacientes.Controls.Add(this.btnNuevoPaciente);
            this.tabListadoPacientes.Location = new System.Drawing.Point(4, 22);
            this.tabListadoPacientes.Name = "tabListadoPacientes";
            this.tabListadoPacientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabListadoPacientes.Size = new System.Drawing.Size(920, 579);
            this.tabListadoPacientes.TabIndex = 0;
            this.tabListadoPacientes.Text = "Listado";
            this.tabListadoPacientes.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(832, 83);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.Location = new System.Drawing.Point(832, 112);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(75, 23);
            this.btnInformes.TabIndex = 6;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Location = new System.Drawing.Point(832, 178);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPaciente.TabIndex = 5;
            this.btnEliminarPaciente.Text = "Eliminar";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Location = new System.Drawing.Point(832, 38);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPaciente.TabIndex = 4;
            this.btnEditarPaciente.Text = "Editar";
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click);
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.Location = new System.Drawing.Point(832, 9);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoPaciente.TabIndex = 3;
            this.btnNuevoPaciente.Text = "Nuevo";
            this.btnNuevoPaciente.UseVisualStyleBackColor = true;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // txtBuscarPractica
            // 
            this.txtBuscarPractica.Controls.Add(this.grpPaciente);
            this.txtBuscarPractica.Controls.Add(this.grpHistoriaClinica);
            this.txtBuscarPractica.Location = new System.Drawing.Point(4, 22);
            this.txtBuscarPractica.Name = "txtBuscarPractica";
            this.txtBuscarPractica.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscarPractica.Size = new System.Drawing.Size(920, 579);
            this.txtBuscarPractica.TabIndex = 1;
            this.txtBuscarPractica.Text = "Paciente";
            this.txtBuscarPractica.UseVisualStyleBackColor = true;
            // 
            // grpPaciente
            // 
            this.grpPaciente.Controls.Add(this.lblSexo);
            this.grpPaciente.Controls.Add(this.cbxSexo);
            this.grpPaciente.Controls.Add(this.txtCodigoPostal);
            this.grpPaciente.Controls.Add(this.txtDepto);
            this.grpPaciente.Controls.Add(this.lblCodigoPostal);
            this.grpPaciente.Controls.Add(this.lblDepto);
            this.grpPaciente.Controls.Add(this.txtNroCalle);
            this.grpPaciente.Controls.Add(this.txtPiso);
            this.grpPaciente.Controls.Add(this.lblPiso);
            this.grpPaciente.Controls.Add(this.lblNroCalle);
            this.grpPaciente.Controls.Add(this.dtpFechaNac);
            this.grpPaciente.Controls.Add(this.lblFechaNac);
            this.grpPaciente.Controls.Add(this.btnEliminarObraSocial);
            this.grpPaciente.Controls.Add(this.btnAgregarObrasSociales);
            this.grpPaciente.Controls.Add(this.lstObrasSocialesPaciente);
            this.grpPaciente.Controls.Add(this.btnGuardarPaciente);
            this.grpPaciente.Controls.Add(this.btnDescartarPaciente);
            this.grpPaciente.Controls.Add(this.cbxFactorSanguineo);
            this.grpPaciente.Controls.Add(this.lblFactorSanguineo);
            this.grpPaciente.Controls.Add(this.lblTipoDoc);
            this.grpPaciente.Controls.Add(this.cbxTipoDoc);
            this.grpPaciente.Controls.Add(this.txtNumeroDoc);
            this.grpPaciente.Controls.Add(this.lblNroDoc);
            this.grpPaciente.Controls.Add(this.lblNroAfiliado);
            this.grpPaciente.Controls.Add(this.cbxGrupoSanguineo);
            this.grpPaciente.Controls.Add(this.txtDomicilio);
            this.grpPaciente.Controls.Add(this.txtEmail);
            this.grpPaciente.Controls.Add(this.txtCelular);
            this.grpPaciente.Controls.Add(this.txtTelefono);
            this.grpPaciente.Controls.Add(this.txtNroAfiliado);
            this.grpPaciente.Controls.Add(this.txtNombre);
            this.grpPaciente.Controls.Add(this.lblDomicilio);
            this.grpPaciente.Controls.Add(this.lblEmail);
            this.grpPaciente.Controls.Add(this.lblCelular);
            this.grpPaciente.Controls.Add(this.lblTelefono);
            this.grpPaciente.Controls.Add(this.lblGrupoSanguineo);
            this.grpPaciente.Controls.Add(this.lblObraSocial);
            this.grpPaciente.Controls.Add(this.lblNombre);
            this.grpPaciente.Controls.Add(this.txtApellido);
            this.grpPaciente.Controls.Add(this.lblApellido);
            this.grpPaciente.Location = new System.Drawing.Point(16, 11);
            this.grpPaciente.Name = "grpPaciente";
            this.grpPaciente.Size = new System.Drawing.Size(886, 131);
            this.grpPaciente.TabIndex = 0;
            this.grpPaciente.TabStop = false;
            this.grpPaciente.Text = "Datos del Paciente";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(23, 93);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 55;
            this.lblSexo.Text = "Sexo";
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Location = new System.Drawing.Point(57, 90);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(44, 21);
            this.cbxSexo.TabIndex = 54;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(426, 42);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(60, 20);
            this.txtCodigoPostal.TabIndex = 53;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(375, 42);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(16, 20);
            this.txtDepto.TabIndex = 52;
            // 
            // lblCodigoPostal
            // 
            this.lblCodigoPostal.AutoSize = true;
            this.lblCodigoPostal.Location = new System.Drawing.Point(397, 46);
            this.lblCodigoPostal.Name = "lblCodigoPostal";
            this.lblCodigoPostal.Size = new System.Drawing.Size(30, 13);
            this.lblCodigoPostal.TabIndex = 51;
            this.lblCodigoPostal.Text = "C.P.:";
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(339, 46);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(33, 13);
            this.lblDepto.TabIndex = 50;
            this.lblDepto.Text = "Dpto.";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(450, 18);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(36, 20);
            this.txtNroCalle.TabIndex = 47;
            this.txtNroCalle.TextChanged += new System.EventHandler(this.txtNroCalle_TextChanged);
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(306, 42);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(27, 20);
            this.txtPiso.TabIndex = 48;
            this.txtPiso.TextChanged += new System.EventHandler(this.txtPiso_TextChanged);
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(277, 45);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 49;
            this.lblPiso.Text = "Piso";
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.Location = new System.Drawing.Point(432, 21);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(20, 13);
            this.lblNroCalle.TabIndex = 0;
            this.lblNroCalle.Text = "Nº";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNac.Location = new System.Drawing.Point(164, 90);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(73, 20);
            this.dtpFechaNac.TabIndex = 46;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(121, 93);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(42, 13);
            this.lblFechaNac.TabIndex = 45;
            this.lblFechaNac.Text = "F. Nac.";
            // 
            // btnEliminarObraSocial
            // 
            this.btnEliminarObraSocial.Location = new System.Drawing.Point(717, 42);
            this.btnEliminarObraSocial.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarObraSocial.Name = "btnEliminarObraSocial";
            this.btnEliminarObraSocial.Size = new System.Drawing.Size(55, 20);
            this.btnEliminarObraSocial.TabIndex = 44;
            this.btnEliminarObraSocial.Text = "Eliminar";
            this.btnEliminarObraSocial.UseVisualStyleBackColor = true;
            this.btnEliminarObraSocial.Click += new System.EventHandler(this.btnEliminarObraSocial_Click);
            // 
            // btnAgregarObrasSociales
            // 
            this.btnAgregarObrasSociales.Location = new System.Drawing.Point(717, 17);
            this.btnAgregarObrasSociales.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarObrasSociales.Name = "btnAgregarObrasSociales";
            this.btnAgregarObrasSociales.Size = new System.Drawing.Size(55, 20);
            this.btnAgregarObrasSociales.TabIndex = 43;
            this.btnAgregarObrasSociales.Text = "Agregar";
            this.btnAgregarObrasSociales.UseVisualStyleBackColor = true;
            this.btnAgregarObrasSociales.Click += new System.EventHandler(this.btnAgregarObrasSociales_Click);
            // 
            // lstObrasSocialesPaciente
            // 
            this.lstObrasSocialesPaciente.FormattingEnabled = true;
            this.lstObrasSocialesPaciente.Location = new System.Drawing.Point(592, 18);
            this.lstObrasSocialesPaciente.Name = "lstObrasSocialesPaciente";
            this.lstObrasSocialesPaciente.Size = new System.Drawing.Size(122, 43);
            this.lstObrasSocialesPaciente.TabIndex = 42;
            this.lstObrasSocialesPaciente.SelectedIndexChanged += new System.EventHandler(this.lstObrasSocialesPaciente_SelectedIndexChanged);
            // 
            // btnGuardarPaciente
            // 
            this.btnGuardarPaciente.Location = new System.Drawing.Point(805, 69);
            this.btnGuardarPaciente.Name = "btnGuardarPaciente";
            this.btnGuardarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPaciente.TabIndex = 40;
            this.btnGuardarPaciente.Text = "Guardar";
            this.btnGuardarPaciente.UseVisualStyleBackColor = true;
            this.btnGuardarPaciente.Click += new System.EventHandler(this.btnGuardarPaciente_Click);
            // 
            // btnDescartarPaciente
            // 
            this.btnDescartarPaciente.Location = new System.Drawing.Point(805, 102);
            this.btnDescartarPaciente.Name = "btnDescartarPaciente";
            this.btnDescartarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnDescartarPaciente.TabIndex = 26;
            this.btnDescartarPaciente.Text = "Descartar";
            this.btnDescartarPaciente.UseVisualStyleBackColor = true;
            this.btnDescartarPaciente.Click += new System.EventHandler(this.btnDescartarPaciente_Click);
            // 
            // cbxFactorSanguineo
            // 
            this.cbxFactorSanguineo.FormattingEnabled = true;
            this.cbxFactorSanguineo.Location = new System.Drawing.Point(708, 90);
            this.cbxFactorSanguineo.Name = "cbxFactorSanguineo";
            this.cbxFactorSanguineo.Size = new System.Drawing.Size(64, 21);
            this.cbxFactorSanguineo.TabIndex = 39;
            this.cbxFactorSanguineo.SelectedIndexChanged += new System.EventHandler(this.cbxFactorSanguineo_SelectedIndexChanged);
            // 
            // lblFactorSanguineo
            // 
            this.lblFactorSanguineo.AutoSize = true;
            this.lblFactorSanguineo.Location = new System.Drawing.Point(665, 93);
            this.lblFactorSanguineo.Name = "lblFactorSanguineo";
            this.lblFactorSanguineo.Size = new System.Drawing.Size(37, 13);
            this.lblFactorSanguineo.TabIndex = 38;
            this.lblFactorSanguineo.Text = "Factor";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(11, 69);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(43, 13);
            this.lblTipoDoc.TabIndex = 37;
            this.lblTipoDoc.Text = "T. Doc.";
            // 
            // cbxTipoDoc
            // 
            this.cbxTipoDoc.FormattingEnabled = true;
            this.cbxTipoDoc.Location = new System.Drawing.Point(57, 65);
            this.cbxTipoDoc.Name = "cbxTipoDoc";
            this.cbxTipoDoc.Size = new System.Drawing.Size(44, 21);
            this.cbxTipoDoc.TabIndex = 36;
            this.cbxTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDoc_SelectedIndexChanged);
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(164, 65);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(73, 20);
            this.txtNumeroDoc.TabIndex = 1;
            this.txtNumeroDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumeroDoc.TextChanged += new System.EventHandler(this.txtNumeroDoc_TextChanged);
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(118, 69);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(45, 13);
            this.lblNroDoc.TabIndex = 35;
            this.lblNroDoc.Text = "Nº Doc.";
            // 
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Location = new System.Drawing.Point(524, 68);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(64, 13);
            this.lblNroAfiliado.TabIndex = 34;
            this.lblNroAfiliado.Text = "Nro. Afiliado";
            // 
            // cbxGrupoSanguineo
            // 
            this.cbxGrupoSanguineo.FormattingEnabled = true;
            this.cbxGrupoSanguineo.Location = new System.Drawing.Point(592, 90);
            this.cbxGrupoSanguineo.Name = "cbxGrupoSanguineo";
            this.cbxGrupoSanguineo.Size = new System.Drawing.Size(64, 21);
            this.cbxGrupoSanguineo.TabIndex = 33;
            this.cbxGrupoSanguineo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupoSanguineo_SelectedIndexChanged);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(306, 18);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(121, 20);
            this.txtDomicilio.TabIndex = 31;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(306, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 30;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.AutoCompleteCustomSource.AddRange(new string[] {
            "(03471) 15"});
            this.txtCelular.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCelular.Location = new System.Drawing.Point(306, 91);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(180, 20);
            this.txtCelular.TabIndex = 29;
            this.txtCelular.Visible = false;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoCompleteCustomSource.AddRange(new string[] {
            "(03471)"});
            this.txtTelefono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtTelefono.Location = new System.Drawing.Point(306, 66);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 20);
            this.txtTelefono.TabIndex = 28;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(592, 65);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(180, 20);
            this.txtNroAfiliado.TabIndex = 26;
            this.txtNroAfiliado.TextChanged += new System.EventHandler(this.txtNroAfiliado_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(57, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(274, 20);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(30, 13);
            this.lblDomicilio.TabIndex = 24;
            this.lblDomicilio.Text = "Calle";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(272, 93);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Email";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(258, 94);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(46, 13);
            this.lblCelular.TabIndex = 22;
            this.lblCelular.Text = "Tel. Cel.";
            this.lblCelular.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(255, 69);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 21;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(516, 93);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(72, 13);
            this.lblGrupoSanguineo.TabIndex = 20;
            this.lblGrupoSanguineo.Text = "G. Sanguineo";
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(510, 22);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(78, 13);
            this.lblObraSocial.TabIndex = 19;
            this.lblObraSocial.Text = "Obras Sociales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(57, 19);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(10, 21);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // grpHistoriaClinica
            // 
            this.grpHistoriaClinica.Controls.Add(this.txtNotas);
            this.grpHistoriaClinica.Controls.Add(this.lblNotas);
            this.grpHistoriaClinica.Controls.Add(this.txtProblemas);
            this.grpHistoriaClinica.Controls.Add(this.lblProblemas);
            this.grpHistoriaClinica.Controls.Add(this.grpConsultas);
            this.grpHistoriaClinica.Controls.Add(this.grpBusqueda);
            this.grpHistoriaClinica.Location = new System.Drawing.Point(16, 148);
            this.grpHistoriaClinica.Name = "grpHistoriaClinica";
            this.grpHistoriaClinica.Size = new System.Drawing.Size(886, 425);
            this.grpHistoriaClinica.TabIndex = 1;
            this.grpHistoriaClinica.TabStop = false;
            this.grpHistoriaClinica.Text = "Historia Clínica";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(64, 63);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(474, 48);
            this.txtNotas.TabIndex = 7;
            this.txtNotas.TextChanged += new System.EventHandler(this.txtNotas_TextChanged);
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(24, 66);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(35, 13);
            this.lblNotas.TabIndex = 6;
            this.lblNotas.Text = "Notas";
            // 
            // txtProblemas
            // 
            this.txtProblemas.Location = new System.Drawing.Point(65, 32);
            this.txtProblemas.Name = "txtProblemas";
            this.txtProblemas.Size = new System.Drawing.Size(473, 20);
            this.txtProblemas.TabIndex = 5;
            this.txtProblemas.TextChanged += new System.EventHandler(this.txtProblemas_TextChanged);
            // 
            // lblProblemas
            // 
            this.lblProblemas.AutoSize = true;
            this.lblProblemas.Location = new System.Drawing.Point(3, 35);
            this.lblProblemas.Name = "lblProblemas";
            this.lblProblemas.Size = new System.Drawing.Size(56, 13);
            this.lblProblemas.TabIndex = 4;
            this.lblProblemas.Text = "Problemas";
            // 
            // grpConsultas
            // 
            this.grpConsultas.Controls.Add(this.tabConsultas);
            this.grpConsultas.Location = new System.Drawing.Point(14, 126);
            this.grpConsultas.Name = "grpConsultas";
            this.grpConsultas.Size = new System.Drawing.Size(866, 288);
            this.grpConsultas.TabIndex = 3;
            this.grpConsultas.TabStop = false;
            this.grpConsultas.Text = "Consultas";
            // 
            // tabConsultas
            // 
            this.tabConsultas.Controls.Add(this.tabListadoConsultas);
            this.tabConsultas.Controls.Add(this.tabConsulta);
            this.tabConsultas.Controls.Add(this.tabDiagnostico);
            this.tabConsultas.Controls.Add(this.tabPractica);
            this.tabConsultas.Controls.Add(this.tabReceta);
            this.tabConsultas.Location = new System.Drawing.Point(12, 19);
            this.tabConsultas.Name = "tabConsultas";
            this.tabConsultas.SelectedIndex = 0;
            this.tabConsultas.Size = new System.Drawing.Size(848, 261);
            this.tabConsultas.TabIndex = 4;
            this.tabConsultas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabConsultas_MouseClick);
            // 
            // tabListadoConsultas
            // 
            this.tabListadoConsultas.Controls.Add(this.lstConsultas);
            this.tabListadoConsultas.Controls.Add(this.btnEliminarConsulta);
            this.tabListadoConsultas.Controls.Add(this.btnEditarConsulta);
            this.tabListadoConsultas.Controls.Add(this.btnNuevaConsulta);
            this.tabListadoConsultas.Location = new System.Drawing.Point(4, 22);
            this.tabListadoConsultas.Name = "tabListadoConsultas";
            this.tabListadoConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabListadoConsultas.Size = new System.Drawing.Size(840, 235);
            this.tabListadoConsultas.TabIndex = 0;
            this.tabListadoConsultas.Text = "Listado de Consultas";
            this.tabListadoConsultas.UseVisualStyleBackColor = true;
            // 
            // lstConsultas
            // 
            this.lstConsultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdConsulta,
            this.colFecha,
            this.colPractica,
            this.colDiagnostico,
            this.colDetalle});
            this.lstConsultas.FullRowSelect = true;
            this.lstConsultas.Location = new System.Drawing.Point(0, 3);
            this.lstConsultas.Name = "lstConsultas";
            this.lstConsultas.ShowGroups = false;
            this.lstConsultas.Size = new System.Drawing.Size(729, 229);
            this.lstConsultas.TabIndex = 5;
            this.lstConsultas.UseCompatibleStateImageBehavior = false;
            this.lstConsultas.View = System.Windows.Forms.View.Details;
            // 
            // colIdConsulta
            // 
            this.colIdConsulta.Text = "Id";
            this.colIdConsulta.Width = 0;
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 147;
            // 
            // colPractica
            // 
            this.colPractica.Text = "Practica";
            this.colPractica.Width = 125;
            // 
            // colDiagnostico
            // 
            this.colDiagnostico.Text = "Diagnóstico";
            this.colDiagnostico.Width = 106;
            // 
            // colDetalle
            // 
            this.colDetalle.Text = "Detalle";
            this.colDetalle.Width = 370;
            // 
            // btnEliminarConsulta
            // 
            this.btnEliminarConsulta.Location = new System.Drawing.Point(742, 94);
            this.btnEliminarConsulta.Name = "btnEliminarConsulta";
            this.btnEliminarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarConsulta.TabIndex = 2;
            this.btnEliminarConsulta.Text = "Eliminar";
            this.btnEliminarConsulta.UseVisualStyleBackColor = true;
            this.btnEliminarConsulta.Click += new System.EventHandler(this.btnEliminarConsulta_Click);
            // 
            // btnEditarConsulta
            // 
            this.btnEditarConsulta.Location = new System.Drawing.Point(742, 40);
            this.btnEditarConsulta.Name = "btnEditarConsulta";
            this.btnEditarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnEditarConsulta.TabIndex = 1;
            this.btnEditarConsulta.Text = "Editar";
            this.btnEditarConsulta.UseVisualStyleBackColor = true;
            this.btnEditarConsulta.Click += new System.EventHandler(this.btnEditarConsulta_Click);
            // 
            // btnNuevaConsulta
            // 
            this.btnNuevaConsulta.Location = new System.Drawing.Point(742, 11);
            this.btnNuevaConsulta.Name = "btnNuevaConsulta";
            this.btnNuevaConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnNuevaConsulta.TabIndex = 0;
            this.btnNuevaConsulta.Text = "Nueva";
            this.btnNuevaConsulta.UseVisualStyleBackColor = true;
            this.btnNuevaConsulta.Click += new System.EventHandler(this.btnNuevaConsulta_Click);
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.grpDatosConsulta);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(840, 235);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // grpDatosConsulta
            // 
            this.grpDatosConsulta.Controls.Add(this.button3);
            this.grpDatosConsulta.Controls.Add(this.button4);
            this.grpDatosConsulta.Controls.Add(this.button1);
            this.grpDatosConsulta.Controls.Add(this.btnAgregarDiagnostico);
            this.grpDatosConsulta.Controls.Add(this.lstPracticaConsulta);
            this.grpDatosConsulta.Controls.Add(this.lblPrestacion2);
            this.grpDatosConsulta.Controls.Add(this.btnGuardarConsulta);
            this.grpDatosConsulta.Controls.Add(this.btnDescartarConsulta);
            this.grpDatosConsulta.Controls.Add(this.lstDiagnosticoConsulta);
            this.grpDatosConsulta.Controls.Add(this.txtMotivo);
            this.grpDatosConsulta.Controls.Add(this.lblPractica);
            this.grpDatosConsulta.Controls.Add(this.dtpFechaConsulta);
            this.grpDatosConsulta.Controls.Add(this.txtDetalleConsulta);
            this.grpDatosConsulta.Controls.Add(this.lblDetalleConsulta);
            this.grpDatosConsulta.Controls.Add(this.lblFechaConsulta);
            this.grpDatosConsulta.Controls.Add(this.lblDiagnostico);
            this.grpDatosConsulta.Location = new System.Drawing.Point(10, 9);
            this.grpDatosConsulta.Name = "grpDatosConsulta";
            this.grpDatosConsulta.Size = new System.Drawing.Size(804, 215);
            this.grpDatosConsulta.TabIndex = 1;
            this.grpDatosConsulta.TabStop = false;
            this.grpDatosConsulta.Text = "Consulta";
            this.grpDatosConsulta.Enter += new System.EventHandler(this.grpDatosConsulta_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(745, 99);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 20);
            this.button3.TabIndex = 48;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(745, 71);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 20);
            this.button4.TabIndex = 47;
            this.button4.Text = "Agregar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 97);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 20);
            this.button1.TabIndex = 46;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDiagnostico
            // 
            this.btnAgregarDiagnostico.Location = new System.Drawing.Point(354, 71);
            this.btnAgregarDiagnostico.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarDiagnostico.Name = "btnAgregarDiagnostico";
            this.btnAgregarDiagnostico.Size = new System.Drawing.Size(55, 20);
            this.btnAgregarDiagnostico.TabIndex = 45;
            this.btnAgregarDiagnostico.Text = "Agregar";
            this.btnAgregarDiagnostico.UseVisualStyleBackColor = true;
            // 
            // lstPracticaConsulta
            // 
            this.lstPracticaConsulta.FormattingEnabled = true;
            this.lstPracticaConsulta.Location = new System.Drawing.Point(474, 50);
            this.lstPracticaConsulta.Name = "lstPracticaConsulta";
            this.lstPracticaConsulta.Size = new System.Drawing.Size(267, 69);
            this.lstPracticaConsulta.TabIndex = 28;
            // 
            // lblPrestacion2
            // 
            this.lblPrestacion2.AutoSize = true;
            this.lblPrestacion2.Location = new System.Drawing.Point(425, 50);
            this.lblPrestacion2.Name = "lblPrestacion2";
            this.lblPrestacion2.Size = new System.Drawing.Size(46, 13);
            this.lblPrestacion2.TabIndex = 29;
            this.lblPrestacion2.Text = "Practica";
            // 
            // btnGuardarConsulta
            // 
            this.btnGuardarConsulta.Location = new System.Drawing.Point(723, 157);
            this.btnGuardarConsulta.Name = "btnGuardarConsulta";
            this.btnGuardarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarConsulta.TabIndex = 23;
            this.btnGuardarConsulta.Text = "Guardar";
            this.btnGuardarConsulta.UseVisualStyleBackColor = true;
            this.btnGuardarConsulta.Click += new System.EventHandler(this.btnGuardarConsulta_Click);
            // 
            // btnDescartarConsulta
            // 
            this.btnDescartarConsulta.Location = new System.Drawing.Point(723, 186);
            this.btnDescartarConsulta.Name = "btnDescartarConsulta";
            this.btnDescartarConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnDescartarConsulta.TabIndex = 24;
            this.btnDescartarConsulta.Text = "Descartar";
            this.btnDescartarConsulta.UseVisualStyleBackColor = true;
            this.btnDescartarConsulta.Click += new System.EventHandler(this.btnDescartarConsulta_Click);
            // 
            // lstDiagnosticoConsulta
            // 
            this.lstDiagnosticoConsulta.FormattingEnabled = true;
            this.lstDiagnosticoConsulta.Location = new System.Drawing.Point(70, 48);
            this.lstDiagnosticoConsulta.Name = "lstDiagnosticoConsulta";
            this.lstDiagnosticoConsulta.Size = new System.Drawing.Size(281, 69);
            this.lstDiagnosticoConsulta.TabIndex = 27;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(70, 19);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(561, 20);
            this.txtMotivo.TabIndex = 26;
            // 
            // lblPractica
            // 
            this.lblPractica.AutoSize = true;
            this.lblPractica.Location = new System.Drawing.Point(18, 22);
            this.lblPractica.Name = "lblPractica";
            this.lblPractica.Size = new System.Drawing.Size(39, 13);
            this.lblPractica.TabIndex = 25;
            this.lblPractica.Text = "Motivo";
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaConsulta.Location = new System.Drawing.Point(677, 19);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(123, 20);
            this.dtpFechaConsulta.TabIndex = 7;
            // 
            // txtDetalleConsulta
            // 
            this.txtDetalleConsulta.Location = new System.Drawing.Point(70, 124);
            this.txtDetalleConsulta.Multiline = true;
            this.txtDetalleConsulta.Name = "txtDetalleConsulta";
            this.txtDetalleConsulta.Size = new System.Drawing.Size(647, 85);
            this.txtDetalleConsulta.TabIndex = 9;
            this.txtDetalleConsulta.TextChanged += new System.EventHandler(this.txtDetalleConsulta_TextChanged);
            // 
            // lblDetalleConsulta
            // 
            this.lblDetalleConsulta.AutoSize = true;
            this.lblDetalleConsulta.Location = new System.Drawing.Point(5, 124);
            this.lblDetalleConsulta.Name = "lblDetalleConsulta";
            this.lblDetalleConsulta.Size = new System.Drawing.Size(40, 13);
            this.lblDetalleConsulta.TabIndex = 4;
            this.lblDetalleConsulta.Text = "Detalle";
            // 
            // lblFechaConsulta
            // 
            this.lblFechaConsulta.AutoSize = true;
            this.lblFechaConsulta.Location = new System.Drawing.Point(637, 22);
            this.lblFechaConsulta.Name = "lblFechaConsulta";
            this.lblFechaConsulta.Size = new System.Drawing.Size(37, 13);
            this.lblFechaConsulta.TabIndex = 2;
            this.lblFechaConsulta.Text = "Fecha";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(5, 50);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(63, 13);
            this.lblDiagnostico.TabIndex = 1;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // tabDiagnostico
            // 
            this.tabDiagnostico.Controls.Add(this.txtBuscarDiagnostico);
            this.tabDiagnostico.Controls.Add(this.lstDiagnosticos);
            this.tabDiagnostico.Controls.Add(this.btnVerTodosLosDiagnosticos);
            this.tabDiagnostico.Controls.Add(this.btnAgregarDiagnosticoSecundario);
            this.tabDiagnostico.Controls.Add(this.btnAgregarDiagnosticoPrinicpal);
            this.tabDiagnostico.Location = new System.Drawing.Point(4, 22);
            this.tabDiagnostico.Name = "tabDiagnostico";
            this.tabDiagnostico.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiagnostico.Size = new System.Drawing.Size(840, 235);
            this.tabDiagnostico.TabIndex = 2;
            this.tabDiagnostico.Text = "Diagnostico";
            this.tabDiagnostico.UseVisualStyleBackColor = true;
            // 
            // txtBuscarDiagnostico
            // 
            this.txtBuscarDiagnostico.Location = new System.Drawing.Point(11, 10);
            this.txtBuscarDiagnostico.Name = "txtBuscarDiagnostico";
            this.txtBuscarDiagnostico.Size = new System.Drawing.Size(715, 20);
            this.txtBuscarDiagnostico.TabIndex = 6;
            // 
            // lstDiagnosticos
            // 
            this.lstDiagnosticos.FormattingEnabled = true;
            this.lstDiagnosticos.Location = new System.Drawing.Point(11, 30);
            this.lstDiagnosticos.Name = "lstDiagnosticos";
            this.lstDiagnosticos.Size = new System.Drawing.Size(715, 199);
            this.lstDiagnosticos.TabIndex = 5;
            // 
            // btnVerTodosLosDiagnosticos
            // 
            this.btnVerTodosLosDiagnosticos.Location = new System.Drawing.Point(746, 103);
            this.btnVerTodosLosDiagnosticos.Name = "btnVerTodosLosDiagnosticos";
            this.btnVerTodosLosDiagnosticos.Size = new System.Drawing.Size(75, 23);
            this.btnVerTodosLosDiagnosticos.TabIndex = 3;
            this.btnVerTodosLosDiagnosticos.Text = "Ver Todos";
            this.btnVerTodosLosDiagnosticos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDiagnosticoSecundario
            // 
            this.btnAgregarDiagnosticoSecundario.Location = new System.Drawing.Point(746, 60);
            this.btnAgregarDiagnosticoSecundario.Name = "btnAgregarDiagnosticoSecundario";
            this.btnAgregarDiagnosticoSecundario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDiagnosticoSecundario.TabIndex = 2;
            this.btnAgregarDiagnosticoSecundario.Text = "Secundario";
            this.btnAgregarDiagnosticoSecundario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarDiagnosticoPrinicpal
            // 
            this.btnAgregarDiagnosticoPrinicpal.Location = new System.Drawing.Point(746, 30);
            this.btnAgregarDiagnosticoPrinicpal.Name = "btnAgregarDiagnosticoPrinicpal";
            this.btnAgregarDiagnosticoPrinicpal.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDiagnosticoPrinicpal.TabIndex = 1;
            this.btnAgregarDiagnosticoPrinicpal.Text = "Principal";
            this.btnAgregarDiagnosticoPrinicpal.UseVisualStyleBackColor = true;
            // 
            // tabPractica
            // 
            this.tabPractica.Controls.Add(this.radioButton2);
            this.tabPractica.Controls.Add(this.radioButton1);
            this.tabPractica.Controls.Add(this.cbxModulo);
            this.tabPractica.Controls.Add(this.txtCantidadPracticas);
            this.tabPractica.Controls.Add(this.label1);
            this.tabPractica.Controls.Add(this.btnVerTodasLasPracticas);
            this.tabPractica.Controls.Add(this.btnAgregarPracticaSolicitada);
            this.tabPractica.Controls.Add(this.btnAgregarPracticaRealizada);
            this.tabPractica.Controls.Add(this.textBox6);
            this.tabPractica.Controls.Add(this.lstPracticas);
            this.tabPractica.Location = new System.Drawing.Point(4, 22);
            this.tabPractica.Name = "tabPractica";
            this.tabPractica.Size = new System.Drawing.Size(840, 235);
            this.tabPractica.TabIndex = 3;
            this.tabPractica.Text = "Práctica";
            this.tabPractica.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(746, 181);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.Text = "Solicitada";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(746, 158);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "Realizada";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // cbxModulo
            // 
            this.cbxModulo.FormattingEnabled = true;
            this.cbxModulo.Location = new System.Drawing.Point(735, 206);
            this.cbxModulo.Name = "cbxModulo";
            this.cbxModulo.Size = new System.Drawing.Size(92, 21);
            this.cbxModulo.TabIndex = 11;
            this.cbxModulo.TabStop = false;
            this.cbxModulo.Visible = false;
            // 
            // txtCantidadPracticas
            // 
            this.txtCantidadPracticas.Location = new System.Drawing.Point(697, 10);
            this.txtCantidadPracticas.Name = "txtCantidadPracticas";
            this.txtCantidadPracticas.Size = new System.Drawing.Size(29, 20);
            this.txtCantidadPracticas.TabIndex = 9;
            this.txtCantidadPracticas.Text = "1";
            this.txtCantidadPracticas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cantidad";
            // 
            // btnVerTodasLasPracticas
            // 
            this.btnVerTodasLasPracticas.Location = new System.Drawing.Point(746, 103);
            this.btnVerTodasLasPracticas.Name = "btnVerTodasLasPracticas";
            this.btnVerTodasLasPracticas.Size = new System.Drawing.Size(75, 23);
            this.btnVerTodasLasPracticas.TabIndex = 7;
            this.btnVerTodasLasPracticas.Text = "Ver Todas\r\n";
            this.btnVerTodasLasPracticas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPracticaSolicitada
            // 
            this.btnAgregarPracticaSolicitada.Location = new System.Drawing.Point(746, 60);
            this.btnAgregarPracticaSolicitada.Name = "btnAgregarPracticaSolicitada";
            this.btnAgregarPracticaSolicitada.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPracticaSolicitada.TabIndex = 6;
            this.btnAgregarPracticaSolicitada.Text = "Solicitada";
            this.btnAgregarPracticaSolicitada.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPracticaRealizada
            // 
            this.btnAgregarPracticaRealizada.Location = new System.Drawing.Point(746, 30);
            this.btnAgregarPracticaRealizada.Name = "btnAgregarPracticaRealizada";
            this.btnAgregarPracticaRealizada.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPracticaRealizada.TabIndex = 5;
            this.btnAgregarPracticaRealizada.Text = "Realizada";
            this.btnAgregarPracticaRealizada.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(11, 10);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(630, 20);
            this.textBox6.TabIndex = 17;
            // 
            // lstPracticas
            // 
            this.lstPracticas.FormattingEnabled = true;
            this.lstPracticas.Location = new System.Drawing.Point(11, 30);
            this.lstPracticas.Name = "lstPracticas";
            this.lstPracticas.Size = new System.Drawing.Size(715, 199);
            this.lstPracticas.TabIndex = 16;
            // 
            // tabReceta
            // 
            this.tabReceta.Controls.Add(this.groupBox3);
            this.tabReceta.Controls.Add(this.gbxConcentracionMedicamento);
            this.tabReceta.Controls.Add(this.gbxPresentacionMedicamento);
            this.tabReceta.Controls.Add(this.gbxMedicamento);
            this.tabReceta.Location = new System.Drawing.Point(4, 22);
            this.tabReceta.Name = "tabReceta";
            this.tabReceta.Size = new System.Drawing.Size(840, 235);
            this.tabReceta.TabIndex = 5;
            this.tabReceta.Text = "Receta";
            this.tabReceta.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.lblNotaReceta);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.lblDosisReceta);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Location = new System.Drawing.Point(279, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 110);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receta";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(480, 81);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(357, 20);
            this.textBox4.TabIndex = 5;
            // 
            // lblNotaReceta
            // 
            this.lblNotaReceta.AutoSize = true;
            this.lblNotaReceta.Location = new System.Drawing.Point(91, 16);
            this.lblNotaReceta.Name = "lblNotaReceta";
            this.lblNotaReceta.Size = new System.Drawing.Size(30, 13);
            this.lblNotaReceta.TabIndex = 4;
            this.lblNotaReceta.Text = "Nota";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(29, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "1";
            // 
            // lblDosisReceta
            // 
            this.lblDosisReceta.AutoSize = true;
            this.lblDosisReceta.Location = new System.Drawing.Point(8, 16);
            this.lblDosisReceta.Name = "lblDosisReceta";
            this.lblDosisReceta.Size = new System.Drawing.Size(33, 13);
            this.lblDosisReceta.TabIndex = 1;
            this.lblDosisReceta.Text = "Dosis";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(11, 35);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(466, 69);
            this.listBox3.TabIndex = 0;
            // 
            // gbxConcentracionMedicamento
            // 
            this.gbxConcentracionMedicamento.Controls.Add(this.txtBuscarConcentracionMedicamento);
            this.gbxConcentracionMedicamento.Controls.Add(this.lstConcentracionesMedicamento);
            this.gbxConcentracionMedicamento.Location = new System.Drawing.Point(562, 3);
            this.gbxConcentracionMedicamento.Name = "gbxConcentracionMedicamento";
            this.gbxConcentracionMedicamento.Size = new System.Drawing.Size(275, 113);
            this.gbxConcentracionMedicamento.TabIndex = 7;
            this.gbxConcentracionMedicamento.TabStop = false;
            this.gbxConcentracionMedicamento.Text = "Concentración";
            // 
            // txtBuscarConcentracionMedicamento
            // 
            this.txtBuscarConcentracionMedicamento.Location = new System.Drawing.Point(6, 17);
            this.txtBuscarConcentracionMedicamento.Name = "txtBuscarConcentracionMedicamento";
            this.txtBuscarConcentracionMedicamento.Size = new System.Drawing.Size(263, 20);
            this.txtBuscarConcentracionMedicamento.TabIndex = 1;
            // 
            // lstConcentracionesMedicamento
            // 
            this.lstConcentracionesMedicamento.FormattingEnabled = true;
            this.lstConcentracionesMedicamento.Location = new System.Drawing.Point(6, 37);
            this.lstConcentracionesMedicamento.Name = "lstConcentracionesMedicamento";
            this.lstConcentracionesMedicamento.Size = new System.Drawing.Size(263, 69);
            this.lstConcentracionesMedicamento.TabIndex = 0;
            // 
            // gbxPresentacionMedicamento
            // 
            this.gbxPresentacionMedicamento.Controls.Add(this.txtBuscarPresentacionMedicamento);
            this.gbxPresentacionMedicamento.Controls.Add(this.lstPresentacionesMedicamento);
            this.gbxPresentacionMedicamento.Location = new System.Drawing.Point(281, 3);
            this.gbxPresentacionMedicamento.Name = "gbxPresentacionMedicamento";
            this.gbxPresentacionMedicamento.Size = new System.Drawing.Size(275, 113);
            this.gbxPresentacionMedicamento.TabIndex = 6;
            this.gbxPresentacionMedicamento.TabStop = false;
            this.gbxPresentacionMedicamento.Text = "Presentación";
            // 
            // txtBuscarPresentacionMedicamento
            // 
            this.txtBuscarPresentacionMedicamento.Location = new System.Drawing.Point(6, 17);
            this.txtBuscarPresentacionMedicamento.Name = "txtBuscarPresentacionMedicamento";
            this.txtBuscarPresentacionMedicamento.Size = new System.Drawing.Size(263, 20);
            this.txtBuscarPresentacionMedicamento.TabIndex = 1;
            // 
            // lstPresentacionesMedicamento
            // 
            this.lstPresentacionesMedicamento.FormattingEnabled = true;
            this.lstPresentacionesMedicamento.Location = new System.Drawing.Point(6, 37);
            this.lstPresentacionesMedicamento.Name = "lstPresentacionesMedicamento";
            this.lstPresentacionesMedicamento.Size = new System.Drawing.Size(263, 69);
            this.lstPresentacionesMedicamento.TabIndex = 0;
            // 
            // gbxMedicamento
            // 
            this.gbxMedicamento.Controls.Add(this.txtBuscarMedicamento);
            this.gbxMedicamento.Controls.Add(this.lstMedicamentos);
            this.gbxMedicamento.Location = new System.Drawing.Point(0, 3);
            this.gbxMedicamento.Name = "gbxMedicamento";
            this.gbxMedicamento.Size = new System.Drawing.Size(275, 229);
            this.gbxMedicamento.TabIndex = 5;
            this.gbxMedicamento.TabStop = false;
            this.gbxMedicamento.Text = "Medicamento";
            // 
            // txtBuscarMedicamento
            // 
            this.txtBuscarMedicamento.Location = new System.Drawing.Point(6, 17);
            this.txtBuscarMedicamento.Name = "txtBuscarMedicamento";
            this.txtBuscarMedicamento.Size = new System.Drawing.Size(263, 20);
            this.txtBuscarMedicamento.TabIndex = 1;
            // 
            // lstMedicamentos
            // 
            this.lstMedicamentos.FormattingEnabled = true;
            this.lstMedicamentos.Location = new System.Drawing.Point(6, 37);
            this.lstMedicamentos.Name = "lstMedicamentos";
            this.lstMedicamentos.Size = new System.Drawing.Size(263, 186);
            this.lstMedicamentos.TabIndex = 0;
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.grpPeriodo);
            this.grpBusqueda.Controls.Add(this.rdbTodas);
            this.grpBusqueda.Controls.Add(this.rdbPeriodo);
            this.grpBusqueda.Controls.Add(this.rdbUltimoMes);
            this.grpBusqueda.Location = new System.Drawing.Point(585, 19);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(295, 92);
            this.grpBusqueda.TabIndex = 2;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Buscar Consultas";
            // 
            // grpPeriodo
            // 
            this.grpPeriodo.Controls.Add(this.dtpFechaHasta);
            this.grpPeriodo.Controls.Add(this.dtpFechaDesde);
            this.grpPeriodo.Controls.Add(this.lblFechaHasta);
            this.grpPeriodo.Controls.Add(this.lblFechaDesde);
            this.grpPeriodo.Location = new System.Drawing.Point(123, 16);
            this.grpPeriodo.Name = "grpPeriodo";
            this.grpPeriodo.Size = new System.Drawing.Size(161, 65);
            this.grpPeriodo.TabIndex = 3;
            this.grpPeriodo.TabStop = false;
            this.grpPeriodo.Text = "Período";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(57, 37);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaHasta.TabIndex = 8;
            this.dtpFechaHasta.ValueChanged += new System.EventHandler(this.dtpFechaHasta_ValueChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(57, 15);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaDesde.TabIndex = 8;
            this.dtpFechaDesde.ValueChanged += new System.EventHandler(this.dtpFechaDesde_ValueChanged);
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(10, 40);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(35, 13);
            this.lblFechaHasta.TabIndex = 1;
            this.lblFechaHasta.Text = "Hasta";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(10, 20);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(38, 13);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Desde";
            // 
            // rdbTodas
            // 
            this.rdbTodas.AutoSize = true;
            this.rdbTodas.Location = new System.Drawing.Point(7, 60);
            this.rdbTodas.Name = "rdbTodas";
            this.rdbTodas.Size = new System.Drawing.Size(55, 17);
            this.rdbTodas.TabIndex = 2;
            this.rdbTodas.TabStop = true;
            this.rdbTodas.Text = "Todas";
            this.rdbTodas.UseVisualStyleBackColor = true;
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Location = new System.Drawing.Point(7, 40);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(63, 17);
            this.rdbPeriodo.TabIndex = 1;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "Período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            // 
            // rdbUltimoMes
            // 
            this.rdbUltimoMes.AutoSize = true;
            this.rdbUltimoMes.Location = new System.Drawing.Point(7, 20);
            this.rdbUltimoMes.Name = "rdbUltimoMes";
            this.rdbUltimoMes.Size = new System.Drawing.Size(76, 17);
            this.rdbUltimoMes.TabIndex = 0;
            this.rdbUltimoMes.TabStop = true;
            this.rdbUltimoMes.Text = "Ultimo mes";
            this.rdbUltimoMes.UseVisualStyleBackColor = true;
            this.rdbUltimoMes.CheckedChanged += new System.EventHandler(this.rdbUltimoMes_CheckedChanged);
            // 
            // practicasBindingSource
            // 
            this.practicasBindingSource.DataSource = typeof(Business.Entities.Practicas);
            // 
            // diagnosticosBindingSource
            // 
            this.diagnosticosBindingSource.DataSource = typeof(Business.Entities.Diagnosticos);
            // 
            // obrasSocialesBindingSource3
            // 
            this.obrasSocialesBindingSource3.DataSource = typeof(Business.Entities.ObrasSociales);
            // 
            // obrasSocialesBindingSource
            // 
            this.obrasSocialesBindingSource.DataSource = typeof(Business.Entities.ObrasSociales);
            // 
            // practicasBindingSource1
            // 
            this.practicasBindingSource1.DataSource = typeof(Business.Entities.Practicas);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(607, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha2.Location = new System.Drawing.Point(103, 35);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(129, 20);
            this.dtpFecha2.TabIndex = 7;
            // 
            // cbxIdDiagnostico
            // 
            this.cbxIdDiagnostico.FormattingEnabled = true;
            this.cbxIdDiagnostico.Location = new System.Drawing.Point(103, 61);
            this.cbxIdDiagnostico.Name = "cbxIdDiagnostico";
            this.cbxIdDiagnostico.Size = new System.Drawing.Size(90, 21);
            this.cbxIdDiagnostico.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(516, 248);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblTemaRequerido
            // 
            this.lblTemaRequerido.AutoSize = true;
            this.lblTemaRequerido.Location = new System.Drawing.Point(392, 63);
            this.lblTemaRequerido.Name = "lblTemaRequerido";
            this.lblTemaRequerido.Size = new System.Drawing.Size(11, 13);
            this.lblTemaRequerido.TabIndex = 19;
            this.lblTemaRequerido.Text = "*";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(103, 114);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(579, 110);
            this.txtResultado.TabIndex = 9;
            // 
            // txtDiagnostico_borrar
            // 
            this.txtDiagnostico_borrar.Location = new System.Drawing.Point(103, 87);
            this.txtDiagnostico_borrar.Name = "txtDiagnostico_borrar";
            this.txtDiagnostico_borrar.Size = new System.Drawing.Size(270, 20);
            this.txtDiagnostico_borrar.TabIndex = 6;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(57, 114);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 4;
            this.lblDetalle.Text = "Detalle";
            // 
            // lblIdDiagnostico_borrar
            // 
            this.lblIdDiagnostico_borrar.AutoSize = true;
            this.lblIdDiagnostico_borrar.Location = new System.Drawing.Point(19, 64);
            this.lblIdDiagnostico_borrar.Name = "lblIdDiagnostico_borrar";
            this.lblIdDiagnostico_borrar.Size = new System.Drawing.Size(78, 13);
            this.lblIdDiagnostico_borrar.TabIndex = 3;
            this.lblIdDiagnostico_borrar.Text = "Id. Diagnostico";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(60, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDiagnostico_borrar
            // 
            this.lblDiagnostico_borrar.AutoSize = true;
            this.lblDiagnostico_borrar.Location = new System.Drawing.Point(1, 2);
            this.lblDiagnostico_borrar.Name = "lblDiagnostico_borrar";
            this.lblDiagnostico_borrar.Size = new System.Drawing.Size(63, 13);
            this.lblDiagnostico_borrar.TabIndex = 2;
            this.lblDiagnostico_borrar.Text = "Diagnostico";
            // 
            // obrasSocialesBindingSource1
            // 
            this.obrasSocialesBindingSource1.DataSource = typeof(Business.Entities.ObrasSociales);
            // 
            // obraSocialBindingSource
            // 
            this.obraSocialBindingSource.DataSource = typeof(Business.Entities.ObraSocial);
            // 
            // diagnosticoBindingSource
            // 
            this.diagnosticoBindingSource.DataSource = typeof(Business.Entities.Diagnostico);
            // 
            // obrasSocialesBindingSource2
            // 
            this.obrasSocialesBindingSource2.DataSource = typeof(Business.Entities.ObrasSociales);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 229);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamento";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 186);
            this.listBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 229);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicamento";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 37);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(263, 186);
            this.listBox2.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 623);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.sttMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.sttMain.ResumeLayout(false);
            this.sttMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabListadoPacientes.ResumeLayout(false);
            this.txtBuscarPractica.ResumeLayout(false);
            this.grpPaciente.ResumeLayout(false);
            this.grpPaciente.PerformLayout();
            this.grpHistoriaClinica.ResumeLayout(false);
            this.grpHistoriaClinica.PerformLayout();
            this.grpConsultas.ResumeLayout(false);
            this.tabConsultas.ResumeLayout(false);
            this.tabListadoConsultas.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.grpDatosConsulta.ResumeLayout(false);
            this.grpDatosConsulta.PerformLayout();
            this.tabDiagnostico.ResumeLayout(false);
            this.tabDiagnostico.PerformLayout();
            this.tabPractica.ResumeLayout(false);
            this.tabPractica.PerformLayout();
            this.tabReceta.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxConcentracionMedicamento.ResumeLayout(false);
            this.gbxConcentracionMedicamento.PerformLayout();
            this.gbxPresentacionMedicamento.ResumeLayout(false);
            this.gbxPresentacionMedicamento.PerformLayout();
            this.gbxMedicamento.ResumeLayout(false);
            this.gbxMedicamento.PerformLayout();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpPeriodo.ResumeLayout(false);
            this.grpPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasSocialesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasSocialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasSocialesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obraSocialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obrasSocialesBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sttMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusBar;
        private System.Windows.Forms.ListView lstPacientes;
        private System.Windows.Forms.ColumnHeader colApellido;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colObraSocial;
        private System.Windows.Forms.ColumnHeader colTelefono;
        private System.Windows.Forms.ColumnHeader colDireccion;
        private System.Windows.Forms.ColumnHeader colUltimaVisita;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabListadoPacientes;
        private System.Windows.Forms.TabPage txtBuscarPractica;
        private System.Windows.Forms.GroupBox grpPaciente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.ComboBox cbxIdDiagnostico;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTemaRequerido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtDiagnostico_borrar;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblIdDiagnostico_borrar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDiagnostico_borrar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cbxGrupoSanguineo;
        private System.Windows.Forms.Label lblNroAfiliado;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cbxTipoDoc;
        private System.Windows.Forms.GroupBox grpHistoriaClinica;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.GroupBox grpPeriodo;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.RadioButton rdbTodas;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.RadioButton rdbUltimoMes;
        private System.Windows.Forms.GroupBox grpConsultas;
        private System.Windows.Forms.Button btnEliminarConsulta;
        private System.Windows.Forms.Button btnEditarConsulta;
        private System.Windows.Forms.Button btnNuevaConsulta;
        private System.Windows.Forms.TabControl tabConsultas;
        private System.Windows.Forms.TabPage tabListadoConsultas;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.GroupBox grpDatosConsulta;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.TextBox txtDetalleConsulta;
        private System.Windows.Forms.Label lblDetalleConsulta;
        private System.Windows.Forms.Label lblFechaConsulta;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtProblemas;
        private System.Windows.Forms.Label lblProblemas;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnEditarPaciente;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnDescartarConsulta;
        private System.Windows.Forms.Button btnGuardarConsulta;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblPractica;
        private System.Windows.Forms.ComboBox cbxFactorSanguineo;
        private System.Windows.Forms.Label lblFactorSanguineo;
        private System.Windows.Forms.Button btnDescartarPaciente;
        private System.Windows.Forms.ColumnHeader colIdPaciente;
        private System.Windows.Forms.ColumnHeader colTipoNumDoc;
        private System.Windows.Forms.BindingSource obrasSocialesBindingSource;
        private System.Windows.Forms.BindingSource obrasSocialesBindingSource1;
        private System.Windows.Forms.BindingSource obraSocialBindingSource;
        private System.Windows.Forms.BindingSource practicasBindingSource;
        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private System.Windows.Forms.BindingSource practicasBindingSource1;
        private System.Windows.Forms.BindingSource diagnosticoBindingSource;
        private System.Windows.Forms.Button btnGuardarPaciente;
        private System.Windows.Forms.ListView lstConsultas;
        private System.Windows.Forms.ColumnHeader colIdConsulta;
        private System.Windows.Forms.ColumnHeader colPractica;
        private System.Windows.Forms.ColumnHeader colDiagnostico;
        private System.Windows.Forms.ColumnHeader colDetalle;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.BindingSource obrasSocialesBindingSource2;
        private System.Windows.Forms.BindingSource obrasSocialesBindingSource3;
        private System.Windows.Forms.ListBox lstObrasSocialesPaciente;
        private System.Windows.Forms.Button btnEliminarObraSocial;
        private System.Windows.Forms.Button btnAgregarObrasSociales;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtNroCalle;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.Label lblCodigoPostal;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.TabPage tabDiagnostico;
        private System.Windows.Forms.TabPage tabPractica;
        private System.Windows.Forms.ListBox lstDiagnosticoConsulta;
        private System.Windows.Forms.ListBox lstPracticaConsulta;
        private System.Windows.Forms.Label lblPrestacion2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarDiagnostico;
        private System.Windows.Forms.Button btnVerTodosLosDiagnosticos;
        private System.Windows.Forms.Button btnAgregarDiagnosticoSecundario;
        private System.Windows.Forms.Button btnAgregarDiagnosticoPrinicpal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerTodasLasPracticas;
        private System.Windows.Forms.Button btnAgregarPracticaSolicitada;
        private System.Windows.Forms.Button btnAgregarPracticaRealizada;
        private System.Windows.Forms.ComboBox cbxModulo;
        private System.Windows.Forms.TextBox txtCantidadPracticas;
        private System.Windows.Forms.TabPage tabReceta;
        private System.Windows.Forms.ListBox lstMedicamentos;
        private System.Windows.Forms.GroupBox gbxMedicamento;
        private System.Windows.Forms.TextBox txtBuscarMedicamento;
        private System.Windows.Forms.GroupBox gbxConcentracionMedicamento;
        private System.Windows.Forms.TextBox txtBuscarConcentracionMedicamento;
        private System.Windows.Forms.ListBox lstConcentracionesMedicamento;
        private System.Windows.Forms.GroupBox gbxPresentacionMedicamento;
        private System.Windows.Forms.TextBox txtBuscarPresentacionMedicamento;
        private System.Windows.Forms.ListBox lstPresentacionesMedicamento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblDosisReceta;
        private System.Windows.Forms.Label lblNotaReceta;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtBuscarDiagnostico;
        private System.Windows.Forms.ListBox lstDiagnosticos;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox lstPracticas;
    }
}

