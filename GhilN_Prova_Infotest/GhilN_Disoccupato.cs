﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilN_Prova_Infotest
{
    public abstract class GhilN_Disoccupato : GhilN_Prova_Candidato, IEquatable<GhilN_Disoccupato>, IComparable<GhilN_Disoccupato> 
    {
        int GhilN_voto;
        bool GhilN_lode;

        public int Voto
        {
            get
            {
                return GhilN_voto;
            }
            set
            {
                if (value < 110 && value >= 0)
                {
                    GhilN_voto = value;
                }
                else
                {
                    throw new Exception("Inserisci un voto accettabile 0 < x < 110");
                }
            }

        }

        public bool Lode
        {
            get 
            { 
                return GhilN_lode; 
            }
            set
            {
                if (Voto == 110)
                {
                    Lode = true;
                }
                else
                {
                    throw new Exception("Per la lode è necessario voto uguale a 110");
                }
            }
        }

        public GhilN_Disoccupato() 
        {
            Voto = 0;
            Lode = false;
        }
        public GhilN_Disoccupato(int voto, bool lode, int nome, string matricola): base(nome, matricola)
        {
            Voto = voto;
            Lode = lode;
        }

        public override int punteggio()
        {
            if (Lode)
            {
                return (Voto * 100) / 110 + 5;
            }
            else
                return (Voto * 100) / 110;
        }


        public override bool isIdoneo()
        {
            if(punteggio() >= 72)
            {
                return true;
            }
            else return false;

        }

        public override string ToString()
        {
            return Nome + ";" + Matricola + ";" + Voto + ";" + Lode;
        }

        public bool Equals(GhilN_Disoccupato d)
        {
            return ((base.Equals((GhilN_Disoccupato)d)) && (d.GhilN_voto == this.GhilN_voto) && (d.GhilN_lode == this.GhilN_lode));
        }


        public int CompareTo(GhilN_Disoccupato l)
        {
            return (base.CompareTo((GhilN_Disoccupato)l));
        }

        public override int GetHashCode() => (Matricola, Nome).GetHashCode();



    }
}
