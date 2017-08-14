---
-api-id: M:Windows.Graphics.Display.BrightnessOverride.SaveForSystemAsync(Windows.Graphics.Display.BrightnessOverride)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> BrightnessOverride.SaveForSystemAsync(BrightnessOverride value)
-->

# Windows.Graphics.Display.BrightnessOverride.SaveForSystemAsync

## -description
Saves the specified brightness override settings by committing these values to user settings. Use this method to persist the override settings after overriding stops. If a NULL object is passed in, the system turns on auto-brightness. 

## -parameters

### -param value
The brightness override object.

## -returns
BOOLEAN value to indicate if the operation is successful or not.

## -remarks
Requires the __systemManagement__ capability to be declared in your app's package manifest. This capability allows apps to have basic system administration privileges. If it isn’t declared, this method throws an access is denied exception. For more info, see [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations#general-use-capabilities).

## -see-also

## -examples

