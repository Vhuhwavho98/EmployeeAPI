﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Applications.Mappings
{
    public interface IMapForm<T>
    {
        void Mapping(Profile profile);
    }
}
