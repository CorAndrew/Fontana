using System;
using System.Collections.Generic;

namespace Fontana
{
    public class Cfontana
    {
        protected string NomeFontana { get; set; }
        protected float ConsumoAcqua { get; set; }
        protected bool StatoNotturno { get; set; } // true = accesa di notte
        protected List<string> Manutenzioni { get; set; }
        protected string Autore { get; set; }

        public Cfontana()
        {
            NomeFontana = "Sconosciuto";
            ConsumoAcqua = 0;
            StatoNotturno = false;
            Manutenzioni = new List<string>();
            Autore = "Sconosciuto";
        }

        public Cfontana(string nome, float consumoAcqua, bool statoNotturno, string autore)
        {
            NomeFontana = nome;
            ConsumoAcqua = consumoAcqua;
            StatoNotturno = statoNotturno;
            Manutenzioni = new List<string>();
            Autore = autore;
        }

        public void AggiungiManutenzione(string manutenzione)
        {
            Manutenzioni.Add(manutenzione);
        }

        public void RimuoviTutteManutenzioni()
        {
            Manutenzioni.Clear();
        }
        // metodo personalizzato
        public float CalcolaConsumoPeriodo(int giorni)
        {
            return ConsumoAcqua * giorni;
        }
    }
}