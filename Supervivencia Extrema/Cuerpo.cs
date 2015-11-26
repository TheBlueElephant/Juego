using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivencia_Extrema
{
    class Cuerpo
    {
        // Partes del cuerpo.
        private bool cabeza;
        private bool cuello;
        private bool pecho;
        private bool brazos;
        private bool manoDer;
        private bool manoIzq;
        private bool cintura;
        private bool piernas;
        private bool pies;

        // Constructor de la clase Cuerpo.
        public Cuerpo()
        {
            getCuerpoInicial();
        }

        // Crea un cuerpo inicial vacio.
        private void getCuerpoInicial()
        {
            cabeza = false;
            cuello = false;
            pecho = false;
            brazos = false;
            manoDer = false;
            manoIzq = false;
            cintura = false;
            piernas = false;
            pies = false;
        }


        // Getter y Setter de los partes del cuerpo.
        public bool Cabeza
        {
            get
            {
                return cabeza;
            }
            set
            {
                cabeza = value;
            }
        }

        public bool Cuello
        {
            get
            {
                return cuello;
            }
            set
            {
                cuello = value;
            }
        }

        public bool Pecho
        {
            get
            {
                return pecho;
            }
            set
            {
                pecho = value;
            }
        }

        public bool Brazos
        {
            get
            {
                return brazos;
            }
            set
            {
                brazos = value;
            }
        }

        public bool ManoDer
        {
            get
            {
                return manoDer;
            }
            set
            {
                manoDer = value;
            }
        }

        public bool ManoIzq
        {
            get
            {
                return manoIzq;
            }
            set
            {
                manoIzq = value;
            }
        }

        public bool Cintura
        {
            get
            {
                return cintura;
            }
            set
            {
                cintura = value;
            }
        }

        public bool Piernas
        {
            get
            {
                return piernas;
            }
            set
            {
                piernas = value;
            }
        }

        public bool Pies
        {
            get
            {
                return pies;
            }
            set
            {
                pies = value;
            }
        }


        // Cambiar los estados de las partes de los cuerpos.
        public void cambiarCabeza()
        {
            Cabeza = !Cabeza;
        }

        public void cambiarCuello()
        {
            Cuello = !Cuello;
        }

        public void cambiarPecho()
        {
            Pecho = !Pecho;
        }

        public void cambiarBrazos()
        {
            Brazos = !Brazos;
        }

        public void cambiarManoDer()
        {
            ManoDer = !ManoDer;
        }

        public void cambiarManoIzq()
        {
            ManoIzq = !ManoIzq;
        }

        public void cambiarCintura()
        {
            Cintura = !Cintura;
        }
        
        public void cambiarPiernas()
        {
            Piernas = !Piernas;
        }

        public void cambiarPies()
        {
            Pies = !Pies;
        }

        
    }//Fin de clase
}
