# CSharp(c#) Wrapper for OpenFoodFacts

##### DotNet (C#) wrapper for https://world.openfoodfacts.org
 

## Usage

Add one dependency to your cs file:
```c#
//Console App
IOpenFoodFactsApiClient obj = new OpenFoodFactsApiClient();

//Dependency Injection
service.AddScoped<IOpenFoodFactsApiClient,OpenFoodFactsApiClient>();

//Or

service.AddScoped<IOpenFoodFactsApiClient>(x=>
{
	return new OpenFoodFactsApiClient("URL");
});
```

Create wrapper object and find product by its barcode:
```c#
//Console App
IOpenFoodFactsApiClient obj = new OpenFoodFactsApiClient();
await obj.FetchProductByCode("1234");

//Dependency Injection
public class Something
{
	private readonly IOpenFoodFactsApiClient _client;
	public Something(IOpenFoodFactsApiClient client)
	{
		_client = client;
	}
	
	public async Task FetchProduct()
	{
		_client.FetchProductByCode("1234");
	}
}
```


## Third party applications
Feel free to open a PR to add your application in this list.

## Authors