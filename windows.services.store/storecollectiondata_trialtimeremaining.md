---
-api-id: P:Windows.Services.Store.StoreCollectionData.TrialTimeRemaining
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan TrialTimeRemaining { get; }
-->

# Windows.Services.Store.StoreCollectionData.TrialTimeRemaining

## -description
Gets the remaining trial time for the trial that is associated with this product SKU.

## -property-value
The remaining trial time for the trial that is associated with this product SKU. For usage-limited trials, this property may not return meaningful values since these trials expire based on usage rather than time.

## -remarks
This property is primarily intended for **time-limited trials** where the trial expires after a specific time period.

For **usage-limited trials** configured in [Partner Center](https://partner.microsoft.com/dashboard), this property may not provide meaningful information since these trials expire based on usage (such as number of features used, content accessed, or other usage metrics) rather than time. For usage-limited trials, this property may return a very large value or other non-intuitive results.

To properly handle trial logic for different trial types:
- For **time-limited trials**: Use this property to get the actual remaining time
- For **usage-limited trials**: Check the [IsTrial](storecollectiondata_istrial.md) property and implement your own usage tracking mechanism based on your app's specific trial limitations

Usage-limited trials are currently available only to some developer accounts in Xbox managed partner programs.

> [!NOTE]
> Be aware that trial behavior may vary between testing environments and production deployments from the Microsoft Store. Always test your trial logic thoroughly in both environments.

## -examples

## -see-also
