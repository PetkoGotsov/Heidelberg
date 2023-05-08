The project is a .NET CORE 6.0 WebAPI, consisting of a single controller with a swagger UI interface.
The Get method provides capability to query weather forecast for a specifiic city.
Made use of a third-party library https://github.com/swiftyspiffy/OpenWeatherMap-API-CSharp to avoid manually creating the complex model classes. 
This library creates the QueryResponse model as per the definiton of the documentation, and uses an HttpClient to query the https://api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key} endpoint using the provided free subscription api key in appsettings. 
The tests use mocking of the controller and assert that it works correctly with existing input and throws an error for non existing cities. 
The application is published to a free Azure subscription and connected to an API Management resource, which acts as a proxy for the incoming requests and can be used for monitoring and applying poliicies.
