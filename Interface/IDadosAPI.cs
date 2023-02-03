using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesafioAlterdata.Entite;
using DesafioAlterdata.Entites;

namespace DesafioAlterdata.Interface
{
    public interface IDadosAPI
    {
        Task<DataTable> BuscarTodos();
        Task<EntidateDados> Buscar(int codigoID);
        Task<DadosResponse> Cadastrar(DadosResponse dados);
        Task<DadosResponse> Alterar(string codigoID, DadosResponse dados);
    }

    
}
