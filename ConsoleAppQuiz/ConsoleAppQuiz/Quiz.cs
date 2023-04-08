using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQuiz
{
    internal class Quiz
    {
        static public List<Vraag> vragen = new List<Vraag>
        {
            new Vraag("Waarom staan flamingo’s vaak op één been?", new string[] {"Om niet af te koelen","Tegen bijtende visjes","Om het andere been te sparen"}, 1, "Flamingo's staan op één been om niet af te koelen. Een poot minder in het water betekent minder warmteverlies."),
            new Vraag("Bij welke sport wordt soms heel hard geroepen: One hundred and eighty!", new string[] {"Darten","Kogelstoten","Klassiek ballet" },1,"Bij het darten is de maximale score 100."),
            new Vraag("Welk fruit is vernoemd naar een vogel?",new string[] {"Durian","Kiwi","Pink Lady" },2,"De kiwi is vernoemd naar een vogel uit Nieuw-Zeeland die niet kan vliegen.")
        };

        public bool isGeeindigd;
        private int HuidigeVraag = 0;
        private int AantalCorrectGeantwoord;


        public string StelVraag()
        {
            string result;
            int teller = 1;
            result = vragen[HuidigeVraag].VraagTekst + "\n";
            foreach (var antwoord in vragen[HuidigeVraag].Antwoorden)
            {
                result += $"\n{teller++}. {antwoord}";
            }
            result += "\n\n1, 2 of 3? ";
            return result;
        }

        public string ControleerAntwoord(int antwoord)
        {
            if (antwoord == vragen[HuidigeVraag].Correct)
            {
                AantalCorrectGeantwoord++;
                return $"Het antwoord was juist! {vragen[HuidigeVraag].Uitleg}";
            }
            else return $"Het antwoord was fout!\nHet juiste antwoord was {vragen[HuidigeVraag].Correct}. {vragen[HuidigeVraag].Uitleg}";
        }

        public string Score()
        {
            int ronde = HuidigeVraag;
            return $"Jouw score: {AantalCorrectGeantwoord}/{++ronde}";
        }

        public void GaNaarVolgendeVraag()
        {
            if (HuidigeVraag < vragen.Count - 1) HuidigeVraag++;
            else isGeeindigd = true;
        }
    }
}
