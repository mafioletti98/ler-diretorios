using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace Rotina_Ler_Diretorios
{
    public partial class frmRotinaDiretorios : Form
    {
        public frmRotinaDiretorios()
        {
            InitializeComponent();
        }

        async void btnDireEntrada_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {   
                    txtEntrada.Text = fbd.SelectedPath;
                    await PreencherDataGridComArquivos(fbd.SelectedPath, ckbLerDiretSubDiret.Checked);                    
                }
            }
        }

        async void btnDireSaidaExport_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtSaida.Text = fbd.SelectedPath;
                }
            }
        }

        async void btnCarregar_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtEntrada.Text))
            {
                MessageBox.Show("Por favor, selecione um diretório de entrada válido.");
                return;
            }

            if (string.IsNullOrEmpty(txtSaida.Text))
            {
                MessageBox.Show("Por favor, selecione um diretório de saída.");
                return;
            }

            await ExportarParaExcel(dgvTotalArquivos, txtSaida.Text);
        }

        async Task PreencherDataGridComArquivos(string diretorio, bool incluirSubdiretorios)
        {
            dgvTotalArquivos.Rows.Clear();
            dgvTotalDiretorios.Rows.Clear();            

            if (dgvTotalArquivos.Columns.Count == 0)
            {
                dgvTotalArquivos.Columns.Add("Nome", "Nome do Arquivo");
                dgvTotalArquivos.Columns.Add("Tamanho", "Tamanho");
                dgvTotalArquivos.Columns.Add("Extensão", "Extensão");
                dgvTotalArquivos.Columns.Add("BQL", "BQL");
                dgvTotalArquivos.Columns.Add("Caminho Completo", "Caminho Completo");                
            }

            if (dgvTotalDiretorios.Columns.Count == 0)
            {
                dgvTotalDiretorios.Columns.Add("Diretorio", "Diretório");
            }            

            var searchOption = incluirSubdiretorios ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            try
            {
                var arquivos = await Task.Run(() => Directory.GetFiles(diretorio, "*.*", searchOption)
                                            .Where(file => file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                           file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase))
                                            .ToArray());

                progressBarLeitura.Visible = true;
                progressBarLeitura.Minimum = 0;
                progressBarLeitura.Maximum = arquivos.Length;
                progressBarLeitura.Value = 0;
                progressBarLeitura.Step = 1;


                foreach (var arquivo in arquivos)
                {
                    var fileInfo = new FileInfo(arquivo);
                    string bql = ObterBQLDoArquivo(fileInfo.Name); // Extrai o BQL
                    string tamanhoFormatado = FormatarTamanhoArquivo(fileInfo.Length);

                    dgvTotalArquivos.Rows.Add(fileInfo.Name, tamanhoFormatado, fileInfo.Extension, bql, fileInfo.FullName);

                    progressBarLeitura.PerformStep();
                }                

                if (incluirSubdiretorios)
                {
                    var diretorios = await Task.Run(() => Directory.GetDirectories(diretorio, "*", SearchOption.AllDirectories));

                    foreach (var subDiretorio in diretorios)
                    {
                        dgvTotalDiretorios.Rows.Add(subDiretorio);                        
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Erro de permissão ao acessar alguns subdiretórios: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar arquivos: " + ex.Message);
            }
            finally
            {
                progressBarLeitura.Visible = false;
            }

            dgvTotalArquivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTotalDiretorios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private string ObterBQLDoArquivo(string nomeArquivo)
        {
            int indexInicio = nomeArquivo.IndexOf("FACHADA_");

            if (indexInicio >= 0)
            {
                // Pular o texto "FACHADA_"
                indexInicio += "FACHADA_".Length;

                // Encontrar o próximo "_" após o BQL, ou o início da extensão ".png"
                int indexFim = nomeArquivo.IndexOf('_', indexInicio);

                // Se não encontrar um "_" após o BQL, buscar o ".png" para finalizar o BQL
                if (indexFim == -1)
                {
                    indexFim = nomeArquivo.IndexOf(".png", indexInicio, StringComparison.OrdinalIgnoreCase);
                }

                // Se encontrar um "_" ou ".png" após o BQL, capturar o BQL
                if (indexFim > indexInicio)
                {
                    return nomeArquivo.Substring(indexInicio, indexFim - indexInicio);
                }
            }
            return "BQL não encontrado";
        }



        private string FormatarTamanhoArquivo(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            return String.Format("{0:0.##} {1}", len, sizes[order]);
        }


        async Task ExportarParaExcel(DataGridView dgv, string diretorioSaida)
        {
            try
            {
                await Task.Run(() =>
                {
                    IWorkbook workbook = new XSSFWorkbook();
                    ISheet sheet = workbook.CreateSheet("Arquivos");

                    IRow headerRow = sheet.CreateRow(0);
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        headerRow.CreateCell(i).SetCellValue(dgv.Columns[i].HeaderText);
                    }

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        IRow row = sheet.CreateRow(i + 1);
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            if (dgv.Rows[i].Cells[j].Value != null)
                            {
                                row.CreateCell(j).SetCellValue(dgv.Rows[i].Cells[j].Value.ToString());
                            }
                        }
                    }

                    string filePath = Path.Combine(diretorioSaida, "ListagemArquivos.xlsx");
                    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    {
                        workbook.Write(fs);
                    }
                });

                MessageBox.Show("Exportação concluída com sucesso!");

                txtEntrada.Clear();
                txtSaida.Clear();

                dgvTotalArquivos.Rows.Clear();
                dgvTotalDiretorios.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar para Excel: " + ex.Message);
            }
        }

        private void btnExcPasta_Click(object sender, EventArgs e)
        {
            frmExcluirPasta excluirPastaForm = new frmExcluirPasta();
            excluirPastaForm.ShowDialog();            
        }        
    }
}
