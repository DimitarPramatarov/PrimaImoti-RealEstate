namespace PrimaImoti.DataModels.Estate
{
    public interface IEstate
    {
        int Id { get; set; }

        string Location { get; set; }

        string Adress { get; set; }

        int Area { get; set; }

        string Furniture { get; set; }

        string Building { get; set; }

        int Floor { get; set; }

        string Heating { get; set; }

        EstateFeatures EstateFeatures {get; set;}

    }
}
