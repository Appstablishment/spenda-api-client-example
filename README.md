# Spenda SDK Documentation
SDK - Software Development Kit

Developer Portal: https://spenda-api-dev.synkd.net/

GitHub Repository: https://github.com/Appstablishment/spenda-api-client-example 

APIs: https://spenda-api.synkd.net/

[About Us](/aboutus.md "About Us") 

---
## Accessing Developer Portal

When accessing the Developer portal for the first time, developers must sign up first and subscribe in order to be able to list, view, and use all available API methods.

Steps:
1. Sign up ⇒ [Spenda API Developer Portal](https://spenda-api-dev.synkd.net/signup "Spenda API Developer Portal") 
2. Subscribe ⇒ [Spenda API - Product Subscription](https://spenda-api.developer.azure-api.net/products "Spenda API - Product Subscription")
3. Explore Spenda API ⇒ [Spenda APIs](https://spenda-api.developer.azure-api.net/apis "Spenda APIs")    

---
## Using the Developer Portal

Before using the Developer Portal to try out or make requests to the API methods, developers must register in our transactional platform so they can log in to the API and get an Authorization token to be allowed to make requests. 

<br />

## Synk’d Registration

Please go to the following [Registration Link](https://preprodasweb.azurewebsites.net/public/login?redirect=%2Ftransaction-queue "Registration Link") and click the registration link in order to create an account.

When registering you can either choose to be an Individual User or a Company, fill the rest of the fields in the form and click register. An example is shown below

![Synk'd Registration](Images/Synkd.PNG?style=centerme "Synk'd Registration")

<br />

## API Authentication

Developers must Authenticate in the API by using the Autorisation - Login API Method. If the Authentication process is valid, the API will return a JSON response containing the Company or person details and the access token that will be needed to make other requests such as Create Customers, Get Customers or push Inventory items into Spenda.

Please find below an example of how to Authenticate using the Autorisation - Login API Method.

<br />

## Login Example

1. Click in try it green button which is on the right.
![Synk'd Registration](Images/Try_1.png?style=centerme "Synk'd Registration")
<br />

2. When clicked, a new panel that contains the request’s  URL, parameters,  header and body will appear.

![Synk'd Registration](Images/Parameters_2.png?style=centerme "Synk'd Registration")
<br />

3. In the body text area, developers must add their details as it is shown in the LoginBodyText tab.

![Synk'd Registration](Images/BodyExample_3.png?style=centerme "Synk'd Registration")
<br />

    **Remember to follow the Encoding rules:**

    - When adding a '+' symbol this must be replaced by '%2B'

    - When adding a '@' symbol this must be replaced by  '%40'

    **Example:**

    `jim.citizen+spenda@email.net encoded => jim.citizen%2Bspenda%40email.net`

4. When adding all information needed, please click en send to test the request. If the authentication details are valid then the response will return a 200 HTTP response along with the token and the expiry date.  As is shown below.

![Synk'd Registration](Images/HttpResponse_4.png?style=centerme "Synk'd Registration")
<br />

5. Having a successful response from this method, we can store the token given and use it in another API method.

---
## Operations

| **Operation Name** | **Methods**        |
| -----------------  |:------------------:|
| Customer           | [`POST`](Json%20Examples/Customer/NewCustomerT.json "POST Request Example")  [`GET`](Json%20Examples/Customer/SynkSaveQueueResponseOfCustomerT.json "GET Response Example")  [`PUT`](Json%20Examples/Customer/NewCustomerT.json "POST Request Example")  |
| Inventory          | [`POST`](Json%20Examples/Inventory/NewInventoryItemT.json "POST Request Example") |
| Invoices           | `POST` `GET` `PUT` |
| Payment            | `POST` `GET` `PUT` |                     

<br />

## Resources

| **Resource Type**  | **Resource URL**        |
| -----------------  |:------------------------|
| Developer Portal           | https://spenda-api-dev.synkd.net/   |
| GitHub Repository          | https://github.com/Appstablishment/spenda-api-client-example  |
| GitHub Repository - C# Code Example  | https://github.com/Appstablishment/spenda-api-client-example/tree/Master/C%23 |
| Json Examples            | https://github.com/Appstablishment/spenda-api-client-example/blob/Master/Json%20Examples/README.md  |
| APIs            | https://spenda-api.synkd.net/ |
| Online Swagger Editor            | https://editor.swagger.io/ |
| NSwag           | https://github.com/RicoSuter/NSwag  |
| Open API - generator           | https://github.com/OpenAPITools/openapi-generator  |



<p align="center">
  <img width="460" height="300" src="http://www.fillmurray.com/460/300">
</p>

<style>
img[src$="centerme"] {
  display:block;
  margin: 0 auto;
}
</style>
