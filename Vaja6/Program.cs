using System.IO;

namespace vaja6 {

  // Enumerator za tip poklica
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

		// Privzeti konstruktor
        public Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }

		// Bralna lastnost, ki dovoli branje privatne spremenljivke id
        public int Id {
            get
            {
                return id;
            }
        }

		// Bralno-Pisalna lastnost, ki dovoli branje in spreminjanje privatne spremenljivke ime
        public string U_ime 
		{
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }

		// Bralno-Pisalna lastnost, ki dovoli branje in spreminjanje privatne spremenljivke geslo
        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }

		// Bralna lastnost, ki dovoli branje privatne spremenljivke stIg
        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
