---
-api-id: P:Windows.Globalization.ApplicationLanguages.Languages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> Languages { get; }
-->

# Windows.Globalization.ApplicationLanguages.Languages

## -description

Gets a ranked list of current runtime language values preferred by the user.

## -property-value

A computed list of languages that merges the app's declared supported languages ([ApplicationLanguages.ManifestLanguages](applicationlanguages_manifestlanguages.md)) with the user's ranked list of preferred languages.

## -remarks

At runtime, the list of languages for which your app has declared support (the app manifest language list) is compared with the list of languages for which the user has declared a preference (the user profile language list). The app runtime language list is set to this intersection (if the intersection is not empty), or to just the app's default language (if the intersection is empty). For more detail, see the [App runtime language list](/windows/uwp/design/globalizing/manage-language-and-region#app-runtime-language-list) section in [Understand user profile languages and app manifest languages](/windows/uwp/design/globalizing/manage-language-and-region).

> [!NOTE]
> This property returns the same values as the language list exposed by [Windows.ApplicationModel.Resources.Core.ResourceManager.DefaultContext.Languages](../windows.applicationmodel.resources.core/resourcecontext_languages.md).

## -examples

## -see-also
[ApplicationLanguages.ManifestLanguages](applicationlanguages_manifestlanguages.md), [Windows.ApplicationModel.Resources.Core.ResourceManager.DefaultContext.Languages](../windows.applicationmodel.resources.core/resourcecontext_languages.md)