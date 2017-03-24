---
-api-id: M:Windows.ApplicationModel.Payments.PaymentCurrencyAmount.#ctor(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public PaymentCurrencyAmount(System.String value, System.String currency)
-->

# Windows.ApplicationModel.Payments.PaymentCurrencyAmount.PaymentCurrencyAmount

## -description
Creates a new [PaymentCurrencyAmount](paymentcurrencyamount.md) object

## -parameters
### -param value
The monetary value. An exception will be thrown if this value doesn't match the following regex pattern.
```
^-?[0-9]+(\.[0-9]+)?$
```



### -param currency
The currency identifier. The default **CurrencySystem** is urn:iso:std:iso:4217.

> [!IMPORTANT]
> Validity of currency values are not enforced.

## -remarks

## -examples

## -see-also