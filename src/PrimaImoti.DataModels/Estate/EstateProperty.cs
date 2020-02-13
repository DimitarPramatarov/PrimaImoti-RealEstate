using PrimaImoti.DataModels.Estate;
using System.ComponentModel.DataAnnotations;

namespace PrimaImoti.DataModels
{
    public class EstateProperty : IEstate
    {
      
        public int Id { get; set; }

        public string Location { get; set; }

        public string SecondLocation {get; set;}

        public string Adress { get; set; }

        public int Area { get; set; }

        public string Furniture { get; set; }

        public string Building { get; set; }

        public int Floor { get; set; }

        public string Heating { get; set; }

        public byte[] Image {get; set;}

        public EstateFeatures EstateFeatures {get; set;}

    }
}
