---
-api-id: T:Windows.ApplicationModel.Search.LocalContentSuggestionSettings
-api-type: winrt class
---

<!-- Class syntax.
public class LocalContentSuggestionSettings : Windows.ApplicationModel.Search.ILocalContentSuggestionSettings
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings

## -description
Stores settings that determine whether the app provides suggestions based on local files, and that define the criteria used to locate and filter these suggestions.

## -remarks
The suggestions that the app provides are based on metadata fields and properties on the user's local, indexed files.

If enabled, local suggestions are displayed in the search pane when the user enters a query in the search box.

Disable these suggestions by setting the [enabled](localcontentsuggestionsettings_enabled.md) property to false.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

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

In the example, suggestions are restricted to one kind of file, music files, using an Advanced Query Syntax (AQS) string. Two of the most common Advanced Query Syntax (AQS) filters restrict based on file kind, like "kind:=.music" in the example; and based on file name extension, like "ext:=.mp3". You can learn more about Advanced Query Syntax (AQS) in [](https://msdn.microsoft.com/library/8e55bd40-c7cf-44a6-bc18-24bc7a267779).

## -see-also
[Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [Quickstart: Adding search](/previous-versions/windows/apps/hh465238(v=win.10)), [](https://msdn.microsoft.com/library/8e55bd40-c7cf-44a6-bc18-24bc7a267779), [SearchPane class](searchpane.md), [SearchPane.setLocalContentSuggestionSettings method](searchpane_setlocalcontentsuggestionsettings_156524340.md)
