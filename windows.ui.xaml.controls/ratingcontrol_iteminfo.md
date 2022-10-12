---
-api-id: P:Windows.UI.Xaml.Controls.RatingControl.ItemInfo
-api-type: winrt property
---

<!-- Property syntax.
public RatingItemInfo ItemInfo { get;  set; }
-->

# Windows.UI.Xaml.Controls.RatingControl.ItemInfo

## -description

Gets or sets info about the visual states of the items that represent a rating.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.RatingControl.ItemInfo](/windows/winui/api/microsoft.ui.xaml.controls.ratingcontrol.iteminfo) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<RatingControl ItemInfo="resourceReferenceToRatingItemInfo"/>
- or -
<RatingControl>
  <RatingControl.ItemInfo>
    ratingItemInfo
  </RatingControl.ItemInfo>
</RatingControl>
```

## -xaml-values

<dl><dt>resourceReferenceToRatingItemInfo</dt><dd>resourceReferenceToRatingItemInfoA resource reference to an existing RatingItemInfo-derived object from a resources collection. The resource reference must specify the desired RatingItemInfo by key through a {StaticResource} markup extension usage.</dd>
<dt>ratingItemInfo</dt><dd>ratingItemInfoDefinition for the RatingItemInfo-derived object.</dd>
</dl>

## -property-value

A RatingItemInfo-derived object that contains details about the visual states of the items that represent a rating.

## -remarks

You can set the ItemInfo property to replace the default stars with other glyphs or images that represent a rating.

## -see-also

## -examples

