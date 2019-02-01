---
-api-id: M:Windows.Globalization.Language.TrySetInputMethodLanguageTag(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool TrySetInputMethodLanguageTag(System.String languageTag)
-->

# Windows.Globalization.Language.TrySetInputMethodLanguageTag

## -description
Tries to set the normalized [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tag of this language.

## -parameters
### -param languageTag
The normalized [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tag.

**Starting in :** Language tags can support Unicode extensions. See the Remarks for the [Language](language_language_290278668.md) constructor.

## -returns
**true** if the value is successfully set, otherwise **false**.

This method will only attempt to change the input language if the application is running on an IoT device. On non-IoT devices, the return value is always **false**.

## -remarks

## -examples

## -see-also


## -capabilities
systemManagement
