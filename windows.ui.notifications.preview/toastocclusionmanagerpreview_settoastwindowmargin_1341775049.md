---
-api-id: M:Windows.UI.Notifications.Preview.ToastOcclusionManagerPreview.SetToastWindowMargin(Windows.UI.WindowId,System.Double)
-api-type: winrt method
---

# Windows.UI.Notifications.Preview.ToastOcclusionManagerPreview.SetToastWindowMargin(Windows.UI.WindowId,System.Double)

<!--
public static void SetToastWindowMargin (Windows.UI.WindowId appWindowId, double margin);
-->


## -description

Requests that the OS display app notifications with the specified vertical offset, in view pixels, in order to avoid the notification occluding content in the specified window.

> [!IMPORTANT]
> The **ToastOcclusionManagerPreview.SetToastWindowMargin** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).


## -parameters

### -param appWindowId

The **WindowId** of the window for associated with the notification offset request. For the offset to be applied, the specified window must be maximized, in focus, on the primary screen, and the onscreen keyboard must not be visible. 

### -param margin

The vertical offset with which app notifications are displayed, in view pixels. The current maximum value for the margin is 180 pixels. Requests for margins greater than 180 pixels will succeed, but will be clamped to 180 pixels. If a negative value is specified, it is clamped to 0.

## -remarks

This API is being released as a preview to enable testing of the feature by enterprise customers. This API is likely to be removed and/or modified in a future release. Before using the API, apps should call [LimitedAccessFeatures.TryUnlockFeature](/uwp/api/windows.applicationmodel.limitedaccessfeatures.tryunlockfeature), passing in the feature ID and app token provided by Microsoft, to verify that the app is authorized to use the API. Calls by unauthorized apps will have no effect.

The following example code demonstrates how to check for the availability of **SetToastWindowMargin** for the calling app and, if it is available, call the API to request that app notifications be shifted up by 90 pixels. These calls should be made during app launch. 

#### [UWP](#tab/uwp) 

```cpp
// App.xaml.cpp

static Platform::String^ FeatureName = L"com.microsoft.windows.ui.notifications.preview.toastOcclusionManagerPreview";
static Platform::String^ ApiToken = L"[API token]";
static Platform::String^ ApiAttestation = L"[Package family name] has registered their use of com.microsoft.windows.ui.notifications.preview.toastOcclusionManagerPreview with Microsoft and agrees to the terms of use.";


App::App()
{
    InitializeComponent();
    Suspending += ref new SuspendingEventHandler(this, &App::OnSuspending);

    m_isToastOcclusionManagerPreviewAvailable = DetectToastOcclusionManagerPreview();
}

bool App::DetectToastOcclusionManagerPreview()
{
    LimitedAccessFeatureRequestResult^ result = LimitedAccessFeatures::TryUnlockFeature(FeatureName, ApiToken, ApiAttestation);
    switch (result->Status)
    {
    case LimitedAccessFeatureStatus::Available:
    case LimitedAccessFeatureStatus::AvailableWithoutToken:
        return true;
    }
    return false;
}

void App::OnLaunched(Windows::ApplicationModel::Activation::LaunchActivatedEventArgs^ e)
{
    ...

    // Request for toast window to be shifted up 90 pixels
    // Toasts will only be shifted up if the window is maximized,
    // on the primary screen and the software keyboard isn't present. 
    if (!m_isRegistered && m_isToastOcclusionManagerPreviewAvailable)
    {
        HWND window;

        IInspectable* inspectable = reinterpret_cast<IInspectable*>(CoreWindow::GetForCurrentThread());

        winrt::com_ptr<ICoreWindowInterop> interop;

        if (SUCCEEDED(inspectable->QueryInterface(IID_PPV_ARGS(&interop))) && SUCCEEDED(interop->get_WindowHandle(&window)))
        {
            // Get the windowId
            winrt::Windows::UI::WindowId windowId{ reinterpret_cast<uint64_t>(window) };

            ToastOcclusionManagerPreview::SetToastWindowMargin(windowId, 90);
        }

        m_isRegistered = true;
    }
}
```

#### [Win32](#tab/win32)

```cpp
static hstring FeatureName = L"com.microsoft.windows.ui.notifications.preview.toastOcclusionManagerPreview";
static hstring ApiToken = L"[API Token]";
static hstring ApiAttestation = L"[Package family name] has registered their use of com.microsoft.windows.ui.notifications.preview.toastOcclusionManagerPreview with Microsoft and agrees to the terms of use.";


BOOL InitInstance(HINSTANCE hInstance, int nCmdShow)
{
   hInst = hInstance; // Store instance handle in our global variable

   HWND hWnd = CreateWindowW(szWindowClass, szTitle, WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT, 0, CW_USEDEFAULT, 0, nullptr, nullptr, hInstance, nullptr);

   if (!hWnd)
   {
      return FALSE;
   }

   ShowWindow(hWnd, nCmdShow);
   UpdateWindow(hWnd);

   BOOL isToastOcclusionManagerPreviewAvailable = DetectToastOcclusionManagerPreview();

   // Request for toast window to be shifted up 90 pixels
   // Toasts will only be shifted up if the window is maximized,
   // on the primary screen, and the software keyboard isn't present. 
   if (isToastOcclusionManagerPreviewAvailable)
   {
       // Get the windowId
       winrt::Windows::UI::WindowId windowId{ reinterpret_cast<uint64_t>(hWnd) };

       ToastOcclusionManagerPreview::SetToastWindowMargin(windowId, 90);
   }

   return TRUE;
}

BOOL DetectToastOcclusionManagerPreview()
{
    LimitedAccessFeatureRequestResult result = LimitedAccessFeatures::TryUnlockFeature(FeatureName, ApiToken, ApiAttestation);
    switch (result.Status())
    {
    case LimitedAccessFeatureStatus::Available:
    case LimitedAccessFeatureStatus::AvailableWithoutToken:
        return TRUE;
    }
    return FALSE;
}
```
---


## -see-also

[LimitedAccessFeatures](/uwp/api/windows.applicationmodel.limitedaccessfeatures)

## -examples


