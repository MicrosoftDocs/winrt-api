---
-api-id: T:Windows.ApplicationModel.Payments.PaymentDetails
-api-type: winrt class
---

<!-- Class syntax.
public class PaymentDetails : Windows.ApplicationModel.Payments.IPaymentDetails
-->

# Windows.ApplicationModel.Payments.PaymentDetails

## -description
This class provides information about the requested transaction; it is passed to the [PaymentRequest](paymentrequest.md) and [PaymentRequestChangedResult](paymentrequestchangedresult.md) constructors. This class reflects the [W3C PaymentDetails dictionary](https://aka.ms/prapi#paymentdetailsmodifier-dictionary).

## -remarks
If this class is used to update the payment request in [PaymentRequestChangedResult](paymentrequestchangedresult.md), properties that are null indicate that property hasn't been changed and that the old property value should

## -examples

## -see-also