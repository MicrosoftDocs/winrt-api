---
-api-id: M:Windows.ApplicationModel.Search.SearchPane.SetLocalContentSuggestionSettings(Windows.ApplicationModel.Search.LocalContentSuggestionSettings)
-api-type: winrt method
---

<!-- Method syntax
public void SetLocalContentSuggestionSettings(Windows.ApplicationModel.Search.LocalContentSuggestionSettings settings)
-->

# Windows.ApplicationModel.Search.SearchPane.SetLocalContentSuggestionSettings

## -description
Specifies whether suggestions based on local files are automatically displayed in the search pane, and defines the criteria that Windows uses to locate and filter these suggestions.

## -parameters
### -param settings
The new settings for local content suggestions.

## -remarks
> [!NOTE]
> An app can't use both the search box ([Windows.UI.Xaml.Controls.SearchBox](../windows.ui.xaml.controls/searchbox.md) for UWP app using C++, C#, or Visual Basic, [WinJS.UI.SearchBox](/previous-versions/windows/apps/dn301949(v=win.10)) for Windows app using JavaScript) and the [SearchPane](searchpane.md). Using both the search box and the search pane in the same app causes the app to throw an exception with this message: "Cannot create instance of type 'Windows.UI.Xaml.Controls.SearchBox.'"

When local content suggestions are enabled, Windows will provide search suggestions from the user's local files as the user enters query text. For example, a picture application can configure local content suggestions so that search suggestions come only from a particular kind of image file that is stored in the user's picture library.




## -examples
The [Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample) demonstrates how to customize local suggestions by restricting the locations and kinds of files that the suggestions are based on.

> [!TIP]
> You should add this code to your app's global scope and run it as soon as your app is launched.

```csharp
// Have Windows provide suggestions from local files.
// This code should be placed in your apps global scope and run as soon as your app is launched.
var settings = new LocalContentSuggestionSettings();
settings.Enabled = true;
if (isLocal)
{
    settings.Locations.Add(KnownFolders.MusicLibrary);
    settings.AqsFilter = "kind:Music";
}
SearchPane.GetForCurrentView().SetLocalContentSuggestionSettings(settings);
```

```javascript
var settings = new Windows.ApplicationModel.Search.LocalContentSuggestionSettings();
settings.enabled = true;
settings.locations.append(Windows.Storage.KnownFolders.musicLibrary);
settings.aqsFilter = "kind:=music";

Windows.ApplicationModel.Search.SearchPane.getForCurrentView().setLocalContentSuggestionSettings(settings);
```

In the example, suggestions are restricted to one kind of file, music files, using an Advanced Query Syntax (AQS) string. Two of the most common Advanced Query Syntax (AQS) filters restrict based on file kind, like "kind:=.music" in the example; and based on file name extension, like "ext:=.mp3". You can learn more about AQS in [Advanced Query Syntax (AQS)](/windows/desktop/lwef/-search-2x-wds-aqsreference).

## -see-also
[](https://msdn.microsoft.com/library/8e55bd40-c7cf-44a6-bc18-24bc7a267779), [Quickstart: Adding search](/previous-versions/windows/apps/hh465238(v=win.10)), [Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [SearchPane class](searchpane.md)
