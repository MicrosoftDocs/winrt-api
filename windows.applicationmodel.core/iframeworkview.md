---
-api-id: T:Windows.ApplicationModel.Core.IFrameworkView
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IFrameworkView : 
-->

# Windows.ApplicationModel.Core.IFrameworkView

## -description
Represents an app view provider.

## -remarks
Object that implement this interface should be returned by the [CreateView](iframeworkviewsource_createview_164792513.md) method on your implementation of [IFrameworkViewSource](iframeworkviewsource.md), which is a factory type interface.

These three methods are called, in order, after the app object (defined by a [CoreApplication](coreapplication.md) singleton instance) has started.
+ [Initialize](iframeworkview_initialize_1389154906.md)
+ [Load](iframeworkview_load_1077941801.md)
+ [Run](coreapplication_run_1480028297.md)

The following code example demonstrates how you can use IFrameworkView to implement a simple Direct3D view provider.

```cppwinrt
// App.cpp in a CoreApp project.
#include "pch.h"
#include <d3d11_2.h>

using namespace winrt;
using namespace Windows;
using namespace Windows::ApplicationModel::Activation;
using namespace Windows::ApplicationModel::Core;
using namespace Windows::Foundation::Numerics;
using namespace Windows::UI;
using namespace Windows::UI::Core;
using namespace Windows::UI::Composition;

struct App : implements<App, IFrameworkViewSource, IFrameworkView>
{
    IFrameworkView CreateView()
    {
        return *this;
    }

    // This method is called on application launch.
    void Initialize(CoreApplicationView const& applicationView)
    {
        applicationView.Activated({ this, &App::OnActivated });
    }

    void Load(winrt::hstring const& /*entryPoint*/)
    {
    }

    void OnActivated(CoreApplicationView const& /* applicationView */, IActivatedEventArgs const& /* args */)
    {
        // Activate the application window, making it visible and enabling it to receive events.
        CoreWindow::GetForCurrentThread().Activate();
    }

    // This method is called after Load.
    void Run()
    {
        // First, create the Direct3D device.

        // This flag is required in order to enable compatibility with Direct2D.
        UINT creationFlags = D3D11_CREATE_DEVICE_BGRA_SUPPORT;

#if defined(_DEBUG)
        // If the project is in a debug build, enable debugging via SDK Layers with this flag.
        creationFlags |= D3D11_CREATE_DEVICE_DEBUG;
#endif

        // This array defines the ordering of feature levels that D3D should attempt to create.
        D3D_FEATURE_LEVEL featureLevels[] =
        {
            D3D_FEATURE_LEVEL_11_1,
            D3D_FEATURE_LEVEL_11_0,
            D3D_FEATURE_LEVEL_10_1,
            D3D_FEATURE_LEVEL_10_0,
            D3D_FEATURE_LEVEL_9_3,
            D3D_FEATURE_LEVEL_9_1
        };

        winrt::com_ptr<ID3D11Device> d3dDevice;
        winrt::com_ptr<ID3D11DeviceContext> d3dDeviceContext;
        winrt::check_hresult(
            ::D3D11CreateDevice(
                nullptr,                    // specify nullptr to use the default adapter
                D3D_DRIVER_TYPE_HARDWARE,
                nullptr,                    // leave as nullptr if hardware is used
                creationFlags,              // optionally set debug and Direct2D compatibility flags
                featureLevels,
                ARRAYSIZE(featureLevels),
                D3D11_SDK_VERSION,          // always set this to D3D11_SDK_VERSION
                d3dDevice.put(),
                nullptr,
                d3dDeviceContext.put()
            )
        );

        // Retrieve the Direct3D 11.1 interfaces.
        m_d3dDevice = d3dDevice.as<ID3D11Device1>();
        m_d3dDeviceContext = d3dDeviceContext.as<ID3D11DeviceContext1>();

        // After the D3D device is created, create additional application resources.
        CreateWindowSizeDependentResources();

        // Enter the render loop.  Note that a UWP app should never exit.
        while (true)
        {
            // Process events incoming to the window.
            m_window.get().Dispatcher().ProcessEvents(CoreProcessEventsOption::ProcessAllIfPresent);

            // Specify the render target we created as the output target.
            ID3D11RenderTargetView *const targets[1]{ m_renderTargetView.get() };
            m_d3dDeviceContext->OMSetRenderTargets(
                1,
                targets,
                nullptr // use no depth stencil
            );

            // Clear the render target to a solid color.
            const float clearColor[4] = { 0.071f, 0.04f, 0.561f, 1.0f };
            m_d3dDeviceContext->ClearRenderTargetView(
                m_renderTargetView.get(),
                clearColor
            );

            // Present the rendered image to the window.  Because the maximum frame latency is set to 1,
            // the render loop will generally be throttled to the screen refresh rate, typically around
            // 60Hz, by sleeping the application on Present until the screen is refreshed.
            winrt::check_hresult(
                m_swapChain->Present(1, 0)
            );
        }
    }

    // This method is called after Initialize.
    void SetWindow(CoreWindow const& window)
    {
        m_window = window;

        // Specify the cursor type as the standard arrow cursor.
        m_window.get().PointerCursor(CoreCursor{ CoreCursorType::Arrow, 0 });

        // Allow the application to respond when the window size changes.
        window.SizeChanged({ this, &App::OnWindowSizeChanged });
    }

    // This method is called before the application exits.
    void Uninitialize()
    {
    }

private:
    winrt::agile_ref<CoreWindow> m_window;
    winrt::com_ptr<IDXGISwapChain1> m_swapChain;
    winrt::com_ptr<ID3D11Device1> m_d3dDevice;
    winrt::com_ptr<ID3D11DeviceContext1> m_d3dDeviceContext;
    winrt::com_ptr<ID3D11RenderTargetView> m_renderTargetView;

    // This method creates all application resources that depend on
    // the application window size.  It is called at app initialization,
    // and whenever the application window size changes.
    void CreateWindowSizeDependentResources()
    {
        if (m_swapChain != nullptr)
        {
            // If the swap chain already exists, resize it.
            winrt::check_hresult(
                m_swapChain->ResizeBuffers(
                    2,
                    0,
                    0,
                    DXGI_FORMAT_B8G8R8A8_UNORM,
                    0
                )
            );
        }
        else
        {
            // If the swap chain does not exist, create it.
            DXGI_SWAP_CHAIN_DESC1 swapChainDesc = { 0 };

            swapChainDesc.Stereo = false;
            swapChainDesc.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
            swapChainDesc.Scaling = DXGI_SCALING_NONE;
            swapChainDesc.Flags = 0;

            // Use automatic sizing.
            swapChainDesc.Width = 0;
            swapChainDesc.Height = 0;

            // This is the most common swap chain format.
            swapChainDesc.Format = DXGI_FORMAT_B8G8R8A8_UNORM;

            // Don't use multi-sampling.
            swapChainDesc.SampleDesc.Count = 1;
            swapChainDesc.SampleDesc.Quality = 0;

            // Use two buffers to enable flip effect.
            swapChainDesc.BufferCount = 2;

            // We recommend using this swap effect for all applications.
            swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL;


            // Once the swap chain description is configured, it must be
            // created on the same adapter as the existing D3D Device.

            // First, retrieve the underlying DXGI Device from the D3D Device.
            winrt::com_ptr<IDXGIDevice2> dxgiDevice{ m_d3dDevice.as<IDXGIDevice2>() };

            // Ensure that DXGI does not queue more than one frame at a time. This both reduces
            // latency and ensures that the application will only render after each VSync, minimizing
            // power consumption.
            winrt::check_hresult(
                dxgiDevice->SetMaximumFrameLatency(1)
            );

            // Next, get the parent factory from the DXGI Device.
            winrt::com_ptr<IDXGIAdapter> dxgiAdapter;
            winrt::check_hresult(
                dxgiDevice->GetAdapter(dxgiAdapter.put())
            );

            winrt::com_ptr<IDXGIFactory2> dxgiFactory;
            winrt::check_hresult(
                dxgiAdapter->GetParent(__uuidof(dxgiFactory), dxgiFactory.put_void())
            );

            // Finally, create the swap chain.
            winrt::check_hresult(
                dxgiFactory->CreateSwapChainForCoreWindow(
                    m_d3dDevice.get(),
                    winrt::get_unknown(m_window.get()),
                    &swapChainDesc,
                    nullptr, // allow on all displays
                    m_swapChain.put()
                )
            );
        }

        // Once the swap chain is created, create a render target view.  This will
        // allow Direct3D to render graphics to the window.

        winrt::com_ptr<ID3D11Texture2D> backBuffer;
        winrt::check_hresult(
            m_swapChain->GetBuffer(0, __uuidof(backBuffer), backBuffer.put_void())
        );

        winrt::check_hresult(
            m_d3dDevice->CreateRenderTargetView(
                backBuffer.get(),
                nullptr,
                m_renderTargetView.put()
            )
        );

        // After the render target view is created, specify that the viewport,
        // which describes what portion of the window to draw to, should cover
        // the entire window.

        D3D11_TEXTURE2D_DESC backBufferDesc = { 0 };
        backBuffer->GetDesc(&backBufferDesc);

        D3D11_VIEWPORT viewport;
        viewport.TopLeftX = 0.0f;
        viewport.TopLeftY = 0.0f;
        viewport.Width = static_cast<float>(backBufferDesc.Width);
        viewport.Height = static_cast<float>(backBufferDesc.Height);
        viewport.MinDepth = D3D11_MIN_DEPTH;
        viewport.MaxDepth = D3D11_MAX_DEPTH;

        m_d3dDeviceContext->RSSetViewports(1, &viewport);
    }

    // This method is called whenever the application window size changes.
    void OnWindowSizeChanged(CoreWindow const& /*sender*/, WindowSizeChangedEventArgs const& /* args */)
    {
        m_renderTargetView = nullptr;
        CreateWindowSizeDependentResources();
    }
};

int __stdcall wWinMain(HINSTANCE, HINSTANCE, PWSTR, int)
{
    CoreApplication::Run(winrt::make<App>());
}
```

