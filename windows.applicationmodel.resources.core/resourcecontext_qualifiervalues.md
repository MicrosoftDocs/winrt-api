---
-api-id: P:Windows.ApplicationModel.Resources.Core.ResourceContext.QualifierValues
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IObservableMap<string, string> QualifierValues { get; }
-->

# Windows.ApplicationModel.Resources.Core.ResourceContext.QualifierValues

## -description
Gets a writable, observable map of all supported qualifiers, indexed by name.

## -property-value
The map of qualifiers, which you use to map a qualifier name to a qualifier value. The qualifier value returned represents the current setting. Here is a reference table of all the possible qualifier values that can be returned. See [Tailor your resources for language, scale, high contrast, and other qualifiers](/windows/uwp/app-resources/tailor-resources-lang-scale-contrast) for an explanation of the general concept of qualifiers, how to use them, and the purpose of each of the qualifier names.

| Qualifier name | Qualifier values |
| ---------- | -------------------- |
| **alternateform**, or **altform** | A string, between 1 and 16 chars in length, representing an alternate form of a resource. |
| **configuration**, or **config** | A string. Matches the value of the `MS_CONFIGURATION_ATTRIBUTE_VALUE` environment variable. It’s unlikely that you’ll need to use this qualifier name (see the Configuration section of [Tailor your resources for language, scale, high contrast, and other qualifiers](/windows/uwp/app-resources/tailor-resources-lang-scale-contrast)). |
| **contrast** | Either **standard** (the default; matches high contrast off), **high** (matches any high contrast setting), **black** (matches High Contrast Black, High Contrast #1, and High Contrast #2), or **white** (matches High Contrast White). |
| **custom** | A custom value. |
| **devicefamily** | It’s unlikely that you’ll need to use this qualifier name (see the DeviceFamily section of [Tailor your resources for language, scale, high contrast, and other qualifiers](/windows/uwp/app-resources/tailor-resources-lang-scale-contrast)). If you do need to use it, then execute ```ResourceContext.GetForCurrentView().QualifierValues["devicefamily"]``` on each of the devices that you want to support and name your resources for the values that are returned. |
| **dxfeaturelevel**, or **dxfl** | Either **DX9**, **DX10**, **DX11**, or **DX12**. It’s unlikely that you’ll need to use this qualifier name (see the DXFeatureLevel section of [Tailor your resources for language, scale, high contrast, and other qualifiers](/windows/uwp/app-resources/tailor-resources-lang-scale-contrast)). |
| **homeregion** | Any valid [BCP-47 region tag](https://tools.ietf.org/html/bcp47) (such as **us**, or **840**). That is, any ISO 3166-1 alpha-2 two-letter region code, plus the set of ISO 3166-1 numeric three-digit geographic codes for composed regions (see [United Nations Statistic Division M49 composition of region codes](https://go.microsoft.com/fwlink/p/?linkid=247929)). Matches the country or region setting. |
| **language**, or **lang** | Any valid [BCP-47 language tag](https://tools.ietf.org/html/bcp47) (such as **en**, or **en-us**). Matches the display language setting. For a list of languages, see the [IANA language subtag registry](https://go.microsoft.com/fwlink/p/?linkid=227303). |
| **layoutdirection**, or **layoutdir** | Either **LTR** (left-to-right), **RTL** (right-to-left), **TTBLTR** (top-to-bottom, left-to-right), or **TTBRTL** (top-to-bottom, right-to-left). Matches the layout direction of the display language setting. |
| **scale** | Either **80**, **100** (default), **120**, **125**, **140**, **150**, **160**, **175**, **180**, **200**, **225**, **250**, **300**, **350**, **400**, or **450**. Matches the display scale setting. The values 125, 150, 175, 225, 250, 300, 350, 400, and 450 were introduced in Windows 10. |
| **targetsize** | A positive integer that represents the side length of a square image in raw (physical) pixels. Matches the View setting in File Explorer. |
| **theme** | Either **dark** or **light**. Matches the default or overridden app mode setting. |

## -remarks

## -examples

## -see-also
