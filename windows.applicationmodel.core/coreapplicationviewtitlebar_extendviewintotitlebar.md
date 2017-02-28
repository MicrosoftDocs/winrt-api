---
-api-id: P:Windows.ApplicationModel.Core.CoreApplicationViewTitleBar.ExtendViewIntoTitleBar
-api-type: winrt property
---

<!-- Property syntax
public bool ExtendViewIntoTitleBar { get;  set; }
-->

# Windows.ApplicationModel.Core.CoreApplicationViewTitleBar.ExtendViewIntoTitleBar

## -description
Gets or sets a value that specifies whether this title bar should replace the default window title bar.

## -property-value
Set to **true** to replace the default window title bar; otherwise, **false**.

## -remarks
This is cached by OS so that if you set it to some value and then the view gets closed and reopened (e.g. due to app restart) the property will retain the old value.

## -examples

## -see-also
