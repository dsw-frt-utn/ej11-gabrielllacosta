using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        Alumno alumno1 = new Alumno(1, "Gabriel", 8.5);
        Alumno alumno2 = new Alumno(2, "Juan", 7.2);
        Alumno alumno3 = new Alumno(3, "Pedro", 9.1);

        casoList.AgregarAlumno(alumno1);
        casoList.AgregarAlumno(alumno2);
        casoList.AgregarAlumno(alumno3);

        Console.WriteLine("Lista de alumnos:");
        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        Console.WriteLine("\nBuscar alumno existente:");
        Alumno? alumnoEncontrado = casoList.BuscarPorNombre("Gabriel");

        if (alumnoEncontrado != null)
        {
            Console.WriteLine(alumnoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nBuscar alumno inexistente:");
        Alumno? alumnoNoEncontrado = casoList.BuscarPorNombre("Carlos");

        if (alumnoNoEncontrado != null)
        {
            Console.WriteLine(alumnoNoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        casoList.EliminarAlumno(alumno2);

        Console.WriteLine("\nLista después de eliminar un alumno:");
        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

        casoList.EliminarAlumnoEnPosicion(0);

        Console.WriteLine("\nLista después de eliminar el primer elemento:");
        foreach (Alumno alumno in casoList.RetornarLista())
        {
            Console.WriteLine(alumno);
        }

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        Alumno alumno1 = new Alumno(1, "Gabriel", 8.5);
        Alumno alumno2 = new Alumno(2, "Juan", 7.2);
        Alumno alumno3 = new Alumno(3, "Pedro", 9.1);

        casoDictionary.AgregarAlumno(alumno1.Id, alumno1);
        casoDictionary.AgregarAlumno(alumno2.Id, alumno2);
        casoDictionary.AgregarAlumno(alumno3.Id, alumno3);

        Console.WriteLine("Diccionario de alumnos:");
        foreach (KeyValuePair<int, Alumno> item in casoDictionary.RetornarDiccionario())
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        Console.WriteLine("\nBuscar alumno existente:");
        Alumno? alumnoEncontrado = casoDictionary.BuscarPorLegajo(1);

        if (alumnoEncontrado != null)
        {
            Console.WriteLine(alumnoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        Console.WriteLine("\nBuscar alumno inexistente:");
        Alumno? alumnoNoEncontrado = casoDictionary.BuscarPorLegajo(99);

        if (alumnoNoEncontrado != null)
        {
            Console.WriteLine(alumnoNoEncontrado);
        }
        else
        {
            Console.WriteLine("No existe");
        }

        casoDictionary.EliminarAlumno(2);

        Console.WriteLine("\nDiccionario después de eliminar un alumno:");
        foreach (KeyValuePair<int, Alumno> item in casoDictionary.RetornarDiccionario())
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("Primer libro:");
        Console.WriteLine(casoLinq.GetPrimero());

        Console.WriteLine("\nÚltimo libro:");
        Console.WriteLine(casoLinq.GetUltimo());

        Console.WriteLine($"\nTotal de precios: {casoLinq.GetTotalPrecios():C}");

        Console.WriteLine($"\nPromedio de precios: {casoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\nLibros con Id mayor a 15:");
        foreach (Libro libro in casoLinq.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibros con título y precio:");
        foreach (string libro in casoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibro con mayor precio:");
        Console.WriteLine(casoLinq.GetMayorPrecio());

        Console.WriteLine("\nLibro con menor precio:");
        Console.WriteLine(casoLinq.GetMenorPrecio());

        Console.WriteLine("\nLibros con precio mayor al promedio:");
        foreach (Libro libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibros ordenados por título descendente:");
        foreach (Libro libro in casoLinq.GetLibrosOrdenadosDescendente())
        {
            Console.WriteLine(libro);
        }
    }

}

