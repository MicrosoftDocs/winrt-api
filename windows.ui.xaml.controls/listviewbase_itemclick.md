---
-api-id: E:Windows.UI.Xaml.Controls.ListViewBase.ItemClick
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.ItemClickEventHandler ItemClick
-->

# Windows.UI.Xaml.Controls.ListViewBase.ItemClick

## -description
Occurs when an item in the list view receives an interaction, and the [IsItemClickEnabled](listviewbase_isitemclickenabled.md) property is **true**.

## -xaml-syntax
```xaml
<listViewBase ItemClick="eventhandler" />
```


## -remarks
If the list view is one of the views in a [SemanticZoom](semanticzoom.md), selection entails additional behavior that might change between the views. This behavior is built in to the [ListViewBase](listviewbase.md) class, not the[SemanticZoom](semanticzoom.md) class.

## -examples

## -see-also
[IsItemClickEnabled](listviewbase_isitemclickenabled.md), [How to change the interaction mode](http://msdn.microsoft.com/library/7591268b-3835-4a48-a4ba-b2e6c9db73e6)