﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Obslugajson : ObslugaPlikow,IDisposable
    {
        public readonly string path = ConfigurationManager.AppSettings["file"];
        public override List<Ksiazka> Read(string path)
        {
            List<Ksiazka> listaKsiazek = new List<Ksiazka>();
            foreach (var item in File.ReadAllLines(path))
            {
                Ksiazka ksiazka = JsonConvert.DeserializeObject<Ksiazka>(item);
                listaKsiazek.Add(ksiazka);
            }
            return listaKsiazek;
        }

        public override void Write(List<Ksiazka> lista)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            foreach (var ksiazka in lista)
            {
                string temp = JsonConvert.SerializeObject(ksiazka);
                File.AppendAllText(path, temp + Environment.NewLine);
            }
        }
        public void Update(Ksiazka ksiazka)
        {
            var listaKsiazek = Read(path);
            Updatowanie(ksiazka, listaKsiazek);
        }
        public void Remove(int id)
        {
            var listaKsiazek = Read(path);
            Usuwanie(id, listaKsiazek);
        }
        public void Add(Ksiazka ksiazka)
        {
            var listaKsiazek = Read(path);
            Dodawanie(ksiazka, listaKsiazek);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
