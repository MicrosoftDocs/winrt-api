---
-api-id: P:Windows.ApplicationModel.AppInstance.IsCurrentInstance
-api-type: winrt property
---

<!-- Property syntax.
public bool IsCurrentInstance { get; }
-->

# Windows.ApplicationModel.AppInstance.IsCurrentInstance

## -description
Whether the current instance of the app is the registered instance of the app for the specific key that this instance has defined.

## -property-value
A Boolean that indicates whether the current app is the registered instance of the app.

## -remarks

## -see-also

## -examples
In the following example, if the instance found is the current instance, that instance is activated.
If it is not the current instance, the example redirects to the app instance that is found. 

```csharp
if (theInstance.IsCurrentInstance)
{
    global::Windows.UI.Xaml.Application.Start((p) => new App(activatedArgs));
}
else
{
    theInstance.RedirectActivationTo();
}

```

