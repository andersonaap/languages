
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(Infraestrutura.IoC.App_Start.StructuremapMvc), "Start")]
[assembly: ApplicationShutdownMethod(typeof(Infraestrutura.IoC.App_Start.StructuremapMvc), "End")]
