using Castle.MicroKernel.SubSystems.Conversion;
using OnlineBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
public class Book
{ 
    public int BookId { get; set; }
    public string Name { get; set; }
    //[Required(ErrorMessage = "Please Enter Name of the Book")]
    public string AuthorName { get; set; }
    //[Required(ErrorMessage = "Please Enter Name of the Author")]
    public string ShortDescription { get; set; }
    //[Required(ErrorMessage = "Cannot be Empty")]
    public string LongDescription { get; set; }
    //[Required(ErrorMessage = "Cannot be Empty")]
    public decimal Price { get; set; }
    //[Required(ErrorMessage = "Please Enter Price of the Book")]
    public string ImageUrl { get; set; }
    //[Required(ErrorMessage = "Cannot be Empty")]
    public bool InStock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    //[Required(ErrorMessage = "Cannot be Empty")]
    //public DateTime BookAdded { get; set; }
    public bool IsDeleted=false;
 
}
