---
-api-id: T:Windows.UI.Xaml.FontEastAsianLanguage
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.FontEastAsianLanguage : int
-->

# FontEastAsianLanguage

## -description
Provides a mechanism for selecting font-specific versions of glyphs for a specified East Asian writing system or language.



## -xaml-syntax
```xaml
<object property="enumMemberName"/>
 
```


## -enum-fields
### -field Normal:0
No font-specific glyph versions are applied.

### -field HojoKanji:1
Replaces default glyphs with the corresponding forms from the Hojo Kanji specification.

### -field Jis04:2
Replaces default Japanese glyphs with the corresponding forms from the JIS04 specification.

### -field Jis78:3
Replaces default Japanese glyphs with the corresponding forms from the JIS78 specification.

### -field Jis83:4
Replaces default Japanese glyphs with the corresponding forms from the JIS83 specification.

### -field Jis90:5
Replaces default Japanese glyphs with the corresponding forms from the JIS90 specification.

### -field NlcKanji:6
Replaces default glyphs with the corresponding forms from the NLC Kanji specification.

### -field Simplified:7
Replaces traditional Chinese or Japanese forms with their corresponding simplified forms.

### -field Traditional:8
Replaces simplified Chinese or Japanese forms with their corresponding traditional forms.

### -field TraditionalNames:9
Replaces simplified Kanji forms with their corresponding traditional forms. This glyph set is explicitly limited to the traditional forms considered proper for use in personal names.


## -remarks
This enumeration is used by the [Typography.EastAsianLanguage](/uwp/api/windows.ui.xaml.documents.typography.eastasianlanguage) attached property.

## -examples

## -see-also
[Typography](../windows.ui.xaml.documents/typography.md)
