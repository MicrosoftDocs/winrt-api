---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.AreTransportControlsEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool AreTransportControlsEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.AreTransportControlsEnabled

## -description
Gets or sets a value that determines whether the standard transport controls are enabled.


## -xaml-syntax
```xaml
<MediaElement AreTransportControlsEnabled="bool" />
```


## -property-value
**true** if the standard transport controls are enabled; otherwise, **false**. The default is **false**.

## -remarks
The transport controls are exposed as a [MediaTransportControls](mediatransportcontrols.md) object that you can access through the [MediaElement.TransportControls](mediaelement_transportcontrols.md) property. See [MediaTransportControls](mediatransportcontrols.md) for more info.

If AreTransportControlsEnabled is **true**, the standard transport controls are enabled and displayed on the [MediaElement](mediaelement.md). If AreTransportControlsEnabled is **false**, the standard transport controls are not enabled and are not displayed.

The transport controls hide themselves after a short period of no user interaction with the [MediaElement](mediaelement.md). They reappear when the user interacts with the [MediaElement](mediaelement.md).

If the [Width](../windows.ui.xaml/frameworkelement_width.md) of [MediaElement](mediaelement.md) is not sufficient to display all of the transport controls, a subset of the controls are displayed.

### Notes for previous versions

> **Windows 8.1**
> You can't access and modify the built-in transport controls. If you create custom transport controls for your app, set this property to **false** to disable the built-in controls.

## -examples
Here is some code that creates a [MediaElement](mediaelement.md) with the built-in transport controls enabled and the [AutoPlay](mediaelement_autoplay.md) property set to **false.**



[!code-xaml[BasicMediaElementControls](../windows.ui.xaml.controls/code/MediaPlayback2/csharp/MainPage.xaml#SnippetBasicMediaElementControls)]

## -see-also
