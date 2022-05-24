---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.IsFullWindow
-api-type: winrt property
---

<!-- Property syntax
public bool IsFullWindow { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.IsFullWindow

## -description
Gets a value that specifies if the [MediaElement](mediaelement.md) is rendering in full window mode. Setting this property enables or disables full window rendering.


## -xaml-syntax
```xaml
<MediaElement IsFullWindow="bool" />
```


## -property-value
**true** if the [MediaElement](mediaelement.md) is in full window mode; otherwise, **false**. The default is **false**.

## -remarks
Setting and un-setting this property enables and disables full window rendering.

Always use the IsFullWindow property to enable and disable full window rendering. This ensures system level optimizations are used during media playback.

When in full-window mode, input events received on the [MediaElement](mediaelement.md) will still route through to the visual tree in the background. For example, if the [MediaElement](mediaelement.md) is in a [ListBox](listbox.md), turning the scroll wheel could cause the [ListBox](listbox.md) to scroll in the background. This can cause unexpected behavior. If input events should not be routed when in full-window mode, the [MediaElement](mediaelement.md) should handle the events.

## -examples

## -see-also
