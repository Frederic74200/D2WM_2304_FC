using ClassLibraryLépidoptère.Stades;

namespace ClassLibraryLépidoptère
{


    public class Lepidoptere
    {      

        private Stade stadeCorent;

        private int genre0m1f; // 0 = mâle  ; 1 = femelle 
        Random rnd = new Random();

        public int Genre0m1f { get => genre0m1f; set => genre0m1f = value; }
        public Stade StadeCorent { get => stadeCorent; set => stadeCorent = value; }

        public Lepidoptere(Stade _stadeCorent, int _genre0m1f)
        {
            stadeCorent = _stadeCorent;

            genre0m1f = _genre0m1f;
        }


        public Lepidoptere()

        {           
            stadeCorent  = new Œuf();

             genre0m1f = rnd.Next(2);
        }

        public Lepidoptere(Lepidoptere lepiAcloner)
            : this(lepiAcloner.stadeCorent, lepiAcloner.genre0m1f)
        {

        }

        public String SeDeplacer()
        {
           string deplacement;          
           deplacement = stadeCorent.SeDeplacer(); 
                 
           return deplacement;
        }

        public Stade SeMetamorphoser()
        {
            stadeCorent = stadeCorent.SeMetamorphoser();    
            return stadeCorent;
        }


        
    }
}