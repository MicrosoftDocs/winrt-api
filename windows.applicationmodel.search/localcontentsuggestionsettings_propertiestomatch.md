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

Adding properties to this list limits local suggestions to the values of the specified properties for local, indexed files. For example, if you want to limit suggestions to musical artists, you would append the "System.Music.AlbumArtist" (Album artists) or the "System.Music.Artist" (Contributing artists) property to the [PropertiesToMatch](localcontentsuggestionsettings_propertiestomatch.md) list.

Adding properties to this list limits local suggestions to local, indexed files that have the listed properties.


<!--{annotation author="grerol" time="7/18/2011 3:39:00 PM"}TODO: Need to insert or link to a list of file props. Apparently, they're listed in the Type Ahead Spec.-->

## -examples

## -see-also
[Access to user resources using the Windows Runtime](http://msdn.microsoft.com/library/7b4402ea-55f6-438d-b9d1-8e65d56c8f42), [Quickstart: Adding search](http://msdn.microsoft.com/library/d412c562-22d2-41c4-9f27-27503b89b9e9), [Search contract sample](http://go.microsoft.com/fwlink/p/?linkid=234892), [Object class](https://msdn.microsoft.com/library/system.object.aspx), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [LocalContentSuggestionSettings.Enabled](localcontentsuggestionsettings_enabled.md), [SearchPane.SetLocalContentSuggestionSettings](searchpane_setlocalcontentsuggestionsettings.md)