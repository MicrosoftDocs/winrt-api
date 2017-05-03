---
-api-id: M:Windows.ApplicationModel.Payments.PaymentCurrencyAmount.#ctor(System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public PaymentCurrencyAmount(System.String value, System.String currency, System.String currencySystem)
-->

# Windows.ApplicationModel.Payments.PaymentCurrencyAmount.PaymentCurrencyAmount

## -description
Creates a new PaymentCurrencyAmount object.

## -parameters
### -param value
The monetary value. An exception will be thrown if this value doesn't match the following regex pattern.
```
^-?[0-9]+(\.[0-9]+)?$
```



### -param currency
The currency. Valid values are determined by *currencySystem*. For example, if *currencySystem* is urn:iso:std:iso:4217 then **USD** is a valid currency value. 

> [!IMPORTANT]
> Validity of currency values are not enforced.

### -param currencySystem
The currency system.

## -remarks

## -examples

## -see-also