using System;
using System.Collections.Generic;

namespace EjemplosLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Jeferson", Apellido="Alcivar", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Luis",  Apellido="Tuarez",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Luis",  Apellido="Cornejo",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Carlos",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Ramon",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };

         
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
        
        }
    }
}
