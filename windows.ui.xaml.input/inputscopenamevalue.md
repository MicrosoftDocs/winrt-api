---
-api-id: T:Windows.UI.Xaml.Input.InputScopeNameValue
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Input.InputScopeNameValue : int
-->

# InputScopeNameValue

## -description

Specifies a particular named input mode ([InputScopeName](inputscopename.md)) used to populate an [InputScope](inputscope.md).



## -xaml-syntax

```xaml
<object property="enumNamedConstant"/>
```

## -enum-fields

### -field Default:0

No input scope is applied.

### -field Url:1

Indicates a Uniform Resource Identifier (URI). This can include URL, File, or File Transfer Protocol (FTP) formats.

Keyboard includes .com and Go keys (as well as :, -, and / keys). Pressing and holding the .com key displays additional options (.org, .net, and region-specific suffixes).

### -field EmailSmtpAddress:5

Input scope is intended for working with a Simple Mail Transport Protocol (SMTP) form e-mail address (accountname@host).

Keyboard includes @ and .com keys. Pressing and holding the .com key displays additional options (.org, .net, and region-specific suffixes).

See [EmailNameOrAddress](#-field-emailnameoraddress60) for less specific keyboard.

### -field PersonalFullName:7

Input scope is intended for working with a complete personal name.

### -field CurrencyAmountAndSymbol:20

Input scope is intended for working with amount and symbol of currency.

### -field CurrencyAmount:21

Input scope is intended for working with a currency amount (no currency symbol).

### -field DateMonthNumber:23

Input scope is intended for working with a numeric month of the year.

### -field DateDayNumber:24

Input scope is intended for working with a numeric day of the month.

### -field DateYear:25

Input scope is intended for working with a numeric year.

### -field Digits:28

Input scope is intended for working with a collection of numbers.

### -field Number:29

Input scope is intended for working with digits 0-9.

### -field Password:31

Input scope is intended for working with an alphanumeric password, including other symbols, such as punctuation and mathematical symbols.

### -field TelephoneNumber:32

Input scope is intended for working with telephone numbers.

### -field TelephoneCountryCode:33

Input scope is intended for working with a numeric telephone country/region code.

### -field TelephoneAreaCode:34

Input scope is intended for working with a numeric telephone area code.

### -field TelephoneLocalNumber:35

Input scope is intended for working with a local telephone number.

### -field TimeHour:37

Input scope is intended for working with a numeric hour of the day.

### -field TimeMinutesOrSeconds:38

Input scope is intended for working with a numeric minute of the hour, or second of the minute.

### -field NumberFullWidth:39

Input scope is intended for full-width number characters.

### -field AlphanumericHalfWidth:40

Input scope is intended for alphanumeric half-width characters.

### -field AlphanumericFullWidth:41

Input scope is intended for alphanumeric full-width characters.

### -field Hiragana:44

Input scope is intended for Hiragana characters.

### -field KatakanaHalfWidth:45

Input scope is intended for Katakana half-width characters.

### -field KatakanaFullWidth:46

Input scope is intended for Katakana full-width characters.

### -field Hanja:47

Input scope is intended for Hanja characters.

### -field HangulHalfWidth:48

Input scope is intended for Hangul half-width characters.

### -field HangulFullWidth:49

Input scope is intended for Hangul full-width characters.

### -field Search:50

Input scope is intended for search strings.

### -field Formula:51

Input scope is intended for spreadsheet formula strings.

### -field SearchIncremental:52

Input scope is intended for search boxes where incremental results are displayed as the user types.

### -field ChineseHalfWidth:53

Input scope is intended for Chinese half-width characters.

### -field ChineseFullWidth:54

Input scope is intended for Chinese full-width characters.

### -field NativeScript:55

Input scope is intended for native script.

### -field Text:57

Input scope is intended for working with text.

### -field Chat:58

Input scope is intended for chat strings.

### -field NameOrPhoneNumber:59

Input scope is intended for working with a name or telephone number.

### -field EmailNameOrAddress:60

Input scope is intended for working with an email, name, or address.

See [EmailSmtpAddress](#-field-emailsmtpaddress5) for email-specific keyboard.

### -field Private: 61

Expected input is private data. Advises input processors that the text should **NOT** be stored or logged.

The user can also specify this through the "Improve inking and typing" setting (Settings->Privacy->Diagnostics & Feedback).

### -field Maps:62

Input scope is intended for working with a map location.

### -field NumericPassword:63

Expected input is a numeric password, or PIN.

### -field NumericPin:64

Expected input is a numeric PIN.

### -field AlphanumericPin:65

Expected input is an alphanumeric PIN.

### -field FormulaNumber:67

Expected input is a mathematical formula. Advises input processors to show the number page.

### -field ChatWithoutEmoji:68

Expected input does not include emoji. Advises input processors to not show the emoji key.

## -xaml-syntax

```xaml
<object property="enumNamedConstant"/>
```

## -remarks

> [!NOTE]
> Support for a given input scope value can vary across input methods.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ChatWithoutEmoji |

## -examples

## -see-also

[InputScope.Names](inputscope_names.md), [PasswordBox.InputScope](../windows.ui.xaml.controls/passwordbox_inputscope.md), [RichEditBox.InputScope](../windows.ui.xaml.controls/richeditbox_inputscope.md), [TextBox.InputScope](../windows.ui.xaml.controls/textbox_inputscope.md), [Windows.UI.Xaml.Input enumerations](/uwp/api/windows.ui.xaml.input), [Use input scope to change the touch keyboard](/windows/uwp/design/input/use-input-scope-to-change-the-touch-keyboard)
