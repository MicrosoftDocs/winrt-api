---
-api-id: T:Windows.Services.Store.StoreSku
-api-type: winrt class
---

<!-- Class syntax.
public class StoreSku : Windows.Services.Store.IStoreSku
-->

# Windows.Services.Store.StoreSku

## -description
Provides info for a SKU of a product in the Windows Store.

## -remarks
Products in the Store are organized in a hierarcy of *product*, *SKU*, and *availability* objects. Products are represented by [StoreProduct](storeproduct.md) objects. The SKUs for each product are represented by **StoreSku** objects, and the availabilities for each SKU are represented by [StoreAvailability](storeavailability.md) objects. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials#products-skus).

To access the SKUs for a product, use the [Skus](storeproduct_skus.md) property of the [StoreProduct](storeproduct.md) for the product in which you are interested.

## -examples

## -see-also
[In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials)