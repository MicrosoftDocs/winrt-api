---
-api-id: P:Windows.UI.Core.CoreWindowFlyout.IsInteractionDelayed
-api-type: winrt property
---

<!-- Property syntax
public int IsInteractionDelayed { get;  set; }
-->

# Windows.UI.Core.CoreWindowFlyout.IsInteractionDelayed

## -description
Gets or sets a value that indicates whether any UI interaction event message is slightly delayed or not. This delay prevents a user from accidentally invoking an action on the flyout window.

## -property-value
**true** if a fractional delay is introduced to any interactions with the flyout; **false** if it is not.

## -remarks
Set this property to **true** when the flyout is asking the user for permission to perform some action which could affect the user’s privacy, security, or data.

## -examples

## -see-also
