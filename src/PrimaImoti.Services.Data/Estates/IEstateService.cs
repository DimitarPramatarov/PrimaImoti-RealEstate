namespace PrimaImoti.Services.Data.Estates
{
    using Microsoft.EntityFrameworkCore.Metadata;
    using PrimaImoti.DataModels.Ad;
    using PrimaImoti.Services.Data.Estates.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public interface IEstateService
    {
        Task<IEnumerable<WaitingEstatesServiceModel>> WaitingForAprove();

        Task CreateAsync(Ad ad);
    }

}
