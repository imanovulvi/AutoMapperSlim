using Mapping.Common.Abstraction;

namespace Mapping.Common.Concret;

public class AutoMapperSlim: IAutoMapperSlim
{
    public TResult Map<TResult, TMapping>(TMapping mapping) where TResult : new()
    {
        TResult result = new TResult();
        Type _TMapping = typeof(TMapping);
        Type _TResult = typeof(TMapping);

        foreach (var _mapping in _TMapping.GetProperties())
        {

            typeof(TResult)?.GetProperty(_mapping.Name)?.SetValue(result, _mapping.GetValue(mapping));
        }

        return result;
    }


    public ICollection<TResult> Map<TResult, TMapping>(ICollection<TMapping> mappings) where TResult : new()
    {
        List<TResult> result = new List<TResult>();

        foreach (var item in mappings)
        {
            result.Add(Map<TResult, TMapping>(item));
        }

        return result;
    }




}
