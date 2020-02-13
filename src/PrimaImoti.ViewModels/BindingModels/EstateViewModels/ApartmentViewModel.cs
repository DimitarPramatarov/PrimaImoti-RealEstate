namespace PrimaImoti.ViewModels.EstateViewModels
{
    public class ApartmentViewModel : EstateViewModel
    {
        //  public ApartmentViewModel(string adress, int area, string furniture, string building, 
        //      int buildFloor, string heating, string location, int rooms, int apartmentFloor) 
        //      : base(adress, area, furniture, building, buildFloor, heating, location)
        //  {
        //      this.Rooms = rooms;
        //      this.ApartmentFloor = apartmentFloor;
        //  }

        public ApartmentViewModel()
        {

        }

        public int Rooms {get; set;}

        public int ApartmentFloor {get; set;}
    }
}
