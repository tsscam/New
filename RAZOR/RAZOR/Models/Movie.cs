using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAZOR.Models
{
    public class Movie
    {

        private string title;
        private string category;
        private string director;

        public Movie():this("","","")
        {

        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public string Director
        {
            get
            {
                return director;
            }

            set
            {
                director = value;
            }
        }

        public Movie(string titleInput, string categoryInput, string directorInput)
        {
            title = titleInput;
            category = categoryInput;
            director = directorInput;
        }

     }
}