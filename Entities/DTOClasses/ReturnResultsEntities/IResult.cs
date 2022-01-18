using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOClasses.ReturnResults
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
