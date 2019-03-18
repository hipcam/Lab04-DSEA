namespace Evaluacion
{
    partial class FrmClientesPorPais
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.dgvPedidosxCliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNroPedidos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosxCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAIS :";
            // 
            // cboPais
            // 
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(107, 34);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(321, 21);
            this.cboPais.TabIndex = 1;
            this.cboPais.SelectionChangeCommitted += new System.EventHandler(this.cboPais_SelectionChangeCommitted);
            this.cboPais.SelectedValueChanged += new System.EventHandler(this.cboPais_SelectedValueChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 61);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(475, 112);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // dgvPedidosxCliente
            // 
            this.dgvPedidosxCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPedidosxCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosxCliente.Location = new System.Drawing.Point(12, 182);
            this.dgvPedidosxCliente.Name = "dgvPedidosxCliente";
            this.dgvPedidosxCliente.Size = new System.Drawing.Size(268, 112);
            this.dgvPedidosxCliente.TabIndex = 3;
            this.dgvPedidosxCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidosxCliente_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nro de Pedidos";
            // 
            // txtNroPedidos
            // 
            this.txtNroPedidos.Location = new System.Drawing.Point(307, 255);
            this.txtNroPedidos.Name = "txtNroPedidos";
            this.txtNroPedidos.ReadOnly = true;
            this.txtNroPedidos.Size = new System.Drawing.Size(100, 20);
            this.txtNroPedidos.TabIndex = 5;
            this.txtNroPedidos.TextChanged += new System.EventHandler(this.txtNroPedidos_TextChanged);
            // 
            // FrmClientesPorPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 306);
            this.Controls.Add(this.txtNroPedidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPedidosxCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientesPorPais";
            this.Text = "FrmClientesPorPais";
            this.Load += new System.EventHandler(this.FrmClientesPorPais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosxCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridView dgvPedidosxCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNroPedidos;
    }
}