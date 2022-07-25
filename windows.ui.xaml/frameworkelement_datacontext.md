---
-api-id: P:Windows.UI.Xaml.FrameworkElement.DataContext
-api-type: winrt property
---

<!-- Property syntax
public object DataContext { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.DataContext

## -description
Gets or sets the data context for a [FrameworkElement](frameworkelement.md). A common use of a data context is when a **FrameworkElement** uses the [{Binding}](/windows/uwp/xaml-platform/binding-markup-extension) markup extension and participates in data binding.



## -xaml-syntax
```xaml
<frameworkElement DataContext="binding"/>
- or -
<frameworkElement DataContext="{StaticResource keyedObject}"/>
```

## -xaml-values
<dl><dt>binding</dt><dd>bindingA binding expression that can reference an existing data context, or a property in the data context. See Data binding overview or {Binding} markup extension.</dd>
<dt>keyedObject</dt><dd>keyedObjectThe x:Key attribute value of an object that exists in an in-scope Resources collection. Typically, this is an object element instantiation of a custom type defined elsewhere in your code, and requires a custom XAML namespace mapping in the ResourceDictionary.</dd>
</dl>

## -property-value
The object to use as data context.

## -remarks
*Data context* is a concept where objects can inherit data binding information from successive parent objects in an object relationship hierarchy.

The most important aspect of data context is the data source that is used for data binding. A typical use of DataContext is to set it directly to a data source object. This data source might be an instance of a class such as a business object. Or you can create a data source as an observable collection, so that the data context enables detecting changes in the backing collection. If the data source is defined by a library that is also included in the project, setting a DataContext is often combined with instantiating the data source as a keyed resource in a [ResourceDictionary](resourcedictionary.md), and then setting the DataContext in XAML with a [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) reference.

Another technique for setting DataContext is to add it to the root of the runtime object tree, as part of app initialization logic, just after calling **InitializeComponent**. This technique is shown in [Data binding overview](/windows/uwp/data-binding/data-binding-quickstart).

In addition to specifying the source, a data context can also store additional characteristics of a binding declaration, such as a path into the data source.

Setting a DataContext is convenient for setting several bindings of different properties on the same object to a shared data context. However, it is valid for a DataContext to be undefined, and for all the necessary binding qualifications to exist in separate binding statements.

How you implement the object data source varies depending on your requirements and your programming language. For more info, see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).

A common scenario for C# and Microsoft Visual Basic data contexts is to use a CLR-defined business object that supports change notification. For a business object, the custom class used as data context typically implements [INotifyPropertyChanged](../windows.ui.xaml.data/inotifypropertychanged.md), so that updates to the data can update a one-way or two-way binding. If the data source is a collection of business objects, it can implement [INotifyCollectionChanged](../windows.ui.xaml.interop/inotifycollectionchanged.md) plus list support ([IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true) or [List<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)), or derive from [ObservableCollection<T>](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true).

## -examples
This example sets the DataContext directly to an instance of a custom class.

If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/intro-to-using-cpp-with-winrt) and the [{Binding}](/windows/uwp/xaml-platform/binding-markup-extension) markup extension, then you'll use the **FrameworkElement::DataContext** property, and the [BindableAttribute](/uwp/api/windows.ui.xaml.data.bindableattribute). If you're using the [{x:Bind}](/windows/uwp/xaml-platform/x-bind-markup-extension) markup extension, then you won't use **FrameworkElement::DataContext** nor the **BindableAttribute**.

For more background on the C++/WinRT code example below (for example, how to use the `.idl` file listing, and what to do with the implementation files that it generates for you), see [XAML controls; bind to a C++/WinRT property](/windows/uwp/cpp-and-winrt-apis/binding-property).

```cppwinrt
// MyColors.idl
namespace MyColorsApp
{
    [bindable]
    [default_interface]
    runtimeclass MyColors : Windows.UI.Xaml.Data.INotifyPropertyChanged
    {
        MyColors();
        Windows.UI.Xaml.Media.SolidColorBrush Brush1;
    }
}

// MyColors.h
#pragma once
#include "MyColors.g.h"
namespace winrt::MyColorsApp::implementation
{
    struct MyColors : MyColorsT<MyColors>
    {
        MyColors() = default;

        Windows::UI::Xaml::Media::SolidColorBrush Brush1();
        void Brush1(Windows::UI::Xaml::Media::SolidColorBrush const& value);
        winrt::event_token PropertyChanged(Windows::UI::Xaml::Data::PropertyChangedEventHandler const& handler);
        void PropertyChanged(winrt::event_token const& token) noexcept;

    private:
        Windows::UI::Xaml::Media::SolidColorBrush m_brush1{ nullptr };
        winrt::event<Windows::UI::Xaml::Data::PropertyChangedEventHandler> m_propertyChanged;
    };
}

namespace winrt::MyColorsApp::factory_implementation
{
    struct MyColors : MyColorsT<MyColors, implementation::MyColors>
    {
    };
}

// MyColors.cpp
#include "pch.h"
#include "MyColors.h"

namespace winrt::MyColorsApp::implementation
{
    Windows::UI::Xaml::Media::SolidColorBrush MyColors::Brush1()
    {
        return m_brush1;
    }

    void MyColors::Brush1(Windows::UI::Xaml::Media::SolidColorBrush const& value)
    {
        if (m_brush1 != value)
        {
            m_brush1 = value;
            m_propertyChanged(*this, Windows::UI::Xaml::Data::PropertyChangedEventArgs{ L"Brush1" });
        }
    }

    winrt::event_token MyColors::PropertyChanged(Windows::UI::Xaml::Data::PropertyChangedEventHandler const& handler)
    {
        return m_propertyChanged.add(handler);
    }

    void MyColors::PropertyChanged(winrt::event_token const& token) noexcept
    {
        m_propertyChanged.remove(token);
    }
}

<!-- MainPage.xaml-->
...
<TextBox x:Name="MyTextBox" Background="{Binding Brush1}"/>
...

// MainPage.h
...
#include "MyColors.h"
#include "MainPage.g.h"
...

// MainPage.cpp
#include "pch.h"
#include "MainPage.h"

using namespace winrt;
using namespace Windows::UI;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Media;

namespace winrt::MyColorsApp::implementation
{
    MainPage::MainPage()
    {
        InitializeComponent();

        // Create an instance of the MyColors class
        // which implements INotifyPropertyChanged.
        winrt::MyColorsApp::MyColors textcolor{ winrt::make<winrt::MyColorsApp::implementation::MyColors>() };

        // Set the Brush1 property value to a new SolidColorBrush
        // with the color Red.
        textcolor.Brush1(SolidColorBrush(Colors::Red()));

        // Set the DataContext of the TextBox named MyTextBox.
        MyTextBox().DataContext(textcolor);
    }
...
}
```

[!code-csharp[DataContext](../windows.ui.xaml.controls.primitives/code/Binding_Simple/csharp/Page.xaml.cs#SnippetDataContext)]

[!code-vb[DataContext](../windows.ui.xaml.controls.primitives/code/Binding_Simple/vbnet/BlankPage.xaml.vb#SnippetDataContext)]

## -see-also
[Binding](../windows.ui.xaml.data/binding.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth), [ObservableCollection<T>](/dotnet/api/system.collections.objectmodel.observablecollection-1?view=dotnet-uwp-10.0&preserve-view=true)
