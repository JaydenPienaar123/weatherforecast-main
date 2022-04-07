
Weather API

<!-- ABOUT THE PROJECT -->
## About The Project

This project required the developer to build a REST API using ASP.NET with C#. This API would be used to retrieve the weather based on a city name.


### Built With

The following languages and frameworks were used to complete the project

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.Net core](https://dotnet.microsoft.com/en-us/download/)

Along with the following Nuget packages

* Newtonsoft.Json (13.0.1)
* Swashbuckle.AspNetCore (5.6.3)


<!-- GETTING STARTED -->
## Getting Started

Get the project up and running with these steps

### Prerequisites

This project will require

* [.Net Core 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

### Installation

1. Install [.Net Core 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0/)
2. Clone the code from this repository

   ```sh
   git clone https://github.com/JaydenPienaar123/weatherforecast-main.git
   ```

<!-- USAGE EXAMPLES -->
### Through a terminal

The project can be run by
1. Opening a terminal and navigating to your local repository directory, for example if you had cloned the repository into c:/source/projects/weatherforecast-main
  the command would be:
  
   ```sh
   cd c:/source/projects/weatherforecast-main
   ```
2. Executing the 'dotnet run' command:

   ```sh
   dotnet run
   ```

The API can be utilized through a swagger page on https://localhost:5001/swagger/index.html

<!-- IMPROVEMENTS -->
## Improvements

Given more time, this project and API could be enhanced with some of the following options:
1) Security: For the current API call and functionality no security was required, however implementing this API in a production environment I would
   advise the use of some security measures such as Security protocol and Authentication such as a password and username.
2) Scalability: The current project wouldnt need any vertical scaling, however could scale horizontally by running the project on multiple instances using a Load balancer.
3) User Experience: The API could further have a view and frontend added to the controller to allow for an improved user experience depening on the application of the 
   project in a production environment.
4) Improved use of logging.
5) The use of Unit tests.
6) Integration testing to test integrations with 3rd party API's.