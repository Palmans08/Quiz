using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQuiz
{
    internal class Vraag
    {
        public string VraagTekst;
        public string[] Antwoorden = { };
        public int Correct;
        public string Uitleg;

        public Vraag(string vraagTekst, string[] antwoorden, int correct, string uitleg)
        {
            VraagTekst = vraagTekst;
            Antwoorden = antwoorden;
            Correct = correct;
            Uitleg = uitleg;
        }
    }
}
