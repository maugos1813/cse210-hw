using System;

public class MathAssignment : Assignment //La clase de "MathAssignment" hereda la clase de "Assignment"
{
    private string _textbookSection; // Campo privado para almacenar la sección del libro de texto
    private string _problems; // Campo privado para almacenar los problemas de la tarea

    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    : base(studentName, topic) // Llama al constructor de la clase base "Assignment" para heredar "studentName" y "topic"
    {
        _textbookSection = textbookSection; // Creamos un campo nuevo para almacenar la sección del Libro de Texto
        _problems = problems; // Creamos un campo nuevo para almacenar los problemas de la tarea
    }

    public string GetHomeworkList() // Creamos una clase neuva para mostrar la lista de tareas
    {
        return $"Section {_textbookSection} Problems {_problems}"; // Devuelve un string con la sección del Libro de texto y los problemas de la tarea
    }
}