---
-api-id: P:Windows.ApplicationModel.Search.LocalContentSuggestionSettings.AqsFilter
-api-type: winrt property
---

<!-- Property syntax
public string AqsFilter { get;  set; }
-->

# Windows.ApplicationModel.Search.LocalContentSuggestionSettings.AqsFilter

## -description
An Advanced Query Syntax (AQS) string that limits the types and kinds of files that are used to provide suggestions. If no Advanced Query Syntax (AQS) string is specified, suggestions are provided from all local files in locations specified by the [locations](localcontentsuggestionsettings_locations.md) property.

## -property-value
The Advanced Query Syntax (AQS) string that is used to refine which local, indexed files are used to provide suggestions. By default, this string is empty. Learn more about Advanced Query Syntax (AQS) in [](https://msdn.microsoft.com/library/8e55bd40-c7cf-44a6-bc18-24bc7a267779).


## -remarks
If local suggestions are disabled, this property has no effect. Set [localContentSuggestionSettings.enabled](localcontentsuggestionsettings_enabled.md) property to true to display local suggestions in the search pane.

Use an AQS filter to help keep local suggestions relevant. For example, if your app is a video player, you may want to limit suggestions to videos or a specific file type.

<!--This allows the developer to refine the file types or kinds that they want to be used for local content suggestions since they may only service specific files in their Search Results.  For example, if the developer specifies �Kind:music or Type:avi� they will only receive suggestions from music or avi files.-->

## -examples
The [Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample/C%23) demonstrates how to use Advanced Query Syntax (AQS) to provide local suggestions from music files:



[!code-js[lssettings_aqs_js](../windows.applicationmodel.search/code/SearchContract/js/js/scenario4.js#Snippetlssettings_aqs_js)]

## -see-also
[](https://msdn.microsoft.com/library/8e55bd40-c7cf-44a6-bc18-24bc7a267779), [Quickstart: Adding search](https://docs.microsoft.com/previous-versions/windows/apps/hh465238(v=win.10)), [Search contract sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [Object class](https://docs.microsoft.com/dotnet/api/system.object?redirectedfrom=MSDN), [LocalContentSuggestionSettings class](localcontentsuggestionsettings.md), [SearchPane.SetLocalContentSuggestionSettings method](searchpane_setlocalcontentsuggestionsettings_156524340.md)
