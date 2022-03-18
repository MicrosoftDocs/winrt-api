---
-api-id: T:Windows.UI.Xaml.Hosting.DesignerAppManager
-api-type: winrt class
---

<!-- Class syntax.
public class DesignerAppManager : IClosable
-->

# Windows.UI.Xaml.Hosting.DesignerAppManager

## -description

Manages an application in a XAML design surface that runs in a regular UWP context, compared to the legacy designer which uses the [XamlUIPresenter](/uwp/api/Windows.UI.Xaml.Hosting.XamlUIPresenter) and runs in a Win32 process. The process is required to specify the NoUIEntryPoints-DesignModeV2 [DisplayName](/uwp/schemas/appxpackage/uapmanifestschema/element-displayname) property in the .APPX in order to be activated successfully in this mode. The launched application will not show up in the TaskBar or TaskView switcher.

## -remarks

## -see-also

## -examples

