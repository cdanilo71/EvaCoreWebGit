using EvaCoreWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace EvaCoreWeb.Models
{
    public class Tag
    {
        [Key]
        public int isn_tag { get; set; }
        public string dsc_tag { get; set; }
        public Status isn_status_tag { get; set; }
    }
}
