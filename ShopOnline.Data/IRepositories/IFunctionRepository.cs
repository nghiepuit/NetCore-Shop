﻿using ShopOnline.Data.Entities;
using ShopOnline.Infrastructure.Interfaces;

namespace ShopOnline.Data.IRepositories
{
    public interface IFunctionRepository : IRepository<Function, string>
    {
    }
}