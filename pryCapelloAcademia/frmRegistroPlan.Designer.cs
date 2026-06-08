namespace pryCapelloAcademia
{
    partial class frmRegistroPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listPlanes = new System.Windows.Forms.ListBox();
            this.btnAgregarPlan = new System.Windows.Forms.Button();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.listPlanes);
            this.panel1.Controls.Add(this.btnAgregarPlan);
            this.panel1.Controls.Add(this.lblPlan);
            this.panel1.Controls.Add(this.txtPlan);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 271);
            this.panel1.TabIndex = 0;
            // 
            // listPlanes
            // 
            this.listPlanes.FormattingEnabled = true;
            this.listPlanes.Location = new System.Drawing.Point(20, 45);
            this.listPlanes.Name = "listPlanes";
            this.listPlanes.Size = new System.Drawing.Size(336, 186);
            this.listPlanes.TabIndex = 3;
            this.listPlanes.SelectedIndexChanged += new System.EventHandler(this.listPlanes_SelectedIndexChanged);
            // 
            // btnAgregarPlan
            // 
            this.btnAgregarPlan.Location = new System.Drawing.Point(191, 236);
            this.btnAgregarPlan.Name = "btnAgregarPlan";
            this.btnAgregarPlan.Size = new System.Drawing.Size(165, 23);
            this.btnAgregarPlan.TabIndex = 1;
            this.btnAgregarPlan.Text = "Agregar Plan";
            this.btnAgregarPlan.UseVisualStyleBackColor = true;
            this.btnAgregarPlan.Click += new System.EventHandler(this.btnAgregarPlan_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(17, 22);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(85, 13);
            this.lblPlan.TabIndex = 1;
            this.lblPlan.Text = "Nombre del Plan";
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(123, 19);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(233, 20);
            this.txtPlan.TabIndex = 0;
            this.txtPlan.TextChanged += new System.EventHandler(this.txtPlan_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(20, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(165, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmRegistroPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 288);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistroPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Plan";
            this.Load += new System.EventHandler(this.frmRegistroPlan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Button btnAgregarPlan;
        private System.Windows.Forms.ListBox listPlanes;
        private System.Windows.Forms.Button btnCancelar;
    }
}