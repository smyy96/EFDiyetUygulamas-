﻿using System;
using EFDiyet.DAL.Context.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyet.DAL.Repository.Concrete
{
    public class CategoryRepository: Repository<Category>
    {
        public CategoryRepository(DietDbContext db):base(db) { }
    }
}