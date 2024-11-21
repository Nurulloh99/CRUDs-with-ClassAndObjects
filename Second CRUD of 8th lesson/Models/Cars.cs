using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_CRUD_of_8th_lesson.Models;

public class Cars
{
    public Guid Id { get; set; }
    public string Model { get; set; }
    public DateTime Year { get; set; }
    public string BuiltPlace { get; set; }
    public string Owner { get; set; }
    public string Description { get; set; }
    public string Colour { get; set; }
    public double CarMileage { get; set; }
}
