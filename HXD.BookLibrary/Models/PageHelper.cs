using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HXD.BookLibrary.Models
{
    public class PageHelper
    {
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int RecordCount { get; set; }
    }
}