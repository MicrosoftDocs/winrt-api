---
-api-id: M:Windows.ApplicationModel.AppInstance.GetActivatedEventArgs
-api-type: winrt method
---

<!-- Method syntax.
public IActivatedEventArgs AppInstance.GetActivatedEventArgs()
-->

# Windows.ApplicationModel.AppInstance.GetActivatedEventArgs

## -description

Gets the current [IActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.iactivatedeventargs), the same that would normally be passed in to the _OnActivated_ method of the app.

## -returns

The current **IActivatedEventArgs**, or `null`.

## -remarks

This method gets the same arguments that would be passed in to the _OnActivated_ method of the app.

This method allows the app to access its arguments much earlier, in its `Main` method, which is the first app method to be called.

> [!NOTE]
> For packaged apps, this method only returns arguments on its first call. Subsequent calls return `null`.

## -see-also

[IActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.iactivatedeventargs)

## -examples

This example gets the event arguments for the specified app instance.

```csharp
IActivatedEventArgs activatedArgs = AppInstance.GetActivatedEventArgs();
```
