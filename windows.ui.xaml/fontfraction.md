---
-api-id: T:Windows.UI.Xaml.FontFraction
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FontFraction : int
-->

# FontFraction

## -description
Describes a fraction style value for the [Typography.Fraction](/uwp/api/windows.ui.xaml.documents.typography.fraction) attached property.

Equivalent **WinUI 2 API for UWP**: [FontFraction](/windows/winui/api/microsoft.ui.xaml.fontfraction) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax
```xaml
<object property="enumMemberName"/>
 
```


## -enum-fields
### -field Normal:0
Default style is used.

### -field Stacked:1
Slashed fraction style is used.

### -field Slashed:2
Stacked fraction style is used.


## -remarks
This enumeration is used by the [Typography.Fraction](/uwp/api/windows.ui.xaml.documents.typography.fraction) attached property.

Generally, Microsoft OpenType fonts support styles for fractions, including slashed and stacked.

A slashed style is also known as a diagonal style. Usually the slashed style does have a baseline offset between the two numerals with the first appearing higher than the second, but exactly how large that offset is can depend on the font.

## -examples

## -see-also
[Typography](../windows.ui.xaml.documents/typography.md)
