---
-api-id: M:Windows.ApplicationModel.AppInstance.GetActivatedEventArgs
-api-type: winrt method
---

<!-- Method syntax.
public IActivatedEventArgs AppInstance.GetActivatedEventArgs()
-->

# Windows.ApplicationModel.AppInstance.GetActivatedEventArgs

## -description
Gets the current **IActivatedEventArgs**, the same as would normally be passed in to the app’s OnActivated method. 

## -returns
The current **IActivatedEventArgs**, or NULL.

## -remarks
This method gets the same argurments that would be passed in to the *OnActivated* method of the app.

This method allows the app to its arguments much earlier, in main.

This method only returns arguments on its first call.
Subsequent calls return NULL.

## -see-also

## -examples

