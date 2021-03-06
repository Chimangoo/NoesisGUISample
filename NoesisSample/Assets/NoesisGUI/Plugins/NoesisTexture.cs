using System;
using System.Runtime.InteropServices;

namespace Noesis
{
    public partial class Texture
    {
        public static Texture WrapTexture(object texture, IntPtr nativePointer,
            int width, int height, int numLevels)
        {
            IntPtr texturePtr = Noesis_WrapTexture_(nativePointer, width, height, numLevels);
            Noesis.Texture tex = new Noesis.Texture(texturePtr, true);
            tex.SetPrivateData(texture != null ? new ManagedTexture { Texture = texture } : null);
            return tex;
        }

        #region Imports
        static IntPtr Noesis_WrapTexture_(IntPtr texture, int width, int height,
            int numLevels)
        {
            IntPtr texturePtr = Noesis_WrapTexture(texture, width, height, numLevels);
            Noesis.Error.Check();

            return texturePtr;
        }

        [DllImport(Library.Name)]
        static extern IntPtr Noesis_WrapTexture(IntPtr texture, int width, int height,int numLevels);
        #endregion
    }
}
