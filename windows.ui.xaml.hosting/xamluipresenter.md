---
-api-id: T:Windows.UI.Xaml.Hosting.XamlUIPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class XamlUIPresenter : Windows.UI.Xaml.Hosting.IXamlUIPresenter
-->

# Windows.UI.Xaml.Hosting.XamlUIPresenter

## -description
Enables presenting a visual tree on a Microsoft Direct3D surface. This type is used for design tool hosting scenarios and is not intended for general use.

## -remarks
 [XamlUIPresenter](xamluipresenter.md) is not intended for general Microsoft DirectX and Windows Runtime interoperation scenarios. You cannot use this API in a Windows Store app that you submit to the Windows Store, it will not pass certification.

For techniques for XAML-Microsoft DirectX interoperation functionality, instead see [DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f).

 [XamlUIPresenter](xamluipresenter.md) is specifically intended for interoperation with designer surfaces that represent Windows Runtime objects or their XAML markup as graphical objects in a Microsoft DirectX  UI.

 [XamlUIPresenter](xamluipresenter.md) has no constructor in the Windows Runtime. To get an instance of [XamlUIPresenter](xamluipresenter.md) you must invoke a Component Object Model (COM) function ([CreateXamlUIPresenter](http://msdn.microsoft.com/library/3160e4c2-39d3-8ff5-ed37-78e645d1ac2e)) as exported from a Windows Runtime DLL. For example, as part of a C# application you can import the Component Object Model (COM) library:

```csharp
[DllImport("windows.ui.xaml.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
public static extern void CreateXamlUIPresenter(
    IViewObjectPresentNotifySite presentSite, out Windows.UI.Xaml.Hosting.XamlUIPresenter presenter
);

```

<!--These instructions are vague By Design. The product unit does not want this API to be a gate for general interop, it was intended to be limited to this Blend designer scenario. Anyone that can't figure out what to do based on the general hint that this is really a COM API shouldn't be messing with this type and is probably envisioning unsupported scenarios.-->

## -examples

## -see-also