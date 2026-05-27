namespace pryCapelloAcademia
{
    partial class frmRegistro
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
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.mskCode = new System.Windows.Forms.MaskedTextBox();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnRegistrarPlan = new System.Windows.Forms.Button();
            this.gbRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistro
            // 
            this.gbRegistro.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbRegistro.Controls.Add(this.btnRegistrarPlan);
            this.gbRegistro.Controls.Add(this.mskCode);
            this.gbRegistro.Controls.Add(this.btnListado);
            this.gbRegistro.Controls.Add(this.btnCancelar);
            this.gbRegistro.Controls.Add(this.btnRegistrar);
            this.gbRegistro.Controls.Add(this.cboPlan);
            this.gbRegistro.Controls.Add(this.txtNombre);
            this.gbRegistro.Controls.Add(this.lblActivo);
            this.gbRegistro.Controls.Add(this.lblPlan);
            this.gbRegistro.Controls.Add(this.chkActivo);
            this.gbRegistro.Controls.Add(this.lblNombre);
            this.gbRegistro.Controls.Add(this.lblCode);
            this.gbRegistro.Location = new System.Drawing.Point(12, 12);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(248, 204);
            this.gbRegistro.TabIndex = 0;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Registro Materia/Asignatura";
            // 
            // mskCode
            // 
            this.mskCode.Location = new System.Drawing.Point(93, 30);
            this.mskCode.Mask = "99999";
            this.mskCode.Name = "mskCode";
            this.mskCode.Size = new System.Drawing.Size(121, 20);
            this.mskCode.TabIndex = 0;
            this.mskCode.ValidatingType = typeof(int);
            this.mskCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCode_MaskInputRejected);
            // 
            // btnListado
            // 
            this.btnListado.Location = new System.Drawing.Point(5, 170);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(75, 23);
            this.btnListado.TabIndex = 6;
            this.btnListado.Text = "Listado";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(86, 170);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(167, 170);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cboPlan
            // 
            this.cboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Items.AddRange(new object[] {
            "Plan 1",
            "Plan 2",
            "Plan 3"});
            this.cboPlan.Location = new System.Drawing.Point(93, 100);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(121, 21);
            this.cboPlan.TabIndex = 2;
            this.cboPlan.SelectedIndexChanged += new System.EventHandler(this.cboPlan_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(16, 135);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(38, 15);
            this.lblActivo.TabIndex = 5;
            this.lblActivo.Text = "Activo";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlan.Location = new System.Drawing.Point(16, 100);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(32, 15);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "Plan";
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(93, 136);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(15, 14);
            this.chkActivo.TabIndex = 3;
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(16, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Código";
            // 
            // btnRegistrarPlan
            // 
            this.btnRegistrarPlan.Location = new System.Drawing.Point(114, 132);
            this.btnRegistrarPlan.Name = "btnRegistrarPlan";
            this.btnRegistrarPlan.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrarPlan.TabIndex = 7;
            this.btnRegistrarPlan.Text = "Registrar Plan";
            this.btnRegistrarPlan.UseVisualStyleBackColor = true;
            this.btnRegistrarPlan.Click += new System.EventHandler(this.btnRegistrarPlan_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(275, 226);
            this.Controls.Add(this.gbRegistro);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.MaskedTextBox mskCode;
        private System.Windows.Forms.Button btnRegistrarPlan;
    }
}