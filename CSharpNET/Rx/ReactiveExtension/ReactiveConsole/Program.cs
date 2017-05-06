using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.IO;
using System.Reactive.Concurrency;
using System.Reactive.PlatformServices;

namespace ReactiveConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"c:\mifichero.txt";
            var observableLines = Observable.Create<string>(observer =>
            {
                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        observer.OnNext(line);
                    }
                }

                observer.OnCompleted();

                return () => { };
            });

            observableLines.Subscribe(Imprimir);

            observableLines.SubscribeOn(NewThreadScheduler.Default).Subscribe(line => Lineas += line);
        }

        static string Lineas = "";

        static void Imprimir(string mensaje)
        {

        }

        static void Imprimir2()
        {
        }


    }
}
