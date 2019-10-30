using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media.Media3D;

namespace Matrix3DProjectionSample
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        // <SnippetMatrix3DProjectionSample_code>
        private void ApplyProjection(Object sender, PointerRoutedEventArgs e)
        {
            // Translate the image along the negative Z-axis such that it occupies 50% of the
            // vertical field of view.
            double fovY = Math.PI / 2.0;
            double translationZ = -BeachImage.ActualHeight / Math.Tan(fovY / 2.0);
            double theta = 20.0 * Math.PI / 180.0;

            // You can create a 3D effect by creating a number of simple 
            // tranformation Matrix3D matrices and then multiply them together.
            Matrix3D centerImageAtOrigin = TranslationTransform(
                     -BeachImage.ActualWidth / 2.0,
                     -BeachImage.ActualHeight / 2.0, 0);
            Matrix3D invertYAxis = CreateScaleTransform(1.0, -1.0, 1.0);
            Matrix3D rotateAboutY = RotateYTransform(theta);
            Matrix3D translateAwayFromCamera = TranslationTransform(0, 0, translationZ);
            Matrix3D perspective = PerspectiveTransformFovRH(fovY,
                    LayoutRoot.ActualWidth / LayoutRoot.ActualHeight,   // aspect ratio
                    1.0,                                                // near plane
                    1000.0);                                            // far plane
            Matrix3D viewport = ViewportTransform(LayoutRoot.ActualWidth, LayoutRoot.ActualHeight);

            Matrix3D m = Matrix3DHelper.Multiply(centerImageAtOrigin,invertYAxis);
            m = Matrix3D.Multiply(m ,rotateAboutY);
            m = Matrix3D.Multiply(m,translateAwayFromCamera);
            m = Matrix3D.Multiply(m,perspective);
            m = Matrix3D.Multiply(m,viewport);

            Matrix3DProjection m3dProjection = new Matrix3DProjection();
            m3dProjection.ProjectionMatrix = m;

            BeachImage.Projection = m3dProjection;
        }

        private Matrix3D TranslationTransform(double tx, double ty, double tz)
        {
            Matrix3D m = new Matrix3D();

            m.M11 = 1.0; m.M12 = 0.0; m.M13 = 0.0; m.M14 = 0.0;
            m.M21 = 0.0; m.M22 = 1.0; m.M23 = 0.0; m.M24 = 0.0;
            m.M31 = 0.0; m.M32 = 0.0; m.M33 = 1.0; m.M34 = 0.0;
            m.OffsetX = tx; m.OffsetY = ty; m.OffsetZ = tz; m.M44 = 1.0;

            return m;
        }

        private Matrix3D CreateScaleTransform(double sx, double sy, double sz)
        {
            Matrix3D m = new Matrix3D();

            m.M11 = sx; m.M12 = 0.0; m.M13 = 0.0; m.M14 = 0.0;
            m.M21 = 0.0; m.M22 = sy; m.M23 = 0.0; m.M24 = 0.0;
            m.M31 = 0.0; m.M32 = 0.0; m.M33 = sz; m.M34 = 0.0;
            m.OffsetX = 0.0; m.OffsetY = 0.0; m.OffsetZ = 0.0; m.M44 = 1.0;

            return m;
        }

        private Matrix3D RotateYTransform(double theta)
        {
            double sin = Math.Sin(theta);
            double cos = Math.Cos(theta);

            Matrix3D m = new Matrix3D();

            m.M11 = cos; m.M12 = 0.0; m.M13 = -sin; m.M14 = 0.0;
            m.M21 = 0.0; m.M22 = 1.0; m.M23 = 0.0; m.M24 = 0.0;
            m.M31 = sin; m.M32 = 0.0; m.M33 = cos; m.M34 = 0.0;
            m.OffsetX = 0.0; m.OffsetY = 0.0; m.OffsetZ = 0.0; m.M44 = 1.0;

            return m;
        }

        private Matrix3D RotateZTransform(double theta)
        {
            double cos = Math.Cos(theta);
            double sin = Math.Sin(theta);

            Matrix3D m = new Matrix3D();
            m.M11 = cos; m.M12 = sin; m.M13 = 0.0; m.M14 = 0.0;
            m.M21 = -sin; m.M22 = cos; m.M23 = 0.0; m.M24 = 0.0;
            m.M31 = 0.0; m.M32 = 0.0; m.M33 = 1.0; m.M34 = 0.0;
            m.OffsetX = 0.0; m.OffsetY = 0.0; m.OffsetZ = 0.0; m.M44 = 1.0;
            return m;
        }

        private Matrix3D PerspectiveTransformFovRH(double fieldOfViewY, double aspectRatio, double zNearPlane, double zFarPlane)
        {
            double height = 1.0 / Math.Tan(fieldOfViewY / 2.0);
            double width = height / aspectRatio;
            double d = zNearPlane - zFarPlane;

            Matrix3D m = new Matrix3D();
            m.M11 = width; m.M12 = 0; m.M13 = 0; m.M14 = 0;
            m.M21 = 0; m.M22 = height; m.M23 = 0; m.M24 = 0;
            m.M31 = 0; m.M32 = 0; m.M33 = zFarPlane / d; m.M34 = -1;
            m.OffsetX = 0; m.OffsetY = 0; m.OffsetZ = zNearPlane * zFarPlane / d; m.M44 = 0;

            return m;
        }

        private Matrix3D ViewportTransform(double width, double height)
        {
            Matrix3D m = new Matrix3D();

            m.M11 = width / 2.0; m.M12 = 0.0; m.M13 = 0.0; m.M14 = 0.0;
            m.M21 = 0.0; m.M22 = -height / 2.0; m.M23 = 0.0; m.M24 = 0.0;
            m.M31 = 0.0; m.M32 = 0.0; m.M33 = 1.0; m.M34 = 0.0;
            m.OffsetX = width / 2.0; m.OffsetY = height / 2.0; m.OffsetZ = 0.0; m.M44 = 1.0;

            return m;
        }
        // </SnippetMatrix3DProjectionSample_code>


    }
}
