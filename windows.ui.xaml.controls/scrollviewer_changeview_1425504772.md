---
-api-id: M:Windows.UI.Xaml.Controls.ScrollViewer.ChangeView(Windows.Foundation.IReference{System.Double},Windows.Foundation.IReference{System.Double},Windows.Foundation.IReference{System.Single})
-api-type: winrt method
---

<!-- Method syntax
public bool ChangeView(Windows.Foundation.IReference<System.Double> horizontalOffset, Windows.Foundation.IReference<System.Double> verticalOffset, Windows.Foundation.IReference<System.Single> zoomFactor)
-->

# Windows.UI.Xaml.Controls.ScrollViewer.ChangeView

## -description
Causes the [ScrollViewer](scrollviewer.md) to load a new view into the viewport using the specified offsets and zoom factor.



## -parameters
### -param horizontalOffset
A value between 0 and [ScrollableWidth](scrollviewer_scrollablewidth.md) that specifies the distance the content should be scrolled horizontally.

### -param verticalOffset
A value between 0 and [ScrollableHeight](scrollviewer_scrollableheight.md) that specifies the distance the content should be scrolled vertically.

### -param zoomFactor
A value between [MinZoomFactor](scrollviewer_minzoomfactor.md) and [MaxZoomFactor](scrollviewer_maxzoomfactor.md) that specifies the required target [ZoomFactor](scrollviewer_maxzoomfactor.md).

## -returns
**true** if the view is changed; otherwise, **false**.

## -remarks
You can set parameter values to **null** to use this method to scroll only horizontally, only vertically, or to only change the zoom factor.

## -examples
This code results in a [ScrollViewer](scrollviewer.md) named `myScrollViewer` being scrolled to a horizontal offset of 2.

```csharp
bool flag = myScrollViewer.ChangeView(2, null, null); 
```

```cppwinrt
bool flag{ myScrollViewer.ChangeView(Windows::Foundation::IReference<double>{2.f}, nullptr, nullptr) };
```

## -see-also
[ChangeView(IReference(Double), IReference(Double), IReference(Single), Boolean)](scrollviewer_changeview_579623452.md)
