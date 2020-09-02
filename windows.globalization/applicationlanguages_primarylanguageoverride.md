---
-api-id: P:Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride
-api-type: winrt property
---

<!-- Property syntax
public string PrimaryLanguageOverride { get;  set; }
-->

# Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride

## -description
Gets or sets an override for the app's preferred language, expressed as a [BCP-47](https://tools.ietf.org/html/bcp47) language tag. This setting is persisted.

## -property-value
A [BCP-47](https://tools.ietf.org/html/bcp47) language tag. The app can set it to override the top language of the user's ranked list of preferred languages ([ApplicationLanguages.Languages](applicationlanguages_languages.md)), and its value will persist between app sessions. It must be a single language tag; a delimited list of language tags will fail.

When your app gets the value, PrimaryLanguageOverride returns either a single language tag (if your app has previously set the property) or an empty string.

## -remarks
Apps normally run with language settings determined by the system by comparing the languages supported by the app with the language preferences of the user. The settings for that system behavior can be obtained using the [ApplicationLanguages.Languages](applicationlanguages_languages.md) property. The PrimaryLanguageOverride property is used to override that behavior by setting a specific language as the first language in the Languages list.

The PrimaryLanguageOverride setting is persisted between sessions. It should not be set each time the app is loaded. It should only be set based on user input presented in settings UI. The property can be read at any time. If the property has never been set, it returns an empty string.

When you set the PrimaryLanguageOverride, this is immediately reflected in the [ApplicationLanguages.Languages](applicationlanguages_languages.md) property. However, this change may not take effect immediately on resources loaded in the app UI. To make sure the app responds to such changes, you can listen to the [QualifierValues](../windows.applicationmodel.resources.core/resourcecontext_qualifiervalues.md) property on a default resource context and take whatever actions may be needed to reload resources. Those requirements may vary depending on the UI framework used by the app, and it may be necessary to restart the app.

## -examples

## -see-also
[ApplicationLanguages.Languages](applicationlanguages_languages.md), [BCP-47 language tags](https://tools.ietf.org/html/bcp47)
