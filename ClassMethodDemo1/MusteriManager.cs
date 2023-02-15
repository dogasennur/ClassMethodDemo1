using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo1
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Bankamıza hoşgeldiniz"+ "="+ musteri.firstName);
        
        }   
        public void Listele(Musteri musteri) 
        {
            Console.WriteLine("müşteriler listelendi "+ "="+ musteri.firstName);
        
        }

        public void Silme(Musteri musteri) 
        {
            Console.WriteLine("hoşçakalın"+ "="+ musteri.firstName);
        
        
        }

        public void Add(string firstName, int id) 
        {
            Console.WriteLine(" bankamıza hoşgeldiniz: "+ firstName , id);
        }
    }
}
