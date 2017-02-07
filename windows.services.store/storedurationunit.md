---
-api-id: T:Windows.Services.Store.StoreDurationUnit
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Store.StoreDurationUnit : int
-->

# StoreDurationUnit

## -description
Defines values that represent the units of a trial period or billing period for a subscription.

> [!NOTE]
> Subscriptions are not currently supported by Windows Dev Center or the Store. This enum exists to provide future support for subscriptions, and is not intended to be used by your code in the current release.

## -enum-fields
### -field Minute:0
The period is defined in minutes.

### -field Hour:1
The period is defined in hours.

### -field Day:2
The period is defined in days.

### -field Week:3
The period is defined in weeks.

### -field Month:4
The period is defined in months.

### -field Year:5
The period is defined in years.


## -remarks
The [StoreSubscriptionInfo.BillingPeriodUnit](storesubscriptioninfo_billingperiodunit.md) property returns these values.

## -examples

## -see-also