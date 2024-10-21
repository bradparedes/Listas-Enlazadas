﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    public class School
    {
        private List<estudiante> students ;
        public School() 
        {
            students = new List<estudiante>();
        }
        public void addStudent(estudiante nuevoestudiante) 
        {
            students.Add(nuevoestudiante);
        }
        public bool buscarPorNombre (String name) 
        {
            bool encontrado = false;
            int i = 0;
            while (encontrado == false && i < students.Count)
            {
                if (students[i].Nombre.Equals(name)) 
                {
                    encontrado = true;
                }
                else 
                {
                    i++;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("Name: " + students[i].Nombre + "\n"
                + "Age: " + students[i].Edad + "\n"
                + "Qualification: " + students[i].Calificacion);
                return false;
            }
            else
            {
                Console.WriteLine("No existe el nombre, intente nuevamente...!");
                return true;
            }
        }
    }
}
