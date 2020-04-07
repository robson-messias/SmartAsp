using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SmartAsp.Models.Base;

namespace SmartAsp.Models
{
    public class Product: IEntity
    {
        [StringLength(150, MinimumLength = 3)]
        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }
        [Display(Name = "Departamento")] 
        public int DepartmentID { get; set; }
        [Display(Name = "Marca")] 
        public int BrandID { get; set; }
        [StringLength(255, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [Display(Name = "Link")]
        public string LinkID { get; set; }
        [Display(Name = "RefId")] 
        public string RefId { get; set; }
        [Display(Name = "Visivel")] 
        public bool IsVisible { get; set; } //BIT
        [Display(Name = "Ativo")]
        public bool IsActive { get; set; } //BIT
        [Display(Name ="Exibir sem Estoque")]
        public bool ShowWithoutStock { get; set; } //BIT
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        [Display(Name = "Descrição Curta")] 
        public string DescriptionShort { get; set; }
        [Display(Name = "Date Lançamento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Palavras Chaves")]
        public string KeyWords { get; set; }
        [Display(Name = "Titulo")]
        [StringLength(150)]
        public string Title { get; set; }
        [Display(Name = "MetaTag")]
        [StringLength(500)]
        public string MetaTagDescription { get; set; }
        //public int SupplierlD { get; set; }

        public Department Department { get; set; }
        public Brand Brand { get; set; }

    }
}
