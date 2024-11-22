using Second_CRUD_of_8th_lesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_CRUD_of_8th_lesson.Services
{
    internal class CarsServices
    {
        private List<Cars> ListedCars;
        public CarsServices()
        {
            ListedCars = new List<Cars>();
            DataSeed();
        }

        public Cars AddedCars(Cars addingCars)
        {
            addingCars.Id = Guid.NewGuid();
            ListedCars.Add(addingCars);
            return addingCars;
        }


        public bool DeletedCars(Guid IdForDelete)
        {
            var trueFalse = false;

            foreach(var check in ListedCars)
            {
                if(check.Id == IdForDelete)
                {
                    ListedCars.Remove(check);
                    trueFalse = true;
                    break;
                }
            }
            return trueFalse;
        }


        public bool UpdatedCars(Cars updatingCars)
        {
            for(var i = 0; i < ListedCars.Count; i++)
            {
                if (ListedCars[i].Id == updatingCars.Id)
                {
                    ListedCars[i] = updatingCars;
                    return true;
                }
            }
            return false;
        }


        public Cars GetById(Guid IdForBackWithId)
        {
            foreach(var check in ListedCars)
            {
                if(check.Id == IdForBackWithId)
                {
                    return check;
                }
            }
            return null;
        }


        public List<Cars> GetAllCars()
        {
            return ListedCars;
        }

        public void DataSeed()
        {
            var firstCarExample = new Cars()
            {
                Id = Guid.NewGuid(),
                Model = "BMW",
                Year = 1687,
                BuiltPlace = "Germany",
                Owner = "Nurulloh Lutfullayev",
                Description = "Svejuxa, Tinnu, Kraskasi toza",
                Colour = "Белый жемчуг",
                CarMileage = 57000,
            };

            var secondCarExample = new Cars()
            {
                Id = Guid.NewGuid(),
                Model = "Gentra",
                Year = 1994,
                BuiltPlace = "Uzbekistan",
                Owner = "Tursunboy Adashboyev",
                Description = "Bitta ikta urilgan joyi bor, atak yaxsh yuradi",
                Colour = "Qora",
                CarMileage = 118000,
            };

            var thirdCarExample = new Cars()
            {
                Id = Guid.NewGuid(),
                Model = "Spark",
                Year = 2008,
                BuiltPlace = "Uzbekistan",
                Owner = "Malika holiqova",
                Description = "Faqat ishga qatnagan, aybi yo'q",
                Colour = "Oq",
                CarMileage = 89000,
            };


            ListedCars.Add(firstCarExample);
            ListedCars.Add(secondCarExample);
            ListedCars.Add(thirdCarExample);

        }



    }
}
