using System;
using System.Runtime.InteropServices;

namespace Noesis
{
    public partial class Texture
    {
        public enum Format
        {
            BGRA8,
            BGRX8,
            R8,
            BC1,
            BC2,
            BC3
        }

        private class ManagedTexture
        {
            public object Texture;
        }

        /// <summary>
        /// Creates a Texture wrapper for the specified D3D11 texture native handle
        /// <param name="nativePointer">ID3D11Texture2D native pointer</param>
        /// </summary>
        public static Texture WrapD3D11Texture(object texture, IntPtr nativePointer,
            int width, int height, int numMipMaps, Format format, bool isInverted)
        {
            Texture tex = WrapD3D11(nativePointer, width, height, numMipMaps, (int)format,
                isInverted);

            if (texture != null)
            {
                tex.SetPrivateData(new ManagedTexture { Texture = texture });
            }

            return tex;
        }

        /// <summary>
        /// Creates a Texture wrapper for the specified GL texture native handle
        /// <param name="nativePointer">GLuint texture name</param>
        /// </summary>
        public static Texture WrapGLTexture(object texture, IntPtr nativePointer,
            int width, int height, int numMipMaps, Format format, bool isInverted)
        {
            Texture tex = WrapGL(nativePointer, width, height, numMipMaps, (int)format, isInverted);

            if (texture != null)
            {
                tex.SetPrivateData(new ManagedTexture { Texture = texture });
            }

            return tex;
        }

        #region Imports

        private static Texture WrapD3D11(IntPtr nativePointer, int width, int height, int numMipMaps,
            int format, bool isInverted)
        {
            IntPtr texPtr = Noesis_WrapD3D11Texture(nativePointer, width, height, numMipMaps,
                format, isInverted);
            Error.Check();
            return new Texture(texPtr, true);
        }

        private static Texture WrapGL(IntPtr nativePointer, int width, int height, int numMipMaps,
            int format, bool isInverted)
        {
            IntPtr texPtr = Noesis_WrapGLTexture(nativePointer, width, height, numMipMaps,
                format, isInverted);
            Error.Check();
            return new Texture(texPtr, true);
        }

        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_WrapD3D11Texture(IntPtr nativePointer,
            int width, int height, int numMipMaps, int format, bool isInverted);

        [DllImport(Library.Name)]
        private static extern IntPtr Noesis_WrapGLTexture(IntPtr nativePointer,
            int width, int height, int numMipMaps, int format, bool isInverted);

        #endregion
    }

}
