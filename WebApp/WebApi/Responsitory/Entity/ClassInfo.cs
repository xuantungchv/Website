using Microsoft.AspNetCore.Identity;

namespace WebApi.Responsitory.Entity
{
    public class ClassInfo
    {
        public long Id { get; set; }
        public string? ClassName { get; set; }
        public int? NumberOfStudent { get; set; }
    }
}
