---
-api-id: M:Windows.UI.Xaml.Data.CurrentChangingEventArgs.#ctor(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public CurrentChangingEventArgs(System.Boolean isCancelable)
-->

# Windows.UI.Xaml.Data.CurrentChangingEventArgs.CurrentChangingEventArgs

## -description
Initializes a new instance of the [CurrentChangingEventArgs](currentchangingeventargs.md) class.


## -parameters
### -param isCancelable

**true** if the event can be canceled; **false** if the event cannot be canceled.

## -remarks

If the [IsCancelable](currentchangingeventargs_iscancelable.md) property value is **false**, setting the [Cancel](currentchangingeventargs_cancel.md) property to **true** will throw an `InvalidOperationException`.

## -examples

## -see-also
