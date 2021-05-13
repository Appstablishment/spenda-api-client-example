# IO.Swagger.Api.RegistrationApi

All URIs are relative to *https://spenda-api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RegistrationConfirmEmailAddress**](RegistrationApi.md#registrationconfirmemailaddress) | **POST** /api/Registration/ConfirmEmailAddress | Registration_ConfirmEmailAddress
[**RegistrationFindInvite**](RegistrationApi.md#registrationfindinvite) | **POST** /api/Registration/FindInvite | Registration_FindInvite
[**RegistrationGet**](RegistrationApi.md#registrationget) | **POST** /api/Registration/Get | Registration_Get
[**RegistrationGetTimeZones**](RegistrationApi.md#registrationgettimezones) | **GET** /api/Registration/GetTimeZones | Registration_GetTimeZones
[**RegistrationSave**](RegistrationApi.md#registrationsave) | **POST** /api/Registration/Save | Registration_Save

<a name="registrationconfirmemailaddress"></a>
# **RegistrationConfirmEmailAddress**
> ApiRegistrationConfirmEmailAddressPost200ApplicationJsonResponse RegistrationConfirmEmailAddress (EmailAddressConfirmationRequest body)

Registration_ConfirmEmailAddress

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegistrationConfirmEmailAddressExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new RegistrationApi();
            var body = new EmailAddressConfirmationRequest(); // EmailAddressConfirmationRequest |  (optional) 

            try
            {
                // Registration_ConfirmEmailAddress
                ApiRegistrationConfirmEmailAddressPost200ApplicationJsonResponse result = apiInstance.RegistrationConfirmEmailAddress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.RegistrationConfirmEmailAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmailAddressConfirmationRequest**](EmailAddressConfirmationRequest.md)|  | [optional] 

### Return type

[**ApiRegistrationConfirmEmailAddressPost200ApplicationJsonResponse**](ApiRegistrationConfirmEmailAddressPost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationfindinvite"></a>
# **RegistrationFindInvite**
> ApiRegistrationFindInvitePost200ApplicationJsonResponse RegistrationFindInvite (FindByTokenRequest body)

Registration_FindInvite

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegistrationFindInviteExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new RegistrationApi();
            var body = new FindByTokenRequest(); // FindByTokenRequest |  (optional) 

            try
            {
                // Registration_FindInvite
                ApiRegistrationFindInvitePost200ApplicationJsonResponse result = apiInstance.RegistrationFindInvite(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.RegistrationFindInvite: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FindByTokenRequest**](FindByTokenRequest.md)|  | [optional] 

### Return type

[**ApiRegistrationFindInvitePost200ApplicationJsonResponse**](ApiRegistrationFindInvitePost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationget"></a>
# **RegistrationGet**
> ApiRegistrationGetPost200ApplicationJsonResponse RegistrationGet (RegistrationRequest body)

Registration_Get

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegistrationGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new RegistrationApi();
            var body = new RegistrationRequest(); // RegistrationRequest |  (optional) 

            try
            {
                // Registration_Get
                ApiRegistrationGetPost200ApplicationJsonResponse result = apiInstance.RegistrationGet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.RegistrationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegistrationRequest**](RegistrationRequest.md)|  | [optional] 

### Return type

[**ApiRegistrationGetPost200ApplicationJsonResponse**](ApiRegistrationGetPost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationgettimezones"></a>
# **RegistrationGetTimeZones**
> ApiRegistrationGetTimeZonesGet200ApplicationJsonResponse RegistrationGetTimeZones ()

Registration_GetTimeZones

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegistrationGetTimeZonesExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new RegistrationApi();

            try
            {
                // Registration_GetTimeZones
                ApiRegistrationGetTimeZonesGet200ApplicationJsonResponse result = apiInstance.RegistrationGetTimeZones();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.RegistrationGetTimeZones: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ApiRegistrationGetTimeZonesGet200ApplicationJsonResponse**](ApiRegistrationGetTimeZonesGet200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationsave"></a>
# **RegistrationSave**
> ApiRegistrationSavePost200ApplicationJsonResponse RegistrationSave (RegistrationDetails body)

Registration_Save

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RegistrationSaveExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyHeader
            Configuration.Default.ApiKey.Add("Ocp-Apim-Subscription-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Ocp-Apim-Subscription-Key", "Bearer");
            // Configure API key authorization: apiKeyQuery
            Configuration.Default.ApiKey.Add("subscription-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("subscription-key", "Bearer");

            var apiInstance = new RegistrationApi();
            var body = new RegistrationDetails(); // RegistrationDetails |  (optional) 

            try
            {
                // Registration_Save
                ApiRegistrationSavePost200ApplicationJsonResponse result = apiInstance.RegistrationSave(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegistrationApi.RegistrationSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegistrationDetails**](RegistrationDetails.md)|  | [optional] 

### Return type

[**ApiRegistrationSavePost200ApplicationJsonResponse**](ApiRegistrationSavePost200ApplicationJsonResponse.md)

### Authorization

[apiKeyHeader](../README.md#apiKeyHeader), [apiKeyQuery](../README.md#apiKeyQuery)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

