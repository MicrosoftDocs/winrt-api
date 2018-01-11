---
-api-id: T:Windows.Services.Store.StoreConsumableStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Store.StoreConsumableStatus : int
-->

# StoreConsumableStatus

## -description
Defines values that represent the status of an request that is related to a consumable add-on.

## -enum-fields
### -field Succeeded:0
The request succeeded.

### -field InsufficentQuantity:1
The request did not succeed because the remaining balance of the consumable add-on is too low.

### -field NetworkError:2
The request did not succeed because of a network connectivity error.

### -field ServerError:3
The request did not succeed because of a server error returned by the Microsoft Store.

## -remarks
The [StoreConsumableResult.Status](storeconsumableresult_status.md) property returns [StoreConsumableStatus](storeconsumablestatus.md) values.

## -examples

## -see-also
