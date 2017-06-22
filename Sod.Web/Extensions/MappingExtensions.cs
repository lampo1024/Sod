using Sod.Domain;
using Sod.Domain.QueryModel;
using Sod.Web.Mapper;
using Sod.Web.Models;

namespace Sod.Web.Extensions
{
    public static class MappingExtensions
    {
        public static TDestination MapTo<TSource, TDestination>(this TSource source)
        {
            return AutoMapperConfiguration.Mapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination)
        {
            return AutoMapperConfiguration.Mapper.Map(source, destination);
        }

        #region Person
        public static PersonViewModel ToViewModel(this Person entity)
        {
            return entity.MapTo<Person, PersonViewModel>();
        }

        public static Person ToEntity(this PersonViewModel model)
        {
            return model.MapTo<PersonViewModel, Person>();
        }
        #endregion

        #region Address
        public static AddressViewModel ToViewModel(this AddressWithPersonName entity)
        {
            return entity.MapTo<AddressWithPersonName, AddressViewModel>();
        }
        #endregion
    }
} 