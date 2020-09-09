---
-api-id: T:Windows.Services.Store.StoreAvailability
-api-type: winrt class
---

<!-- Class syntax.
public class StoreAvailability : Windows.Services.Store.IStoreAvailability
-->

# Windows.Services.Store.StoreAvailability

## -description
Represents a specific instance of a product SKU that can be purchased.

## -remarks
Products in the Store are organized in a hierarcy of *product*, *SKU*, and *availability* objects. Products are represented by [StoreProduct](storeproduct.md) objects. The SKUs for each product are represented by [StoreSku](storesku.md) objects, and the availabilities for each SKU are represented by **StoreAvailability** objects. For more information, see [In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials).

To access the availabilities for a SKU, use the [Availabilities](storesku_availabilities.md) property of the [StoreSku](storesku.md) object in which you are interested.

## -examples

## -see-also
[In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials)