using Services;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class TarefaController
    {
        private readonly TarefaService service;

        public TarefaController()
        {
            service = new TarefaService();
        }

        public bool Cadastrar(Tarefa tarefa)
        {
            try
            {
                return service.Cadastrar(tarefa);
            }
            catch (Exception error)
            {
                Console.WriteLine($"Erro ao Cadastrar Tarefa! Erro: ", error.Message);
                return false;
            }
        }

        public bool Alterar(Tarefa tarefa)
        {
            try
            {
                return service.Alterar(tarefa);
            }
            catch (Exception error)
            {
                Console.WriteLine($"Erro ao Alterar Tarefa! Erro: ", error.Message);
                return false;
            }
        }

        public bool Excluir(Tarefa tarefa)
        {
            try
            {
                return service.Excluir(tarefa);
            }
            catch (Exception error)
            {
                Console.WriteLine($"Erro ao Excluir Tarefa! Erro: ", error.Message);
                return false;
            }
        }

        public IEnumerable<Tarefa> ListarTudo()
        {
            try
            {
                return service.ListarTudo();
            }
            catch (Exception error)
            {
                Console.WriteLine($"Erro ao Listar todas as Tarefas! Erro: ", error.Message);
                return new List<Tarefa>();
            }
        }
    }
}