---
-api-id: M:Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SetLocalContentSuggestionSettings(Windows.ApplicationModel.Search.LocalContentSuggestionSettings)
-api-type: winrt method
---

<!-- Method syntax
public void SetLocalContentSuggestionSettings(Windows.ApplicationModel.Search.LocalContentSuggestionSettings settings)
-->

# Windows.ApplicationModel.Search.Core.SearchSuggestionManager.SetLocalContentSuggestionSettings

## -description
Specifies whether suggestions based on local files are added automatically to the [Suggestions](searchsuggestionmanager_suggestions.md) collection, and defines the criteria that Windows uses to locate and filter these suggestions.

## -parameters
### -param settings
The new settings for local content suggestions.

## -remarks
When local content suggestions are enabled, Windows provides search suggestions from the user's local files as the user enters query text. For example, a picture application can configure local content suggestions so that search suggestions come only from a particular kind of image file that is stored in the user's picture library.

Changing the value of the [SetLocalContentSuggestionSettings](searchsuggestionmanager_setlocalcontentsuggestionsettings.md) property doesn't immediately update the suggestions in the [Suggestions](searchsuggestionmanager_suggestions.md) property. Call [SetQuery](searchsuggestionmanager_setquery.md) to update the [Suggestions](searchsuggestionmanager_suggestions.md) property.

## -examples

## -see-also
[SearchBox](../windows.ui.xaml.controls/searchbox.md)