namespace InterfaceSegregation.Interfaces
{
    //si quisieras pones a la interfaz a implementar las otras para hacerla global, pero OJO solo si es necesario
    public interface IActivities : IWorkTeamActivities, IDevelopActivities, ITestActivities, IDesingActivities
    {

        ///dividir la interfaz porque tiene muchos metodos

        //void Plan();
        //void Comunicate();
        //void Design();
        //void Develop();
        //void Test();
    }
}