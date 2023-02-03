using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioAlterdata.Entites;
using DesafioAlterdata.Interface;
using DesafioAlterdata.Logs;
using DesafioAlterdata.Rest;

namespace DesafioAlterdata.Front_End
{
    public partial class FrmNewAndCharge : Form
    {
        private int IDParametroLocal;
        public FrmNewAndCharge()
        {
            InitializeComponent();
        }

        public FrmNewAndCharge(bool Parametro) : this()// 
        {
            CadastroOrAtualizar(Parametro);// 
            DefinirID();

        }

        public FrmNewAndCharge(bool Parametro, int IDParametro) : this()
        {
            CadastroOrAtualizar(Parametro);
            IDParametroLocal = IDParametro;
            CarregarDados();

        }

        /// <summary>
        /// Função responsável por definir o próximo ID do cadastro 
        /// </summary>
        private async void DefinirID()
        {
            try
            {
                var DadosAPI = new DadosAPI();
                DataTable dados = new DataTable();
                dados = await DadosAPI.BuscarTodos();

                int ID = dados.Rows.Count + 1;
                TxtID.Text = ID.ToString();
            }
            catch (Exception xex)
            {
                Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Falha na obtenção do ID de Cadastro", "Motivo da Falha" + " " + xex.Message + " " +  "Data de Sincronização:" + " " + DateTime.Now, "Erro no ID do Formulário de Cadastro");
            }
           

        }

        /// <summary>
        /// Método responsável por ajustar o formulário de acordo com o tipo seja ele para cadastro ou atualização de dados
        /// </summary>
        /// <param name="Parametro"></param>
        private void CadastroOrAtualizar(bool Parametro)
        {
            if (Parametro == true)
            {
                this.BtnAtualizarSair.Visible = false;
                this.BtnSair.Visible = true;
                this.BtrnAtualizar.Visible = false;
                this.BtnSalvar.Visible = true;
                this.lblFoto.Visible = true;
                this.TxtDataDeCadastro.ReadOnly = true;
                this.TxtDataDeCadastro.Text = Convert.ToString(DateTime.Now);
                PbFoto.ImageLocation = Properties.Resources.fotoinicialvazio.ToString();

            }
            else
            {

                this.BtnAtualizarSair.Visible = true;
                this.BtnSair.Visible = false;
                this.BtrnAtualizar.Visible = true;
                this.BtnSalvar.Visible = false;
                this.lblFoto.Visible = true;
                this.TxtDataDeCadastro.ReadOnly = true;
                
            }

            
        }

