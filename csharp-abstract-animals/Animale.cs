using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public interface Inuotante
    {
        public void Nuota()
        {
            Console.WriteLine($"Ciao, sono un {GetType().Name} e sto nuotando!!!");
        }
    }
    public interface IVolante
    {
        public void Vola()
        {
            Console.WriteLine($"Ciao, sono un {GetType().Name} e sto volando!!!!");
        }
    }
    public abstract class Animale
    {
        public void IoSono()
        {
            Console.WriteLine($"Ciao io sono {GetType().Name}");
        }
        public void Dormi()
        {
            Console.WriteLine("Zzzzz");
        }

        public abstract void Mangia();

        public abstract void Verso();
    }
    public class Cane : Animale, Inuotante
    {
        public override void Mangia()
        {
            Console.WriteLine($"sto mangiando carne e crocchette");
        }
        public override void Verso()
        {
            Console.WriteLine("bau Bau");
        }
    }
    public class Passerotto : Animale, IVolante
    {
        public override void Mangia()
        {
            Console.WriteLine("sto mangiando la semenza");
        }
        public override void Verso()
        {
            Console.WriteLine("cip Cip");
        }
    }
    public class Aquila : Animale, IVolante
    {
        public override void Mangia()
        {
            Console.WriteLine("sto mangiando la carne");
        }

        public override void Verso()
        {
            Console.WriteLine("sto stridendo");
        }

    }
    public class Delfino : Animale, Inuotante
    {

        public override void Mangia()
        {
            Console.WriteLine("sto mangiando il pesce");
        }
        public override void Verso()
        {
            Console.WriteLine("sto fischettando");
        }
    }
    public class Orca : Animale, Inuotante
    {

        public override void Mangia()
        {
            Console.WriteLine("sto mangiando il pesce");
        }
        public override void Verso()
        {
            Console.WriteLine("sto cantando");
        }
    }
}
