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
            List<Animale> volatili = new List<Animale>() { new Passerotto(), new Aquila() };
            foreach(IVolante volante in volatili)
            {
                FaiVolare(volante);
            }
            List<Animale> natanti = new List<Animale>() { new Delfino(), new Orca() };
            foreach (Inuotante natante in natanti)
            {
                FaiNuotare(natante);
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
