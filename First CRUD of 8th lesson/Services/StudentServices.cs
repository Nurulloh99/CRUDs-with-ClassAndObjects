using First_CRUD_of_8th_lesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_CRUD_of_8th_lesson.Services;

public class StudentServices
{
    private List<Student> ListOfStudents;
    public StudentServices()
    {
        ListOfStudents = new List<Student>();
        DataSeed();
    }

    public Student AddingStudent(Student addingstudent)
    {
        addingstudent.Id = Guid.NewGuid();
        ListOfStudents.Add(addingstudent);
        return addingstudent;
    }

    public bool DeletedStudent(Guid RemovingStudent)
    {
        var trueFalse = false;

        foreach(var check in ListOfStudents)
        {
            if(check.Id == RemovingStudent)
            {
                ListOfStudents.Remove(check);
                trueFalse = true;
                break;
            }
        }
        return trueFalse;
    }

    public bool UpdatedStudent(Student updatingStudent)
    {
        for(var i = 0; i < ListOfStudents.Count; i++)
        {
            if (ListOfStudents[i].Id == updatingStudent.Id)
            {
                ListOfStudents[i] = updatingStudent;
                return true;
            }
        }
        return false;
    }

    public Student GetById(Guid oneOfStudent)
    {
        foreach(var check in ListOfStudents)
        {
            if(check.Id == oneOfStudent)
            {
                return check;
            }
        }
        return null;
    }


    public List<Student> GetBackAllStudents()
    {
        return ListOfStudents;
    }


    public void DataSeed()
    {
        var firstStudentType = new Student()
        {
            Id = Guid.NewGuid(),
            Name = "Nurulloh",
            Surname = "Lutfullayev",
            Age = 25,
            BirthDay = 1999,
            BirthPlace = "Tashkent",
            LivingPlace = "Tashkent",
            Status = "Studying",
            StatusPlace = "PDP Academy",
        };

        var secondStudentType = new Student()
        {
            Id = Guid.NewGuid(),
            Name = "Ilkhom",
            Surname = "Tilovov",
            Age = 27,
            BirthDay = 1997,
            BirthPlace = "Tashkent",
            LivingPlace = "Tashkent",
            Status = "Studying",
            StatusPlace = "PDP Academy",
        };

        var thirdStudentType = new Student()
        {
            Id = Guid.NewGuid(),
            Name = "Boymurod",
            Surname = "Mamarajabov",
            Age = 24,
            BirthDay = 2000,
            BirthPlace = "Surhandaryo",
            LivingPlace = "Tashkent",
            Status = "Studying",
            StatusPlace = "PDP Academy",
        };

        ListOfStudents.Add(firstStudentType);
        ListOfStudents.Add(secondStudentType);
        ListOfStudents.Add(thirdStudentType);


    }



}
