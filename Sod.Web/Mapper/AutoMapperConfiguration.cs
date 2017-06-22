using AutoMapper;
using Sod.Domain;
using Sod.Domain.QueryModel;
using Sod.Web.Models;

namespace Sod.Web.Mapper
{
    public static class AutoMapperConfiguration
    {
        public static void Init()
        {
            MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Person, PersonViewModel>()
                .ForMember(d => d.Active, o => o.MapFrom(s => s.Active ? "是" : "否"))
                .ForMember(d => d.ModifiedOn, o => o.MapFrom(s => s.ModifiedOn == null ? null : s.ModifiedOn.ToString()));

                cfg.CreateMap<PersonViewModel, Person>();

                #region Address
                cfg.CreateMap<AddressWithPersonName, AddressViewModel>()
                    .ForMember(d => d.FullName, o => o.MapFrom(s => string.Format("{0} {1}", s.FirstName, s.LastName)));
                #endregion

            });

            Mapper = MapperConfiguration.CreateMapper();
        }

        public static IMapper Mapper { get; private set; }

        public static MapperConfiguration MapperConfiguration { get; private set; }
    }
}