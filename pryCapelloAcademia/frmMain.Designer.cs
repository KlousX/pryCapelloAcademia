namespace pryCapelloAcademia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.TMRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.TMAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.TMMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.TMPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.TMListado = new System.Windows.Forms.ToolStripMenuItem();
            this.TMPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.EFecha = new System.Windows.Forms.StatusStrip();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.mStrip.SuspendLayout();
            this.EFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMRegistro,
            this.TMListado});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(1067, 28);
            this.mStrip.TabIndex = 0;
            this.mStrip.Text = "menuStrip1";
            // 
            // TMRegistro
            // 
            this.TMRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMAlumno,
            this.TMMenu,
            this.TMPlan});
            this.TMRegistro.Name = "TMRegistro";
            this.TMRegistro.Size = new System.Drawing.Size(78, 24);
            this.TMRegistro.Text = "Registro";
            // 
            // TMAlumno
            // 
            this.TMAlumno.Name = "TMAlumno";
            this.TMAlumno.Size = new System.Drawing.Size(224, 26);
            this.TMAlumno.Text = "Alumno";
            this.TMAlumno.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // TMMenu
            // 
            this.TMMenu.Name = "TMMenu";
            this.TMMenu.Size = new System.Drawing.Size(224, 26);
            this.TMMenu.Text = "Materia";
            this.TMMenu.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // TMPlan
            // 
            this.TMPlan.Name = "TMPlan";
            this.TMPlan.Size = new System.Drawing.Size(224, 26);
            this.TMPlan.Text = "Plan";
            this.TMPlan.Click += new System.EventHandler(this.planToolStripMenuItem_Click);
            // 
            // TMListado
            // 
            this.TMListado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TMPlanes});
            this.TMListado.Name = "TMListado";
            this.TMListado.Size = new System.Drawing.Size(71, 24);
            this.TMListado.Text = "Listado";
            this.TMListado.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // TMPlanes
            // 
            this.TMPlanes.Name = "TMPlanes";
            this.TMPlanes.Size = new System.Drawing.Size(224, 26);
            this.TMPlanes.Text = "Planes";
            this.TMPlanes.Click += new System.EventHandler(this.planesToolStripMenuItem_Click);
            // 
            // EFecha
            // 
            this.EFecha.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EFecha.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFecha});
            this.EFecha.Location = new System.Drawing.Point(0, 528);
            this.EFecha.Name = "EFecha";
            this.EFecha.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.EFecha.Size = new System.Drawing.Size(1067, 26);
            this.EFecha.TabIndex = 1;
            this.EFecha.Text = "statusStrip1";
            this.EFecha.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 20);
            this.lblFecha.Text = "Fecha";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.EFecha);
            this.Controls.Add(this.mStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.EFecha.ResumeLayout(false);
            this.EFecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem TMRegistro;
        private System.Windows.Forms.ToolStripMenuItem TMAlumno;
        private System.Windows.Forms.ToolStripMenuItem TMMenu;
        private System.Windows.Forms.ToolStripMenuItem TMPlan;
        private System.Windows.Forms.ToolStripMenuItem TMListado;
        private System.Windows.Forms.StatusStrip EFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripMenuItem TMPlanes;
    }
}