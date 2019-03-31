using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GreatTradePreguntas.Models
{


    public partial class Product
    {

        public Product()
        {
            this.Questions = new HashSet<Question>();
        }

        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int SubCategories { get; set; }
        public int Category { get; set; }
        public double Pice { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Units { get; set; }
        public string city { get; set; }
        public virtual ICollection<Question> Questions { get; set; }

    }

    public partial class Question
    {
        public int Id { get; set; }
        public string Pregunta { get; set; }
        public string Answer { get; set; }
        public string Questioner { get; set; }
        public int Status { get; set; }
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }




}
