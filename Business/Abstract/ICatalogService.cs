﻿using Entities.DBClasses;
using Entities.DTOClasses.ReturnResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICatalogService
    {
        Task<IDataResult<List<Catalog>>> GetAll();
        Task<IDataResult<Catalog>> GetById(int catalogId);
        Task<IResult> Delete(Catalog catalog);
        Task<IResult> Update(Catalog catalog);
        Task<IResult> Add(Catalog catalog);
    }
}