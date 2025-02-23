WEB repository: https://github.com/mikhaylov1gor/React-Todo-List

!!! Before running the project, make sure the API is running on the correct port. To change the port for WEB interaction: !!!

1. Open the file `Program.cs`.
2. Find the following code snippet that configures CORS:

   ```csharp
   builder.Services.AddCors(options =>
   {
       options.AddPolicy(name: MyAllowSpecificOrigins,
           policy =>
           {
               policy.WithOrigins("http://localhost:5174") // Change this URL to match the port of your web app
                     .AllowAnyMethod()
                     .AllowAnyHeader();
           });
   });

Running Locally

1. Clone the repository:

 		git clone https://github.com/mikhaylov1gor/Api-Todo-List
   
2. Restore project dependencies:

	 	dotnet restore

3. Build the project:

		dotnet build

4. Apply db migrations:

		dotnet ef database update

	or (visual studio)

		Update-Database

5. Run the project:

		dotnet run
