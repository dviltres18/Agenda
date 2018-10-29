using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Agenda.Authorization;

namespace Agenda
{
    [DependsOn(
        typeof(AgendaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AgendaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AgendaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AgendaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
