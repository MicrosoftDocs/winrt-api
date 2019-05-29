---
-api-id: P:Windows.ApplicationModel.Search.LocalContentSuggestionSettings.PropertiesToMatch
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> PropertiesToMatch { get; }
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings.PropertiesToMatch

## -description
A list of the file properties whose values are used to provide suggestions from local files. If the list is empty, all of the file properties that are available for suggestions are used.

## -property-value
The list of the file properties that are used to provide suggestions from local files. By default, this list is empty and all of the file properties that are available for suggestions are used.

## -remarks
If local suggestions are disabled, this property has no effect.

Adding properties to this list limits local suggestions to the values of the specified properties for local, indexed files. For example, if you want to limit suggestions to musical artists, you would append the "System.Music.AlbumArtist" (Album artists) or the "System.Music.Artist" (Contributing artists) property to the PropertiesToMatch list.

Adding properties to this list limits local suggestions to local, indexed files that have the listed properties.




## -examples

## -see-also
[Access to user resources using the Windows Runtime](https://docs.microsoft.com/previous-versions/windows/apps/hh464936(v=win.10)), [Quickstart: Adding search](https://docs.microsoft.com/previous-versions/windows/apps/hh465238(v=win.10)), [Search contract sample](https://go.microsoft.com/fwlink/p/?linkid=234892), [Object class](https://docs.microsoft.com/dotnet/api/system.object?redirectedfrom=MSDN), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [LocalContentSuggestionSettings.Enabled](localcontentsuggestionsettings_enabled.md), [SearchPane.SetLocalContentSuggestionSettings](searchpane_setlocalcontentsuggestionsettings_156524340.md)
