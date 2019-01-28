---
-api-id: T:Windows.System.Profile.WindowsIntegrityPolicy
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class WindowsIntegrityPolicy 
-->

# Windows.System.Profile.WindowsIntegrityPolicy

## -description
Provides information about the current Windows 10 secure mode (10 S mode), and an event that is raised when the mode changes.

## -remarks
Windows provides 10 S (also known as Windows Lockdown) as a mode. When Windows is in 10 S mode, only Microsoft components and Universal Windows Platform (UWP) apps can run. Certain specific components, such as `regedit.exe` and `cmd.exe`, are also disallowed. UWP apps, particularly security and firewall apps, need to be aware of the current 10 S mode in order to behave properly. Such apps also need to be notified when 10 S mode transitions from enabled to disabled.

## -see-also

## -examples
```csharp
public class WindowsLockdownExample
{
    public WindowsLockdownExample()
    {
        Windows.System.Profile.WindowsIntegrityPolicy.PolicyChanged += this.WindowsIntegrityPolicy_PolicyChanged;
    }

    ~WindowsLockdownExample()
    {
        Windows.System.Profile.WindowsIntegrityPolicy.PolicyChanged -= this.WindowsIntegrityPolicy_PolicyChanged;
    }

    private void WindowsIntegrityPolicy_PolicyChanged(object sender, object e)
    {
        // Windows secure mode (10 S mode) has changed.

        this.ProcessWindowsIntegrityPolicy();

        if (!Windows.System.Profile.WindowsIntegrityPolicy.IsEnabled)
        {
            // There are certain things that you may want to do when Windows secure mode
            // (10 S mode) has changed from the enabled to the disabled state. For example,
            // a security application might want to offer anti-virus software on this 
            // device.
        }
    }

    public void ProcessWindowsIntegrityPolicy()
    {
        // Check Windows secure mode (10 S mode) status.

        if (Windows.System.Profile.WindowsIntegrityPolicy.IsEnabled)
        {
            // Windows secure mode (10 S mode) is enabled.

            if (Windows.System.Profile.WindowsIntegrityPolicy.IsEnabledForTrial)
            {
                // Furthermore, it has been enabled for trial purposes. Respond accordingly.
                // For example, logging/tagging this device for the organization to 
                // monitor devices that are under trial mode.
            }
            else
            {
                // It has been enabled for normal scenarios. Respond accordingly.
                // For example, don’t try to invoke any process that will be blocked
                // by the policy, or change your UI or error message. For example, 
                // security software could show a different error message about the process
                // being blocked when Windows secure mode (10 S mode) is enabled.
            }
        }

        // Check whether Windows secure mode (10 S mode) can be disabled, and whether disabling is supported.

        if (Windows.System.Profile.WindowsIntegrityPolicy.CanDisable)
        {
            if (Windows.System.Profile.WindowsIntegrityPolicy.IsDisableSupported)
            {
                // Windows secure mode (10 S mode) can be disabled, and disabling is supported.
                // Respond accordingly. For example, report this information back to any cloud-based
                // solution, in case it need to push any policy disabling package to the right devices.
            }
            else
            {
                // Windows secure mode (10 S mode) can be disabled, but disabling is not supported.
                // So, Windows secure mode (10 S mode) can never be changed. Work around this situation.
                // For example, show the appropriate error message when you fail to disable Windows
                // secure mode (10 S mode).
            }
        }
    }
}
```
