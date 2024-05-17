---
-api-id: T:Windows.System.Profile.SmartAppControlPolicy
-api-type: winrt class
---

# Windows.System.Profile.SmartAppControlPolicy

<!--
public static class SmartAppControlPolicy
-->

## -description

The **Smart App Control** policy interface and runtime class.

## -remarks

**Smart App Control** is a new security feature in Windows 11, which improves consumer PC security by blocking apps that are malicious or untrusted. It's implemented as a Microsoft Defender Application Control (MDAC) policy, similar to [Windows in S mode](https://support.microsoft.com/windows/windows-10-and-windows-11-in-s-mode-faq-851057d6-1ee9-b9e5-c30b-93baebeebc85).

Apps and services may want to query the **Smart App Control** mode on a given system or register for a notification when the state changes. This can be accomplished with the **SmartAppControlPolicy** APIs.

## -see-also

[What is Smart App Control?](https://support.microsoft.com/topic/what-is-smart-app-control-285ea03d-fa88-4d56-882e-6698afdb7003)

## -examples

The following example shows how apps can register for the [SmartAppControlPolicy.Changed](smartappcontrolpolicy_changed.md) event and handle the event when it's raised.

```csharp
using Windows.System.Profile;

public class SmartAppControlPolicySample: IDisposable
{
    public SmartAppControlPolicySample()
    {
        SmartAppControlPolicy.Changed += OnSmartAppControlPolicyChanged;
        OnSmartAppControlPolicyChanged();
    }

    ~SmartAppControlPolicySample()
    {
        SmartAppControlPolicy.Changed -= OnSmartAppControlPolicyChanged;
    }

    public void HandleSmartAppControlPolicyChange()
    {
        //
        // Change related UI Elements
        //
        ChangeUIForSmartAppControl(SmartAppControlPolicy.IsEnabled);
    }

    void OnSmartAppControlPolicyChanged(object args)
    {
        //
        // Smart App Control Policy state changed.
        //
        HandleSmartAppControlPolicyChange();

        //
        // Manage detection settings.
        //
        if (!SmartAppControlPolicy.IsEnabled)
        {
            //
            // Set AV in full scanning mode.
            //
            SetMalwareDetectionBehavior(MalwareDetectionBehavior.FullDetectionMode);
        }
        else
        {
            //
            // Set AV in light weight scanning mode.
            //
            SetMalwareDetectionBehavior(MalwareDetectionBehavior.LightweightDetectionMode);
        }
    }
}
```
