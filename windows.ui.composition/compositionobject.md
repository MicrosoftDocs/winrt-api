---
-api-id: T:Windows.UI.Composition.CompositionObject
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionObject : Windows.Foundation.IClosable, Windows.UI.Composition.ICompositionObject, Windows.UI.Composition.ICompositionObject2
-->

# Windows.UI.Composition.CompositionObject

## -description
Base class of the composition API representing a node in the visual tree structure.

Composition objects are the visual tree structure on which all other features of the composition API use and build on. The API allows developers to define and create one or many [Visual](visual.md) objects each representing a single node in a Visual tree.



## -remarks
Objects are created using a [Compositor](compositor.md) object. The composition objects can be containers only or can hold content. The API allows for ease of use by providing a clear set of Visual objects for specific tasks that exist in a hierarchy:

+ [Visual](visual.md) – base object, the majority of the properties are here, and inherited by the other Visual objects.
+ [ContainerVisual](containervisual.md) – derives from [Visual](visual.md), and adds the ability to create children.
+ [SpriteVisual](spritevisual.md) – derives from [ContainerVisual](containervisual.md), and contains content in the form of images, effects, and swapchains.
+ [Compositor](compositor.md) – manages the relationship between an application and the system compositor process.
Animations update the properties of any animatable composition object (such as Visual). There are two types of Animations:

+ [KeyFrameAnimation](keyframeanimation.md): Time-based animations with two or more key frames. These frames are markers, allowing developers to define what the animated value should be at the specified time. Animations can additionally be fine-tuned by specifying how the animation interpolates (blends) the values between key frames. [KeyFrameAnimation](keyframeanimation.md) has many subclasses each supporting a different type of key frame value.
+ [ExpressionAnimation](expressionanimation.md): Animations that use a mathematical expression to specify how the animated value should be calculated each frame. The expressions can reference properties from composition objects. [ExpressionAnimation](expressionanimation.md)s are not time-based and are processed each frame (if necessary).

### Primitive Visuals

Primitive Visuals (such as [SpriteVisual](spritevisual.md)) describe visual content on the screen, and the rendering options which will be applied to that content.

### Effects

Effects can be attached to the visual tree in order to cause dynamic pixel changes to source content, such as images, or trees of visuals.

An effect can be simple operations such as a desaturation, more complicated operations such as blurs, or very complex A B blend operations such as cross fades.

See the remarks section of [CompositionEffectBrush](compositioneffectbrush.md) for additional information on creating and using effects.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | Comment |
| 1607 | 14393 | ImplicitAnimations |
| 1607 | 14393 | StartAnimationGroup |
| 1607 | 14393 | StopAnimationGroup |
| 1709 | 16299 | DispatcherQueue |
| 1803 | 17134 | TryGetAnimationController |
| 1809 | 17763 | PopulatePropertyInfo |
| 1809 | 17763 | StartAnimationGroupWithIAnimationObject |
| 1809 | 17763 | StartAnimationWithIAnimationObject |

## -examples
This sample shows how the composition API can be used to create a self-contained app without using XAML, WWA, or DirectX. The sample initializes a new [Compositor](compositor.md), and then creates a scene graph with two [SpriteVisual](spritevisual.md) objects.

