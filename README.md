# linkar-rest-api-dotnet
LINKAR REST API with .NET
In this example, a way to consume the Linkar REST API services from .NET can be seen, it is compatible to compile in the .NET Framework, .NET CORE and MONO.
It is a console application that performs a READ operation against the API and displays the result of the query on the screen.
The HttpClient class is used for consultation; the official documentation <a href = "https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient ? view = netframework-4.8 "target =" blank "> here </a> can be consulted for other information and examples 
This code is used for both XML and JSON calls, it is simply necessary to comment and uncomment the block that interests us, as can be seen in the code.
The variation between both formats is as follows:

- XML:
	HttpContent httpContent = new StringContent("<LkCommand>...</LkCommand>", Encoding.UTF8, "text/xml");
	
- JSON:
	HttpContent httpContent = new StringContent("{ ... }", Encoding.UTF8, "application/json");
