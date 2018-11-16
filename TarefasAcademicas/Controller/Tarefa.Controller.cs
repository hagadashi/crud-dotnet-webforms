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
                Console.WriteLine($"Erro ao Cadastrar Tarefa! Erro ", error.Message);
                return false;
            }
        }
    }
}