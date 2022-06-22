---
-api-id: P:Windows.UI.Xaml.UIElement.TransformMatrix
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Matrix4x4 TransformMatrix { get;  set; }
-->

# Windows.UI.Xaml.UIElement.TransformMatrix

## -description
Gets or sets the transformation matrix to apply to the element.



## -property-value

The transformation matrix to apply to the element.

## -remarks
This property is not compatible with [`ElementCompositionPreview.GetElementVisual`](/uwp/api/windows.ui.xaml.hosting.elementcompositionpreview.getelementvisual?view=winrt-19041#Windows_UI_Xaml_Hosting_ElementCompositionPreview_GetElementVisual_Windows_UI_Xaml_UIElement_). Attempting to use `TransformMatrix` after calling `GetElementVisual` will fail with the following error: 
> Access denied.  Calling TransformMatrix API is not allowed on this object at this time, as this object currently has the ElementCompositionPreview.GetElementVisual property in use.


## -see-also

## -examples

