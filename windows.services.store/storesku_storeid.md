---
-api-id: P:Windows.Services.Store.StoreSku.StoreId
-api-type: winrt property
---

<!-- Property syntax
public string StoreId { get; }
-->

# Windows.Services.Store.StoreSku.StoreId

## -description
Gets the Store ID of this product SKU.

## -property-value
The Store ID of this product SKU.

## -remarks
The Store ID returned by this property has the format *&lt;product Store ID&gt;*/*&lt;SKU Store ID&gt;*, where: 
+ *&lt;product Store ID&gt;* is a 12-character alpha-numeric string, such as 9NBLGGH69M0B. This Store ID is available in the Windows Dev Center dashboard page for the app or add-on, and it is returned by the [StoreId](storeproduct_storeid.md) property of the related [StoreProduct](storeproduct.md) object.
+ *&lt;SKU Store ID&gt;* is a 4-character alpha-numeric string that identifies the SKU.
An example complete Store ID returned by this property is 9NBLGGH69M0B/000N.

## -examples

## -see-also
