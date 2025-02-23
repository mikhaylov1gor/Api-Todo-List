WEB repository: https://github.com/mikhaylov1gor/React-Todo-List

!!! Before running the project, make sure the API is running on the correct port. To change the port for API interaction: !!!

1. Open the file `src/API/api.ts` 
2. Find the line where the API URL is defined, for example:

   ```typescript
   const url = "http://localhost:5207/api/Task";'; // Replace with the port your API is running on

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
