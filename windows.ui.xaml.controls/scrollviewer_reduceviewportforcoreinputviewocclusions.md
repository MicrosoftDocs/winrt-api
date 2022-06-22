---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.ReduceViewportForCoreInputViewOcclusions
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool ReduceViewportForCoreInputViewOcclusions { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.ReduceViewportForCoreInputViewOcclusions

## -description

Gets or sets a value that indicates whether the ScrollViewer should try to adjust its content to keep it visible when a docked CoreInputView occludes part of it.



## -property-value

**true** if the ScrollViewer should try to adjust its content; otherwise, **false**. The default is **false**.

## -remarks

When this feature is enabled and a docked [CoreInputView](/windows.ui.viewmanagement.core/coreinputview.md) covers part of the ScrollViewer control, the ScrollViewer reduces the space available to its content according to the size and location of the CoreInputView. Then the ScrollViewer, as in any other case where the content is constrained, allows the user to pan/scroll the content. Also, any time a text edit control gets focus, it automatically brings itself into view, so the user isn't required to manually pan.

This property defaults to **false**, and it's typically not necessary for you to set it in your app. XAML maintains a ScrollViewer internally with this feature enabled, and your window content is displayed in this ScrollViewer. That is, **Window.Current.Content** is automatically parented to a ScrollViewer that has this feature enabled.

## -see-also

## -examples

