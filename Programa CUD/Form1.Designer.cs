namespace Programa_CUD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbTabla = new System.Windows.Forms.ComboBox();
            this.btnEjecutarConsulta = new System.Windows.Forms.Button();
            this.cbAcciones = new System.Windows.Forms.ComboBox();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.lblTablas = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCampos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 380);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbTabla
            // 
            this.cbTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbTabla.FormattingEnabled = true;
            this.cbTabla.Items.AddRange(new object[] {
            "AcesorLegalDepartamento",
            "AcesorLegalDivision",
            "AcesorLegalGeneral",
            "AcesorLegalSeccion",
            "AcesorFinancieroDepartamento",
            "AcesorFinancieroDivision",
            "AcesorFinancieroGeneral",
            "AcesorFinancieroSeccion",
            "AcesorTecnicoGeneral",
            "AdministradorMision",
            "AgenteCampo ",
            "AnalistaDivision",
            "AnalistaDepartamento",
            "AnalistaGeneral",
            "AnalistaSeccion",
            "CampoEntrenamiento",
            "Candidato",
            "CentroMisiones",
            "Departamento",
            "DirectorEscuela",
            "DirectorDepartamento",
            "DirectorGeneralAdjunto",
            "DirectorGeneral",
            "DirectorSeccion",
            "DirectorDivision",
            "Division",
            "Embajada",
            "Entrenador",
            "Escuela",
            "Evaluador",
            "Examen",
            "Fuente",
            "Informacion ",
            "Informe",
            "JefeRecursosHumanos",
            "Maestro",
            "Mision",
            "OficinaRecursosHumanos",
            "Pais",
            "Presupuesto ",
            "Reporte",
            "Recurso ",
            "Seccion",
            "SupervisorDivision",
            "SupervisorDepartamento",
            "SupervisorGeneral",
            "SupervisorMision",
            "SupervisorSeccion",
            "TecnicoDepartamento",
            "TecnicoDivision",
            "TecnicoSeccion",
            "EntrenadorCandidato",
            "MaestroCandidato",
            "DirectorDepartamentoReporte",
            "DirectorDivisionReporte",
            "DirectorSeccionReporte"});
            this.cbTabla.Location = new System.Drawing.Point(66, 54);
            this.cbTabla.Name = "cbTabla";
            this.cbTabla.Size = new System.Drawing.Size(121, 21);
            this.cbTabla.TabIndex = 7;
            this.cbTabla.Text = "AgenteCampo ";
            this.cbTabla.TextChanged += new System.EventHandler(this.cbTabla_TextChanged);
            // 
            // btnEjecutarConsulta
            // 
            this.btnEjecutarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEjecutarConsulta.Location = new System.Drawing.Point(198, 52);
            this.btnEjecutarConsulta.Name = "btnEjecutarConsulta";
            this.btnEjecutarConsulta.Size = new System.Drawing.Size(121, 23);
            this.btnEjecutarConsulta.TabIndex = 9;
            this.btnEjecutarConsulta.Text = "Ejecutar Consulta";
            this.btnEjecutarConsulta.UseVisualStyleBackColor = false;
            this.btnEjecutarConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAcciones
            // 
            this.cbAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbAcciones.FormattingEnabled = true;
            this.cbAcciones.Items.AddRange(new object[] {
            "Insertar Registro",
            "Mostrar Registros",
            "Actualizar Registros",
            "Eliminar Registros"});
            this.cbAcciones.Location = new System.Drawing.Point(66, 19);
            this.cbAcciones.Name = "cbAcciones";
            this.cbAcciones.Size = new System.Drawing.Size(121, 21);
            this.cbAcciones.TabIndex = 10;
            this.cbAcciones.Text = "Mostrar Registros";
            this.cbAcciones.TextChanged += new System.EventHandler(this.cbAcciones_TextChanged);
            // 
            // lblAcciones
            // 
            this.lblAcciones.AutoSize = true;
            this.lblAcciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAcciones.Location = new System.Drawing.Point(3, 22);
            this.lblAcciones.Name = "lblAcciones";
            this.lblAcciones.Size = new System.Drawing.Size(63, 13);
            this.lblAcciones.TabIndex = 11;
            this.lblAcciones.Text = "Acciones:";
            // 
            // lblTablas
            // 
            this.lblTablas.AutoSize = true;
            this.lblTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTablas.Location = new System.Drawing.Point(16, 57);
            this.lblTablas.Name = "lblTablas";
            this.lblTablas.Size = new System.Drawing.Size(49, 13);
            this.lblTablas.TabIndex = 12;
            this.lblTablas.Text = "Tablas:";
            // 
            // cbCampo
            // 
            this.cbCampo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(247, 20);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 13;
            this.cbCampo.Text = "Campo";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.Location = new System.Drawing.Point(396, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 20);
            this.txtId.TabIndex = 14;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValor.Location = new System.Drawing.Point(484, 21);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 20);
            this.txtValor.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblID.Location = new System.Drawing.Point(371, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "ID:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblValor.Location = new System.Drawing.Point(443, 24);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(40, 13);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor:";
            // 
            // lblCampos
            // 
            this.lblCampos.AutoSize = true;
            this.lblCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCampos.Location = new System.Drawing.Point(190, 23);
            this.lblCampos.Name = "lblCampos";
            this.lblCampos.Size = new System.Drawing.Size(55, 13);
            this.lblCampos.TabIndex = 18;
            this.lblCampos.Text = "Campos:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cbTabla);
            this.groupBox1.Controls.Add(this.lblCampos);
            this.groupBox1.Controls.Add(this.btnEjecutarConsulta);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.cbAcciones);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lblAcciones);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblTablas);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.cbCampo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 78);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(632, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 702);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los datos del nuevo registro:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(927, 723);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbTabla;
        private System.Windows.Forms.Button btnEjecutarConsulta;
        private System.Windows.Forms.ComboBox cbAcciones;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

