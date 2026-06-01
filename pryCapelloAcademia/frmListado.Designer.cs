namespace pryCapelloAcademia
{
    partial class frmListado
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
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.cboPlan = new System.Windows.Forms.ComboBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rdbPlan = new System.Windows.Forms.RadioButton();
            this.rdbCode = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mskCode = new System.Windows.Forms.MaskedTextBox();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(18, 25);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 4;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // cboPlan
            // 
            this.cboPlan.FormattingEnabled = true;
            this.cboPlan.Location = new System.Drawing.Point(101, 124);
            this.cboPlan.Name = "cboPlan";
            this.cboPlan.Size = new System.Drawing.Size(123, 21);
            this.cboPlan.TabIndex = 6;
            // 
            // gbBuscar
            // 
            this.gbBuscar.BackColor = System.Drawing.Color.White;
            this.gbBuscar.Controls.Add(this.mskCode);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.rdbPlan);
            this.gbBuscar.Controls.Add(this.rdbCode);
            this.gbBuscar.Controls.Add(this.rdbNombre);
            this.gbBuscar.Controls.Add(this.txtNombre);
            this.gbBuscar.Controls.Add(this.cboPlan);
            this.gbBuscar.Controls.Add(this.rdbTodos);
            this.gbBuscar.Location = new System.Drawing.Point(12, 7);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(230, 190);
            this.gbBuscar.TabIndex = 7;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(125, 161);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbPlan
            // 
            this.rdbPlan.AutoSize = true;
            this.rdbPlan.Location = new System.Drawing.Point(18, 125);
            this.rdbPlan.Name = "rdbPlan";
            this.rdbPlan.Size = new System.Drawing.Size(46, 17);
            this.rdbPlan.TabIndex = 9;
            this.rdbPlan.TabStop = true;
            this.rdbPlan.Text = "Plan";
            this.rdbPlan.UseVisualStyleBackColor = true;
            // 
            // rdbCode
            // 
            this.rdbCode.AutoSize = true;
            this.rdbCode.Location = new System.Drawing.Point(18, 89);
            this.rdbCode.Name = "rdbCode";
            this.rdbCode.Size = new System.Drawing.Size(58, 17);
            this.rdbCode.TabIndex = 8;
            this.rdbCode.TabStop = true;
            this.rdbCode.Text = "Código";
            this.rdbCode.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(18, 56);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 7;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colCode,
            this.colPlan,
            this.colActivo});
            this.dgvListado.Location = new System.Drawing.Point(248, 7);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(432, 190);
            this.dgvListado.TabIndex = 8;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Código";
            this.colCode.Name = "colCode";
            // 
            // colPlan
            // 
            this.colPlan.HeaderText = "Plan";
            this.colPlan.Name = "colPlan";
            // 
            // colActivo
            // 
            this.colActivo.HeaderText = "Activo";
            this.colActivo.Name = "colActivo";
            // 
            // mskCode
            // 
            this.mskCode.Location = new System.Drawing.Point(101, 89);
            this.mskCode.Mask = "99999999999";
            this.mskCode.Name = "mskCode";
            this.mskCode.Size = new System.Drawing.Size(123, 20);
            this.mskCode.TabIndex = 11;
            this.mskCode.ValidatingType = typeof(int);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 203);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.gbBuscar);
            this.Name = "frmListado";
            this.Text = "Búsqueda";
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.RadioButton rdbPlan;
        private System.Windows.Forms.RadioButton rdbCode;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
        private System.Windows.Forms.MaskedTextBox mskCode;
    }
}