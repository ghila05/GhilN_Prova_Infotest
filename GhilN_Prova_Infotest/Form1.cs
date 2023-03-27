using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GhilN_Prova_Infotest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<GhilN_Prova_Candidato> lista;

        bool first = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new List<GhilN_Prova_Candidato>();


            if (first)
            {
                listView1.View = View.Details;
                listView1.FullRowSelect = true;
                first = false;

                listView1.Columns.Add("CANDIDATO", 60);


                ListViewItem item = new ListViewItem();



            }
            

        }
        public void AddCandidato(GhilN_Prova_Candidato u)
        {
            if(u == null)
            {
                throw new Exception("invalid");
            }
            lista.Add(u);

        }
        public string[] Candidati()
        {
            string[] cand = new string[] {};
     
            for(int i=0; i<lista.Count(); i++)
            {
                cand[i] = lista[i].Nome;
            }
            return cand;
        }

        public void Mod(GhilN_Prova_Candidato u)
        {
            if (u == null) throw new Exception("invalid argument");
            for(int i=0; i<lista.Count(); i++)
            {
                if (lista[i].Matricola == u.Matricola)
                {
                    lista[i].Nome = u.Nome;
                    
                }
            }

        }
        public void Delete(GhilN_Prova_Candidato d)
        {
            if (d == null) throw new Exception("invalid argument");
            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista[i].Matricola == d.Matricola)
                {
                    lista.RemoveAt(i);
                }
            }
        }

        public void Ordina()
        {
            lista.Sort();

        }
    }
}
