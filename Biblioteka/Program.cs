using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteka
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ksiazka> listaKsiazek = new List<Ksiazka>();
            listaKsiazek.Add(new Ksiazka(1, "AAAA", "0000", new Status()));
            listaKsiazek.Add(new Ksiazka(2, "BBBB", "1111", new Status()));
            listaKsiazek.Add(new Ksiazka(3, "CCCC", "2222", new Status()));
            listaKsiazek.Add(new Ksiazka(4, "DDDD", "3333", new Status()));
            listaKsiazek.Add(new Ksiazka(5, "EEEE", "4444", new Status()));
            listaKsiazek.Add(new Ksiazka(6, "FFFF", "5555", new Status()));
            listaKsiazek.Add(new Ksiazka(7, "GGGG", "6666", new Status()));
            //listaKsiazek.Add(new Ksiazka(8, "HHHH", "7777", new Status()));
            //listaKsiazek.Add(new Ksiazka(9, "IIIII", "8888", new Status()));
            //listaKsiazek.Add(new Ksiazka(10, "JJJJJ", "9999", new Status()));
            //Obslugajson obsluga = new Obslugajson();
            Obslugatxt obsluga = new Obslugatxt();
            //Obslugaxml obsluga = new Obslugaxml();
            obsluga.Write(listaKsiazek);
            obsluga.Remove(1);

            Biblioteka biblioteka = new Biblioteka();
            Console.WriteLine(".....");

            //obsluga.Update(new Ksiazka(5, "Lord of the Rings", "0000", new Status(Dostepnosc.Wypozyczona,"Derek Banas")));
            //obsluga.Add(new Ksiazka(27, "JJJJJ", "9999", new Status()));
            //obsluga.Add(new Ksiazka(15, "JJJJJ", "9999", new Status()));
            //obsluga.Remove(27);
            //biblioteka.ListaKsiazek = obsluga.Read("danetxt.txt");
            //Console.WriteLine(biblioteka.ListaKsiazek[4].ToString());
            
            Console.Read();
        }

    
    }
}
