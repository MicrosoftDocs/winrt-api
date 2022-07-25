---
-api-id: P:Windows.UI.Xaml.Controls.ListViewBase.IsSwipeEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsSwipeEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.ListViewBase.IsSwipeEnabled

## -description
Gets or sets a value that indicates whether the view supports discrete input processing for a *swipe* interaction.



## -xaml-syntax
```xaml
<listViewBase IsSwipeEnabled="bool" .../>
```


## -property-value
**true** if discrete input processing for *swipe* interactions is enabled; otherwise, **false**. The default is **true**.

## -remarks
Setting IsSwipeEnabled to **false** disables some default touch interactions, so it should be set to **true** when these interactions are needed. For example:
+ If item selection is enabled and you set IsSwipeEnabled to **false**, a user can deselect items by right-clicking with the mouse, but can't deselect an item with touch by using a *swipe* gesture.
+ If you set [CanDragItems](listviewbase_candragitems.md) to **true** and IsSwipeEnabled to **false**, a user can drag items with the mouse, but not with touch.
+ If you set [CanReorderItems](listviewbase_canreorderitems.md) to **true** and IsSwipeEnabled to **false**, a user can reorder items with the mouse, but not with touch.


You typically set IsSwipeEnabled to **false** to disable *swipe* animations when items in the view don't support interactions that use the *swipe* gesture, like deselecting, dragging, and reordering. Disabling the animation when it's not needed can improve the performance of your app.

## -examples

## -see-also
[Touch interactions](/windows/uwp/design/input/touch-interactions)
