namespace PrimaImoti.ViewModels.ViewModels
{
    using PrimaImoti.Services.Data.Estates.Models;
    using System.Collections.Generic;

    public class WaitingEstatesViewModel
    {
        public IEnumerable<WaitingEstatesServiceModel> WaitingEstates { get; set; }
    }
}