```csharp

using System;
using System.Numerics;

using Windows.ApplicationModel.Core;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Core;

namespace HelloCompositionCs
{
    public sealed class HelloComposition : IFrameworkView
    {
        //------------------------------------------------------------------------------
        //
        // HelloComposition.Initialize
        //
        // This method is called during startup to associate the IFrameworkView with the
        // CoreApplicationView.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.Initialize(CoreApplicationView view)
        {
            _view = view;
        }


        //------------------------------------------------------------------------------
        //
        // HelloComposition.SetWindow
        //
        // This method is called when the CoreApplication has created a new CoreWindow,
        // allowing the application to configure the window and start producing content
        // to display.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.SetWindow(CoreWindow window)
        {
            _window = window;
            InitNewComposition();
        }


        //------------------------------------------------------------------------------
        //
        // HelloComposition.Load
        //
        // This method is called when a specific page is being loaded in the
        // application.  It is not used for this application.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.Load(string unused)
        {

        }


        //------------------------------------------------------------------------------
        //
        // HelloComposition.Run
        //
        // This method is called by CoreApplication.Run to actually run the
        // dispatcher's message pump.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.Run()
        {
            _window.Activate();
            _window.Dispatcher.ProcessEvents(CoreProcessEventsOption.ProcessUntilQuit);
        }


        //------------------------------------------------------------------------------
        //
        // HelloComposition.Uninitialize
        //
        // This method is called during shutdown to disconnect the CoreApplicationView,
        // and CoreWindow from the IFrameworkView.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.Uninitialize()
        {
            _window = null;
            _view = null;
        }


        //------------------------------------------------------------------------------
        //
        // HelloComposition.InitNewComposition
        //
        // This method is called by SetWindow, where we initialize Composition after
        // the CoreWindow has been created.
        //
        //------------------------------------------------------------------------------

        void InitNewComposition()
        {
            //
            // Set up Windows.UI.Composition Compositor, root ContainerVisual, and associate with
            // the CoreWindow.
            //

            _compositor = new Compositor();

            _root = _compositor.CreateContainerVisual();
            _view.CompositionRootVisual = _root;


            //
            // Create a simple scene.
            //

            var child1 = _compositor.CreateSpriteVisual();
            child1.Offset = new Vector2(50.0f, 50.0f);
            child1.Size = new Vector2(200, 200);
            child1.Brush = _compositor.CreateColorBrush(Color.FromArgb(0xFF, 0x00, 0xCC, 0x00));

            _root.Children.InsertAtTop(child1);
            
            var child2 = _compositor.CreateSpriteVisual();
            child2.Offset = new Vector2(50.0f, 50.0f);
            child2.Size = new Vector2(200, 200);
            child2.Brush = _compositor.CreateColorBrush(Color.FromArgb(0xFF, 0x00, 0x00, 0xCC));
            
            child1.Children.InsertAtTop(child2);

        }


        // CoreWindow / CoreApplicationView
        private CoreWindow _window;
        private CoreApplicationView _view;

        // Windows.UI.Composition
        private Compositor _compositor;
        private ContainerVisual _root;
    }


    public sealed class HelloCompositionFactory : IFrameworkViewSource
    {
        //------------------------------------------------------------------------------
        //
        // HelloCompositionFactory.CreateView
        //
        // This method is called by CoreApplication to provide a new IFrameworkView for
        // a CoreWindow that is being created.
        //
        //------------------------------------------------------------------------------

        IFrameworkView IFrameworkViewSource.CreateView()
        {
            return new HelloComposition();
        }


        //------------------------------------------------------------------------------
        //
        // main
        //
        //------------------------------------------------------------------------------

        static int Main(string[] args)
        {
            CoreApplication.Run(new HelloCompositionFactory());

            return 0;
        }
    }

} // namespace HelloCompositionCs
          
          
```

This sample shows how to construct and walk a simple tree of Visuals to change opacity without using XAML, WWA, or DirectX. This sample builds on the previous sample to show how child Visuals are created, added and properties are changed.

In this scenario a Visual tree hierarchy of Visuals is built. Once a Compositor is created it is used to create objects which can then be managed.

