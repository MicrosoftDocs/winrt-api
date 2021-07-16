---
-api-id: P:Windows.ApplicationModel.Payments.PaymentDetailsModifier.Total
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Payments.PaymentItem Total { get; }
-->

# Windows.ApplicationModel.Payments.PaymentDetailsModifier.Total

## -description
This is the total of all [DisplayItems](paymentdetails_displayitems.md). This value serves as a replacement for the [PaymentDetails.Total](paymentdetails_total.md) property when one of the payment methods in the [SupportedMethodIds](paymentdetailsmodifier_supportedmethodids.md) list is used. Therefore, this value needs to be the sum of [PaymentDetail.DisplayItems](paymentdetails_displayitems.md), the selected shipping option in the [PaymentDetails.ShippingOptions](paymentdetails_shippingoptions.md) collection (See [PaymentShippingOption.IsSelected](paymentshippingoption_isselected.md)), and [AdditionalDisplayItems](paymentdetailsmodifier_additionaldisplayitems.md).

## -property-value
Gets or sets the Total.

## -remarks

## -examples

## -see-also