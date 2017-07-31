---
-api-id: T:Windows.Media.Capture.GameBarTargetCapturePolicy
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum GameBarTargetCapturePolicy : int {
	EnabledBySystem = 0
	EnabledByUser = 1
	NotEnabled = 2
	ProhibitedByPublisher = 4
	ProhibitedBySystem = 3
}
-->

# Windows.Media.Capture.GameBarTargetCapturePolicy

## -description
Provides information around the allowable actions for this application.

## -enum-fields

## -field ProhibitedBySystem:3
The OS determined that the target is prohibited from being captured.

## -field ProhibitedByPublisher:4
The publisher of the target has indicated that capture is not allowed.

## -field NotEnabled:2
The OS doesn’t know the policy for the app and hasn’t been identified by the user as capturable.

## -field EnabledByUser:1
The OS does not know the policy for the app, but the user did identify the target as capturable.

## -field EnabledBySystem:0
The OS determined that the target allows capture

## -remarks

## -see-also

## -examples



## -capabilities
gameBarServices