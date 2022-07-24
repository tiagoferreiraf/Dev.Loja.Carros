using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Loja.Carros.Models
{
    public class Carro
    {
       
        public Guid Id { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public int Ano { get; set; }
        
        public string LinkImg { get; set; }
      
        //
        public Carro()
        {
            Id = Guid.NewGuid();
        }
    }
}
