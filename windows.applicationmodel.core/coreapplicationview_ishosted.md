---
-api-id: P:Windows.ApplicationModel.Core.CoreApplicationView.IsHosted
-api-type: winrt property
---

<!-- Property syntax
public bool IsHosted { get; }
-->

# Windows.ApplicationModel.Core.CoreApplicationView.IsHosted

## -description
Gets the value that indicates whether this app view is hosted or not.

## -property-value
If **true**, this app view is hosted; if **false**, it is not.

## -remarks
An app view is considered hosted when the process that launched it controls its lifetime. For example, the window that opens when a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) is launched is considered hosted.

## -examples

## -see-also
