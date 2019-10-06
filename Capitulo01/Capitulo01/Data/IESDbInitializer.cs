using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capitulo01.Models;

namespace Capitulo01.Data
{
    public class IESDbInitializer
    {

        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Departamentos.Any())
            {
                return;
            }

            var departamentos = new Departamento[]
            {
                new Departamento { Nome="Ciência da Camputação"},
                new Departamento { Nome="Ciência de Alimentos"}
            };

            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();
        }
    }
}
