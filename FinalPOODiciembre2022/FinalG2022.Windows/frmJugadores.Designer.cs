
namespace FinalG2022.Windows
{
    partial class frmJugadores
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.JugadoresDataGridView = new System.Windows.Forms.DataGridView();
            this.colJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAptitud = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.VerEquipoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.JugadoresDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.VerEquipoButton);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 677;
            this.splitContainer1.TabIndex = 0;
            // 
            // JugadoresDataGridView
            // 
            this.JugadoresDataGridView.AllowUserToAddRows = false;
            this.JugadoresDataGridView.AllowUserToDeleteRows = false;
            this.JugadoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JugadoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJugador,
            this.colEdad,
            this.colPosicion,
            this.colAptitud,
            this.colAgregar});
            this.JugadoresDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JugadoresDataGridView.Location = new System.Drawing.Point(0, 0);
            this.JugadoresDataGridView.Name = "JugadoresDataGridView";
            this.JugadoresDataGridView.ReadOnly = true;
            this.JugadoresDataGridView.Size = new System.Drawing.Size(677, 450);
            this.JugadoresDataGridView.TabIndex = 0;
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
            this.colAptitud.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAptitud.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colAgregar
            // 
            this.colAgregar.HeaderText = "";
            this.colAgregar.Name = "colAgregar";
            this.colAgregar.ReadOnly = true;
            this.colAgregar.Text = "Agregar";
            // 
            // VerEquipoButton
            // 
            this.VerEquipoButton.Location = new System.Drawing.Point(20, 33);
            this.VerEquipoButton.Name = "VerEquipoButton";
            this.VerEquipoButton.Size = new System.Drawing.Size(75, 71);
            this.VerEquipoButton.TabIndex = 0;
            this.VerEquipoButton.Text = "Ver Equipo";
            this.VerEquipoButton.UseVisualStyleBackColor = true;
            // 
            // frmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmJugadores";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView JugadoresDataGridView;
        private System.Windows.Forms.Button VerEquipoButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosicion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAptitud;
        private System.Windows.Forms.DataGridViewButtonColumn colAgregar;
    }
}

