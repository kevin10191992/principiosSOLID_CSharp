using SingleResponsability;
using SingleResponsability.Helpers;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new ExportHelper();
exportHelper.ExportStudents(studentRepository.GetAll());
//studentRepository.Export();
Console.WriteLine("Proceso Completado");