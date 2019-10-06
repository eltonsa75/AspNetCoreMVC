﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01.Models
{
    public class Instituicao
    {
        public long? InstituicaoID { get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }
    }

    public class Departamento
    {
        public long? DepartamentoID { get; set; }
        public string Nome { get; set; }
    }
}
