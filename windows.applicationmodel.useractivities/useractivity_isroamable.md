---
-api-id: P:Windows.ApplicationModel.UserActivities.UserActivity.IsRoamable
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsRoamable { get;  set; }
-->

# Windows.ApplicationModel.UserActivities.UserActivity.IsRoamable

## -description

Gets and sets whether the particular activity's metadata should be uploaded to the Microsoft Cloud.

## -property-value

The boolean representing whether metadata should uploaded. If not set, this property defaults to True.

## -remarks

When this property is set to False, the activity and its associated metadata will not be uploaded. The activity can still be serialized to JSON, put on the clipboard, and otherwise made available to other applications. In that case, it is the responsibility of the application recieving the activity to determine whether or not to enforce this property.

## -see-also

## -examples

