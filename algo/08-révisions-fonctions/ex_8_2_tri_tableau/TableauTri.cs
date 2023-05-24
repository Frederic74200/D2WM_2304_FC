using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8_2_tri_tableau
{
    internal class TableauTri
    {


        private List<int> tableau;





        public TableauTri()
        {
           this.tableau = new List<int>() { 128, 64, 8, 512, 16, 32, 256};
        }


        public TableauTri(List<int> _tableau)
        {
          
            this.tableau = _tableau;
        }




        public void printTableau ()
        {
           foreach (int i in tableau)
            {
                Console.Write("{0} | ", i);
            }
        }


        public List<int> TrierLeTableau()
        {
            for (int i = 0; i < tableau.Count; i++)
            {
                int tmp = tableau[i];
                int min = tmp;
                int index = i;
             
                for (int j = i; j < tableau.Count; j++)
                {

                    if (tableau[j] < min)
                    {
                        min = tableau[j];
                        index = j;
                    }
                }            

                tableau[i] = min;
                tableau[index] = tmp;
            }


            return this.tableau;
        }








    }
}
