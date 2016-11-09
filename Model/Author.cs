using System.Collections.Generic;

namespace MvcMovie.Model
{
    public class Author
    {
       public int Id{get;set;}

       public string FirstName{get;set;}

       public string LastName{get;set;}

       public List<Article> Articles{get;set;} = new List<Article>(); 
    }
}