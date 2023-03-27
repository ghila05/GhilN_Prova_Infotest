﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhilN_Prova_Infotest
{
    public abstract class GhilN_Lavoratore : GhilN_Prova_Candidato
    {
        int GhilN_esperienze;

        public int Esperienze
        {
            get
            {
                return GhilN_esperienze;
            }
            set
            {
                if(value > 5 && value >=0)
                {
                    Esperienze = value;
                }
            }
        }

        public GhilN_Lavoratore()
        {
            Esperienze = 0;
        }
        public GhilN_Lavoratore(int esperienza, int matricola, string nome): base (nome, matricola)
        {
            Esperienze = esperienza;
        }

        public override int punteggio()
        {
            return Esperienze * 20;
        }

        public override bool isIdoneo()
        {
            if (punteggio() >= 60)
            {
                return true;
            }
            else return false;
        }



    }
}
