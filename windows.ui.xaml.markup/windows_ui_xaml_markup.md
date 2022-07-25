---
-api-id: N:Windows.UI.Xaml.Markup
-api-type: winrt namespace
---

# Windows.UI.Xaml.Markup

## -description
Provides XAML language support API for UWP app and the Windows Runtime.



## -remarks
Many of the types in this namespace are infrastructure or types that support uncommon scenarios. But there are two types in this namespace that apps might use in more typical app scenarios.
+ [XamlParseException](/dotnet/api/system.xaml.xamlparseexception) is the specialized exception that is thrown by the Windows Runtime XAML parser in cases where it attempts to load XAML but can't generate the expected run-time object tree from that XAML. Most of the time any problems with XAML are detectable at design-time, but it's still possible for problems to occur that would only be known at run-time, in which case you get a [XamlParseException](/dotnet/api/system.xaml.xamlparseexception). [XamlParseException](/dotnet/api/system.xaml.xamlparseexception) is only thrown if your app is written using C# or Microsoft Visual Basic (Visual C++ component extensions (C++/CX) uses [Platform::COMException](/cpp/cppcx/platform-comexception-class) instead).
+ [XamlReader](xamlreader.md) is a static class that can parse XAML and produce object trees. This class enables run-time access to the Windows Runtime XAML parser, the same parser that's used when XAML UI definition pages are parsed into object representations when an app starts. You can then connect the generated object tree to other existing UI elements and make the new objects appear in your UI.


## -examples

## -see-also
[XAML overview](/windows/uwp/xaml-platform/xaml-overview)
