using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioAlterdata.Entite;
using DesafioAlterdata.Entites;
using DesafioAlterdata.Interface;
using DesafioAlterdata.Logs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DesafioAlterdata.Rest
{
    /// <summary>
    /// Classe repsonsável por realizar as chamadas da API Externa e executar os métodos 
    /// </summary>
    public class DadosAPI : IDadosAPI
    {
        /// <summary>
        /// Método responsável por atualizar os dados de um usuário pelo ID dentro da API
        /// </summary>
        /// <param name="codigoID"></param>
        /// <returns></returns>
        public async Task<DadosResponse> Alterar(string codigoID, DadosResponse dados)
        {
            DadosResponse DadosAtualizar = new DadosResponse();
           
            try
            {
               
                DadosAtualizar = dados;

                var client = new HttpClient();
                var url = client.BaseAddress = new Uri($"https://61a170e06c3b400017e69d00.mockapi.io/DevTest/Dev/{codigoID}");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.PutAsJsonAsync(url, DadosAtualizar);

                if (response.IsSuccessStatusCode)
                {
                    string status = HttpStatusCode.OK.ToString();
                    MessageBox.Show("Dados Atualizados com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Processo de Alteração de Dados de Cadastro", "Status Code:" + " " + status + " " + "Data de Sincronização:" + " " + DateTime.Now, "Atualização de Cadastro");

                }
                else
                {
                    string status = HttpStatusCode.BadRequest.ToString();
                    MessageBox.Show("Não foi possível atualizar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

               
            }
            catch (Exception ex)
            {
                Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Falha no Processo de Alteração de Dados de Cadastro", "Motivo da Falha:" + " " + ex.Message + " " + "Data de Sincronização:" + " " + DateTime.Now, "Falha Atualização de Cadastro");
            }

            return DadosAtualizar;

        }


        /// <summary>
        /// Método repsonsável por buscar os dados da API via código para realizar o carregamento e posterior atualizar deles
        /// </summary>
        /// <param name="codigoID"></param>
        /// <returns></returns>
        public async Task<EntidateDados> Buscar(int codigoID)
        {

            EntidateDados DadosRetorno = new EntidateDados();

            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri($"https://61a170e06c3b400017e69d00.mockapi.io/DevTest/Dev/{codigoID}");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("").ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {

                    var dados = await response.Content.ReadAsStringAsync();

                    DadosRetorno = (EntidateDados)JsonConvert.DeserializeObject(dados, typeof(EntidateDados));
                    DadosRetorno.StatusCode = response.IsSuccessStatusCode.ToString();
                    Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Processo de buscar de Dados por ID", "Status Code:" + " " + DadosRetorno.StatusCode + " " + "ID do Cadastro: " + codigoID + "  " + " " + "Data de Sincronização:" + " " + DateTime.Now, "Processo de Recuperação de Dados da API por ID");

                }
                else
                {
                    DadosRetorno.StatusCode = response.IsSuccessStatusCode.ToString();
                    MessageBox.Show("Não foi possível carregar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Falha no Processo de buscar de Dados na API", "Motivo da Falha:" + " " + ex.Message + " " + "Data de Sincronização:" + " " + DateTime.Now, "Falha na Busca dos dados da API");
            }
            
            
           return DadosRetorno;
        }

        /// <summary>
        /// Método responsável por buscar todos os dados da API e convertê-lo no formato de DaTable para serem carregados no datagridview
        /// </summary>
        /// <returns></returns>
        public async Task<DataTable> BuscarTodos()
        {
            DataTable dt = new DataTable();
           
            try
            {
               
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://61a170e06c3b400017e69d00.mockapi.io/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("DevTest/Dev").ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    dynamic result = await response.Content.ReadAsStringAsync();
                    dt = (DataTable)JsonConvert.DeserializeObject(result, typeof(DataTable));
                    Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Processo de buscar de Dados por ID", "Status Code:" + " " + response.IsSuccessStatusCode + " " + "Data de Sincronização:" + " " + DateTime.Now, "Processo de Recuperação de Dados da API por ID");
                }
               
            }
            catch (Exception ex)
            {
                Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Falha no Processo de Recuperação de Todos os dados da API", "Motivo da Falha:" + " " + ex.Message + " " + "Data de Sincronização:" + " " + DateTime.Now, "Falha na obtenção dos dados da API");
            }
            return dt;
        }


        /// <summary>
        /// Função responsável por cadastrar os dados na API Externa
        /// </summary>
        /// <param name="dados"></param>
        /// <returns></returns>
        public async Task<DadosResponse> Cadastrar(DadosResponse dados)
        {
            DadosResponse DadosCadastrar = new DadosResponse();

            try
            {
                DadosCadastrar = dados;

                var client = new HttpClient();
                var url = client.BaseAddress = new Uri($"https://61a170e06c3b400017e69d00.mockapi.io/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var json = JsonConvert.SerializeObject(DadosCadastrar);
                StringContent httpConent = new StringContent(json, Encoding.UTF8);

                HttpResponseMessage response2 = await client.PostAsync("DevTest/Dev", httpConent);


                if (response2.IsSuccessStatusCode)
                {
                    string status = HttpStatusCode.OK.ToString();
                    MessageBox.Show("Cadastro realizado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Processo de Cadastro de Dados na API", "Status Code:" + " " + status + " " + "ID do Cadastro: " + DadosCadastrar.Id + "  " + "Data de Sincronização:" + " " + DateTime.Now, "Processo de Cadastro de Dados na API");

                }
                else
                {
                    string status = HttpStatusCode.BadRequest.ToString();
                    MessageBox.Show("Não foi possível cadastrar os dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Logs.Logs.GravarLogs(PastasDeSistema.Caminho_Log, "Falha no Processo de Cadastro dos dados na API", "Motivo da Falha:" + " " + ex.Message + " " + "Data de Sincronização:" + " " + DateTime.Now, "Falha no cadastro de dados da API");
            }
            
           

            return DadosCadastrar;
        }
    }
}
