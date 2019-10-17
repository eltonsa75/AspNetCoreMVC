using Microsoft.EntityFrameworkCore;
using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01.Data.DAL.Cadastros
{
    public class DepartamentoDAL
    {

        private IESContext _context;

        public DepartamentoDAL(IESContext context)
        {
            _context = context;
        }

        public IQueryable<Departamento> ObterDepartamentoClassificadoPorNome()
        {
            return _context.Departamentos.OrderBy(b => b.Nome);
        }
    }
}
