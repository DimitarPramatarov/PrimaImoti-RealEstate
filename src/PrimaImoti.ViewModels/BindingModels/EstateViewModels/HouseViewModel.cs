namespace PrimaImoti.ViewModels.EstateViewModels
{
    public class HouseViewModel : EstateViewModel
    {
        //  public HouseViewModel(string adress, int area, string furniture, string building, 
        //      int buildFloor, string heating, string location, int yard, int bedRooms, int bathRooms)
        //      : base(adress, area, furniture, building, buildFloor, heating, location)
        //  {
        //      this.Yard = yard;
        //      this.BedRooms = bedRooms;
        //      this.BathRooms = bathRooms;
        //  }

        public HouseViewModel()
        {

        }

        public int Yard {get; set;}

        public int BedRooms {get; set;}

        public int BathRooms {get; set;}
    }
}
