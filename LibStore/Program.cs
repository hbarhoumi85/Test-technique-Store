using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibStore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nouvelle instance de la classe Ninject.StandardKernel
            StandardKernel _Kernel = new StandardKernel();

            // Charger les Modules
            _Kernel.Load(Assembly.GetExecutingAssembly());

            IStore _ObjIStore = _Kernel.Get<IStore>();

            Library _ObjLibrary = new Library(_ObjIStore);

            //Lecture du fichier Json
            var catalogAsJson = File.ReadAllText(@"store.json");

            //Import
            Console.WriteLine("=======================================");
            _ObjLibrary.Import(catalogAsJson);
            Console.WriteLine("      Import effectué avec succès          ");
            Console.WriteLine("=======================================");


            //Quantité
            Console.WriteLine("      Informations sur le livre          ");
            Console.WriteLine();
            Console.WriteLine("Veuillez saisir le nom du livre:");
            string line = Console.ReadLine();
            int qte = _ObjLibrary.Quantity(line);
            Console.WriteLine();
            Console.WriteLine("La quantité disponible pour ce livre est: "+qte);
            Console.WriteLine("=======================================");
            Console.ReadLine();

        }
    }
}
