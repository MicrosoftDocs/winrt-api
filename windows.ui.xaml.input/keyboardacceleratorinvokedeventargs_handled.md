---
-api-id: P:Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.Input.KeyboardAcceleratorInvokedEventArgs.Handled

## -description
Gets or sets a value that marks the event as handled. 



## -property-value
**true** to mark the event handled; **false** to leave the event unhandled, which permits the event to potentially route further. The default is **false**.

## -remarks
The keyboard accelerator event bubbles from the element that has the focus to the root Window element. If the event isn't handled, the framework looks for other accelerators outside of the bubbling path using a table of global accelerators. All accelerators are registered as global unless scoped using [ScopeOwner](keyboardaccelerator_scopeowner.md).

Scoped accelerators are invoked only if focus is inside a specific scope. For example, in a Grid that contains many controls, the accelerator can be associated with a control scoped to the Grid (the Grid is the [ScopeOwner](keyboardaccelerator_scopeowner.md)). In this case, the root element is the Grid.

If two accelerators are defined with the same key combination, the first accelerator found in the table is invoked.

## -see-also
[Keyboard Accelerators](/windows/uwp/design/input/keyboard-accelerators)

## -examples

