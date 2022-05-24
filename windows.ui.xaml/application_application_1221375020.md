---
-api-id: M:Windows.UI.Xaml.Application.#ctor
-api-type: winrt method
---

<!-- Method syntax
public Application()
-->

# Windows.UI.Xaml.Application.Application

## -description
Initializes a new instance of the [Application](application.md) class.


## -remarks
The [Application](application.md) object is typically provided in the initial XAML for App.xaml. The default project templates in Visual Studio generate an `App` class that derives from [Application](application.md). This class associates itself with the XAML by calling the generated `InitializeComponent` method in its constructor. You can add additional initialization code to the `App` constructor, but you will typically only add code to associate handlers to [Application](application.md) events. For other initialization code, you should override one or more initialization methods such as [OnLaunched](application_onlaunched_859642554.md).

## -examples

## -see-also
