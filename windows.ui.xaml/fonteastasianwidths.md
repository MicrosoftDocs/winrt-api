---
-api-id: T:Windows.UI.Xaml.FontEastAsianWidths
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FontEastAsianWidths : int
-->

# FontEastAsianWidths

## -description
Provides a mechanism for selecting glyphs of different width styles.



## -xaml-syntax
```xaml
<object property="enumMemberName"/>
 
```


## -enum-fields
### -field Normal:0
Default width style.

### -field Full:1
Replaces uniform width glyphs with full width (usually em) glyphs.

### -field Half:2
Replaces uniform width glyphs with half width (half em) glyphs

### -field Proportional:3
Replaces uniform width glyphs with proportionally spaced glyphs.

### -field Quarter:4
Replaces uniform width glyphs with one-quarter width (one-quarter em) glyphs.

### -field Third:5
Replaces uniform width glyphs with one-third width (one-third em) glyphs.


## -remarks
This enumeration is used by the [Typography.EastAsianWidths](/uwp/api/windows.ui.xaml.documents.typography.eastasianwidths) attached property.

## -examples

## -see-also
[Typography](../windows.ui.xaml.documents/typography.md)
