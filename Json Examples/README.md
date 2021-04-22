
# **Example JSON Payloads**

## Customers
`POST` ***/api/v3/Customers*** [Request](Customer/NewCustomerT.json) [Response](Customer/SynkSaveQueueResponseOfCustomerT.json)

`GET` ***/api/v3/Customers/{id}*** [Response](Customer/GetCustomerT.json)

`PUT` ***/api/v3/Customers?id={id}*** [Request](Customer/NewCustomerT.json) [Response](Customer/SynkSaveQueueResponseOfCustomerT.json)

## Inventory
`POST` ***/api/Inventory*** [Request](Inventory/NewInventoryItemT.json) [Response](Inventory/SynkSaveQueueResponse.json)

`GET`  ***/api/Inventory/{id}*** [Response](Inventory/InventoryEditResponse.json)

`PUT`  ***/api/Inventory/{id}*** [Request](Inventory/UpdateInventoryItemT.json) [Response](Inventory/SynkSaveQueueResponse.json)

## Invoice
`POST` ***/api/Invoice*** [Request](Invoice/NewInvoiceT.json) [Response](Invoice/SynkSaveQueueResponse.json)

`GET`  ***/api/Invoice/{id}*** [Response](Invoice/TransactionEditResponseOfInvoiceT.json)

## Payment
`POST` ***/api/Payment*** [Request](Payment/NewPaymentT.json) [Response](Payment/SynkSaveQueueResponseOfPaymentT.json)

`GET`  ***/api/Payment/{id}*** [Response](Payment/EditResponseOfPaymentT.json)

[[Back to README]](../README.md)
