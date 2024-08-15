using System.ComponentModel.DataAnnotations;

namespace AbbeyWeb.Model
{
    public class Category
    {
        //creating 3 coloumns for the database table
        [Key]
        public int Id { get; set; }
        [Required]
        public string  Name { get; set; }
        public  int DisplayOrder { get; set; }
    }
}
