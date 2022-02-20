# Setup
Created a ASP.NET Core API with .NET 6 Framework.
Created the application Core and Infrastructure Layer (Class Library ) 
Created 3 folders with in the Application Core 
	Contracts folder (Includes Repositories folder which has the IRepository)
		Includes Service folder which has the IService
	Entities folder
		Includes the classes that matches the database data
	Models
		Includes the response model 
Created 3 folders with in the Infrastructure
	Data
		db connection to the database using EF Core
	Repository
		Implementation (inherit) the Application Core IRepository (interface)
	Services
		Implementation (inherit) the Application Core IService (interface)
## Setup db connection
	TitleDbContext derive the DbContext class
		Inject the connection strying in the program.cs
		Construction injection to inject the connection string
		Connection string is set in the appsettings.json
		DbSet represent the tables in the database

### Talking to the database
	In the Infrastructure layer
	Go to program.cs and:

	```csharp
	//Service
	builder.Services.AddScoped<IService, Service>();
	//Repository
	builder.Services.AddScoped<IRepository, Repository>();
	```
	Use constructure in  Repository.cs
	Write LINQ query to get the corresponding data from the database

	Inject Repository into Service.cs
	Store the data into right data model

	After the completion of the Application Core Layer and Infrastructure Layer
	We can start woking on the APIs

#### Created TitleController for creating necesscary APIs
	By injecting Service (constructor injection)

##### Enable CROS in program.cs

	


		
		