---
-api-id: T:Windows.UI.Xaml.Controls.MediaTransportControlsHelper
-api-type: winrt class
---

<!-- Class syntax.
public class MediaTransportControlsHelper : Windows.UI.Xaml.Controls.IMediaTransportControlsHelper
-->

# Windows.UI.Xaml.Controls.MediaTransportControlsHelper

## -description
Provides properties and methods to customize media transport controls.

Equivalent WinUI class: [Microsoft.UI.Xaml.Controls.MediaTransportControlsHelper](/windows/winui/api/microsoft.ui.xaml.controls.mediatransportcontrolshelper).

## -remarks
You do not instantiate this class directly. To use this class, set the MediaTransportControlsHelper.DropoutOrder attached property on a control in the template of a [MediaTransportControls](mediatransportcontrols.md) object.

### XAML attached properties

MediaTransportControlsHelper is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| DropoutOrder | Gets or sets the priority order in which a transport control drops out to the overflow menu as the window shrinks.<ul><li>Type: Nullable&lt;int></li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.mediatransportcontrolshelper.dropoutorderproperty">DropoutOrderProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.mediatransportcontrolshelper.getdropoutorder">GetDropoutOrder</a>, <a href="/uwp/api/windows.ui.xaml.controls.mediatransportcontrolshelper.setdropoutorder">SetDropoutOrder</a></li></ul> If you re-template [MediaTransportControls](mediatransportcontrols.md), you can set this attached property on individual controls to specify the order in which they drop out to the overflow menu.|

## -examples

## -see-also
