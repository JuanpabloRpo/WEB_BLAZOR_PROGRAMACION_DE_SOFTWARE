using WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Entities;

namespace WEB_BLAZOR_PROGRAMACION_DE_SOFTWARE.Interfaces
{
    public interface IMaterialService
    {
        Task<List<Material>> ListMaterials();
        Task<List<Material>> ListAvailableMaterials();
        Task<Material> GetMaterial(int id);
        Task<Boolean> CreateMaterial(Book material);
        Task<Boolean> CreateMaterial(Audiovisual material);/*
        Task<Boolean> UpdateMaterial(Material material);
        Task<Boolean> DeleteMaterial(int id);*/
    }
}
