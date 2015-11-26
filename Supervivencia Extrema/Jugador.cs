using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervivencia_Extrema
{
    public class Jugador
    {
        private String usuario;
        private String password;
        // Nivel
        private int nivel;
        private int experiencia;
        // PA
        private int paMax;
        private int pa;
        // PM
        private int pmMax;
        private int pm;

        // Estadisticas calculadas
        private int damange;
        private int armor;
        private int vida;

        //Estadisticas basicas
        private int fuerza;
        private int destreza;
        private int constitucion;
        private int inteligencia;
        private int sabiduria;
        private int carisma;

        // Partes del cuerpo
        Cuerpo cuerpoJugador;

        // Clase
        ClaseJugador clase;

        // Constructor
        public Jugador(String nombre, String password)
        {
            Usuario = nombre;
            Password = password;


        }


        private void estadoIncial()
        {
            Damange = 0;
            Armor = 0;
            Vida = 0;
            CuerpoJugador = new Cuerpo();
            Nivel = 0;
        }

        // Getter y Settet de la clase
        public String Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }
            set
            {
                nivel = value;
            }
        }

        public int Experiencia
        {
            get
            {
                return experiencia;
            }
            set
            {
                experiencia = value;
            }
        }

        public int PaMax
        {
            get
            {
                return paMax;
            }
            set
            {
                paMax = value;
            }
        }

        public int Pa
        {
            get
            {
                return pa;
            }
            set
            {
                pa = value;
            }
        }

        public int PmMax
        {
            get
            {
                return pmMax;
            }
            set
            {
                pmMax = value;
            }
        }

        public int Pm
        {
            get
            {
                return pm;
            }
            set
            {
                pm = value;
            }
        }

        public int Damange
        {
            get
            {
                return damange;
            }
            set
            {
                damange = value;
            }
        }

        public int Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }

        public int Vida
        {
            get
            {
                return vida;
            }
            set
            {
                vida = value;
            }
        }

        public int Fuerza
        {
            get
            {
                return fuerza;
            }
            set
            {
                fuerza = value;
            }
        }

        public int Destreza
        {
            get
            {
                return destreza;
            }
            set
            {
                destreza = value;
            }
        }

        public int Constitucion
        {
            get
            {
                return constitucion;
            }
            set
            {
                constitucion = value;
            }
        }

        public int Inteligencia
        {
            get
            {
                return inteligencia;
            }
            set
            {
                inteligencia = value;
            }
        }

        public int Sabiduria
        {
            get
            {
                return sabiduria;
            }
            set
            {
                sabiduria = value;
            }
        }

        public int Carisma
        {
            get
            {
                return carisma;
            }
            set
            {
                carisma = value;
            }
        }

        public Cuerpo CuerpoJugador
        {
            get
            {
                return cuerpoJugador;
            }
            set
            {
                cuerpoJugador = value;
            }
        }

        public ClaseJugador Clase
        {
            get
            {
                return clase;
            }
            set
            {
                clase = value;
            }
        }


    }// Fin de clase
}
