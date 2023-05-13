using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace PBL3_Project.Models
{
    public class BaiDangChoDuyet
    {
        [Key]
        public int ID_BaiDang { get; set; }
        public bool TinhTrang { get; set; }
    }
}
