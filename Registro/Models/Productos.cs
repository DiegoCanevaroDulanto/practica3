using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Registro
{
    public class Productos
    {
        public int id {get;set;}

        [Required(ErrorMessage="¡Por favor, Ingrese un producto!")]
        [Display(Name="Nombre del producto")]
        public string nombre{ get; set; }

        [Required(ErrorMessage="¡Por favor, Ingrese una url válida!")]
        [Display(Name="URL")]
        public string imagen { get; set; }
        
        [Required(ErrorMessage="¡Por favor, Ingrese una descripción del producto!")]
        [Display(Name="Descripción del producto")]
        public string descripcion { get; set; }
        
        [Required(ErrorMessage="¡Por favor, Ingrese el precio!")]
        [Display(Name="Precio del producto")]
        public double precio { get; set; }
        
        [Required(ErrorMessage="¡Por favor, Ingrese un número de contacto!")]
        [Display(Name="Número de contacto")]    
        public int celular { get; set; }
        
        [Required(ErrorMessage="¡Por favor, Ingrese un lugar de compra!")]
        [Display(Name="Lugar de compra")]
        public string lugar { get; set; }

        [Required(ErrorMessage="¡Por favor, Ingrese una categoria!")]
        [Display(Name="Categoria")]
        public string categoria { get; set; }
        

        [Required(ErrorMessage="¡Por favor, Ingrese un nuevo usuario!")]
        [Display(Name="Usuario")]
        public string usuario { get; set; }

        [Required]
        public DateTime date { get; set; }
    }
}