﻿using AutoInspection.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInspection.Core
{
    class Inspector1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
      

        public Inspector1 CreateFromPerson(Inspector inspector)
        {
            Id = inspector.Id;
            Name = inspector.Name;
            Surname = inspector.Surname;
            Patronymic = inspector.Patronymic;
            Login = inspector.Login;
            Password = inspector.Password;         
            return this;
        }

    }
}
