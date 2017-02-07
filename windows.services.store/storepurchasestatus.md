---
-api-id: T:Windows.Services.Store.StorePurchaseStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Store.StorePurchaseStatus : int
-->

# StorePurchaseStatus

## -description
Defines values that represent the status of a request to purchase an app or add-on.

## -enum-fields
### -field Succeeded:0
The purchase request succeeded.

### -field AlreadyPurchased:1
The current user has already purchased the specified app or add-on.

### -field NotPurchased:2
The purchase request did not succeed.

### -field NetworkError:3
The purchase request did not succeed because of a network connectivity error.

### -field ServerError:4
The purchase request did not succeed because of a server error returned by the Windows Store.


## -remarks
The [StorePurchaseResult.Status](storepurchaseresult_status.md) property returns these values.

## -examples

## -see-also