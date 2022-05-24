---
-api-id: P:Windows.UI.Xaml.Controls.MediaPlayerElement.IsFullWindow
-api-type: winrt property
---

<!-- Property syntax
public bool IsFullWindow { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaPlayerElement.IsFullWindow

## -description
Gets or sets a value that specifies if the [MediaPlayerElement](mediaplayerelement.md) is rendering in full window mode.


## -xaml-syntax
```xaml
<MediaPlayerElement IsFullWindow="bool" />
```


## -property-value
**true** if the [MediaPlayerElement](mediaplayerelement.md) is in full window mode; otherwise, **false**. The default is **false**.

## -remarks
Setting and un-setting this property enables and disables full window rendering.

Always use the IsFullWindow property to enable and disable full window rendering. This ensures system level optimizations are used during media playback.

When in full-window mode, input events received on the [MediaPlayerElement](mediaplayerelement.md) will still route through to the visual tree in the background. For example, if the [MediaPlayerElement](mediaplayerelement.md) is in a [ListBox](listbox.md), turning the scroll wheel could cause the [ListBox](listbox.md) to scroll in the background. This can cause unexpected behavior. If input events should not be routed when in full-window mode, the [MediaPlayerElement](mediaplayerelement.md) should handle the events.

## -examples

## -see-also
