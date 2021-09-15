using System.ComponentModel.Composition;
using Core.Common.Contracts;
using Core.Common.Core;

namespace CarRental.Business
{
    [Export(typeof(IBusinessEngineFactory))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class BusinessEngineFactory : IBusinessEngineFactory
    {
        T IBusinessEngineFactory.GetBusinessEngine<T>()
        {
            return ObjectBase.Container.GetExportedValue<T>();
        }
    }
}
