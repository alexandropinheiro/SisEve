using System.Linq;
using Siseve.Dominio;
using Siseve.Infraestrutura;
using Siseve.UI.Properties;
using System;
using System.Windows.Forms;

namespace Siseve.UI.Utilitarios
{
    public partial class frmTipoServico : Form
    {
        private readonly TipoServicoRepository _tipoServicoRepository = new TipoServicoRepository();

        public frmTipoServico()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTipoServico_Load(object sender, EventArgs e)
        {
            PreencheGrid();
        }

        private void PreencheGrid()
        {
            try
            {
                dgvDados.Rows.Clear();
                var dados = _tipoServicoRepository.ObterTodos();

                foreach (var tipoServico in dados)
                    dgvDados.Rows.Add(tipoServico.Id, tipoServico.Descricao, tipoServico.Ativo ? "SIM" : "NÃO");

                if (dados.Any())
                    dgvDados_CellClick(dgvDados, new DataGridViewCellEventArgs(0, 0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            StatusTela(ModoFormularioEnum.Incluir);
        }

        private void StatusTela(ModoFormularioEnum modoFormulario)
        {
            switch (modoFormulario)
            {
                case ModoFormularioEnum.Incluir:
                    txtCodigo.Text = string.Empty;
                    txtDescricao.Text = string.Empty;
                    rdAtivoSim.Checked = true;
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnSalvar.Text = Resources.botao_salvar;
                    rdAtivoSim.Checked = true;
                    gbAtivo.Enabled = false;
                    txtDescricao.Enabled = true;
                    txtDescricao.Focus();
                    break;

                case ModoFormularioEnum.Alterar:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = true;
                    btnSalvar.Text = Resources.botao_alterar;
                    gbAtivo.Enabled = true;
                    txtDescricao.Enabled = true;
                    break;

                case ModoFormularioEnum.Consultar:
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = false;
                    gbAtivo.Enabled = false;
                    txtDescricao.Enabled = false;
                    break;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    var tipoServicoFactory = new TipoServicoFactory(txtDescricao.Text, 1);
                    var tipoServico = tipoServicoFactory.Criar();

                    _tipoServicoRepository.IncluirTipoServico(tipoServico);
                    MessageBox.Show(Resources.Registro_incluido);
                }
                else
                {
                    var tipoServico = new TipoServico
                    {
                        IdFormatado = txtCodigo.Text,
                        Descricao = txtDescricao.Text,
                        Ativo = rdAtivoSim.Checked,
                        DataAlteracao = DateTime.Now,
                        IdUsuarioAlteracao = 1
                    };

                    _tipoServicoRepository.AlterarTipoServico(tipoServico);
                    MessageBox.Show(Resources.Registro_alterado);
                }
                PreencheGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvDados.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dgvDados.CurrentRow.Cells[1].Value.ToString();
            if (dgvDados.CurrentRow.Cells[2].Value.ToString() == "SIM")
                rdAtivoSim.Checked = true;
            else
            {
                rdAtivoNao.Checked = true;
            }
            StatusTela(ModoFormularioEnum.Alterar);
        }
    }
}
