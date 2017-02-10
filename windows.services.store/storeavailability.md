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
The [StoreSku.Availabilities](storesku_availabilities.md) property returns objects of this type.

Each product SKU can have one or more *availabilities* that have different prices. To access the availabilities for a SKU, use the [Availabilities](storesku_availabilities.md) property of the [StoreSku](storesku.md) object for the SKU in which you are interested. For more information about availabilities and their relationship with products and SKUs, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).

## -examples

## -see-also
[In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials)