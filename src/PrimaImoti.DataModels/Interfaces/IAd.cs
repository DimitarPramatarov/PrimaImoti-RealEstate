namespace PrimaImoti.DataModels.Interfaces
{
    public interface IAd
    {
        int Id {get; set;}

        EstateProperty Estate {get; set;}

        double Price {get; set;}

        string Description {get; set;}

        byte[] Images {get; set;}

    }
}
