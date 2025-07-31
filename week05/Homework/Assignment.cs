using System; // Permite usar las clases escenciales como Console, String, etc. Es lo básivo, siempre se pone

public class Assignment // Declaración de clase "Assingment" define el modelo de una tarea (simplemente es la manera de poder crear una clase pública)
{
    private string _studentName; // Campos privados que son las variables de la clase. El "_"(guión bajo) es una convención para indicar que son privados. (Sirven para almacenar en este caso el nombre del estudiante)
    private string _topic;

    public Assignment(string studentName, string topic) // Constructor de clase. Se llama automáticamente cuando creamos un nuevo objeto con "new Assignment()"
    {
        _studentName = studentName; //Cuerpo del constructor
        _topic = topic; // Cuerpo del constructor
    }


    public string GetSummary() // Es un método público que devuelve un string con el resumen de la tarea
    {
        return $"{_studentName} - {_topic}"; //Cuerpo del método "GetSummary
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}