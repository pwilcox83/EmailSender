using System.Reflection;
using Mapster;

namespace EmailDispatcherApi.Configuration
{
    public class MapsterRegistrations : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            config.AdaptTo("[name]Dto")
                .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "Infrastructure.Models");

            config.GenerateMapper("[name]Mapper")
                .ForType<Course>()
                .ForType<Student>();
        }
    }
}

//https://github.com/MapsterMapper/Mapster/wiki/Fluent-API-Code-generation