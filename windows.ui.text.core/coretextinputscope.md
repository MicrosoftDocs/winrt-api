---
-api-id: T:Windows.UI.Text.Core.CoreTextInputScope
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.Core.CoreTextInputScope : int
-->

# CoreTextInputScope

## -description
Defines constants that specify the set of input scope names. Input scope is used by the text input server and input processors to determine the layout of the Soft Input Panel (SIP), and what type of language model to use.

## -enum-fields
### -field Default:0
No input scope is applied.

### -field Url:1
Expected input is a URL.

### -field FilePath:2
Expected input is characters used in describing a file path.

### -field FileName:3
Expected input is characters used in describing a file name.

### -field EmailUserName:4
Expected input is the account name portion of an email address.

### -field EmailAddress:5
Expected input is an SMTP form email address (&lt;accountname&gt;@&lt;host&gt;).

### -field UserName:6
Expected input is a log-in name and a domain (&lt;accountname&gt; or &lt;domain&gt;\&lt;accountname&gt;).

### -field PersonalFullName:7
Expected input is a person’s full name, including prefix, given name, middle name, surname, and suffix.

### -field PersonalNamePrefix:8
Expected input is the prefix portion of a person’s full name. (For example, "Mr.")

### -field PersonalGivenName:9
Expected input is the given (or first) name portion of a person’s full name.

### -field PersonalMiddleName:10
Expected input is the middle name portion of a person’s full name.

### -field PersonalSurname:11
Expected input is the family (or last) name portion of a person’s full name.

### -field PersonalNameSuffix:12
Expected input is the suffix portion of a person’s full name. (For example, "Jr.")

### -field Address:13
Expected input is a full postal address. (For example, "One Microsoft Way, Redmond, WA 98052, U.S.A.")

### -field AddressPostalCode:14
Expected input is the postal code (or zip code) portion a full address. (For example, "98052".)

### -field AddressStreet:15
Expected input is the street portion a full address. (For example, "Microsoft Way".)

### -field AddressStateOrProvince:16
Expected input is the state or province portion a full address. (For example, "WA".)

### -field AddressCity:17
Expected input is the city portion a full address. (For example, "Redmond".)

### -field AddressCountryName:18
Expected input is the country name portion a full address. (For example, "United States of America".)

### -field AddressCountryShortName:19
Expected input is the country abbreviation portion a full address. (For example, "U.S.A.")

### -field CurrencyAmountAndSymbol:20
Expected input is an amount of currency and a currency symbol.

### -field CurrencyAmount:21
Expected input is an amount of currency.

### -field Date:22
Expected input is a calendar date.

### -field DateMonth:23
Expected input is the numeric month portion of a calendar date.

### -field DateDay:24
Expected input is the numeric day portion of a calendar date.

### -field DateYear:25
Expected input is the year portion of a calendar date.

### -field DateMonthName:26
Expected input is the alphabetic name of the month from a calendar date.

### -field DateDayName:27
Expected input is the alphabetic name of the day from a calendar date.

### -field Digits:28
Expected input includes positive whole numbers, constrained to 0-9.

### -field Number:29
Expected input includes the digits 0-9, decimal separators, place separators, and negative sign. The exact characters used for  decimal separators, place separators, and negative sign, depend on the user’s regional settings. 

### -field SingleCharacter:30
Expected input is a single ANSI character, codepage 1252.

### -field Password:31
Expected input is a password.

### -field TelephoneNumber:32
Expected input is a full telephone number. (For example, "1(800)555-5555".)

### -field TelephoneCountryCode:33
Expected input is the country code portion of a full telephone number. (For example, "1".)

### -field TelephoneAreaCode:34
Expected input is the area code portion of a full telephone number. (For example, "(800)".)

### -field TelephoneLocalNumber:35
Expected input is the local number portion of a full telephone number. (For example, "555-5555".)

### -field Time:36
Expected input is a time value.

### -field TimeHour:37
Expected input is the hour portion of a time value.

### -field TimeMinuteOrSecond:38
Expected input is the minute or second portion of a time value.

### -field NumberFullWidth:39
Expected input is full-width number characters.

### -field AlphanumericHalfWidth:40
Expected input is half-width alphanumeric characters.

### -field AlphanumericFullWidth:41
Expected input is full-width alphanumeric characters.

### -field CurrencyChinese:42
Expected input is Chinese currency.

### -field Bopomofo:43
Expected input is the Bopomofo Mandarin Chinese phonetic transcription system.

### -field Hiragana:44
Expected input is Hiragana characters.

### -field KatakanaHalfWidth:45
Expected input is Katakana half-width characters.

### -field KatakanaFullWidth:46
Expected input is Katakana full-width characters.

### -field Hanja:47
Expected input is Hanja characters.

### -field HangulHalfWidth:48
Expected input is Hangul half-width characters.

### -field HangulFullWidth:49
Expected input is Hangul full-width characters.

### -field Search:50
Expected input is a search string.

### -field Formula:51
Expected input is a mathematical formula.

### -field SearchIncremental:52
Expected input is a search string. Use for search boxes where incremental results are displayed as the user types.

### -field ChineseHalfWidth:53
Expected input is Chinese half-width characters.

### -field ChineseFullWidth:54
Expected input is Chinese full-width characters.

### -field NativeScript:55
Expected input is native script.

### -field Text:57
Expected input is text; turns on typing intelligence.

### -field Chat:58
Expected input is chat strings.

### -field NameOrPhoneNumber:59
Expected input is a name or a telephone number.

### -field EmailUserNameOrAddress:60
Expected input is an email user name (\<accountname>) or full email address (\<accountname>@\<host>).

### -field Private:61
Expected input is private data. Advises input processors that the text should not be stored nor logged.

### -field Maps:62
Expected input is from the device's Maps layout; does not include typing intelligence.

### -field PasswordNumeric:63
Expected input is a numeric password, or PIN.

### -field PinNumeric:64
Expected input is an numeric password, or PIN. Typically constrained to 5-6 digits.

### -field PinAlphanumeric:65
Expected input is an alphanumeric password, or PIN. Typically constrained to 5-6 characters.

### -field FormulaNumber:67
Expected input is a mathematical formula. Advises input processors to show the number page.

### -field ChatWithoutEmoji:68
Expected input does not include emoji. Advises input processors to not display the emoji key.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ChatWithoutEmoji |
| 1709 | 16299 | Digits |
| 1709 | 16299 | PinAlphanumeric |
| 1709 | 16299 | PinNumeric |

## -examples

## -see-also
[Windows.UI.Text.Core](windows_ui_text_core.md), [Use input scope to change the touch keyboard](/windows/uwp/design/input/use-input-scope-to-change-the-touch-keyboard)


