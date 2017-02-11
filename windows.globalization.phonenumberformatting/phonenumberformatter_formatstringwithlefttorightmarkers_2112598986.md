---
-api-id: M:Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter.FormatStringWithLeftToRightMarkers(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string FormatStringWithLeftToRightMarkers(System.String number)
-->

# Windows.Globalization.PhoneNumberFormatting.PhoneNumberFormatter.FormatStringWithLeftToRightMarkers

## -description
Returns the input string, formatted as a phone number, surrounded by Unicode Left to Right (LTR) markers.

## -parameters
### -param number
The input string to be formatted.

## -returns
The input string, formatted as a phone number, using the region specified when this PhoneNumberFormatter was created. The string is surrounded by Unicode Left to Right (LTR) markers.

## -remarks
Use this method when rendering a phone number for display and the current region settings specify a Right to Left (RTL) language. Phone numbers should still be rendered Left to Right, even when rendered in RTL languages.

## -examples

## -see-also
