using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping.Common.Abstraction
{
    public interface IAutoMapperSlim
    {
        TResult Map<TResult, TMapping>(TMapping mapping) where TResult : new();
        ICollection<TResult> Map<TResult, TMapping>(ICollection<TMapping> mappings) where TResult : new();
    }
}
