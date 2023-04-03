﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarimiApp.Model;

namespace KarimiApp.Interface.Server
{
   public interface IPerson:IMain<PersonModel>
    {
        string Settle(PersonModel person);
    }
}
