using PrimaImoti.Data;
using PrimaImoti.DataModels.Ad;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaImoti.Services.Data
{
    public interface IPropertyService
    {
        void Delete();

        void AddProperty();

        void EditProperty(int id);

        void AllEstates(Ad ad);

        void ShowHouses();

        void ShowApartments();

    }
}
