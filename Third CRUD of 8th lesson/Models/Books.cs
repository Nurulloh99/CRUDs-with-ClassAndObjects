using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_CRUD_of_8th_lesson.Models;

public class Books
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public string Description { get; set; }
    public DateTime DateTimee { get; set; }
    public string Where { get; set; }
    public int Pages { get; set; }
}
