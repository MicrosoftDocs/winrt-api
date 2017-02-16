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

> [!NOTE]
> Subscriptions are not currently supported by Windows Dev Center or the Store. This member exists to provide future support for subscriptions, and is not intended to be used by your code in the current release.

## -property-value
An object that contains subscription information for this product SKU. If this product SKU is not a recurring billing subscription, this property returns **null**.

## -remarks

## -examples

## -see-also
