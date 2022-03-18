---
-api-id: T:Windows.Data.Text.UnicodeNumericType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Data.Text.UnicodeNumericType : int
-->

# UnicodeNumericType

## -description
Defines the type of numeral when a Unicode character represents a number.

## -enum-fields
### -field None:0
Not a numeric character.

### -field Decimal:1
A decimal digit in a decimal system that uses 0 through 9.

### -field Digit:2
A digit in the range 0 through 9 that is used in special contexts.

### -field Numeric:3
A character that represents another type of numeric value, such as a fraction.


## -remarks
A member of this enumeration is returned by [GetNumericType](unicodecharacters_getnumerictype_1735068207.md).

These values follow the types in the [Unicode Standard Annex #44](https://www.unicode.org/reports/tr44/#Numeric_Type).

## -examples

## -see-also
[GetNumericType](unicodecharacters_getnumerictype_1735068207.md)
