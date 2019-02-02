---
-api-id: P:Windows.ApplicationModel.Resources.Core.ResourceContext.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get;  set; }
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext.Languages

## -description
Gets or sets the language qualifier for this context.

## -property-value
A collection of [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) language tags.

## -remarks
The language qualifier is a list of valid [BCP-47](https://go.microsoft.com/fwlink/p/?linkid=227302) tags. The default value for the language qualifier is drawn from the app-specific language setting and the user language profile.

The language qualifier value is represented as a string containing a semicolon-delimited list. The [Languages](resourcecontext_languages.md) property wraps it in a container for convenience.

## -examples

## -see-also
[BCP-47 language tags](https://go.microsoft.com/fwlink/p/?linkid=227302)
