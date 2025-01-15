using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Ifrastructure.Responsitory.Entity
{
    public class ClassInfo
    {
        public long Id { get; set; }
        public string? ClassName { get; set; }
        public int? NumberOfStudent { get; set; }
        public long ? NameOfTeacher { get; set; }
    }
}
