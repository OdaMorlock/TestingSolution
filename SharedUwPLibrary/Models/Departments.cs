﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedUwPLibrary.Models
{
    public class Departments : ObservableCollection<string>
    {

        public Departments()
        {
            Add("Administration");
            Add("Development");
            Add("Education");
        }

    }
}
