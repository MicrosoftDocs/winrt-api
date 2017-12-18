---
-api-id: P:Windows.ApplicationModel.AppInstance.IsCurrentInstance
-api-type: winrt property
---

<!-- Property syntax.
public bool IsCurrentInstance { get; }
-->

# Windows.ApplicationModel.AppInstance.IsCurrentInstance

## -description
Whether the current instance of the app is the registered instance of the app.

## -property-value
A Boolean that indicates whether the current app is the registered instance of the app.

## -remarks

## -see-also

## -examples
If the instance found is the current instance, the example activates the instance.
If it is not the current instance, the example redirects to that app instance. 

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

