---
-api-id: T:Windows.Media.Effects.IVideoCompositor
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IVideoCompositor : Windows.Media.IMediaExtension
-->

# Windows.Media.Effects.IVideoCompositor

## -description
The interface you implement to create a custom video compositor.

## -remarks
1. In a Windows Runtime Component project, derive a public sealed class from this interface (see example below).
2. Use the full class name in a [MediaOverlayLayer](/uwp/api/windows.media.editing.mediaoverlaylayer) constructor.  

    var propertySet = new PropertySet
    {
        ["Feather"] = true,
        ["Tolerance"] = 0.2f,
        ["Color"] = Colors.Blue
    };

    var compositorDefinition = new VideoCompositorDefinition(
        "Effects.ChromaKeyVideoCompositor",
        propertySet);

    var mediaOverlayLayer = new MediaOverlayLayer(compositorDefinition);
    
## -examples
    
    using Microsoft.Graphics.Canvas;
    using Microsoft.Graphics.Canvas.Effects;
    using Windows.Foundation.Collections;
    using Windows.Graphics.DirectX.Direct3D11;
    using Windows.Media.Effects;
    using Windows.Media.MediaProperties;
    using Windows.UI;

    namespace Effects
    {
        /// <summary>
        /// Chroma key compositor
        /// <list type="Bullet">
        /// <listheader>Properties</listheader>
        /// <item>Color (Color) : Chroma key color (default is black)</item>
        /// <item>Feather (Boolean): true to soften edges of the output (default is false)</item>
        /// <item>Tolerance (float): Color tolerance 0-1 (default is 0.1)</item>
        /// <item>InvertAlpha (Boolean): invert the alpha value (default is false)</item>
        /// </list>
        /// </summary>
        public sealed class ChromaKeyVideoCompositor : IVideoCompositor
        {
            #region Fields
            private VideoEncodingProperties _backgroundProperties;
            private CanvasDevice _canvasDevice;
            #endregion

            #region Properties
            /// <summary>
            /// Gets the chroma-key color
            /// </summary>
            public Color Color { get; private set; } = Colors.Black;

            /// <summary>
            /// Gets a value indicating whether to feather the edges of the chroma key
            /// </summary>
            public bool Feather { get; private set; } = false;

            /// <summary>
            /// Gets the color tolerance 
            /// </summary>
            public float Tolerance { get; private set; } = 0.1f;

            /// <summary>
            /// Gets a value indicating whether to invert the alpha transparency
            /// </summary>
            public bool InvertAlpha { get; private set; } = false;

            /// <summary>
            /// Gets a value indicating whether the compositor is time-independent
            /// </summary>
            public bool TimeIndependent => true;
            #endregion

            #region Methods
            /// <summary>
            /// Sets the encoding properties
            /// </summary>
            /// <param name="backgroundProperties">the background properties</param>
            /// <param name="device">the Direct3D device</param>
            public void SetEncodingProperties(VideoEncodingProperties backgroundProperties, IDirect3DDevice device)
            {
                _backgroundProperties = backgroundProperties;

                _canvasDevice = CanvasDevice.CreateFromDirect3D11Device(device);
            }

            /// <summary>
            /// Composite the frame
            /// </summary>
            /// <param name="context">the composite frame context</param>
            public void CompositeFrame(CompositeVideoFrameContext context)
            {
                foreach (var surface in context.SurfacesToOverlay)
                {
                    using (CanvasBitmap inputBitmap = CanvasBitmap.CreateFromDirect3D11Surface(_canvasDevice, surface))
                    using (CanvasRenderTarget renderTarget = CanvasRenderTarget.CreateFromDirect3D11Surface(_canvasDevice, context.OutputFrame.Direct3DSurface))
                    using (CanvasDrawingSession ds = renderTarget.CreateDrawingSession())
                    using (var chromaKeyEffect = new ChromaKeyEffect
                    {
                        Source = inputBitmap,
                        Color = Color,
                        Feather = Feather,
                        Tolerance = Tolerance,
                        InvertAlpha = InvertAlpha
                    })
                    {
                        var overlay = context.GetOverlayForSurface(surface);

                        var destinationRectangle = overlay.Position;

                        var sourceRectangle = inputBitmap.Bounds;
                    
                        var opacity = System.Convert.ToSingle(overlay.Opacity);

                        ds.DrawImage(chromaKeyEffect, destinationRectangle, sourceRectangle, opacity);
                    }
                }
            }

            /// <summary>
            /// Close the compositor & dispose of the canvas device
            /// </summary>
            /// <param name="reason">the media effect closed reason</param>
            public void Close(MediaEffectClosedReason reason)
            {
                if (_canvasDevice != null)
                {
                    _canvasDevice.Dispose();
                    _canvasDevice = null;
                }
            }

            /// <summary>
            /// Discard of the queued frames
            /// </summary>
            /// <remarks>this does nothing</remarks>
            public void DiscardQueuedFrames()
            {
            }

            /// <summary>
            /// Sets the properties passed into the compositor
            /// </summary>
            /// <param name="configuration">the configuration</param>
            public void SetProperties(IPropertySet configuration)
            {
                if (configuration == null)
                {
                    return;
                }

                object value;

                if (configuration.TryGetValue("Color", out value))
                {
                    Color = (Color)value;
                }

                if (configuration.TryGetValue("Tolerance", out value))
                {
                    Tolerance = (float)value;
                }

                if (configuration.TryGetValue("Feather", out value))
                {
                    Feather = (bool)value;
                }

                if (configuration.TryGetValue("InvertAlpha", out value))
                {
                    InvertAlpha = (bool)value;
                }
            }
            #endregion
        }
    }

## -see-also
[IMediaExtension](../windows.media/imediaextension.md)
