---
-api-id: M:Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter.TryCreate(System.String,Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter@)
-api-type: winrt method
---

<!-- Method syntax
public void TryCreate(System.String regionCode, Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter phoneNumber)
-->

# Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter.TryCreate

## -description
Attempts to create a [PhoneNumberFormatter](phonenumberformatter.md) for a given region code, and doesn't throw on failure.

## -parameters
### -param regionCode
The region code of the new [PhoneNumberFormatter](phonenumberformatter.md).

### -param phoneNumber
On success, a new [PhoneNumberFormatter](phonenumberformatter.md) for the requested region code.

On failure, this value is **null**.

## -remarks
The following code snippet demonstrates how to use this method to create a [PhoneNumberFormatter](phonenumberformatter.md) for the "BR" region.

```csharp

    using Windows.Globalization.PhoneNumberFormatting;

    PhoneNumberFormatter currentFormatter = null;

    PhoneNumberFormatter.TryCreate("BR", out currentFormatter);
    if (currentFormatter != null)
    {
        // use the formatter 
    }  
    else
    {
        // formatter could not be created for the given region. 
        // put your fallback logic here.
    }

```



## -examples

## -see-also
