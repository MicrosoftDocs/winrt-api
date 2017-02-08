---
-api-id: P:Windows.Globalization.ApplicationLanguages.ManifestLanguages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> ManifestLanguages { get; }
-->

# Windows.Globalization.ApplicationLanguages.ManifestLanguages

## -description
Gets the app's declared list of supported languages.

## -property-value
The list of supported languages declared in the app's manifest.

## -remarks
### **Starting in :**

Windows Store app can be deployed using resource packages. When language resource packages are used, the packages that are installed and registered for a given user are determined by the languages in the user's language profile. The set of languages returned by the [ManifestLanguages](applicationlanguages_manifestlanguages.md) property is limited to the languages currently available on the system for the user. Languages included in the main app package manifest will always be returned; languages from resource packs will be returned only if the language is applicable for the user (that is, is in the user's preferences) and that resource package has been installed and registered for the user at the time the property is accessed.

## -examples

## -see-also
