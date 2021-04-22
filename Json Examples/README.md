
# Example JSON Payloads

## Customers 
<br/> POST /api/v3/Customers [New Customer Request](Customer/NewCustomerT.json) [New Customer Response](Customer/SynkSaveQueueResponseOfCustomerT.json)
<br/> GET  /api/v3/Customers/{id} [Customer Response](Customer/GetCustomerT.json)
<br/> PUT  /api/v3/Customers?id={id} [Update Customer Request](Customer/NewCustomerT.json) [Update Customer Response](Customer/SynkSaveQueueResponseOfCustomerT.json)

## Inventory
<br/> POST /api/Inventory [New Inventory Request](Inventory/NewInventoryItemT.json) [New Inventory Response](Inventory/SynkSaveQueueResponseOfCustomerT.json)
<br/> GET  /api/Inventory/{id} [Inventory Response](Inventory/NewCustomerT.json)
<br/> PUT  /api/Inventory/{id} [Update Inventory Request](Inventory/NewInventoryItemT.json) [Update Inventory Response](Inventory/SynkSaveQueueResponseOfCustomerT.json)

## Invoice
<br/> POST /api/Invoice [New Invoice](Invoice/NewInvoiceT.json)
<br/> GET  /api/Invoice/{id} [Invoice Response](Invoice/NewCustomerT.json)

## Payment
<br/> POST /api/Payment [New Payment Request](Payment/NewPaymentT.json)
<br/> GET  /api/Payment/{id} [Payment Response](Payment/NewCustomerT.json)
