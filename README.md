# ZemogaBlog-Api
This repo it's about the API in charge of retrevie the data toward front-End 

Prerequsites:
-Visual Studio 2019 o Visual Studio Code
-Net Core 3.1 Installed
-SQL Server

To start using the Web API, be sure to configure de database connection.

- In project ZemogaPost.API,  find appsettings.json and open it.
  Edit ConnectionString in the DefaultConection, Sever Option set the name of your local server
 "ConnectionStrings": {
    "DefaultConnection": "Server=DESKTOP-HR9EAJN;Database=ZemogaBlog;Trusted_Connection=True;"
  },
  
 - Repeat de Above step in Infraestructure project, find context folder, in the BlogDbContext File in OnConfiguring metod
 
 optionsBuilder.UseSqlServer("Server=DESKTOP-HR9EAJN;Database=ZemogaBlog;Trusted_Connection=True;");
 
 Edit Sever Option set the name of your local server
 
 -Run the Application and be sure that the database ZemogaBlog was create in your local server
