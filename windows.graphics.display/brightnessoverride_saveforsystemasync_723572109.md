---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.SaveForSystemAsync(Windows.Graphics.Display.BrightnessOverride)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> BrightnessOverride.SaveForSystemAsync(BrightnessOverride value)
-->

# Windows.Graphics.Display.BrightnessOverride.SaveForSystemAsync

## -description
Saves the specified brightness override settings by committing these values to user settings. Use this method to persist the override settings after overriding stops. If `null` is passed for *value*, then the system turns on auto-brightness. 

## -parameters

### -param value
A brightness override object; or `null` to turn on auto-brightness.

## -returns
Boolean value to indicate whether the operation is successful or not.

## -remarks
Requires the *systemManagement* capability to be declared in your app's package manifest. That capability allows apps to have basic system administration privileges. If it isn't declared, then this method throws an access is denied exception. For more info, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations#general-use-capabilities).

## -see-also

## -examples
