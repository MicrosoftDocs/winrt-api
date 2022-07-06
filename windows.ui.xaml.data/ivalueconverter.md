---
-api-id: T:Windows.UI.Xaml.Data.IValueConverter
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IValueConverter : 
-->

# Windows.UI.Xaml.Data.IValueConverter

## -description
Exposes methods that allow the data to be modified as it passes through the binding engine.



## -examples
The following example shows how to implement the IValueConverter interface and use the converter when data binding to a collection of objects.

> [!NOTE]
> If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) (or C++/CX), then see [Formatting or converting data values for display](/windows/uwp/data-binding/data-binding-quickstart#formatting-or-converting-data-values-for-display) for more code examples of authoring your own value converter. That topic also discusses how you could use the [ConverterParameter](binding_converterparameter.md) attribute with C++ string-formatting functions.

[!code-xaml[1](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/csharp/Page.xaml#Snippet1)]

[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/csharp/Page.xaml.cs#Snippet2)]

```cppwinrt
// pch.h
#include <winrt/Windows.Globalization.h>

// MainPage.idl
namespace ConverterParameterEx
{
    [default_interface]
    runtimeclass MainPage : Windows.UI.Xaml.Controls.Page
    {
        MainPage();
    }
}

<!-- MainPage.xaml -->
<Page
    x:Class="ConverterParameterEx.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:ConverterParameterEx"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">

    <local:Page/>
</Page>

// MainPage.h
#pragma once

#include "MainPage.g.h"

namespace winrt::ConverterParameterEx::implementation
{
    struct MainPage : MainPageT<MainPage>
    {
        MainPage();
    };
}

namespace winrt::ConverterParameterEx::factory_implementation
{
    struct MainPage : MainPageT<MainPage, implementation::MainPage>
    {
    };
}

// MainPage.cpp
#include "pch.h"
#include "MainPage.h"
#include "MainPage.g.cpp"

using namespace winrt;
using namespace Windows::UI::Xaml;

namespace winrt::ConverterParameterEx::implementation
{
    MainPage::MainPage()
    {
        InitializeComponent();
    }
}

// Page.idl
namespace ConverterParameterEx
{
    [default_interface]
    runtimeclass Page : Windows.UI.Xaml.Controls.UserControl
    {
        Page();
        Windows.Foundation.Collections.IVector<IInspectable> MyMusic{ get; };
    }
}

<!-- Page.xaml -->
<!-- see listing above -->

// Page.h
#pragma once

#include "winrt/Windows.UI.Xaml.h"
#include "winrt/Windows.UI.Xaml.Markup.h"
#include "winrt/Windows.UI.Xaml.Interop.h"
#include "winrt/Windows.UI.Xaml.Controls.Primitives.h"
#include "Page.g.h"
#include "DateFormatter.h"

namespace winrt::ConverterParameterEx::implementation
{
    struct Page : PageT<Page>
    {
        Page();
        Windows::Foundation::Collections::IVector<Windows::Foundation::IInspectable> MyMusic();

    private:
        Windows::Foundation::Collections::IVector<Windows::Foundation::IInspectable> m_myMusic;
    };
}

namespace winrt::ConverterParameterEx::factory_implementation
{
    struct Page : PageT<Page, implementation::Page>
    {
    };
}

// Page.cpp
#include "pch.h"
#include "Page.h"
#if __has_include("Page.g.cpp")
#include "Page.g.cpp"
#endif
#include "Recording.h"

using namespace winrt;
using namespace Windows::UI::Xaml;

namespace winrt::ConverterParameterEx::implementation
{
    Page::Page()
    {
        InitializeComponent();

        std::vector<Windows::Foundation::IInspectable> recordings;

        Windows::Globalization::Calendar releaseDateTime;
        releaseDateTime.Month(7); releaseDateTime.Day(8); releaseDateTime.Year(1748);
        recordings.push_back(winrt::make<Recording>(L"Johann Sebastian Bach", L"Mass in B minor", releaseDateTime));

        releaseDateTime = Windows::Globalization::Calendar{};
        releaseDateTime.Month(11); releaseDateTime.Day(2); releaseDateTime.Year(1805);
        recordings.push_back(winrt::make<Recording>(L"Ludwig van Beethoven", L"Third Symphony", releaseDateTime));

        releaseDateTime = Windows::Globalization::Calendar{};
        releaseDateTime.Month(3); releaseDateTime.Day(12); releaseDateTime.Year(1737);
        recordings.push_back(winrt::make<Recording>(L"George Frideric Handel", L"Serse", releaseDateTime));

        m_myMusic = winrt::single_threaded_observable_vector<Windows::Foundation::IInspectable>(std::move(recordings));

        MusicCombo().DataContext(m_myMusic);
    }

    Windows::Foundation::Collections::IVector<Windows::Foundation::IInspectable> Page::MyMusic() { return m_myMusic; }
}

// Recording.idl
namespace ConverterParameterEx
{
    [bindable]
    runtimeclass Recording
    {
        Recording(String artist, String name, Windows.Globalization.Calendar releaseDate);
        String Artist{ get; };
        String Name{ get; };
        Windows.Globalization.Calendar ReleaseDate{ get; };
    }
}

// Recording.h
#pragma once
#include "Recording.g.h"

namespace winrt::ConverterParameterEx::implementation
{
    struct Recording : RecordingT<Recording>
    {
        Recording() = default;

        Recording(hstring const& artist, hstring const& name, winrt::Windows::Globalization::Calendar const& releaseDate);
        hstring Artist();
        hstring Name();
        winrt::Windows::Globalization::Calendar ReleaseDate();

    private:
        std::wstring m_artist;
        std::wstring m_name;
        Windows::Globalization::Calendar m_releaseDate;
    };
}
namespace winrt::ConverterParameterEx::factory_implementation
{
    struct Recording : RecordingT<Recording, implementation::Recording>
    {
    };
}

// Recording.cpp
#include "pch.h"
#include "Recording.h"
#include "Recording.g.cpp"

namespace winrt::ConverterParameterEx::implementation
{
    Recording::Recording(hstring const& artist, hstring const& name, Windows::Globalization::Calendar const& releaseDate) :
        m_artist{ artist.c_str() },
        m_name{ name.c_str() },
        m_releaseDate{ releaseDate } {}

    hstring Recording::Artist() { return hstring{ m_artist }; }
    hstring Recording::Name() { return hstring{ m_name }; }
    Windows::Globalization::Calendar Recording::ReleaseDate() { return m_releaseDate; }
}

// DateFormatter.idl
namespace ConverterParameterEx
{
    runtimeclass DateFormatter : [default] Windows.UI.Xaml.Data.IValueConverter
    {
        DateFormatter();
    }
}

// DateFormatter.h
#pragma once
#include "DateFormatter.g.h"

namespace winrt::ConverterParameterEx::implementation
{
    struct DateFormatter : DateFormatterT<DateFormatter>
    {
        DateFormatter() = default;

        winrt::Windows::Foundation::IInspectable Convert(winrt::Windows::Foundation::IInspectable const& value, winrt::Windows::UI::Xaml::Interop::TypeName const& targetType, winrt::Windows::Foundation::IInspectable const& parameter, hstring const& language);
        winrt::Windows::Foundation::IInspectable ConvertBack(winrt::Windows::Foundation::IInspectable const& value, winrt::Windows::UI::Xaml::Interop::TypeName const& targetType, winrt::Windows::Foundation::IInspectable const& parameter, hstring const& language);
    };
}
namespace winrt::ConverterParameterEx::factory_implementation
{
    struct DateFormatter : DateFormatterT<DateFormatter, implementation::DateFormatter>
    {
    };
}

// DateFormatter.cpp
#include "pch.h"
#include "DateFormatter.h"
#include "DateFormatter.g.cpp"

namespace winrt::ConverterParameterEx::implementation
{
    winrt::Windows::Foundation::IInspectable DateFormatter::Convert(winrt::Windows::Foundation::IInspectable const& value, winrt::Windows::UI::Xaml::Interop::TypeName const& targetType, winrt::Windows::Foundation::IInspectable const& parameter, hstring const& language)
    {
        // Retrieve the value as a Calendar.
        Windows::Globalization::Calendar valueAsCalendar{ value.as<Windows::Globalization::Calendar>() };

        std::wstringstream wstringstream;
        wstringstream << valueAsCalendar.MonthAsNumericString().c_str();
        wstringstream << L"/" << valueAsCalendar.DayAsString().c_str();
        wstringstream << L"/" << valueAsCalendar.YearAsString().c_str();
        return winrt::box_value(hstring{ wstringstream.str().c_str() });
    }
    winrt::Windows::Foundation::IInspectable DateFormatter::ConvertBack(winrt::Windows::Foundation::IInspectable const& value, winrt::Windows::UI::Xaml::Interop::TypeName const& targetType, winrt::Windows::Foundation::IInspectable const& parameter, hstring const& language)
    {
        throw hresult_not_implemented();
    }
}
```

[!code-cpp[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/cpp/MainPage.xaml.h#Snippet2)]

[!code-vb[2](../windows.ui.xaml.controls.primitives/code/DataBindingConverterParameterEx/vbnet/Page.xaml.vb#Snippet2)]

## -remarks
You can create a class that allows you to convert the format of your data between the source and the target by inheriting from IValueConverter. For example, you might want to have a list of colors that you store as **RGBA** values, but display them with color names in the UI. By implementing [Convert](ivalueconverter_convert_101701969.md) and [ConvertBack](ivalueconverter_convertback_2106225504.md), you can change the format of the data values as they are passed between the target and source by the binding engine.
You should always implement [Convert](ivalueconverter_convert_101701969.md) with a functional implementation, but it's fairly common to implement [ConvertBack](ivalueconverter_convertback_2106225504.md) so that it reports a not-implemented exception. You only need a [ConvertBack](ivalueconverter_convertback_2106225504.md) method in your converter if you are using the converter for two-way bindings, or using XAML for serialization.

[UnsetValue](../windows.ui.xaml/dependencyproperty_unsetvalue.md) should be returned from an IValueConverter implementation that provides conversion in a data binding to a dependency property, in any case where the converter is unable to convert a source value. Converters shouldn't throw exceptions for that case in [Convert](ivalueconverter_convert_101701969.md); these will surface as run-time exceptions that you'd need to add handling for in [UnhandledException](../windows.ui.xaml/application_unhandledexception.md) or worse yet appear to users as actual run-time exceptions. Converter implementations should follow the general binding pattern that any failed binding does nothing and does not provide a value, and [UnsetValue](../windows.ui.xaml/dependencyproperty_unsetvalue.md) rather than **null** is the sentinel value for that case that the binding engine understands. For more info, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).


> [!NOTE]
> To data-bind to a custom value converter that is written in Visual C++ component extensions (C++/CX), the header file in which the IValueConverter implementation class is defined must be included, directly or indirectly, in one of the code-behind files. For more info, see [Create your first  using C++](/previous-versions/windows/hh465045(v=win.10)).

> [!TIP]
> Some of the default project templates for a UWP app include a helper class, BooleanToVisibilityConverter. This class is an IValueConverter implementation that handles a common custom-control scenario where you use Boolean values from your control logic class to set the [Visibility](../windows.ui.xaml/uielement_visibility.md) value in XAML control templates.

### Migration notes

In the Windows Runtime, the language parameters for IValueConverter methods use strings, as opposed to using [CultureInfo](/dotnet/api/system.globalization.cultureinfo?view=dotnet-uwp-10.0&preserve-view=true) objects as they do in the Windows Presentation Foundation (WPF) and Microsoft Silverlight definitions of the interface.

## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
b4f1-6caf-4128-a61a-4e400b149011)
