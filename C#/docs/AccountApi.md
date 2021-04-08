# IO.Swagger.Api.AccountApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorisationLogin**](AccountApi.md#authorisationlogin) | **POST** /api/login | Authorisation - Login

<a name="authorisationlogin"></a>
# **AuthorisationLogin**
> void AuthorisationLogin (string contentType,  body)

Authorisation - Login

Authorisation - Login

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthorisationLoginExample
    {
        public void main()
        {

            var apiInstance = new AccountApi();
            var contentType = contentType_example;  // string | 
            var body = new (); //  | Ensure the values inserted for the _username_ and _password_ have been properly HTML encoded. 

For more information about HTML encoding see [here](https://www.w3schools.com/tags/ref_urlencode.asp)

Simple encoding example: 

jim.citizen+spenda@email.net encoded =>  jim.citizen%2Bspenda%40email.net 

 '+' symbol becomes '%2B' 

 '@' symbol becomes '%40' (optional) 

            try
            {
                // Authorisation - Login
                apiInstance.AuthorisationLogin(contentType, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AuthorisationLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contentType** | **string**|  | 
 **body** | [****](.md)| Ensure the values inserted for the _username_ and _password_ have been properly HTML encoded. 

For more information about HTML encoding see [here](https://www.w3schools.com/tags/ref_urlencode.asp)

Simple encoding example: 

jim.citizen+spenda@email.net encoded &#x3D;&gt;  jim.citizen%2Bspenda%40email.net 

 &#x27;+&#x27; symbol becomes &#x27;%2B&#x27; 

 &#x27;@&#x27; symbol becomes &#x27;%40&#x27; | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

