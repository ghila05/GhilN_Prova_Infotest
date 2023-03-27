using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilN_Prova_Infotest
{
    public abstract class GhilN_Prova_Candidato
    {
        int GhilN_Prova_Matricola;
        string GhilN_Prova_nome;

        public int Matricola { get; set; }

        public string Nome { get; set; }

        public GhilN_Prova_Candidato()
        {
            Nome = "";
            Matricola = 0;
        }
        public GhilN_Prova_Candidato(int matricola)
        {
            Matricola = matricola;
            Nome = "";
        }
        public GhilN_Prova_Candidato(string nome)
        {
            Nome = nome;
            Matricola=0;
        }
        public GhilN_Prova_Candidato(string nome, int matricola)
        {
            Nome = nome;
            Matricola = matricola;
        }

        public abstract bool isIdoneo();

        public abstract int punteggio();


    }


}
