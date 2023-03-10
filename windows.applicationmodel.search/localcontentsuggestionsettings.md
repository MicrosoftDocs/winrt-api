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

> [!IMPORTANT]
> To implement search in an app for Windows 10 or later, use [AutoSuggestBox](/uwp/api/windows.ui.xaml.controls.autosuggestbox). See [Auto-suggest box](/windows/apps/design/controls/auto-suggest-box) for more info.
>
> You should not use [Windows.ApplicationModel.Search](/uwp/api/windows.applicationmodel.search) APIs ([SearchPane](/uwp/api/windows.applicationmodel.search.searchpane), `SearchContract`) or [SearchBox](../windows.ui.xaml.controls/searchbox.md) APIs in apps for Windows 10 or later.

The suggestions that the app provides are based on metadata fields and properties on the user's local, indexed files.

If enabled, local suggestions are displayed in the search pane when the user enters a query in the search box.

Disable these suggestions by setting the [Enabled](localcontentsuggestionsettings_enabled.md) property to `false`.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples

## -see-also

[Search contract sample (Windows 8)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Search%20contract%20sample), [SearchPane class](searchpane.md), [SearchPane.setLocalContentSuggestionSettings method](searchpane_setlocalcontentsuggestionsettings_156524340.md)