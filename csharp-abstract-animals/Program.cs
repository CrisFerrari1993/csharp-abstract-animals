using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;
using System;
using System.Runtime.InteropServices;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **Esercizio 1 : classi astratte*
            */
            List<Animale> animaliLista = new List<Animale>();
            animaliLista.Add(new Aquila());
            animaliLista.Add(new Passerotto());
            animaliLista.Add(new Delfino());
            animaliLista.Add(new Cane());
            foreach(Animale animal in animaliLista)
            {
                Console.WriteLine("/*/*/*/*/*/*/*/*/*/*/*/");
                animal.IoSono();
                animal.Verso();
                animal.Mangia();
                animal.Dormi();
            }
            /*
            **Esercizio 2 : interfacce*
            */
            List<Animale> animals = new List<Animale>() { new Passerotto(), new Aquila(), new Cane(), new Orca() };
            foreach(Animale a in animals)
            {
                if(a is IVolante)
                {
                    FaiVolare((IVolante)a);
                }  
                if(a is Inuotante)
                {
                    FaiNuotare((Inuotante)a);                }
            }
            
        }
        static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }
        static void FaiNuotare(Inuotante animale)
        {
            animale.Nuota();
        }

    }
}
