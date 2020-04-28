using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //02
            Fornecedor f = new Fornecedor("Marlon", "Elói Mendes", "(35)3264-1111");
            f.ValorCredito = 1000.00;
            f.ValorDivida = 316.12;
            Console.WriteLine("Fornecedor, saldo de :" + f.obterSaldo());

            //03
            Colaborador c = new Colaborador("Jonny", "Belém do pará", "(91)3205-9000");
            c.CodSetor = 30;
            c.SalarioBase = 818.13;
            c.Impostos = 2; //porcentagem
            Console.WriteLine("Colaborador, salário :" + c.calcularSalario());

            //04
            Administrador a = new Administrador("Hugo", "Varginha", "(35)3222-9204");
            a.CodSetor = 30;
            a.SalarioBase = 818.13;
            a.Impostos = 2; //porcentagem
            a.AjudaDeCusto = 314.07;
            Console.WriteLine("Administrador, salário :" + a.calcularSalario());

            //05
            Operario o = new Operario("Marcio", "Varginha", "(35)3212-2019");
            o.CodSetor = 30;
            o.SalarioBase = 818.13;
            o.Impostos = 2; //porcentagem
            o.ValorProducao = 117.09;
            o.Comissao = 3;
            Console.WriteLine("Operário, salário :" + o.calcularSalario());

            //06
            Vendedor v = new Vendedor("Rodrigo", "Varginha", "(35)3264-2119");
            v.CodSetor = 30;
            v.SalarioBase = 818.13;
            v.Impostos = 2; //porcentagem
            v.ValorVendas = 518.22;
            v.Comissao = 5;
            Console.WriteLine("Vendedor, salário :" + v.calcularSalario());

            Console.ReadKey();
        }
    }
}
