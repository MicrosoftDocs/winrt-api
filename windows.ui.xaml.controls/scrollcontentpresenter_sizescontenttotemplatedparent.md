---
-api-id: P:Windows.UI.Xaml.Controls.ScrollContentPresenter.SizesContentToTemplatedParent
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool SizesContentToTemplatedParent { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollContentPresenter.SizesContentToTemplatedParent

## -description

Gets or sets a value that indicates whether, when used in the ControlTemplate for a ScrollViewer, the presenter restricts the size of its [Content](contentpresenter_content.md) to the owning ScrollViewer size.



## -property-value

**true** if the presenter restricts its [Content](contentpresenter_content.md) size to the owning ScrollViewer size; otherwise, **false**. The default is **false**.

## -remarks

By default, when a ScrollContentPresenter is sizing its [Content](contentpresenter_content.md) during layout, it allows the content to be as wide as the content desires if [CanHorizontallyScroll](scrollcontentpresenter_canhorizontallyscroll.md) is **true**, and allows the content to be as high as the content desires if [CanVerticallyScroll](scrollcontentpresenter_canverticallyscroll.md) is **true**.

When the ScrollContentPresenter is used in the [ControlTemplate](controltemplate.md) for a [ScrollViewer](scrollviewer.md), setting the SizesContentToTemplatedParent property to **true** causes it to restrict the size of its Content to the owning ScrollViewer size.

## -see-also

[Content](contentpresenter_content.md), [ScrollOwner](scrollcontentpresenter_scrollowner.md)

## -examples

