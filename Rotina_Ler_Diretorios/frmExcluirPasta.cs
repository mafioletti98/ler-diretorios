using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Rotina_Ler_Diretorios
{
    public partial class frmExcluirPasta : Form
    {
        public frmExcluirPasta()
        {
            InitializeComponent();
        }

        private async void btnSelecionarArq_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivoSelecionado = openFileDialog.FileName;

                    txtCaminhoCompleto.Text = caminhoArquivoSelecionado;

                    await PreencherDataGrid(caminhoArquivoSelecionado);
                }
            }
        }

        private async Task PreencherDataGrid(string caminhoArquivo)
        {
            dgvArquivosComplet.Rows.Clear();

            if (dgvArquivosComplet.Columns.Count == 0)
            {
                dgvArquivosComplet.Columns.Add("Nome", "Nome do Arquivo");
                dgvArquivosComplet.Columns.Add("Tamanho", "Tamanho");
                dgvArquivosComplet.Columns.Add("Extensão", "Extensão");
                dgvArquivosComplet.Columns.Add("BQL", "BQL");
                dgvArquivosComplet.Columns.Add("Caminho Completo", "Caminho Completo");
            }

            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    IWorkbook workbook;
                    using (FileStream file = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read))
                    {
                        workbook = Path.GetExtension(caminhoArquivo).Equals(".xls") ?
                                    (IWorkbook)new HSSFWorkbook(file) :
                                    new XSSFWorkbook(file);

                        ISheet sheet = workbook.GetSheetAt(0);

                        for (int row = 1; row <= sheet.LastRowNum; row++)
                        {
                            IRow currentRow = sheet.GetRow(row);

                            if (currentRow != null)
                            {
                                string nomeArquivo = currentRow.GetCell(0)?.ToString();
                                string tamanhoArquivo = currentRow.GetCell(1)?.ToString();
                                string extensao = currentRow.GetCell(2)?.ToString();
                                string bql = currentRow.GetCell(3)?.ToString();

                                dgvArquivosComplet.Rows.Add(
                                    nomeArquivo,
                                    tamanhoArquivo,
                                    extensao,
                                    bql,
                                    caminhoArquivo
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao ler o arquivo Excel: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("O caminho especificado não é válido.");
            }

            dgvArquivosComplet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExcluirPasta_Click(object sender, EventArgs e)
        {            
            string bqlPesquisa = txtInformarBQL.Text.Trim();

            // Diretório base onde os arquivos estão localizados
            string diretorioBase = "C:/Users/0561/Documents/pastaThiagoParaTeste";

            // Se o BQL estiver vazio, excluir todo o diretório base
            if (string.IsNullOrEmpty(bqlPesquisa))
            {
                // Confirma exclusão do diretório base
                if (MessageBox.Show($"Você tem certeza que deseja excluir todos os itens no diretório base: {diretorioBase}?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        // Verifica se o diretório base existe
                        if (Directory.Exists(diretorioBase))
                        {
                            // Exclui o diretório base e todo o conteúdo
                            Directory.Delete(diretorioBase, true);
                            MessageBox.Show("Diretório base excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("O diretório base não foi encontrado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o diretório base: " + ex.Message);
                    }
                }
            }
            else
            {
                // Se o BQL for informado, excluir o diretório correspondente ao BQL dentro do diretório base
                string caminhoCompletoBQL = Path.Combine(diretorioBase, bqlPesquisa);

                // Verifica se o diretório do BQL informado existe
                if (!Directory.Exists(caminhoCompletoBQL))
                {
                    MessageBox.Show($"O diretório para o BQL informado não foi encontrado: {caminhoCompletoBQL}");
                    return;
                }

                // Confirma exclusão do diretório correspondente ao BQL
                if (MessageBox.Show($"Você tem certeza que deseja excluir todos os itens no diretório correspondente ao BQL: {bqlPesquisa}?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        // Exclui o diretório e todo o conteúdo
                        Directory.Delete(caminhoCompletoBQL, true);
                        MessageBox.Show("Itens excluídos com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir: " + ex.Message);
                    }
                }
            }

            // Limpa o campo BQL e DataGridView após a exclusão
            txtInformarBQL.Clear();
            dgvArquivosComplet.Rows.Clear();
        }

        private void btnPesquisaBQL_Click(object sender, EventArgs e)
        {
            // Redefinir a visibilidade de todas as linhas antes de aplicar o filtro
            foreach (DataGridViewRow row in dgvArquivosComplet.Rows)
            {
                row.Visible = true;
            }

            // Obter o valor do BQL fornecido
            string bqlPesquisa = txtInformarBQL.Text.Trim().ToLower();

            // Validar se o campo BQL não está vazio
            if (string.IsNullOrEmpty(bqlPesquisa))
            {
                MessageBox.Show("Digite um BQL para pesquisar.");
                return;
            }

            bool encontrou = false; // Variável para controlar se algum BQL foi encontrado

            // Iterar pelas linhas do DataGridView e aplicar o filtro de BQL
            foreach (DataGridViewRow row in dgvArquivosComplet.Rows)
            {
                // Verificar se a célula "BQL" tem valor antes de comparar
                if (row.Cells["BQL"].Value != null)
                {
                    string bqlDaLinha = row.Cells["BQL"].Value.ToString().ToLower();

                    // Verificar se o valor do BQL corresponde ao pesquisado
                    if (bqlDaLinha.Equals(bqlPesquisa, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Visible = true; // Manter a linha visível
                        encontrou = true;   // Marcar como encontrado
                    }
                    else
                    {
                        row.Visible = false; // Ocultar a linha que não corresponde
                    }
                }
                else
                {
                    row.Visible = true; // Ocultar linhas sem valor BQL
                }
            }

            // Verificar se algum BQL foi encontrado e informar o usuário
            if (!encontrou)
            {
                MessageBox.Show("Nenhum arquivo encontrado com o BQL informado.");
            }
        }
    }
}

