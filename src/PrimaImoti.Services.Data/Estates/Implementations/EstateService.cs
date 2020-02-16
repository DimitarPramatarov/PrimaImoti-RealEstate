using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PrimaImoti.Data;
using PrimaImoti.DataModels.Ad;
using PrimaImoti.Services.Data.Estates.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        public async Task CreateAsync(Ad ad)
        {
            if (ad != null)
            {
                this.context.Ads.Add(ad);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<WaitingEstatesServiceModel>> WaitingForAprove()
            => await this.context
            .Ads
            .OrderByDescending(a => a.CreatedOn)
            .ProjectTo<WaitingEstatesServiceModel>(mapper.ConfigurationProvider)
            .ToListAsync();



    }
}