```csharp

//  Copyright (c) Microsoft Corporation. All rights reserved.

using System;
using System.Numerics;

using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Core;

namespace VisualTreeCs
{
    public sealed class VisualTree : IFrameworkView
    {
        //------------------------------------------------------------------------------
        //
        // VisualTree.Initialize
        //
        // This method is called during startup to associate the IFrameworkView with the
        // CoreApplicationView.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.Initialize(CoreApplicationView view)
        {
            _view = view;
            _random = new Random();
        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.SetWindow
        //
        // This method is called when the CoreApplication has created a new CoreWindow,
        // allowing the application to configure the window and start producing content
        // to display.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.SetWindow(CoreWindow window)
        {
            _window = window;
            InitNewComposition();
            _window.PointerPressed += OnPointerPressed;
            _window.PointerMoved += OnPointerMoved;
            _window.PointerReleased += OnPointerReleased;
        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.OnPointerPressed
        //
        // This method is called when the user touches the screen, taps it with a stylus
        // or clicks the mouse.
        //
        //------------------------------------------------------------------------------

        void OnPointerPressed(CoreWindow window, PointerEventArgs args)
        {
            Point position = args.CurrentPoint.Position;

            //
            // Walk our list of visuals to determine who, if anybody, was selected
            //
            foreach (var child in _root.Children)
            {
                //
                // Did we hit this child?
                //
                Vector2 offset = child.Offset;
                Vector2 size = child.Size;

                if ((position.X >= offset.X) &&
                    (position.X < offset.X + size.X) &&
                    (position.Y >= offset.Y) &&
                    (position.Y < offset.Y + size.Y))
                {
                    //
                    // This child was hit. Since the children are stored back to front,
                    // the last one hit is the front-most one so it wins
                    //
                    _currentVisual = child;
                    _offsetBias = new Vector2((float)(offset.X - position.X),
                                              (float)(offset.Y - position.Y));
                }
            }

            //
            // If a visual was hit, bring it to the front of the Z order
            //
            if (_currentVisual != null)
            {
                ContainerVisual parent = _currentVisual.Parent as ContainerVisual;
                parent.Children.Remove(_currentVisual);
                parent.Children.InsertAtTop(_currentVisual);
            }
        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.OnPointerMoved
        //
        // This method is called when the user moves their finger, stylus or mouse with
        // a button pressed over the screen.
        //
        //------------------------------------------------------------------------------

        void OnPointerMoved(CoreWindow window, PointerEventArgs args)
        {
            //
            // If a visual is selected, drag it with the pointer position and
            // make it opaque while we drag it
            //
            if (_currentVisual != null)
            {
                Point position = args.CurrentPoint.Position;
                _currentVisual.Opacity = 1.0f;
                _currentVisual.Offset = new Vector2((float)(position.X + _offsetBias.X),
                                                    (float)(position.Y + _offsetBias.Y));
            }
        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.OnPointerReleased
        //
        // This method is called when the user lifts their finger or stylus from the
        // screen, or lifts the mouse button.
        //
        //------------------------------------------------------------------------------

        void OnPointerReleased(CoreWindow window, PointerEventArgs args)
        {
            //
            // If a visual was selected, make it transparent again when it is
            // released
            //
            if (_currentVisual != null)
            {
                _currentVisual.Opacity = 0.8f;
                _currentVisual = null;
            }
        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.Load
        //
        // This method is called when a specific page is being loaded in the
        // application.  It is not used for this application.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.Load(string unused)
        {

        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.Run
        //
        // This method is called by CoreApplication.Run to actually run the
        // dispatcher's message pump.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.Run()
        {
            _window.Activate();
            _window.Dispatcher.ProcessEvents(CoreProcessEventsOption.ProcessUntilQuit);
        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.Uninitialize
        //
        // This method is called during shutdown to disconnect the CoreApplicationView,
        // and CoreWindow from the IFrameworkView.
        //
        //------------------------------------------------------------------------------

        void IFrameworkView.Uninitialize()
        {
            _window = null;
            _view = null;
        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.InitNewComposition
        //
        // This method is called by SetWindow, where we initialize Composition after
        // the CoreWindow has been created.
        //
        //------------------------------------------------------------------------------

        void InitNewComposition()
        {
            //
            // Set up Windows.UI.Composition Compositor, root ContainerVisual, and associate with
            // the CoreWindow.
            //

            _compositor = new Compositor();

            _root = _compositor.CreateContainerVisual();
            _view.CompositionRootVisual = _root;

            //
            // Create a few visuals for our window
            //
            for (int index = 0; index < 20; index++)
            {
                _root.Children.InsertAtTop(CreateChildElement());
            }
        }

        //------------------------------------------------------------------------------
        //
        // VisualTree.CreateChildElement
        //
        // Creates a small sub-tree to represent a visible element in our application.
        //
        //------------------------------------------------------------------------------

        Visual CreateChildElement()
        {
            //
            // Each element consists of two visuals, which produce the appearance
            // of a framed rectangle
            //
            var visual = _compositor.CreateSpriteVisual();

            //
            // Position this visual randomly within our window
            //
            visual.Offset = new Vector2((float)(_random.NextDouble() * 400), (float)(_random.NextDouble() * 400));

            //
            // The outer rectangle is always white
            //
            visual.Brush = _compositor.CreateColorBrush( Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF) );
            visual.Size = new Vector2(100.0f, 100.0f);

            //
            // The inner rectangle is inset from the outer by three pixels all around
            //
            var child = _compositor.CreateSpriteVisual();
            visual.Children.InsertAtTop(child);
            child.Offset = new Vector2(3.0f, 3.0f);
            child.Size = new Vector2(94.0f, 94.0f);

            //
            // Pick a random color for every rectangle
            //
            byte red = (byte)(0xFF * (0.2f + (_random.NextDouble() / 0.8f)));
            byte green = (byte)(0xFF * (0.2f + (_random.NextDouble() / 0.8f)));
            byte blue = (byte)(0xFF * (0.2f + (_random.NextDouble() / 0.8f)));
            child.Brush = _compositor.CreateColorBrush( Color.FromArgb(0xFF, red, green, blue) );

            //
            // Make the subtree root visual partially transparent. This will cause each visual in the subtree
            // to render partially transparent, since a visual's opacity is multiplied with its parent's
            // opacity
            //
            visual.Opacity = 0.8f;

            return visual;
        }

        // CoreWindow / CoreApplicationView
        private CoreWindow _window;
        private CoreApplicationView _view;

        // Windows.UI.Composition
        private Compositor _compositor;
        private ContainerVisual _root;
        private Visual _currentVisual;
        private Vector2 _offsetBias;

        // Helpers
        private Random _random;
    }


    public sealed class VisualTreeFactory : IFrameworkViewSource
    {
        //------------------------------------------------------------------------------
        //
        // VisualTreeFactory.CreateView
        //
        // This method is called by CoreApplication to provide a new IFrameworkView for
        // a CoreWindow that is being created.
        //
        //------------------------------------------------------------------------------

        IFrameworkView IFrameworkViewSource.CreateView()
        {
            return new VisualTree();
        }

        //------------------------------------------------------------------------------
        //
        // main
        //
        //------------------------------------------------------------------------------

        static int Main(string[] args)
        {
            CoreApplication.Run(new VisualTreeFactory());

            return 0;
        }
    }

} // namespace VisualTreeCs
          
          
```



## -see-also
[IClosable](../windows.foundation/iclosable.md)
