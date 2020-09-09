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
 XamlUIPresenter is not intended for general Microsoft DirectX and Windows Runtime interoperation scenarios. You cannot use this API in a UWP app that you submit to the Microsoft Store, it will not pass certification.

For techniques for XAML-Microsoft DirectX interoperation functionality, instead see [DirectX and XAML interop](/previous-versions/windows/apps/hh825871(v=win.10)).

 XamlUIPresenter is specifically intended for interoperation with designer surfaces that represent Windows Runtime objects or their XAML markup as graphical objects in a Microsoft DirectX  UI.

 XamlUIPresenter has no constructor in the Windows Runtime. To get an instance of XamlUIPresenter you must invoke a Component Object Model (COM) function ([CreateXamlUIPresenter](/windows/desktop/WinRT/createxamluipresenter)) as exported from a Windows Runtime DLL. For example, as part of a C# application you can import the Component Object Model (COM) library:

```csharp
[DllImport("windows.ui.xaml.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
public static extern void CreateXamlUIPresenter(
    IViewObjectPresentNotifySite presentSite, out Windows.UI.Xaml.Hosting.XamlUIPresenter presenter
);

```

<!--These instructions are vague By Design. The product unit does not want this API to be a gate for general interop, it was intended to be limited to this Blend designer scenario. Anyone that can't figure out what to do based on the general hint that this is really a COM API shouldn't be messing with this type and is probably envisioning unsupported scenarios.-->

## -examples

## -see-also
