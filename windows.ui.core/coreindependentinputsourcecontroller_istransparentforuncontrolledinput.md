---
-api-id: P:Windows.UI.Core.CoreIndependentInputSourceController.IsTransparentForUncontrolledInput
-api-type: winrt property
---

# Windows.UI.Core.CoreIndependentInputSourceController.IsTransparentForUncontrolledInput

<!--
public bool IsTransparentForUncontrolledInput { get; set; }
-->

## -description

Gets or sets whether the visual associated with the controller's input source should be treated as transparent for input not currently configured to be delivered to the controller.

## -property-value

True, if the visual should be treated as transparent. Otherwise, false. The default is false.

If true, lower z-order visuals can be hit-tested for input not configured to be delivered to the controller.

## -remarks

This property should be set to true only if the visual associated with the controller does not occlude its lower z-order siblings (such as when the visual is painted with a transparent brush). Otherwise, the system hit-test could find a visual that is not visible to the user, and for which the user would not expect to receive input.

This property enables the creation of an overlay that only intercepts specific input, allowing other input to be processed as if the overlay were not present.

## -see-also

## -examples
