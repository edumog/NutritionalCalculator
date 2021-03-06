﻿using NutritionalCalculator.Model.Entities.Db;
using System;
using System.Collections.Generic;
using System.Text;

namespace NutritionalCalculator.Model.Repositories
{
    public interface IFoodsRepository : IModelRepository<Foods>
    {
        Foods GetByName(string name);
        Foods GetById(string id);
    }
}
