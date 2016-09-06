# AspNetCoreNotAcceptable

The [AspNetCoreNotAcceptable package](https://www.nuget.org/packages/AspNetCoreNotAcceptable/) is an ASP.NET Core solution which requires all http requests to have the 'Accept' header set to 'application/json'.

[![NuGet](https://img.shields.io/nuget/v/AspNetCoreNotAcceptable.svg?maxAge=259200)](https://www.nuget.org/packages/AspNetCoreNotAcceptable/) 

**NuGet install:**

Install-Package AspNetCoreNotAcceptable

**Startup.cs code:**

    public void ConfigureServices(IServiceCollection services)
    {
		services.AddMvc()
				.AddMvcOptions(options =>
				{
					options.Filters.Add(typeof(NotAcceptableResultFilter));
					options.Filters.Add(typeof(ValidateNotAcceptableFilterAttribute));
				});
	}