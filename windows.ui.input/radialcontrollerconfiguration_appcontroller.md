---
-api-id: P:Windows.UI.Input.RadialControllerConfiguration.AppController
-api-type: winrt property
---

<!-- Property syntax.
public RadialController AppController { get;  set; }
-->

# Windows.UI.Input.RadialControllerConfiguration.AppController

## -description
Gets or sets whether the [RadialController](radialcontroller.md) object is bound to the main application process rather than a specific app view (or top-level window). 

If AppController is set, that radial controller (and menu) is used for the top-level window and all views in the application process (overriding any individual view controllers you have defined). 

> [!NOTE]
> You must also set [IsAppControllerEnabled](radialcontrollerconfiguration_isappcontrollerenabled.md) to **true**. 

## -property-value
The [RadialController](radialcontroller.md) object to bind to the active application.

## -remarks
We recommend creating an app controller in the [Loaded](/uwp/api/windows.ui.xaml.frameworkelement.Loaded) handler of your app's main page (or equivalent).

## -examples

## -see-also

[IsAppControllerEnabled](radialcontrollerconfiguration_isappcontrollerenabled.md)

