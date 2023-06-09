﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilN_Prova_Infotest
{
    public abstract class GhilN_Prova_Candidato : IEquatable<GhilN_Prova_Candidato>, IComparable<GhilN_Prova_Candidato>
    {
        int GhilN_Matricola;
        string GhilN_nome;

        public int Matricola { get; set; }

        public string Nome { get; set; }

        public GhilN_Prova_Candidato() : this(0, "")
        {

        }
        public GhilN_Prova_Candidato(int mat) : this(mat, "")
        {

        }
        public GhilN_Prova_Candidato(string nome) : this(0, nome)
        {

        }
        public GhilN_Prova_Candidato(int matr, string nome)
        {
            GhilN_Matricola = matr;
            GhilN_nome = nome;
        }



        public abstract bool isIdoneo();

        public abstract int punteggio();

        public override string ToString()
        {
            return Nome + ";" + Matricola;
        }

        public bool Equals(GhilN_Prova_Candidato tmp)
        {
            if (this.Nome == tmp.Nome && this.Matricola == tmp.Matricola)
                return true;
            else
                return false;
           
        }

        public int CompareTo(GhilN_Prova_Candidato other)
        {
            if (other.punteggio() < this.punteggio()) return 1;


            if (other.punteggio() > this.punteggio()) return -1;

            return 0;


        }


        public override int GetHashCode() => (Matricola, Nome).GetHashCode();




    }


}
