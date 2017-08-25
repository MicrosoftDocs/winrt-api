---
-api-id: P:Windows.Services.Store.StoreSku.SubscriptionInfo
-api-type: winrt property
---

<!-- Property syntax
public Windows.Services.Store.StoreSubscriptionInfo SubscriptionInfo { get; }
-->

# Windows.Services.Store.StoreSku.SubscriptionInfo

## -description
Gets subscription information for this product SKU, if this product SKU is a subscription with recurring billing. To determine whether this product SKU is a subscription, use the [IsSubscription](storesku_issubscription.md) property.

> [!IMPORTANT]
> Currently, the ability to create subscription add-ons is only available to developers who are participating in an early adoption program. We will make subscription add-ons available to all developer accounts in the future. For more information, see [Enable subscription add-ons for your app](https://docs.microsoft.com/windows/uwp/monetize/enable-subscription-add-ons-for-your-app).

## -property-value
An object that contains subscription information for this product SKU. If this product SKU is not a recurring billing subscription, this property returns **null**.

## -remarks

## -examples

## -see-also
[Enable subscription add-ons for your app](https://docs.microsoft.com/windows/uwp/monetize/enable-subscription-add-ons-for-your-app)
