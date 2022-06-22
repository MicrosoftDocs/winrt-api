---
-api-id: P:Windows.UI.Xaml.Controls.UserControl.Content
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.UIElement Content { get;  set; }
-->

# Windows.UI.Xaml.Controls.UserControl.Content

## -description
Gets or sets the content that is contained within a user control.



## -xaml-syntax
```xaml
<UserControl ...>
  singleContentElement
</UserControl>
-or-
<UserControl .../>
```


## -xaml-values
<dl><dt>singleContentElement</dt><dd>singleContentElementExactly one object element for a class that derives from UIElement. This is almost always an object that can take child elements (such as a Panel) so that multiple elements can be added to content. XAML processing of a UserControl has a special behavior that sets this content to the otherwise protected Content property.</dd>
</dl>
## -property-value
The content of the user control.

## -remarks

## -examples

## -see-also
