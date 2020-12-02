# ZemogaBlog-Api
This repo it's about the API in charge of retrevie the data toward front-End 


This project was created using the clean architecture approach, entity framework code firts application and trying to use the least amount of code possible.


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
 
 - Open Package Manager Console and run the following command:  update-database  to create the database from DbConext
 
 
 -Run the Application and be sure that the database ZemogaBlog was create in your local server
 
 - EndPonits example:
 https://localhost:44327/api/BlogPost/GetAllPost
 https://localhost:44327/api/Comment/GetAllComments
 
 You can change it for each method found in the controllers
 
 -time spent developing this website and functionality : 14 hours
