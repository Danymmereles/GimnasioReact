using System;
using System.Collections.Generic;

namespace Gimnasio {
    public class Entrenador {

        public string nombre { set; get; }

        public string categoria { set; get; }

        public List<Boxeador> listaParaEntrenar;

        public Entrenador (string categoria) {
            this.categoria = categoria;
            this.listaParaEntrenar = new List<Boxeador> ();
        }

        public Entrenador () {
            this.listaParaEntrenar = new List<Boxeador> ();
        }

        public void agregarBoxeador (Boxeador boxeador) {
            if (this.listaParaEntrenar.Count < 5) {
                this.listaParaEntrenar.Add(new Boxeador());
                this.listaParaEntrenar[this.listaParaEntrenar.Count-1].cargarDatos(boxeador);
            } else {
                Console.WriteLine ("Lo lamentamos pero no queremos que el entrenador muera de estres");
            }
        }
    }
}