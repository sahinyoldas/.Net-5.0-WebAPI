using Entities.DTOClasses.ReturnResultsEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOClasses.ReturnResultsEntities
{
    public class ErrorDataResult<T> : DataResult<T>, IDataResult<T>
    {

        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }

        public ErrorDataResult(T data) : base(data, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message) // default demek dielim T nin tipi integer ise onun defaultunu doner genelde kullanilmaz
        {

        }

        public ErrorDataResult() : base(default, true)
        {

        }
    }
}
