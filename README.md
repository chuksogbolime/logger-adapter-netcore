# logger-adapter-netcore
An adapter library for .net core to enable unit testing

# Installation

Package Manager: Install-Package NetCoreLoggerAdapter -Version 1.0.0

DotNet CLI: dotnet add package NetCoreLoggerAdapter --version 1.0.0

Package reference : <PackageReference Include="NetCoreLoggerAdapter" Version="1.0.0" />

Paket CLI: paket add NetCoreLoggerAdapter --version 1.0.0

# Usage

1. Register in startup class

    NetCoreLoggerAdapter.DependencyConfiguration.ConfigureLogAdapter(services);
		
    //where services is of type IServiceCollection
		
2. Class usage
		
		public class LogUsecase
		{
			readonly ILoggerServiceAdapter<LogUsecase> _logger;
			public LogUsecase(ILoggerServiceAdapter<LogUsecase> logger)
			{
        _logger=logger;
			}
			public void Testmethod()
			{
				try
        {
          _logger.LogInformation("information");
        }
        catch(Exception ex)
        {
          _logger.LogError(ex,"Error message");
        }
			}
		}
    
 3 In Test project
 
    [Fact]
    public void Test()
    {
      //use a mock framework e.g Moq
      loggerMock.Verify(x => x.LogError(It.IsAny<Exception>(), It.IsAny<string>()),Times.Once);
    }
 
 
 
 
 
