using System;

namespace ConsoleDeber1
{
    class Program
    {
        //Registro de empleados con su sueldo y su cargo dentro de la empresa XYZ
        
        //IMPORTANTEEEEE Para el CMD!!!!!!!!!!!!

        //En el primero Agregar el nombre
        //en el segundo agrega el apellido
        //en el tercero agregar cualquiera de los siguientes cargos: Administrador, Gerente o Contador

        static void Main(string[] argumentos)
           
        {
            //Variables: Dotos personales
            int edad, peso, estatura;
            //array
            int[] sueldo = new int[3];
            //sueldos
            sueldo[0] = 1500;
            sueldo[1] = 900;
            sueldo[2] = 600;

            

            //en cmd: proceso de asignacion de roles y sueldos
            if (argumentos.Length > 0)
            {
         
             //en cmd:se asignaran automaticamente los sueldos dependiendo el cargo.
            if (argumentos[2]=="Administrador")
                {
                    Console.WriteLine("El señor: " + argumentos[0] +" "+ argumentos[1] +"\ncon el rol de:" + argumentos[2]
                        + "\ntendra un sueldo de:" + sueldo[1]);
                }
                if (argumentos[2] == "Gerente")
                {
                    Console.WriteLine("El señor: " + argumentos[0] + " " + argumentos[1] + "\ncon el rol de:" + argumentos[2]
                        + "\ntendra un sueldo de:" + sueldo[0]);
                }
                if (argumentos[2] == "Contador")
                {
                    Console.WriteLine("El señor: " + argumentos[0] + " " + argumentos[1] + "\ncon el rol de:" + argumentos[2]
                        + "\ntendra un sueldo de:" + sueldo[2]);
                }
                else
                {
                    Console.Write("llene todos los campos correctamente");
                }
            }

            Console.WriteLine("Ingrese la edad del empleado; ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso del empleado; ");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la estatura del empleado; ");
            estatura = int.Parse(Console.ReadLine());
            Console.ReadKey();
            
            
        }
    }
}
