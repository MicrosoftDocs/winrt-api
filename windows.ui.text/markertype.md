---
-api-id: T:Windows.UI.Text.MarkerType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.MarkerType : int
-->

# MarkerType

## -description
Specifies the kind of characters used to mark the item paragraphs in a list.



## -enum-fields
### -field Undefined:0
The list type is not defined.

### -field None:1
Not a list paragraph.

### -field Bullet:2
The list uses bullets (character code 0x2022).

### -field Arabic:3
The list is numbered with Arabic numerals (0, 1, 2, ...).

### -field LowercaseEnglishLetter:4
The list is ordered with lowercase letters (a, b, c, ...).

### -field UppercaseEnglishLetter:5
The list is ordered with uppercase letters (A, B, C, ...).

### -field LowercaseRoman:6
The list is ordered with lowercase Roman letters (i, ii, iii, ...).

### -field UppercaseRoman:7
The list is ordered with uppercase Roman letters (I, II, III, ...).

### -field UnicodeSequence:8
The value returned by [ITextParagraphFormat.ListStart](itextparagraphformat_liststart.md) is treated as the first code in a Unicode sequence.

### -field CircledNumber:9
The list is ordered with Unicode circled numbers <img alt="Unicode numbers in a circle." src="images/unicodecirclednumbers.png" />

### -field BlackCircleWingding:10
The list is ordered with Wingdings black circled digits <img alt="Circled black digits." src="images/wingdingblackcircleddigits.png" />

### -field WhiteCircleWingding:11
The list is ordered with Wingdings white circled digits <img alt="White digits in a black circle." src="images/wingdingwhitecircleddigits.png" />

### -field ArabicWide:12
Full-width ASCII (０, １, ２, ３, …).

### -field SimplifiedChinese:13
Chinese with 十 only in items 10 through 99 (一, 二, 三, 四, …).

### -field TraditionalChinese:14
Chinese with 十 only in items 10 through 19.

### -field JapanSimplifiedChinese:15
Chinese with a full-width period, no 十.

### -field JapanKorea:16
Chinese with no 十.

### -field ArabicDictionary:17
Arabic alphabetic ( أ ,ب ,ت ,ث ,…).

### -field ArabicAbjad:18
Arabic abjadi ( أ ,ب ,ج ,د ,…).

### -field Hebrew:19
Hebrew alphabet (א, ב, ג, ד, …).

### -field ThaiAlphabetic:20
Thai alphabetic (ก, ข,ค, ง, …).

### -field ThaiNumeric:21
Thai numbers (๑, ๒,๓, ๔, …).

### -field DevanagariVowel:22
Devanāgarī vowels (अ, आ, इ, ई, …).

### -field DevanagariConsonant:23
Devanāgarī consonants (क, ख, ग, घ, …).

### -field DevanagariNumeric:24
Devanāgarī numbers (१, २, ३, ४, …).


## -remarks

## -examples

## -see-also
[ITextParagraphFormat.ListType](itextparagraphformat_listtype.md)
