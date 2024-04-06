using System.ComponentModel.DataAnnotations;
using VillaStayAPI.Model;

namespace VillaStayAPI.Data
{
    public static class VillaStore
    {
        public static List<Villa> villas = new List<Villa>()
        {
            new Villa(){
                Id = new Guid("D6F5C33C-7ED2-496D-B33B-B3CBF990F6DB"),
                Name = "Beach Villa",
                CreatedDate = DateTime.Today.AddDays(-20)},
            new Villa(){
                Id = new Guid("35ADFAB6-4DE0-4DFE-A36B-0E5D254B7E54"),
                Name = "Sun Villa",
                CreatedDate = DateTime.Today.AddDays(-30)},
            new Villa(){
                Id = new Guid("DA2E5327-3944-421C-8C12-9295A3724E80"),
                Name = "New Villa",
                CreatedDate = DateTime.Today.AddDays(-40)},
            new Villa(){
                Id = new Guid("DE377FD7-FA49-458F-AF8D-9E721EDA9779"),
                Name = "Old Villa",
                CreatedDate = DateTime.Today.AddDays(-50)},
        };
    }
}
