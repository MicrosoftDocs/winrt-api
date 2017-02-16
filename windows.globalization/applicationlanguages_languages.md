---
-api-id: P:Windows.Globalization.ApplicationLanguages.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get; }
-->

# Windows.Globalization.ApplicationLanguages.Languages

## -description
Gets the ranked list of current runtime language values preferred by the user.

## -property-value
A computed list of languages that merges the app's declared supported languages ([ApplicationLanguages.ManifestLanguages](applicationlanguages_manifestlanguages.md)) with the user's ranked list of preferred languages.

## -remarks
This list is the recommended source of the best current runtime language value(s) preferred by the user.

> [!NOTE]
> This property yields the same values as the language list exposed by [Windows.ApplicationModel.Resources.Core.ResourceManager.DefaultContext.Languages](../windows.applicationmodel.resources.core/resourcecontext_languages.md).

## -examples

## -see-also
[ApplicationLanguages.ManifestLanguages](applicationlanguages_manifestlanguages.md), [Windows.ApplicationModel.Resources.Core.ResourceManager.DefaultContext.Languages](../windows.applicationmodel.resources.core/resourcecontext_languages.md)