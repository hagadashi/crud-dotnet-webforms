﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositorys;

namespace Services
{
    public class TarefaService
    {
        public bool Cadastrar(Tarefa tarefa)
        {
            if (String.IsNullOrEmpty(tarefa.Titulo)) throw new ArgumentException("Parâmetro Titulo é obrigatório");
            if (String.IsNullOrEmpty(tarefa.Descricao)) throw new ArgumentException("Parâmetro Descricao é obrigatório");
            if (String.IsNullOrEmpty(tarefa.Tipo)) throw new ArgumentException("Parâmetro Titulo é obrigatório");

            var repository = new TarefaRepository(tarefa);

            return repository.Cadastrar();
        }
    }
}