using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Heranca
{
    class Administrador : Colaborador
    {
        private double ajudaDeCusto;

        public Administrador(string Nome, string End, string Tel) : base(Nome, End, Tel)
        {
        }   
        public double AjudaDeCusto
        {
            get { return ajudaDeCusto; }
            set { ajudaDeCusto = value; }
        }

        public override double calcularSalario()
        {
            return base.calcularSalario() + ajudaDeCusto;
        }
    }
}
