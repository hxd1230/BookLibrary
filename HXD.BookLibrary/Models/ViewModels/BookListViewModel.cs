using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HXD.BookLibrary.Models.ViewModels
{
    public class BookListViewModel
    {
        public PageHelper PageHelper { get; set; }
        public List<Book> Books { get; set; }
    }
}