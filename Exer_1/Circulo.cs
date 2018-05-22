using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_1
{
    class Circulo
    {
        //Variáveis
        private double raio, area, circun;

        //Classes e métodos
        public bool SetRaio(double raio)
        {
            if (raio > 0)
            {
                this.raio = raio;
                return true;
            }
            else return false;

        }

        public void AreaCirculo()
        {
            area = Math.PI * raio * raio;
        }

        public string ValorArea()
        {
            return (area.ToString());
        }

        public void CircunCirculo()
        {
            circun = 2 * Math.PI * raio;            
        }

        public string ValorCircunferencia()
        {
            return (circun.ToString());
        }
    }
}
