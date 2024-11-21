using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CRUD_of_8th_lesson.Models;

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string BirthPlace { get; set; }
    public string LivingPlace { get; set; }
    public string Status { get; set; }
    public string StatusPlace { get; set; }
    public DateTime BirthDay { get; set; }
}
