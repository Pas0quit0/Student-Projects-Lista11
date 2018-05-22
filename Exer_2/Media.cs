using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_2
{
    class Media
    {
        //Variáveis
        private string nome;
        private int nota1, nota2, notaf, media;

        //Classes e métodos
        public bool SetNome(string nome)
        {
            if (nome.Length >= 5)
            {
                this.nome = nome;
                return true;
            }
            else return false;
        }

        public bool SetNota1(int nota1)
        {
            if (nota1 >= 0 && nota1 <= 100)
            {
                this.nota1 = nota1;
                return true;
            }
            else return false;
        }

        public bool SetNota2(int nota2)
        {
            if (nota2 >= 0 && nota2 <= 100)
            {
                this.nota2 = nota2;
                return true;
            }
            else return false;
        }

        public bool SetNotaf(int notaf)
        {
            if (notaf >= 0 && notaf <= 100) 
            { 
                this.notaf = notaf;
                return true;
            }
            else return false;
        }

        public int MediaFinal()
        {
            media = (nota1*2 + nota2*3)/5;
            if (media < 60) media = (media + notaf)/2;

            return media;
        }
    }
}