        /// <summary>
        /// Função responsável por fazer os dados para a atualização quando está no formulário de edição de dados
        /// </summary>
        private async void CarregarDados()
        {

            try
            {
                var DadosAPI = new DadosAPI();
                var retorno = await DadosAPI.Buscar(IDParametroLocal);

                TxtID.Text = retorno.Id;
                TxtNome.Text = retorno.Name;
                TxtEquipe.Text = retorno.Squad;
                TxtLogin.Text = retorno.Login;

                if (retorno.Email != null)
                {
                    TxtEmail.Text = retorno.Email.Replace("@prosoft.com.br", "");
                }
                
                TxtDataDeCadastro.Text = retorno.CreatedAt.ToString();

                if (retorno.Avatar != null)
                {
                    PbFoto.ImageLocation = retorno.Avatar;
                }
                else if (retorno.Avatar == null)
                {
                    PbFoto.ImageLocation = Properties.Resources.fotoinicialvazio.ToString();
                }

                if (retorno.StatusCode.Equals("False"))
                {
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Falha no carregado dos dados da API de Atualização de Cadastro", "Motivo da Falha" + " " + ex.Message + " " + "Data de Sincronização:" + " " + DateTime.Now, "Falha na Comunicação com a API para obtenção dos dados de Atualização de Cadastro");
            }
            

        }
        private void FrmNewAndCharge_Load(object sender, EventArgs e)
        {
          
        }

        private void FuncaoMinimizar()
        {
            this.WindowState = FormWindowState.Minimized;
            this.BringToFront();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            FuncaoMinimizar();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnAtualizarSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        /// <summary>
        /// Função repsonsável por limpar os dados
        /// </summary>
        private void LimparCampos()
        {
            TxtNome.Text = "";
            TxtEquipe.Text = "";
            TxtLogin.Text = "";
            TxtEmail.Text = "";
            PbFoto.ImageLocation = Properties.Resources.fotoinicialvazio.ToString();
        }

        private void BtrnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarDados();
            AtualizarDatagridview();

        }

        /// <summary>
        /// Função responsável por atualizar os dados dentro do datagridview para evitar erros de edição antes de setar o botão atualizar
        /// </summary>
        private void AtualizarDatagridview ()
        {
            FrmHome f1 = (FrmHome)Application.OpenForms["FrmHome"];
            f1.CarregarDados();
            f1.ConfigurarGrade();

        }


        /// <summary>
        /// Função responsável por validar os dados antes de eles serem atualizados
        /// </summary>
        private bool ValidarDadosAtualizar()
        {
            System.Text.RegularExpressions.Regex Email = new System.Text.RegularExpressions.Regex(@"[^0-9-a-zA-Z, \s, $, -, _, .]"); 


            if (TxtNome.Text.Trim() == string.Empty) 
            {
                TxtNome.Focus();
                MessageBox.Show("O nome não pode ficar em branco!", "Aviso!", (MessageBoxButtons.OK), MessageBoxIcon.Information);
                return false;
            }

            if (TxtEquipe.Text.Trim() == string.Empty) 
            {
                TxtEquipe.Focus();
                MessageBox.Show("O nome da equipe não pode ficar em branco", "Aviso!", (MessageBoxButtons.OK), MessageBoxIcon.Information);
                return false;
            }

            if (TxtLogin.Text.Trim() == string.Empty)
            {
                TxtLogin.Focus();
                MessageBox.Show("O login não pode ficar em branco", "Aviso!", (MessageBoxButtons.OK), MessageBoxIcon.Information);
                return false;
            }

           if (TxtEmail.Text.Trim() == string.Empty) 
            {
                TxtEmail.Focus();
                MessageBox.Show("O endereço de e-mail não pode ficar em branco!", "Aviso!", (MessageBoxButtons.OK), MessageBoxIcon.Information);
                return false;
            }

            if (Email.IsMatch(TxtEmail.Text.Trim()))  
            {
                TxtEmail.Clear(); 
                TxtEmail.Focus(); 
                MessageBox.Show("O endereço de e-mail não pode contér o domínio, nem caracetéres especiais, somente letras e números, corrija ele!", "Aviso!", (MessageBoxButtons.OK), MessageBoxIcon.Information);
                return false;
            }
           
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Função responsável por atualizar os dados
        /// </summary>
        private async void AtualizarDados()
        {

            if (ValidarDadosAtualizar() == true)
            {
                try
                {
                    DadosResponse dados = new DadosResponse();
                    dados.Id = TxtID.Text;
                    dados.Name = TxtNome.Text;
                    dados.Avatar = PbFoto.ImageLocation;
                    dados.CreatedAt = Convert.ToDateTime(TxtDataDeCadastro.Text);
                    dados.Squad = TxtEquipe.Text;
                    dados.Email = TxtEmail.Text + "@prosoft.com.br";
                    dados.Login = TxtLogin.Text;

                    var DadosAPI = new DadosAPI();
                    var retorno = await DadosAPI.Alterar(dados.Id, dados);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar os dados!" + Environment.NewLine + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                return;
            }

        }

        /// <summary>
        /// Função responsável por cadastrar os dados na base da API
        /// </summary>
        private async void CadastrarDados()
        {

            if (ValidarDadosAtualizar() == true)
            {
                try
                {
                    DadosResponse dados = new DadosResponse();
                    dados.Id = TxtID.Text;
                    dados.Name = TxtNome.Text;

                    if (dados.Avatar != null)
                    {
                        PbFoto.ImageLocation = dados.Avatar;
                    }
                    else if (dados.Avatar == null)
                    {
                        PbFoto.ImageLocation = Properties.Resources.fotoinicialvazio.ToString();
                    }


                    dados.Avatar = PbFoto.ImageLocation;
                    dados.CreatedAt = Convert.ToDateTime(TxtDataDeCadastro.Text);
                    dados.Squad = TxtEquipe.Text;
                    dados.Email = TxtEmail.Text + "@prosoft.com.br";
                    dados.Login = TxtLogin.Text;

                    var DadosAPI = new DadosAPI();
                    var retorno = await DadosAPI.Cadastrar(dados);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar os dados!" + Environment.NewLine + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                return;
            }

        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarDados();
        }
    }
}
