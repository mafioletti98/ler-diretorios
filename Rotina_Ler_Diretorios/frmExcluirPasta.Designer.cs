namespace Rotina_Ler_Diretorios
{
    partial class frmExcluirPasta
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.btnPesquisaBQL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInformarBQL = new System.Windows.Forms.TextBox();
            this.txtCaminhoCompleto = new System.Windows.Forms.TextBox();
            this.btnSelecionarArq = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvArquivosComplet = new System.Windows.Forms.DataGridView();
            this.btnExcluirPasta = new System.Windows.Forms.Button();
            this.pnlFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivosComplet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Controls.Add(this.btnPesquisaBQL);
            this.pnlFundo.Controls.Add(this.label2);
            this.pnlFundo.Controls.Add(this.txtInformarBQL);
            this.pnlFundo.Controls.Add(this.txtCaminhoCompleto);
            this.pnlFundo.Controls.Add(this.btnSelecionarArq);
            this.pnlFundo.Controls.Add(this.label1);
            this.pnlFundo.Controls.Add(this.dgvArquivosComplet);
            this.pnlFundo.Controls.Add(this.btnExcluirPasta);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(654, 464);
            this.pnlFundo.TabIndex = 0;
            // 
            // btnPesquisaBQL
            // 
            this.btnPesquisaBQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisaBQL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPesquisaBQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaBQL.ForeColor = System.Drawing.Color.White;
            this.btnPesquisaBQL.Location = new System.Drawing.Point(12, 155);
            this.btnPesquisaBQL.Name = "btnPesquisaBQL";
            this.btnPesquisaBQL.Size = new System.Drawing.Size(108, 23);
            this.btnPesquisaBQL.TabIndex = 8;
            this.btnPesquisaBQL.Text = "Pesquisar BQL";
            this.btnPesquisaBQL.UseVisualStyleBackColor = false;
            this.btnPesquisaBQL.Click += new System.EventHandler(this.btnPesquisaBQL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Informe o BQL:";
            // 
            // txtInformarBQL
            // 
            this.txtInformarBQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInformarBQL.Location = new System.Drawing.Point(12, 124);
            this.txtInformarBQL.Name = "txtInformarBQL";
            this.txtInformarBQL.Size = new System.Drawing.Size(630, 20);
            this.txtInformarBQL.TabIndex = 6;
            // 
            // txtCaminhoCompleto
            // 
            this.txtCaminhoCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoCompleto.Enabled = false;
            this.txtCaminhoCompleto.Location = new System.Drawing.Point(12, 85);
            this.txtCaminhoCompleto.Name = "txtCaminhoCompleto";
            this.txtCaminhoCompleto.Size = new System.Drawing.Size(630, 20);
            this.txtCaminhoCompleto.TabIndex = 5;
            // 
            // btnSelecionarArq
            // 
            this.btnSelecionarArq.BackColor = System.Drawing.Color.White;
            this.btnSelecionarArq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSelecionarArq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionarArq.Location = new System.Drawing.Point(12, 26);
            this.btnSelecionarArq.Name = "btnSelecionarArq";
            this.btnSelecionarArq.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarArq.TabIndex = 4;
            this.btnSelecionarArq.Text = "Selecionar Arquivo";
            this.btnSelecionarArq.UseVisualStyleBackColor = false;
            this.btnSelecionarArq.Click += new System.EventHandler(this.btnSelecionarArq_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Caminho Completo";
            // 
            // dgvArquivosComplet
            // 
            this.dgvArquivosComplet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArquivosComplet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArquivosComplet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArquivosComplet.Location = new System.Drawing.Point(12, 184);
            this.dgvArquivosComplet.Name = "dgvArquivosComplet";
            this.dgvArquivosComplet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArquivosComplet.Size = new System.Drawing.Size(545, 277);
            this.dgvArquivosComplet.TabIndex = 2;
            // 
            // btnExcluirPasta
            // 
            this.btnExcluirPasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirPasta.BackColor = System.Drawing.Color.White;
            this.btnExcluirPasta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExcluirPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPasta.Location = new System.Drawing.Point(559, 26);
            this.btnExcluirPasta.Name = "btnExcluirPasta";
            this.btnExcluirPasta.Size = new System.Drawing.Size(83, 23);
            this.btnExcluirPasta.TabIndex = 0;
            this.btnExcluirPasta.Text = "Excluir Pasta";
            this.btnExcluirPasta.UseVisualStyleBackColor = false;
            this.btnExcluirPasta.Click += new System.EventHandler(this.btnExcluirPasta_Click);
            // 
            // frmExcluirPasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(654, 464);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmExcluirPasta";
            this.Text = "Excluir Pasta";
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivosComplet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Button btnExcluirPasta;
        private System.Windows.Forms.DataGridView dgvArquivosComplet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelecionarArq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInformarBQL;
        private System.Windows.Forms.TextBox txtCaminhoCompleto;
        private System.Windows.Forms.Button btnPesquisaBQL;
    }
}