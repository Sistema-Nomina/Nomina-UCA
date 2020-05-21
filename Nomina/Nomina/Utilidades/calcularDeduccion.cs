using System;
namespace Nomina.Utilidades
{
    public class calcularDeduccion
    {
        public calcularDeduccion()
        {
        }

        public double calcularIR(double salarioMesNeto)
        {
            double salarioAnualneto = 0.0, deduccionInss;
            double sobreExceso = 0, porcentajeAplicable = 0, baseTax = 0;
            double IrMensual = 0;

            salarioAnualneto = salarioMesNeto * 12;

            Console.WriteLine("Salrio:" + salarioAnualneto);

            deduccionInss = salarioAnualneto - (salarioAnualneto * 0.0625);



            if (deduccionInss >= 0 && deduccionInss <= 100000)
            {
                sobreExceso = 0;
                porcentajeAplicable = 0;
                baseTax = 0;

                IrMensual = irMensual(sobreExceso,porcentajeAplicable,baseTax,deduccionInss);
            }
            else if (deduccionInss > 100000 && deduccionInss <= 200000)
            {
                sobreExceso = 100000;
                porcentajeAplicable = 0.15;
                baseTax = 0;


                IrMensual = irMensual(sobreExceso, porcentajeAplicable, baseTax, deduccionInss);
            }
            else if (deduccionInss > 200000 && deduccionInss <= 350000)
            {
                sobreExceso = 200000;
                porcentajeAplicable = 0.20;
                baseTax = 15000;


                IrMensual = irMensual(sobreExceso, porcentajeAplicable, baseTax, deduccionInss);
            }
            else if (deduccionInss > 350000 && deduccionInss <= 500000)
            {
                sobreExceso = 350000;
                porcentajeAplicable = 0.25;
                baseTax = 45000;


                IrMensual = irMensual(sobreExceso, porcentajeAplicable, baseTax, deduccionInss);
            }
            else if (deduccionInss > 500000)
            {
                sobreExceso = 500000;
                porcentajeAplicable = 0.30;
                baseTax = 82500;


                IrMensual = irMensual(sobreExceso, porcentajeAplicable, baseTax, deduccionInss);
            }

            return IrMensual;
        }

        private double irMensual(double sobreExceso, double porcentajeAplicable,double baseTax, double deduccionInss)
        {
            double sinSobreExceso = 0, conPorcentajeAplicable = 0, conBaseTax = 0, IrMensual = 0;

            sinSobreExceso = (deduccionInss - sobreExceso);
            conPorcentajeAplicable = (sinSobreExceso * porcentajeAplicable);
            conBaseTax = (conPorcentajeAplicable + baseTax);
            IrMensual = (conBaseTax / 12);

            return IrMensual;
        }

    }
}