```cppcx
ref class MyFrameworkView : public IFrameworkView
{
private:
    Platform::Agile<CoreWindow> m_window;
    ComPtr<IDXGISwapChain1> m_swapChain;
    ComPtr<ID3D11Device1> m_d3dDevice;
    ComPtr<ID3D11DeviceContext1> m_d3dDeviceContext;
    ComPtr<ID3D11RenderTargetView> m_renderTargetView;

public:
    // This method is called on application launch.
    virtual void Initialize(
        _In_ CoreApplicationView^ applicationView
        )
    {
        applicationView->Activated +=
            ref new TypedEventHandler<CoreApplicationView^, IActivatedEventArgs^>(this, &MyFrameworkView::OnActivated);
    }

    // This method is called after Initialize.
    virtual void SetWindow(
        _In_ CoreWindow^ window
        )
    {
        m_window = window;

        // Specify the cursor type as the standard arrow cursor.
        m_window->PointerCursor = ref new CoreCursor(CoreCursorType::Arrow, 0);

        // Allow the application to respond when the window size changes.
        m_window->SizeChanged +=
            ref new TypedEventHandler<CoreWindow^, WindowSizeChangedEventArgs^>(
                this,
                &MyFrameworkView::OnWindowSizeChanged
                );
    }

    void OnActivated(
        _In_ CoreApplicationView^ applicationView,
        _In_ IActivatedEventArgs^ args
        )
    {
        // Activate the application window, making it visible and enabling it to receive events.
        CoreWindow::GetForCurrentThread()->Activate();
    }

    virtual void Load(_In_ Platform::String^ entryPoint)
    {
    }

    // This method is called after Load.
    virtual void Run()
    {
        // First, create the Direct3D device.

        // This flag is required in order to enable compatibility with Direct2D.
        UINT creationFlags = D3D11_CREATE_DEVICE_BGRA_SUPPORT;

#if defined(_DEBUG)
        // If the project is in a debug build, enable debugging via SDK Layers with this flag.
        creationFlags |= D3D11_CREATE_DEVICE_DEBUG;
#endif

        // This array defines the ordering of feature levels that D3D should attempt to create.
        D3D_FEATURE_LEVEL featureLevels[] =
        {
            D3D_FEATURE_LEVEL_11_1,
            D3D_FEATURE_LEVEL_11_0,
            D3D_FEATURE_LEVEL_10_1,
            D3D_FEATURE_LEVEL_10_0,
            D3D_FEATURE_LEVEL_9_3,
            D3D_FEATURE_LEVEL_9_1
        };

        ComPtr<ID3D11Device> d3dDevice;
        ComPtr<ID3D11DeviceContext> d3dDeviceContext;
        DX::ThrowIfFailed(
            D3D11CreateDevice(
                nullptr,                    // specify nullptr to use the default adapter
                D3D_DRIVER_TYPE_HARDWARE,
                nullptr,                    // leave as nullptr if hardware is used
                creationFlags,              // optionally set debug and Direct2D compatibility flags
                featureLevels,
                ARRAYSIZE(featureLevels),
                D3D11_SDK_VERSION,          // always set this to D3D11_SDK_VERSION
                &d3dDevice,
                nullptr,
                &d3dDeviceContext
                )
            );

        // Retrieve the Direct3D 11.1 interfaces.
        DX::ThrowIfFailed(
            d3dDevice.As(&m_d3dDevice)
            );

        DX::ThrowIfFailed(
            d3dDeviceContext.As(&m_d3dDeviceContext)
            );

        // After the D3D device is created, create additional application resources.
        CreateWindowSizeDependentResources();

        // Enter the render loop.  Note that UWP apps should never exit.
        while (true)
        {
            // Process events incoming to the window.
            m_window->Dispatcher->ProcessEvents(CoreProcessEventsOption::ProcessAllIfPresent);

            // Specify the render target we created as the output target.
            m_d3dDeviceContext->OMSetRenderTargets(
                1,
                m_renderTargetView.GetAddressOf(),
                nullptr // use no depth stencil
                );

            // Clear the render target to a solid color.
            const float clearColor[4] = { 0.071f, 0.04f, 0.561f, 1.0f };
            m_d3dDeviceContext->ClearRenderTargetView(
                m_renderTargetView.Get(),
                clearColor
                );

            // Present the rendered image to the window.  Because the maximum frame latency is set to 1,
            // the render loop will generally be throttled to the screen refresh rate, typically around
            // 60Hz, by sleeping the application on Present until the screen is refreshed.
            DX::ThrowIfFailed(
                m_swapChain->Present(1, 0)
                );
        }
    }

    // This method is called before the application exits.
    virtual void Uninitialize()
    {
    }

private:

    // This method is called whenever the application window size changes.
    void OnWindowSizeChanged(
        _In_ CoreWindow^ sender,
        _In_ WindowSizeChangedEventArgs^ args
        )
    {
        m_renderTargetView = nullptr;
        CreateWindowSizeDependentResources();
    }

    // This method creates all application resources that depend on
    // the application window size.  It is called at app initialization,
    // and whenever the application window size changes.
    void CreateWindowSizeDependentResources()
    {
        if (m_swapChain != nullptr)
        {
            // If the swap chain already exists, resize it.
            DX::ThrowIfFailed(
                m_swapChain->ResizeBuffers(
                    2,
                    0,
                    0,
                    DXGI_FORMAT_B8G8R8A8_UNORM,
                    0
                    )
                );
        }
        else
        {
            // If the swap chain does not exist, create it.
            DXGI_SWAP_CHAIN_DESC1 swapChainDesc = {0};

            swapChainDesc.Stereo = false;
            swapChainDesc.BufferUsage = DXGI_USAGE_RENDER_TARGET_OUTPUT;
            swapChainDesc.Scaling = DXGI_SCALING_NONE;
            swapChainDesc.Flags = 0;

            // Use automatic sizing.
            swapChainDesc.Width = 0;
            swapChainDesc.Height = 0;

            // This is the most common swap chain format.
            swapChainDesc.Format = DXGI_FORMAT_B8G8R8A8_UNORM;

            // Don't use multi-sampling.
            swapChainDesc.SampleDesc.Count = 1;
            swapChainDesc.SampleDesc.Quality = 0;

            // Use two buffers to enable flip effect.
            swapChainDesc.BufferCount = 2;

            // We recommend using this swap effect for all applications.
            swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL;


            // Once the swap chain description is configured, it must be
            // created on the same adapter as the existing D3D Device.

            // First, retrieve the underlying DXGI Device from the D3D Device.
            ComPtr<IDXGIDevice2> dxgiDevice;
            DX::ThrowIfFailed(
                m_d3dDevice.As(&dxgiDevice)
                );

            // Ensure that DXGI does not queue more than one frame at a time. This both reduces
            // latency and ensures that the application will only render after each VSync, minimizing
            // power consumption.
            DX::ThrowIfFailed(
                dxgiDevice->SetMaximumFrameLatency(1)
                );

            // Next, get the parent factory from the DXGI Device.
            ComPtr<IDXGIAdapter> dxgiAdapter;
            DX::ThrowIfFailed(
                dxgiDevice->GetAdapter(&dxgiAdapter)
                );

            ComPtr<IDXGIFactory2> dxgiFactory;
            DX::ThrowIfFailed(
                dxgiAdapter->GetParent(IID_PPV_ARGS(&dxgiFactory))
                );

            // Finally, create the swap chain.
            CoreWindow^ window = m_window.Get();
            DX::ThrowIfFailed(
                dxgiFactory->CreateSwapChainForCoreWindow(
                    m_d3dDevice.Get(),
                    reinterpret_cast<IUnknown*>(window),
                    &swapChainDesc,
                    nullptr, // allow on all displays
                    &m_swapChain
                    )
                );
        }

        // Once the swap chain is created, create a render target view.  This will
        // allow Direct3D to render graphics to the window.

        ComPtr<ID3D11Texture2D> backBuffer;
        DX::ThrowIfFailed(
            m_swapChain->GetBuffer(0, IID_PPV_ARGS(&backBuffer))
            );

        DX::ThrowIfFailed(
            m_d3dDevice->CreateRenderTargetView(
                backBuffer.Get(),
                nullptr,
                &m_renderTargetView
                )
            );

        // After the render target view is created, specify that the viewport,
        // which describes what portion of the window to draw to, should cover
        // the entire window.

        D3D11_TEXTURE2D_DESC backBufferDesc = {0};
        backBuffer->GetDesc(&backBufferDesc);

        D3D11_VIEWPORT viewport;
        viewport.TopLeftX = 0.0f;
        viewport.TopLeftY = 0.0f;
        viewport.Width = static_cast<float>(backBufferDesc.Width);
        viewport.Height = static_cast<float>(backBufferDesc.Height);
        viewport.MinDepth = D3D11_MIN_DEPTH;
        viewport.MaxDepth = D3D11_MAX_DEPTH;

        m_d3dDeviceContext->RSSetViewports(1, &viewport);
    }
};
```

## -examples

## -see-also
[DirectX swap chain implementation sample](https://github.com/microsoft/Win2D/tree/master/samples/CoreWindowExample), [IFrameworkViewSource](iframeworkviewsource.md)
