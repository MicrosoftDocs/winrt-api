---
-api-id: M:Windows.Graphics.Holographic.HolographicDisplay.TryGetViewConfiguration(Windows.Graphics.Holographic.HolographicViewConfigurationKind)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public HolographicViewConfiguration HolographicDisplay.TryGetViewConfiguration(HolographicViewConfigurationKind kind)
-->

# Windows.Graphics.Holographic.HolographicDisplay.TryGetViewConfiguration

## -description
Attempts to retrieve the view configuration for this [HolographicDisplay](holographicdisplay.md), which corresponds to the supplied [HolographicViewConfigurationKind](HolographicViewConfigurationKind.md).

## -parameters
### -param kind
A [HolographicViewConfigurationKind](holographicviewconfigurationkind.md) indicating the kind of view configuration to be retrieved.

## -returns
A [HolographicViewConfiguration](holographicviewconfiguration.md) object of the indicated kind, or null if the [HolographicDisplay](holographicdisplay.md) does not support the indicated [HolographicViewConfigurationKind](HolographicViewConfigurationKind.md).

## -remarks

## -see-also
[HolographicViewConfiguration](holographicviewconfiguration.md), [HolographicViewConfigurationKind](holographicviewconfigurationkind.md), [HolographicCamera](holographiccamera.md), [HolographicFrame.AddedCameras](holographicframe_addedcameras.md), [HolographicSpace.CameraAdded](holographicspace_cameraadded.md)

## -examples

**Example 1: Retrieve the default HolographicViewConfiguration**

The default [HolographicViewConfiguration](holographicviewconfiguration.md) for the default [HolographicDisplay](holographicdisplay.md) is always available, and it is enabled by default. You can reliably retrieve this view configuration as shown below.

```cppwinrt
auto defaultDisplayViewConfiguration = HolographicDisplay::GetDefault().TryGetViewConfiguration(HolographicViewConfigurationKind::Display);
```

After completing the step shown above, the app can (for example) use the view configuration to tune parameters such as the back buffer resolution and format.

**Example 2: Enable dedicated rendering for mixed reality capture**

To enable dedicated rendering for mixed reality capture, retrieve the [HolographicViewConfiguration](holographicviewconfiguration.md) for [HolographicViewConfigurationKind::PhotoVideoCamera](HolographicViewConfigurationKind.md) as shown below.

```cppwinrt
auto mrcViewConfiguration = HolographicDisplay::GetDefault().TryGetViewConfiguration(HolographicViewConfigurationKind::PhotoVideoCamera);
if (mrcViewConfiguration)
{
    mrcViewConfiguration.IsEnabled(true);
}
```

After the app has completed the above step, the platform will then provide an additional [HolographicCamera](holographiccamera.md) to the app when the user takes a mixed reality capture photo or video. This [HolographicCamera](holographiccamera.md) provides view matrices corresponding to the photo/video camera location, and it provides projection matrices using the photo/video camera field of view. Content rendered to its back buffer will be composited with the captured image to create the mixed reality capture photo or video. Render target size and format can be set independently from other [HolographicCamera](holographiccamera.md) objects.
