using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteka
{
    class Obslugaxml:ObslugaPlikow
    {
        public readonly string path = "danexml.xml";

        public override List<Ksiazka> Read(string path)
        {
            return new List<Ksiazka>();
        }

        public override void Write(List<Ksiazka> lista)
        {
            XDocument document = new XDocument();
            var ksiazki = new XElement("Ksiazki");
            foreach (var ksiazka in lista)
            {
                ksiazki.Add(KsiazkaToXml(ksiazka));
            }
                document.Add(ksiazki);
                document.Save(path);
        }
        private static XElement KsiazkaToXml(Ksiazka ksiazka)
        {
            var ksiazkaXML = new XElement("ksiazka",
                          new XAttribute(nameof(Ksiazka.Id), ksiazka.Id),
                          new XAttribute(nameof(Ksiazka.Nazwa), ksiazka.Nazwa),
                          new XAttribute(nameof(Ksiazka.Kategoria), ksiazka.Kategoria),
                          new XElement("status",
                                       new XAttribute(nameof(Ksiazka.Status.Dostepny), ksiazka.Status.Dostepny),
                                       new XAttribute(nameof(Ksiazka.Status.Wypozyczony), ksiazka.Status.Wypozyczony),
                                       new XAttribute(nameof(Ksiazka.Status.Zarezerwowany), ksiazka.Status.Zarezerwowany),
                                       new XAttribute(nameof(Ksiazka.Status.UserName), ksiazka.Status.UserName)));
            return ksiazkaXML;
        }
    }
}
