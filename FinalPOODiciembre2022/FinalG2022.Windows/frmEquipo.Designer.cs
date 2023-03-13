
namespace FinalG2022.Windows
{
    partial class frmEquipo
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.EquipoDataGridView = new System.Windows.Forms.DataGridView();
            this.colJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAptitud = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SalirButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.EquipoDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SalirButton);
            this.splitContainer1.Panel2.Controls.Add(this.VolverButton);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 1;
            // 
            // EquipoDataGridView
            // 
            this.EquipoDataGridView.AllowUserToAddRows = false;
            this.EquipoDataGridView.AllowUserToDeleteRows = false;
            this.EquipoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquipoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJugador,
            this.colEdad,
            this.colPosicion,
            this.colAptitud,
            this.colEliminar});
            this.EquipoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EquipoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.EquipoDataGridView.MultiSelect = false;
            this.EquipoDataGridView.Name = "EquipoDataGridView";
            this.EquipoDataGridView.ReadOnly = true;
            this.EquipoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EquipoDataGridView.Size = new System.Drawing.Size(800, 370);
            this.EquipoDataGridView.TabIndex = 0;
            // 
            // colJugador
            // 
            this.colJugador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJugador.HeaderText = "Jugador";
            this.colJugador.Name = "colJugador";
            this.colJugador.ReadOnly = true;
            // 
            // colEdad
            // 
            this.colEdad.HeaderText = "Edad";
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            // 
            // colPosicion
            // 
            this.colPosicion.HeaderText = "Posición";
            this.colPosicion.Name = "colPosicion";
            this.colPosicion.ReadOnly = true;
            // 
            // colAptitud
            // 
            this.colAptitud.HeaderText = "Aptitud";
            this.colAptitud.Name = "colAptitud";
            this.colAptitud.ReadOnly = true;
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "";
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.ReadOnly = true;
            this.colEliminar.Text = "Eliminar";
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(722, 15);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(75, 49);
            this.SalirButton.TabIndex = 0;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(639, 15);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(75, 49);
            this.VolverButton.TabIndex = 0;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEquipo";
            this.Text = "frmEquipo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EquipoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView EquipoDataGridView;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosicion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAptitud;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
    }
}