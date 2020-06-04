using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestAJAXMVC5.Models;

namespace RegistrationApplication.Models.Data
{
    /// <summary>
    /// Класс связи с БД
    /// </summary>
    public class DBCont : DbContext
    {

        public DBCont()
        : base("DB")
        { }

        /// <summary>
        /// Связь с таблицей книг
        /// </summary>
        public DbSet<Book> Books { get; set; }

    }
}