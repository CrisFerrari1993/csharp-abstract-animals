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
            List<Animale> animali = new List<Animale>();
            animali.Add(new Aquila());
            animali.Add(new Passerotto());
            animali.Add(new Delfino());
            animali.Add(new Cane());
            foreach(Animale animale in animali)
            {
                Console.WriteLine("/*/*/*/*/*/*/*/*/*/*/*/");
                animale.IoSono();
                animale.Verso();
                animale.Mangia();
                animale.Dormi();
            }
            /*
            **Esercizio 2 : interfacce*
            */
            List<IVolante> volatili = new List<IVolante>() { new Passerotto() , new Aquila()};
            foreach(IVolante animaleVolatile in volatili)
            {
                animaleVolatile.Vola();
            }
            List<Inuotante> natanti = new List<Inuotante>() { new Cane(), new Delfino()};
            foreach (Inuotante animaleNatante in natanti)
            {
                animaleNatante.Nuota();
            }
        }
        static void FaiVolare(Inuotante animale)
        {
            animale.Nuota();
        }
        static void FaiNuotare(IVolante animale)
        {
            animale.Vola();
        }

    }
}
