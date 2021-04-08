# IO.Swagger.Api.RegistrationApi

All URIs are relative to *https://api.synkd.net*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RegistrationConfirmEmailAddress**](RegistrationApi.md#registrationconfirmemailaddress) | **POST** /api/Registration/ConfirmEmailAddress | 
[**RegistrationFindInvite**](RegistrationApi.md#registrationfindinvite) | **POST** /api/Registration/FindInvite | 
[**RegistrationGet**](RegistrationApi.md#registrationget) | **POST** /api/Registration/Get | 
[**RegistrationGetTimeZones**](RegistrationApi.md#registrationgettimezones) | **GET** /api/Registration/GetTimeZones | 
[**RegistrationSave**](RegistrationApi.md#registrationsave) | **POST** /api/Registration/Save | 

<a name="registrationconfirmemailaddress"></a>
# **RegistrationConfirmEmailAddress**
> Object RegistrationConfirmEmailAddress (EmailAddressConfirmationRequest body)



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

            var apiInstance = new RegistrationApi();
            var body = new EmailAddressConfirmationRequest(); // EmailAddressConfirmationRequest | 

            try
            {
                Object result = apiInstance.RegistrationConfirmEmailAddress(body);
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
 **body** | [**EmailAddressConfirmationRequest**](EmailAddressConfirmationRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationfindinvite"></a>
# **RegistrationFindInvite**
> Object RegistrationFindInvite (FindByTokenRequest body)



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

            var apiInstance = new RegistrationApi();
            var body = new FindByTokenRequest(); // FindByTokenRequest | 

            try
            {
                Object result = apiInstance.RegistrationFindInvite(body);
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
 **body** | [**FindByTokenRequest**](FindByTokenRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationget"></a>
# **RegistrationGet**
> Object RegistrationGet (RegistrationRequest body)



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

            var apiInstance = new RegistrationApi();
            var body = new RegistrationRequest(); // RegistrationRequest | 

            try
            {
                Object result = apiInstance.RegistrationGet(body);
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
 **body** | [**RegistrationRequest**](RegistrationRequest.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationgettimezones"></a>
# **RegistrationGetTimeZones**
> Object RegistrationGetTimeZones ()



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

            var apiInstance = new RegistrationApi();

            try
            {
                Object result = apiInstance.RegistrationGetTimeZones();
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

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registrationsave"></a>
# **RegistrationSave**
> Object RegistrationSave (RegistrationDetails body)



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

            var apiInstance = new RegistrationApi();
            var body = new RegistrationDetails(); // RegistrationDetails | 

            try
            {
                Object result = apiInstance.RegistrationSave(body);
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
 **body** | [**RegistrationDetails**](RegistrationDetails.md)|  | 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

