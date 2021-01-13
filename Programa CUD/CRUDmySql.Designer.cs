namespace Programa_CUD
{
    partial class CRUDmySql
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTabla = new System.Windows.Forms.ComboBox();
            this.lblCampos = new System.Windows.Forms.Label();
            this.btnEjecutarConsulta = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.cbAcciones = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAcciones = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblTablas = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(627, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 702);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingrese los datos del nuevo registro:";
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
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 78);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
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
            // btnEjecutarConsulta
            // 
            this.btnEjecutarConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEjecutarConsulta.Location = new System.Drawing.Point(198, 52);
            this.btnEjecutarConsulta.Name = "btnEjecutarConsulta";
            this.btnEjecutarConsulta.Size = new System.Drawing.Size(121, 23);
            this.btnEjecutarConsulta.TabIndex = 9;
            this.btnEjecutarConsulta.Text = "Ejecutar Consulta";
            this.btnEjecutarConsulta.UseVisualStyleBackColor = false;
            this.btnEjecutarConsulta.Click += new System.EventHandler(this.btnEjecutarConsulta_Click);
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
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValor.Location = new System.Drawing.Point(484, 21);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(132, 20);
            this.txtValor.TabIndex = 15;
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
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtId.Location = new System.Drawing.Point(396, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 20);
            this.txtId.TabIndex = 14;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 380);
            this.dataGridView1.TabIndex = 21;
            // 
            // CRUDmySql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CRUDmySql";
            this.Text = "CRUDmySql";
            this.Load += new System.EventHandler(this.CRUDmySql_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTabla;
        private System.Windows.Forms.Label lblCampos;
        private System.Windows.Forms.Button btnEjecutarConsulta;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cbAcciones;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAcciones;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTablas;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}