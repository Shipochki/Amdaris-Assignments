namespace Amdaris.Logging.Extensions
{
	using Amdaris.Logging.Abstractions;
	using Amdaris.Logging.Targets;
	using Microsoft.Extensions.DependencyInjection;

	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddAmdarisLogging(this IServiceCollection services)
		{
			services.AddScoped<IFilenameManager, FilenameManager>();
			services.AddScoped<AmdarisLogger>();

			return services;
		}
	}
}
