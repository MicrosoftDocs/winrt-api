---
-api-id: T:Windows.Services.Store.StoreCollectionData
-api-type: winrt class
---

<!-- Class syntax.
public class StoreCollectionData : Windows.Services.Store.IStoreCollectionData
-->

# Windows.Services.Store.StoreCollectionData

## -description
Provides additional data for a product SKU that the user has an entitlement to use.

## -remarks
The [StoreSku.CollectionData](storesku_collectiondata.md) property returns an object of this type. This object is only available for SKUs that the user has an entitlement to use (for example, SKUs that the user has purchased, downloaded for free, or acquired through other means from the Microsoft Store).

The **StoreCollectionData** object provides properties such as [AcquiredDate](storecollectiondata_acquireddate.md), which indicates when the user first acquired the SKU from the Microsoft Store.

## -examples
The following example shows how to access **StoreCollectionData** for products in the user's collection.

```csharp
private async void GetCollectionData()
{
    // Get the StoreContext for the current user
    StoreContext storeContext = StoreContext.GetDefault();
    
    // Get the user's collection of owned products
    string[] productKinds = { "Application", "Durable" };
    StoreProductQueryResult queryResult = await storeContext.GetUserCollectionAsync(productKinds);
    
    if (queryResult.ExtendedError == null)
    {
        foreach (StoreProduct product in queryResult.Products)
        {
            foreach (StoreSku sku in product.Skus)
            {
                // Check if the user has an entitlement for this SKU
                if (sku.CollectionData != null)
                {
                    StoreCollectionData collectionData = sku.CollectionData;
                    
                    // Access properties of the collection data
                    DateTime acquiredDate = collectionData.AcquiredDate;
                    bool isTrial = collectionData.IsTrial;
                    
                    System.Diagnostics.Debug.WriteLine($"Product: {product.Title}");
                    System.Diagnostics.Debug.WriteLine($"Acquired: {acquiredDate}");
                    System.Diagnostics.Debug.WriteLine($"Is Trial: {isTrial}");
                }
            }
        }
    }
}
```

## -see-also
[StoreSku.CollectionData](storesku_collectiondata.md), [StoreCollectionData.AcquiredDate](storecollectiondata_acquireddate.md), [StoreContext.GetUserCollectionAsync](storecontext_getusercollectionasync_822351662.md)
