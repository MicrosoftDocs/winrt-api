---
-api-id: M:Windows.Globalization.PhoneNumberFormatting.PhoneNumberInfo.TryParse(System.String,System.String,Windows.Globalization.PhoneNumberFormatting.PhoneNumberInfo@)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Globalization.PhoneNumberFormatting.PhoneNumberParseResult TryParse(System.String input, System.String regionCode, Windows.Globalization.PhoneNumberFormatting.PhoneNumberInfo phoneNumber)
-->

# Windows.Globalization.PhoneNumberFormatting.PhoneNumberInfo.TryParse

## -description
Static method that attempts to parse a given input string as a phone number (using a given region code) and creates a [PhoneNumberInfo](phonenumberinfo.md) encapsulating it.

## -parameters
### -param input
A phone number, in string form.

### -param regionCode
The two-letter region code to be used to parse *input*. Region codes should use upper-case letters.

### -param phoneNumber
On success, this object encapsulates the given phone number.

## -returns
An enumeration value giving details of the attempt to parse *input*.

## -remarks

## -examples

## -see-also
[TryParse(String, PhoneNumberInfo)](phonenumberinfo_tryparse_154311273.md)