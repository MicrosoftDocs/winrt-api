---
-api-id: M:Windows.Globalization.Language.TrySetInputMethodLanguageTag(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool TrySetInputMethodLanguageTag(System.String languageTag)
-->

# Windows.Globalization.Language.TrySetInputMethodLanguageTag

## -description

Tries to set the normalized [BCP-47](https://tools.ietf.org/html/bcp47) language tag of this language.

## -parameters

### -param languageTag

The normalized [BCP-47](https://tools.ietf.org/html/bcp47) language tag.

## -returns

**true** if the value is successfully set, otherwise **false**.

This method will only attempt to change the input language if the application is running on an IoT device. On non-IoT devices, the return value is always **false**.

## -remarks

Language tags support the Unicode extensions "ca-" and "nu-". (See [Unicode Key/Type Definitions](https://www.unicode.org/reports/tr35/#Key_Type_Definitions).) Note that these extensions can affect the calendar used by Calendar objects.

## -examples

## -see-also

## -capabilities

systemManagement
