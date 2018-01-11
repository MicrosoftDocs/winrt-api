---
-api-id: M:Windows.ApplicationModel.AppInstance.Unregister
-api-type: winrt method
---

<!-- Method syntax.
public void AppInstance.Unregister()
-->

# Windows.ApplicationModel.AppInstance.Unregister

## -description
Updates the system cache so that the current instance is no longer available for activation redirection. 

## -remarks

## -see-also

## -examples
Once registered, an instance remains registered until either the instance process terminates or the instance unregisters itself.
This example unregisters the current this app. 
It no longer takes part in instance redirection.
The instance continues to run. 

```csharp
private void OnAllFilesClosed(object sender, EventArgs args)
{
    AppInstance.Unregister();
}

```

