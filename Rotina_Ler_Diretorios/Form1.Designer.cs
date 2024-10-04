namespace Rotina_Ler_Diretorios
{
    partial class frmRotinaDiretorios
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBarLeitura = new System.Windows.Forms.ProgressBar();
            this.dgvTotalArquivos = new System.Windows.Forms.DataGridView();
            this.dgvTotalDiretorios = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcPasta = new System.Windows.Forms.Button();
            this.ckbLerDiretSubDiret = new System.Windows.Forms.CheckBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnDireSaidaExport = new System.Windows.Forms.Button();
            this.btnDireEntrada = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalArquivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalDiretorios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.progressBarLeitura);
            this.panel1.Controls.Add(this.dgvTotalArquivos);
            this.panel1.Controls.Add(this.dgvTotalDiretorios);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSaida);
            this.panel1.Controls.Add(this.txtEntrada);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // progressBarLeitura
            // 
            this.progressBarLeitura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLeitura.Location = new System.Drawing.Point(358, 415);
            this.progressBarLeitura.Name = "progressBarLeitura";
            this.progressBarLeitura.Size = new System.Drawing.Size(86, 23);
            this.progressBarLeitura.TabIndex = 8;
            this.progressBarLeitura.Visible = false;
            // 
            // dgvTotalArquivos
            // 
            this.dgvTotalArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTotalArquivos.Location = new System.Drawing.Point(12, 181);
            this.dgvTotalArquivos.Name = "dgvTotalArquivos";
            this.dgvTotalArquivos.Size = new System.Drawing.Size(338, 257);
            this.dgvTotalArquivos.TabIndex = 5;
            // 
            // dgvTotalDiretorios
            // 
            this.dgvTotalDiretorios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTotalDiretorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalDiretorios.Location = new System.Drawing.Point(448, 181);
            this.dgvTotalDiretorios.Name = "dgvTotalDiretorios";
            this.dgvTotalDiretorios.Size = new System.Drawing.Size(340, 257);
            this.dgvTotalDiretorios.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saída";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entrada";
            // 
            // txtSaida
            // 
            this.txtSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSaida.Enabled = false;
            this.txtSaida.Location = new System.Drawing.Point(12, 155);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(776, 20);
            this.txtSaida.TabIndex = 2;
            // 
            // txtEntrada
            // 
            this.txtEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Location = new System.Drawing.Point(12, 103);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(776, 20);
            this.txtEntrada.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcPasta);
            this.groupBox1.Controls.Add(this.ckbLerDiretSubDiret);
            this.groupBox1.Controls.Add(this.btnCarregar);
            this.groupBox1.Controls.Add(this.btnDireSaidaExport);
            this.groupBox1.Controls.Add(this.btnDireEntrada);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnExcPasta
            // 
            this.btnExcPasta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcPasta.BackColor = System.Drawing.Color.White;
            this.btnExcPasta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcPasta.Location = new System.Drawing.Point(630, 19);
            this.btnExcPasta.Name = "btnExcPasta";
            this.btnExcPasta.Size = new System.Drawing.Size(75, 23);
            this.btnExcPasta.TabIndex = 4;
            this.btnExcPasta.Text = "Excluir";
            this.btnExcPasta.UseVisualStyleBackColor = false;
            this.btnExcPasta.Click += new System.EventHandler(this.btnExcPasta_Click);
            // 
            // ckbLerDiretSubDiret
            // 
            this.ckbLerDiretSubDiret.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbLerDiretSubDiret.AutoSize = true;
            this.ckbLerDiretSubDiret.Location = new System.Drawing.Point(308, 19);
            this.ckbLerDiretSubDiret.Name = "ckbLerDiretSubDiret";
            this.ckbLerDiretSubDiret.Size = new System.Drawing.Size(295, 17);
            this.ckbLerDiretSubDiret.TabIndex = 3;
            this.ckbLerDiretSubDiret.Text = "LER ARQUIVOS DO DIRETORIO + SUBDIRETÓRIOS?";
            this.ckbLerDiretSubDiret.UseVisualStyleBackColor = true;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarregar.BackColor = System.Drawing.Color.White;
            this.btnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregar.Location = new System.Drawing.Point(722, 19);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = false;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnDireSaidaExport
            // 
            this.btnDireSaidaExport.BackColor = System.Drawing.Color.White;
            this.btnDireSaidaExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDireSaidaExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDireSaidaExport.Location = new System.Drawing.Point(136, 19);
            this.btnDireSaidaExport.Name = "btnDireSaidaExport";
            this.btnDireSaidaExport.Size = new System.Drawing.Size(154, 23);
            this.btnDireSaidaExport.TabIndex = 1;
            this.btnDireSaidaExport.Text = "Diretório de Saída (Exportar)";
            this.btnDireSaidaExport.UseVisualStyleBackColor = false;
            this.btnDireSaidaExport.Click += new System.EventHandler(this.btnDireSaidaExport_Click);
            // 
            // btnDireEntrada
            // 
            this.btnDireEntrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDireEntrada.BackColor = System.Drawing.Color.White;
            this.btnDireEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDireEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDireEntrada.Location = new System.Drawing.Point(12, 19);
            this.btnDireEntrada.Name = "btnDireEntrada";
            this.btnDireEntrada.Size = new System.Drawing.Size(118, 23);
            this.btnDireEntrada.TabIndex = 0;
            this.btnDireEntrada.Text = "Diretório de Entrada";
            this.btnDireEntrada.UseVisualStyleBackColor = false;
            this.btnDireEntrada.Click += new System.EventHandler(this.btnDireEntrada_Click);
            // 
            // frmRotinaDiretorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmRotinaDiretorios";
            this.Text = "Rotina Para Ler Diretórios SubDiretórios e Exportar Lista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalArquivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalDiretorios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbLerDiretSubDiret;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnDireSaidaExport;
        private System.Windows.Forms.Button btnDireEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.DataGridView dgvTotalDiretorios;
        private System.Windows.Forms.Button btnExcPasta;
        private System.Windows.Forms.DataGridView dgvTotalArquivos;
        private System.Windows.Forms.ProgressBar progressBarLeitura;
    }
}

