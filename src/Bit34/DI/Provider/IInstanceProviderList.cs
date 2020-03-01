using System;

namespace Bit34.DI.Provider
{
    public interface IInstanceProviderList
    {
        //  METHODS
        IInstanceProvider AddValueProvider(Type targetType, object value);
        IInstanceProvider AddTypedProvider<T>(Type targetType) where T : new();
    }
}
