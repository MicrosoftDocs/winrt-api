---
-api-id: T:Windows.ApplicationModel.Payments.PaymentOptionPresence
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Payments.PaymentOptionPresence : int
-->

# PaymentOptionPresence

## -description
An enumeration that indicates whether the option is required or optional.

## -enum-fields
### -field None:0
Property is not needed or used by the merchant.

### -field Optional:1
Property is not needed by the merchant, but they will accept it if provided. For example, a merchant could optionally send you a receipt to your email address.

### -field Required:2
The merchant can't (or is unwilling to) process the transaction without this information.


## -remarks

## -examples

## -see-also