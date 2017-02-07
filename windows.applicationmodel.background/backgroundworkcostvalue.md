---
-api-id: T:Windows.ApplicationModel.Background.BackgroundWorkCostValue
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Background.BackgroundWorkCostValue : int
-->

# BackgroundWorkCostValue

## -description
Indicates the current cost of doing background work. Used as a hint to background tasks about how much work they can do.

## -enum-fields
### -field Low:0
Background resource usage is low. The background task can do work.

### -field Medium:1
Background resources are in use, but the background task can do some work.

### -field High:2
Background resources are under heavy use and the background task should not do any work.


## -remarks

## -examples

## -see-also