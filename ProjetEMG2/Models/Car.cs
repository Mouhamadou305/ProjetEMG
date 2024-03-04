using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetEMG2.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CodeVIN { get; set; } = null!;

        public int Annee {  get; set; }
        public string Marque { get; set; } = null!;
        public string Modele { get; set; } = null!;

        public string Finition { get; set; } = null!;

        public DateTime DateAchat { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(10,0)")]
        public decimal PrixAchat { get; set; }
        public string Reparations { get; set; } = null!;

        [Column(TypeName = "decimal(10,0)")]
        public decimal CoutsReparation { get; set; }
        public DateTime DateDisponibilite {  get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(10,0)")]
        public decimal PrixVente { get; set; }
        public DateTime DateVente {  get; set; } = DateTime.Now;

        public string? Description { get; set; }

    }
}
