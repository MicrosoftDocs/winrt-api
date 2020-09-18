---
-api-id: P:Windows.UI.Input.RadialControllerConfiguration.IsAppControllerEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsAppControllerEnabled { get;  set; }
-->

# Windows.UI.Input.RadialControllerConfiguration.IsAppControllerEnabled

## -description
Gets or sets whether the [RadialController](radialcontroller.md) object is enabled as an  [AppController](radialcontrollerconfiguration_appcontroller.md) and controller events can be handled by your app.

## -property-value
**true** if enabled. Otherwise, **false**. The default is **false**.

## -remarks
If [AppController](radialcontrollerconfiguration_appcontroller.md) is set, that radial controller (and menu) is used for all top-level windows in the application process (all individual view controllers are overridden).

We recommend creating an app controller in the [Loaded](/uwp/api/windows.ui.xaml.frameworkelement.Loaded) handler of your app's main page (or equivalent).


## -examples

## -see-also

[AppController](radialcontrollerconfiguration_appcontroller.md)

