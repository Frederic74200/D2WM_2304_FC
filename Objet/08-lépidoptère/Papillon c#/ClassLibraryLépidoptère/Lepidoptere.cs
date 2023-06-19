using ClassLibraryLépidoptère.Stades;

namespace ClassLibraryLépidoptère
{


    public class Lepidoptere
    {      

        private Stade stadeCorent; 


        public Lepidoptere()
        {           
            stadeCorent  = new Œuf();
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