namespace pryCapelloAcademia
{
    partial class frmAlumno
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
            this.panGeneral = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFechaActualizacion = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.MaskedTextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.lblRegistroXX = new System.Windows.Forms.Label();
            this.lblActualizacionXX = new System.Windows.Forms.Label();
            this.panGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // panGeneral
            // 
            this.panGeneral.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panGeneral.Controls.Add(this.lblActualizacionXX);
            this.panGeneral.Controls.Add(this.lblRegistroXX);
            this.panGeneral.Controls.Add(this.txtDni);
            this.panGeneral.Controls.Add(this.btnEliminar);
            this.panGeneral.Controls.Add(this.dgvAlumnos);
            this.panGeneral.Controls.Add(this.btnEditar);
            this.panGeneral.Controls.Add(this.btnAgregar);
            this.panGeneral.Controls.Add(this.lblFechaActualizacion);
            this.panGeneral.Controls.Add(this.lblFechaRegistro);
            this.panGeneral.Controls.Add(this.dtpFechaNacimiento);
            this.panGeneral.Controls.Add(this.lblFecha);
            this.panGeneral.Controls.Add(this.txtContacto);
            this.panGeneral.Controls.Add(this.lblContacto);
            this.panGeneral.Controls.Add(this.lblDireccion);
            this.panGeneral.Controls.Add(this.txtDireccion);
            this.panGeneral.Controls.Add(this.lblApellido);
            this.panGeneral.Controls.Add(this.txtApellido);
            this.panGeneral.Controls.Add(this.lblNombre);
            this.panGeneral.Controls.Add(this.txtNombre);
            this.panGeneral.Controls.Add(this.lblDni);
            this.panGeneral.Location = new System.Drawing.Point(9, 10);
            this.panGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panGeneral.Name = "panGeneral";
            this.panGeneral.Size = new System.Drawing.Size(1012, 275);
            this.panGeneral.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(149, 239);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 22);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDni,
            this.colNombre,
            this.colApellido,
            this.colDireccion,
            this.colContacto,
            this.colFechaNacimiento});
            this.dgvAlumnos.Location = new System.Drawing.Point(221, 11);
            this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(780, 250);
            this.dgvAlumnos.TabIndex = 15;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // colDni
            // 
            this.colDni.HeaderText = "DNI";
            this.colDni.MinimumWidth = 6;
            this.colDni.Name = "colDni";
            this.colDni.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.MinimumWidth = 6;
            this.colApellido.Name = "colApellido";
            this.colApellido.Width = 125;
            // 
            // colDireccion
            // 
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.MinimumWidth = 6;
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Width = 125;
            // 
            // colContacto
            // 
            this.colContacto.HeaderText = "Contacto";
            this.colContacto.MinimumWidth = 6;
            this.colContacto.Name = "colContacto";
            this.colContacto.Width = 125;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.colFechaNacimiento.MinimumWidth = 6;
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.Width = 125;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(84, 239);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 22);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 239);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 22);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFechaActualizacion
            // 
            this.lblFechaActualizacion.AutoSize = true;
            this.lblFechaActualizacion.Location = new System.Drawing.Point(17, 212);
            this.lblFechaActualizacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaActualizacion.Name = "lblFechaActualizacion";
            this.lblFechaActualizacion.Size = new System.Drawing.Size(117, 13);
            this.lblFechaActualizacion.TabIndex = 14;
            this.lblFechaActualizacion.Text = "Fecha de actualización";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Location = new System.Drawing.Point(17, 184);
            this.lblFechaRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(89, 13);
            this.lblFechaRegistro.TabIndex = 13;
            this.lblFechaRegistro.Text = "Fecha de registro";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "09/06/2026";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(121, 153);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaNacimiento.TabIndex = 5;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 155);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(106, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(72, 124);
            this.txtContacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContacto.Mask = "(999)000-0000";
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(134, 20);
            this.txtContacto.TabIndex = 4;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(17, 127);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 9;
            this.lblContacto.Text = "Contacto";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 98);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(72, 96);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(134, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 70);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(72, 67);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(134, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 41);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 39);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(17, 13);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 1;
            this.lblDni.Text = "DNI";
            this.lblDni.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(72, 13);
            this.txtDni.Mask = "00000000";
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(133, 20);
            this.txtDni.TabIndex = 0;
            // 
            // lblRegistroXX
            // 
            this.lblRegistroXX.AutoSize = true;
            this.lblRegistroXX.Location = new System.Drawing.Point(167, 184);
            this.lblRegistroXX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistroXX.Name = "lblRegistroXX";
            this.lblRegistroXX.Size = new System.Drawing.Size(17, 13);
            this.lblRegistroXX.TabIndex = 17;
            this.lblRegistroXX.Text = "xx";
            // 
            // lblActualizacionXX
            // 
            this.lblActualizacionXX.AutoSize = true;
            this.lblActualizacionXX.Location = new System.Drawing.Point(167, 212);
            this.lblActualizacionXX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualizacionXX.Name = "lblActualizacionXX";
            this.lblActualizacionXX.Size = new System.Drawing.Size(17, 13);
            this.lblActualizacionXX.TabIndex = 18;
            this.lblActualizacionXX.Text = "xx";
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1032, 293);
            this.Controls.Add(this.panGeneral);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Alumno";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.panGeneral.ResumeLayout(false);
            this.panGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGeneral;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox txtContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.Label lblFechaActualizacion;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNacimiento;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.MaskedTextBox txtDni;
        private System.Windows.Forms.Label lblRegistroXX;
        private System.Windows.Forms.Label lblActualizacionXX;
    }
}