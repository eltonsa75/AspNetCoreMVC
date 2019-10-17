﻿using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01.Data.DAL.Cadastros
{
    public class InstituicaoDAL
    {

        private IESContext _context;

        public InstituicaoDAL(IESContext context)
        {
            _context = context;
        }

        public IQueryable<Instituicao> ObterInstituicoesClassificadasPorNome()
        {
            return _context.Instituicoes.OrderBy(b => b.Nome);
        }
    }
}
