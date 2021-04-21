
# Example JSON Payloads

## Customers 
<br/> POST /api/v3/Customers [New Customer Request](Customer/NewCustomerT.json) [New Customer Response](Customer/SynkSaveQueueResponseOfCustomerT.json)
<br/> GET  /api/v3/Customers/{Id} [Customer Response](Customer/GetCustomerT.json)
<br/> PUT  /api/v3/Customers?id={id} [Update Customer](Customer/NewCustomerT.json)

## Inventory
<br/> POST /api/Inventory [New Inventory](Inventory/NewInventoryItemT.json)
<br/> GET  /api/Inventory [Inventory Response](Inventory/NewCustomerT.json)
<br/> PUT  /api/Inventory/{id} [Update Inventory](Inventory/NewInventoryItemT.json)

## Invoice
<br/> POST /api/Invoice [New Invoice](Invoice/NewInvoiceT.json)
<br/> GET  /api/Invoice [Invoice Response](Invoice/NewCustomerT.json)

## Payment
<br/> POST /api/Payment [New Payment](Payment/NewPaymentT.json)
<br/> GET  /api/Payment [Payment Response](Payment/NewCustomerT.json)
