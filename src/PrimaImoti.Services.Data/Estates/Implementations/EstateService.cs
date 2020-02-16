using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using PrimaImoti.Data;
using PrimaImoti.Services.Data.Estates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaImoti.Services.Data.Estates.Implementations
{

    public class EstateService : IEstateService
    {
        public readonly ApplicationDbContext context;
        public readonly IMapper mapper;

        public EstateService(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<WaitingEstatesServiceModel>> WaitingForAprove()
            => await this.context
            .Ads
            .OrderByDescending(a => a.CreatedOn)
            .ProjectTo<WaitingEstatesServiceModel>(mapper.ConfigurationProvider)
            .ToListAsync();

    }
}
