---
-api-id: P:Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.Input.AccessKeyInvokedEventArgs.Handled

## -description
Gets or sets a value that marks the routed event as handled. A **true** value for [Handled](accesskeyinvokedeventargs_handled.md) prevents most handlers along the event route from handling the same event again.

## -property-value
**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.

## -remarks

## -examples

## -see-also
[Access keys](https://docs.microsoft.com/windows/uwp/design/input/access-keys)