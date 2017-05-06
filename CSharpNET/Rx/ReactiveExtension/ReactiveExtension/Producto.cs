using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveExtension
{
    class Producto
    {
        public System.Reactive.Subjects.ReplaySubject<int> observador;

        public Producto()
        {
            this.observador = new System.Reactive.Subjects.ReplaySubject<int>();
        }
    }
}
