namespace Guia_Lambda
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>() 
            {
                new Estudiante("Emilio Medina", 22, 92.4),
                new Estudiante("Manuel Perez", 19, 88.2),
                new Estudiante("Martin Pardo", 18, 73.5),
                new Estudiante("Monika Espinoza", 18, 95.8),
                new Estudiante("Elvin Marquez", 25, 78.6),
            };

            //Estudiantes de mayor edad en la lista filtrados con una expresion lambda
            List<Estudiante> estuMayor = estudiantes.Where(M => M.Edad > 18).ToList();
            Console.WriteLine("Estudiantes que mayores a 18 años: ");
            foreach(Estudiante estudiante in estuMayor)
            {
                Console.WriteLine($"El estudiante {estudiante.Nombre}, tiene una edad de {estudiante.Edad} años. ");
            }

            //Estudiante con mayor calificacion
            Estudiante mejorResultado = estudiantes.OrderByDescending(N => N.Nota).FirstOrDefault();
            if (mejorResultado != null)
            {
                Console.WriteLine("\nEstudiante con la calificacion más alta:");
                Console.WriteLine($"La estudiante {mejorResultado.Nombre} tiene una calificacion de {mejorResultado.Nota}");
            }
        }
    }
}
