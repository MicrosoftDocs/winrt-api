---
-api-id: M:Windows.Globalization.Language.IsWellFormed(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsWellFormed(System.String languageTag)
-->

# Windows.Globalization.Language.IsWellFormed

## -description
Determines whether a [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302) language tag is well-formed.

## -parameters
### -param languageTag
A [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302) language tag.

## -returns
**True** if the language tag is well-formed as defined by [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302), except when the language tag can never be valid according to [BCP-47](http://go.microsoft.com/fwlink/p/?linkid=227302). Otherwise it returns **false**. If this method returns **true**, an application can safely construct a language by using this tag. If it returns **false**, attempting to construct a language for the given tag will throw an exception.

## -remarks


## -examples

## -see-also
[BCP-47 language tags](http://go.microsoft.com/fwlink/p/?linkid=227302)