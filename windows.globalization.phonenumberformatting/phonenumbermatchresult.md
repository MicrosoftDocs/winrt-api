---
-api-id: T:Windows.Globalization.PhoneNumberFormatting.PhoneNumberMatchResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Globalization.PhoneNumberFormatting.PhoneNumberMatchResult : int
-->

# PhoneNumberMatchResult

## -description
The result of calling the [PhoneNumberInfo.CheckNumberMatch](phonenumberinfo_checknumbermatch_849235604.md) method.

## -enum-fields
### -field NoMatch:0
The two numbers do not match.

### -field ShortNationalSignificantNumberMatch:1
The short national significant part (the subscriber number) of the two numbers match.

### -field NationalSignificantNumberMatch:2
The entire national significant part (area code and subscriber number) of the two numbers match.

### -field ExactMatch:3
The two numbers are an exact match.


## -remarks

## -examples

## -see-also