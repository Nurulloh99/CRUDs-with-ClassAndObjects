﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Third_CRUD_of_8th_lesson.Models;

namespace Third_CRUD_of_8th_lesson.Services
{
    public class BooksServices
    {
        private List<Books> ListedBooks;

        public BooksServices()
        {
            ListedBooks = new List<Books>();
            DataSeed();
        }

        public Books AddedBook(Books addingBook)
        {
            addingBook.Id = Guid.NewGuid();
            ListedBooks.Add(addingBook);
            return addingBook;
        }

        public bool DeletedBook(Guid IdForRemove)
        {
            var trueFalse = false;

            foreach(var check in ListedBooks)
            {
                if(check.Id == IdForRemove)
                {
                    ListedBooks.Remove(check);
                    trueFalse = true;
                    break;
                }
            }
            return trueFalse;
        }

        public bool UpdatedBook(Books updatingBook)
        {
            for(var i = 0; i < ListedBooks.Count; i++)
            {
                if (ListedBooks[i].Id == updatingBook.Id)
                {
                    ListedBooks[i] = updatingBook;
                    return true;
                }
            }
            return false;
        }


        public List<Books> GetBackAllBooks()
        {
            return ListedBooks;
        }

        


        public Books GetByID(Guid bookAydi)
        {
            foreach(var check in ListedBooks)
            {
                if(check.Id == bookAydi)
                {
                    return check;
                }
            }
            return null;
        }





        public void DataSeed()
        {
            var firstBookExample = new Books()
            {
                Id = Guid.NewGuid(),
                Name = "Harry Potter",
                Author = "James Cameron",
                DateTimee = 1995,
                Description = "Magic book",
                Pages = 500,
                Where = "Great Britain",
            };


            var secondBookExample = new Books()
            {
                Id = Guid.NewGuid(),
                Name = "Halqa",
                Author = "Akrom Malik",
                DateTimee = 2000,
                Description = "Hayotiy voqea",
                Pages = 350,
                Where = "Urumchi, China",
            };


            var thirdBookExample = new Books()
            {
                Id = Guid.NewGuid(),
                Name = "Iskanja",
                Author = "Amina Shenlikuglu",
                DateTimee = 2015,
                Description = "Hayotiy qissa",
                Pages = 374,
                Where = "Turkiya",
            };


            ListedBooks.Add(firstBookExample);
            ListedBooks.Add(secondBookExample);
            ListedBooks.Add(thirdBookExample);

        }




    }
}
