---
-api-id: M:Windows.Devices.Display.Core.DisplayPath.FindModes(Windows.Devices.Display.Core.DisplayModeQueryOptions)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IVectorView<DisplayModeInfo> DisplayPath.FindModes(DisplayModeQueryOptions flags)
-->

# Windows.Devices.Display.Core.DisplayPath.FindModes

## -description
Queries the driver to determine the valid mode combinations that can be applied to this [DisplayPath](displaypath.md). Any properties that have already been set on this path are used as constraints to limit the set of modes returned.

## -parameters
### -param flags
A [DisplayModeQueryOptions](displaymodequeryoptions.md) value containing extended options for filtering the resulting modes.

## -returns
A collection containing zero or more modes that the driver reports could be successfully applied to this path. If the collection is empty, then either the driver doesn't support applying the [DisplayState](displaystate.md), or the supplied options are too constraining.

## -remarks
Filtering the returned modes using *flags*, or by setting some properties to constrain the mode enumeration, can provide a significant performance improvement. This method is very expensive if unconstrained, as the driver will be queried directly and may perform complex calculations to determine the union of supported modes.

## -see-also

## -examples
