---
-api-id: P:Windows.Services.Store.StoreSku.CollectionData
-api-type: winrt property
---

<!-- Property syntax
public Windows.Services.Store.StoreCollectionData CollectionData { get; }
-->

# Windows.Services.Store.StoreSku.CollectionData

## -description
Gets additional data for the current product SKU, if the user has an entitlement to use the SKU.

## -property-value
An object that provides additional data for the current product SKU, if the user has an entitlement to use the SKU. This property returns **null** if the user does not have an entitlement for the SKU.

## -remarks
This property returns a [StoreCollectionData](storecollectiondata.md) object only for SKUs that the user has acquired or is entitled to use. This includes SKUs that the user has purchased, downloaded for free, or acquired through other means from the Microsoft Store.

To access **StoreSku** objects with collection data, use methods such as [GetUserCollectionAsync](storecontext_getusercollectionasync_822351662.md) to retrieve the user's collection of owned products.

## -examples
For a complete example of how to access and use this property, see [StoreCollectionData](storecollectiondata.md).

## -see-also
[StoreCollectionData](storecollectiondata.md), [StoreCollectionData.AcquiredDate](storecollectiondata_acquireddate.md), [StoreContext.GetUserCollectionAsync](storecontext_getusercollectionasync_822351662.md)
