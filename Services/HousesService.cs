using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpGregslist.Services
{
    public class HousesService
    {
        private readonly HousesRepository _repo;
        public HousesService(HousesRepository repo)
        {
            _repo = repo;
        }

        internal List<House> Find()
        {
            List<House> houses = _repo.FindAll();
            return houses;
        }
        internal House Find(int id)
        {
            House house = _repo.FindOne(id);
            if (house == null) throw new Exception($"no house at id: {id}");
            return house;
        }
        internal House Create(House houseData)
        {
            House house = _repo.Create(houseData);
            return house;
        }
        internal string Remove(int id)
        {
            House house = this.Find(id);
            bool result = _repo.Remove(id);
            if (!result) throw new Exception($"something horrible went wrong when trying to delete @ id:{id}");
            return $"delted house at id: {house.Id}";
        }
        internal House Update(House updateData)
        {
            House original = this.Find(updateData.Id);
            original.Bedrooms = updateData.Bedrooms != 0 ? updateData.Bedrooms : original.Bedrooms;
            original.Bathrooms = updateData.Bathrooms != 0 ? updateData.Bathrooms : original.Bathrooms;
            original.Year = updateData.Year != 0 ? updateData.Year : original.Year;
            original.Price = updateData.Price != 0 ? updateData.Price : original.Price;
            original.Description = updateData.Description != null ? updateData.Description : original.Description;
            original.ImgUrl = updateData.ImgUrl != null ? updateData.ImgUrl : original.ImgUrl;
            int rowsAffected = _repo.Update(original);
            if (rowsAffected == 0) throw new Exception($"could not modify for some reason");
            if (rowsAffected > 1) throw new Exception($"Something horible went wrong and multiple rows were deleted");
            return original;
        }
    }
}
