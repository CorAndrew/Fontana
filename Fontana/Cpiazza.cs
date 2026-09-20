using System;

namespace Fontana
{
    public class Cpiazza : Cfontana
    {
        protected float Diametro { get; set; }
        protected string Citta { get; set; }
        protected string NomePiazza { get; set; }

        public Cpiazza() : base()
        {
            Diametro = 0;
            Citta = "Sconosciuta";
            NomePiazza = "Sconosciuta";
        }

        public Cpiazza(float diametro, string citta, string nomePiazza, string nomeFontana, float consumoAcqua, bool statoNotturno, string autore): base(nomeFontana, consumoAcqua, statoNotturno, autore)
        {
            Diametro = diametro;
            Citta = citta;
            NomePiazza = nomePiazza;
        }

        public string InfoPiazza()
        {
            string stato;

            if (StatoNotturno)
            {
                stato = "Accesa di notte";
            }
            else
            {
                stato = "Spenta di notte";
            }

            return $"Nome piazza: {NomePiazza}, Città: {Citta}, Diametro: {Diametro}m\n" +
                   $"Nome fontana: {NomeFontana}, Autore: {Autore}, Consumo: {ConsumoAcqua}L/giorno, Stato: {stato}, Manutenzioni pendenti: {Manutenzioni.Count}";
        }

    }
}