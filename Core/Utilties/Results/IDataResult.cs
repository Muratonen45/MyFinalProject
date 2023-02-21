using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilties.Results
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
