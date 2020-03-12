namespace AplicationLayer
{
    partial class frmBuscarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRegistroCliente = new System.Windows.Forms.DataGridView();
            this.cmlTipo_Domunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumero_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrimer_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSegundo_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrimer_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSegundo_Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRegistroCliente);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Controls.Add(this.cmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1493, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvRegistroCliente
            // 
            this.dgvRegistroCliente.AllowUserToAddRows = false;
            this.dgvRegistroCliente.AllowUserToDeleteRows = false;
            this.dgvRegistroCliente.BackgroundColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmlTipo_Domunto,
            this.clmNumero_Documento,
            this.clmPrimer_Nombre,
            this.clmSegundo_Nombre,
            this.clmPrimer_Apellido,
            this.clmSegundo_Apellido,
            this.clmEmail,
            this.clmDireccion,
            this.clmTelefono});
            this.dgvRegistroCliente.Location = new System.Drawing.Point(27, 431);
            this.dgvRegistroCliente.Name = "dgvRegistroCliente";
            this.dgvRegistroCliente.ReadOnly = true;
            this.dgvRegistroCliente.Size = new System.Drawing.Size(1443, 146);
            this.dgvRegistroCliente.TabIndex = 32;
            // 
            // cmlTipo_Domunto
            // 
            this.cmlTipo_Domunto.DataPropertyName = "tipo_documento";
            this.cmlTipo_Domunto.HeaderText = "Tipo Documento";
            this.cmlTipo_Domunto.Name = "cmlTipo_Domunto";
            this.cmlTipo_Domunto.ReadOnly = true;
            this.cmlTipo_Domunto.Width = 150;
            // 
            // clmNumero_Documento
            // 
            this.clmNumero_Documento.DataPropertyName = "numero_documento";
            this.clmNumero_Documento.HeaderText = "Numero Documento";
            this.clmNumero_Documento.Name = "clmNumero_Documento";
            this.clmNumero_Documento.ReadOnly = true;
            this.clmNumero_Documento.Width = 150;
            // 
            // clmPrimer_Nombre
            // 
            this.clmPrimer_Nombre.DataPropertyName = "primer_nombre";
            this.clmPrimer_Nombre.HeaderText = "Primer Nombre";
            this.clmPrimer_Nombre.Name = "clmPrimer_Nombre";
            this.clmPrimer_Nombre.ReadOnly = true;
            this.clmPrimer_Nombre.Width = 150;
            // 
            // clmSegundo_Nombre
            // 
            this.clmSegundo_Nombre.DataPropertyName = "segundo_nombre";
            this.clmSegundo_Nombre.HeaderText = "Segundo Nombre";
            this.clmSegundo_Nombre.Name = "clmSegundo_Nombre";
            this.clmSegundo_Nombre.ReadOnly = true;
            this.clmSegundo_Nombre.Width = 150;
            // 
            // clmPrimer_Apellido
            // 
            this.clmPrimer_Apellido.DataPropertyName = "primer_apellido";
            this.clmPrimer_Apellido.HeaderText = "Primer Apellido";
            this.clmPrimer_Apellido.Name = "clmPrimer_Apellido";
            this.clmPrimer_Apellido.ReadOnly = true;
            this.clmPrimer_Apellido.Width = 150;
            // 
            // clmSegundo_Apellido
            // 
            this.clmSegundo_Apellido.DataPropertyName = "segundo_apellido";
            this.clmSegundo_Apellido.HeaderText = "Segundo Apellido";
            this.clmSegundo_Apellido.Name = "clmSegundo_Apellido";
            this.clmSegundo_Apellido.ReadOnly = true;
            this.clmSegundo_Apellido.Width = 150;
            // 
            // clmEmail
            // 
            this.clmEmail.DataPropertyName = "email";
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 200;
            // 
            // clmDireccion
            // 
            this.clmDireccion.DataPropertyName = "direccion";
            this.clmDireccion.HeaderText = "Direccion";
            this.clmDireccion.Name = "clmDireccion";
            this.clmDireccion.ReadOnly = true;
            this.clmDireccion.Width = 150;
            // 
            // clmTelefono
            // 
            this.clmTelefono.DataPropertyName = "telefono";
            this.clmTelefono.HeaderText = "Telefono";
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.ReadOnly = true;
            this.clmTelefono.Width = 150;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1015, 209);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(128, 48);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(618, 221);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(265, 33);
            this.txt.TabIndex = 17;
            // 
            // cmb
            // 
            this.cmb.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmb.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "buscar numero documento",
            "buscar primer nombre",
            "buscar segundo nombre",
            "buscar primer apellido",
            "buscar segundo apellido"});
            this.cmb.Location = new System.Drawing.Point(170, 221);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(310, 33);
            this.cmb.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1487, 62);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar Cliente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 642);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBuscarClientes";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvRegistroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmlTipo_Domunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrimer_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSegundo_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrimer_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSegundo_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
    }
}