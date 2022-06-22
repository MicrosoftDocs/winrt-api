---
-api-id: T:Windows.UI.Xaml.FontCapitals
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FontCapitals : int
-->

# FontCapitals

## -description
Describes the capital letter style value for the [Typography.Capitals](/uwp/api/windows.ui.xaml.documents.typography.capitals) attached property.



## -xaml-syntax
```xaml
<object property="enumMemberName"/>
 
```


## -enum-fields
### -field Normal:0
Capital letters render normally.

### -field AllSmallCaps:1
Both capital and lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height.

### -field SmallCaps:2
Lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height.

### -field AllPetiteCaps:3
Both capital and lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height. Petite capitals are smaller than small capitals.

### -field PetiteCaps:4
Lowercase letters are replaced with a glyph form of an uppercase letter with the same approximate height. Petite capitals are smaller than small capitals.

### -field Unicase:5
Capital letters display in unicase. Unicase fonts render both uppercase and lowercase letters in a mixture of uppercase and lowercase glyphs determined by the type designer.

### -field Titling:6
Glyph forms are substituted with a typographic form specifically designed for titles.


## -remarks
This enumeration is used by the [Typography.Capitals](/uwp/api/windows.ui.xaml.documents.typography.capitals) attached property.

## -examples

## -see-also
[Typography](../windows.ui.xaml.documents/typography.md)
