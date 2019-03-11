using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Filmes.Models
{
    public class Filme
    {
        public Filme()
        {

        }

        public Filme(string diretor, string titulo, int duracaoMinutos)
        {
            Diretor = diretor;
            Titulo = titulo;
            DuracaoMinutos = duracaoMinutos;
        }

        public int ID { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(255)]
        public string Diretor { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(255)]
        [RegularExpression("^([a-z]|[A-Z]| )+$")]
        public string Titulo { get; set; }
        [Range(30, 240)]
        public int DuracaoMinutos { get; set; }

    }
}
