using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioAlterdata.Front_End;
using DesafioAlterdata.Interface;
using DesafioAlterdata.Logs;
using DesafioAlterdata.Rest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioAlterdata
{
    public partial class FrmHome : Form
    {
       
        public FrmHome()
        {
            InitializeComponent();

        }
        #region parametro para indicar ao formulário 2 se é cadastro ou atualização

        private bool BrnAtualizar; 
        private int IDParametro; 
       
        public bool Parametro 
        {
            get { return BrnAtualizar; }

        }
        #endregion

        public int IDParametroAtualizar 
        {
            get { return IDParametro; }

        }


        /// <summary>
        /// Função responsável por validar e capturar os dados para abrir o formulário de edição do cadastro
        /// </summary>
        /// <returns></returns>
        private int IDAtualizarRow() 
        {
            IDParametro = -1;
            var idselecionado = Dgv_Dados.SelectedRows; 


            if (idselecionado.Count > 0)
            {
                IDParametro = Convert.ToInt32(Dgv_Dados.CurrentRow.Cells[6].Value); 
                return 1;
            }
            else
            {
                MessageBox.Show("Nada foi selecionado para edição!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return 0;

            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            CarregarDados();
            PastasDeSistema.CriarPTas();

        }

        /// <summary>
        /// Função responsável por carregar os dados da para o datagridview e atualizar o contador de registros
        /// </summary>
        public async void CarregarDados()
        {
            
            
            try
            {
                var DadosAPI = new DadosAPI();
                DataTable dados = new DataTable();
                dados = await DadosAPI.BuscarTodos();
                Dgv_Dados.DataSource = dados;
                ConfigurarGrade();
                lbltotal.Text = dados.Rows.Count.ToString();
                Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Inicialização", "Versão do Sistema:" + " " + label2.Text + " " + "Quantidade de Registros:" + " " + lbltotal.Text + " " + " " + "Data de Sincronização:" + " " + DateTime.Now, "Evento de inicialização");
            }
            catch (Exception ex)
            {
                Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Falha no Carregamento dos Dados", "Motivo da Falha" + " " + ex.Message + " " + "Quantidade de Registros:" + " " + lbltotal.Text + " " + " " + "Data de Sincronização:" + " " + DateTime.Now, "Erro no Carregamento dos Dados");
            }
            
        }

       
        /// <summary>
        /// Função repsonsável por configurar a grade para ocultas as colunas que não precisam ser exibidas e ajustar os tamanhos par ao designer
        /// </summary>
        public void ConfigurarGrade()
        {
            Dgv_Dados.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            Dgv_Dados.RowHeadersWidth = 25;
            Dgv_Dados.MultiSelect = false;
            Dgv_Dados.AllowDrop = false;
            Dgv_Dados.AllowUserToAddRows = false;
            Dgv_Dados.AllowUserToResizeRows = false;
            Dgv_Dados.AllowUserToResizeColumns = false;
            Dgv_Dados.EditMode = DataGridViewEditMode.EditProgrammatically;
            Dgv_Dados.RowHeadersVisible = false;

            
            Dgv_Dados.EnableHeadersVisualStyles = false;
            Dgv_Dados.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Dgv_Dados.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.WhiteSmoke;
            Dgv_Dados.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
           
            Dgv_Dados.Columns["Id"].HeaderText = "ID";
            Dgv_Dados.Columns["Id"].Width = 100;
            Dgv_Dados.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Id"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["CreatedAt"].HeaderText = "Data da Criação";
            Dgv_Dados.Columns["CreatedAt"].Width = 150;
            Dgv_Dados.Columns["CreatedAt"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["CreatedAt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["CreatedAt"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["Name"].HeaderText = "Nome"; 
            Dgv_Dados.Columns["Name"].Width = 450;
            Dgv_Dados.Columns["Name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Name"].SortMode = DataGridViewColumnSortMode.NotSortable;

           
            Dgv_Dados.Columns["Avatar"].HeaderText = "Avatar";
            Dgv_Dados.Columns["Avatar"].Width = 50;
            Dgv_Dados.Columns["Avatar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Avatar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Avatar"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["Squad"].HeaderText = "Equipe";
            Dgv_Dados.Columns["Squad"].Width = 150;
            Dgv_Dados.Columns["Squad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Squad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Squad"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["Login"].HeaderText = "Login";
            Dgv_Dados.Columns["Login"].Width = 200;
            Dgv_Dados.Columns["Login"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Login"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Login"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["Email"].HeaderText = "E-mail";
            Dgv_Dados.Columns["Email"].Width = 300;
            Dgv_Dados.Columns["Email"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv_Dados.Columns["Email"].SortMode = DataGridViewColumnSortMode.NotSortable;



            //Colunas ocultadas para melhorar a visualização
            Dgv_Dados.Columns["dtCreation"].HeaderText = "dtCreation";
            Dgv_Dados.Columns["dtCreation"].Visible = false;         
            Dgv_Dados.Columns["dtCreation"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["query"].HeaderText = "query";
            Dgv_Dados.Columns["query"].Visible = false;        
            Dgv_Dados.Columns["query"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["Tag"].HeaderText = "Tag";
            Dgv_Dados.Columns["Tag"].Visible = false;         
            Dgv_Dados.Columns["Tag"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["nome"].HeaderText = "nome";
            Dgv_Dados.Columns["nome"].Visible = false;         
            Dgv_Dados.Columns["nome"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["teste"].HeaderText = "teste";
            Dgv_Dados.Columns["teste"].Visible = false;         
            Dgv_Dados.Columns["teste"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["suqad"].HeaderText = "squadra";
            Dgv_Dados.Columns["suqad"].Visible = false;        
            Dgv_Dados.Columns["suqad"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["{\"id\":null,\"name\":\"Teste99\",\"createdAt\":\"0001-01-01T00:00:00\",\"avatar\":\"https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1.jpg\",\"squad\":\"C#\",\"login\":\"testerr\",\"email\":\"ttttt@prosoft.com\"}"].HeaderText = "squadra";
            Dgv_Dados.Columns["{\"id\":null,\"name\":\"Teste99\",\"createdAt\":\"0001-01-01T00:00:00\",\"avatar\":\"https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1.jpg\",\"squad\":\"C#\",\"login\":\"testerr\",\"email\":\"ttttt@prosoft.com\"}"].Visible = false;         //esconder a linha da tabela gerada pela query
            Dgv_Dados.Columns["{\"id\":null,\"name\":\"Teste99\",\"createdAt\":\"0001-01-01T00:00:00\",\"avatar\":\"https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1.jpg\",\"squad\":\"C#\",\"login\":\"testerr\",\"email\":\"ttttt@prosoft.com\"}"].SortMode = DataGridViewColumnSortMode.NotSortable;

            Dgv_Dados.Columns["StatusCode"].HeaderText = "squadra";
            Dgv_Dados.Columns["StatusCode"].Visible = false;
            Dgv_Dados.Columns["StatusCode"].SortMode = DataGridViewColumnSortMode.NotSortable;


            Dgv_Dados.ClearSelection();

        }

     
        private void BtrnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Função responsável pelo polimofismo do formulário de cadastro ou atualização definindo o valor inicial do parametro a fim de evitar a abertura sem dados ou erros
        /// </summary>
        private void AbrirForm_UserAtualizarCad()
        {
            BrnAtualizar = false; 
            int IDteste = IDAtualizarRow(); 
         
            if (Application.OpenForms.OfType<FrmNewAndCharge>().Count() == 0)
            {
                FrmNewAndCharge FrmAlterar = new FrmNewAndCharge(Parametro, IDParametroAtualizar);
                FrmAlterar.Text = "Formulário de Edição de Dados";
                FrmAlterar.ControlBox = false;
                Dgv_Dados.ClearSelection();
             
                if (IDteste == 1)
                {


                    FrmAlterar.ShowDialog();
                }
                else
                {
                    return;
                }
            }

            else

            {
                Application.OpenForms.OfType<FrmNewAndCharge>().First().BringToFront();
            }
        }

        /// <summary>
        /// Função responsável por abrir o formulário de cadastro
        /// </summary>
        private void AbrirForm_Cadastro()
        {
            BrnAtualizar = true;
            if (Application.OpenForms.OfType<FrmNewAndCharge>().Count() == 0)
            {
                FrmNewAndCharge FrmAlterar = new FrmNewAndCharge(Parametro);
                FrmAlterar.Text = "Formulário de Cadastro de Dados";
                FrmAlterar.ControlBox = false;
                Dgv_Dados.ClearSelection();
                FrmAlterar.ShowDialog();
              
            }

            else

            {
                Application.OpenForms.OfType<FrmNewAndCharge>().First().BringToFront();
            }

        }

        private void BtrnAtualizar_Click(object sender, EventArgs e)
        {
            AbrirForm_UserAtualizarCad();

        }

        private void BtrnMinimizar_Click(object sender, EventArgs e)
        {
            FuncaoMinimizar();
        }

        /// <summary>
        /// Função repsonsável por minimizar o formulário
        /// </summary>
        private void FuncaoMinimizar()
        {
            this.WindowState = FormWindowState.Minimized;
            this.BringToFront();
        }

        private void BtrnAtualizarDados_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void BtrnNovo_Click(object sender, EventArgs e)
        {
            AbrirForm_Cadastro();

        }
    }
}
