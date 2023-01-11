using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Park_API_01.Models
{
    public class Trail
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Distance { get; set; }
        [Required]
        public string Elevation { get; set; }
        public DateTime DateCreated { get; set; }
        public enum DifficultyType { Easy, Moderate, Difficult}
        public DifficultyType Dificulty { get; set; }
        public int NationalParkId { get; set; }
        [ForeignKey("NationalParkId")]
        public NationalPark NationalPark { get; set; }
    }
}
