//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;

namespace Noesis
{

public partial class BaseComponent {
  protected HandleRef swigCPtr;

  internal static BaseComponent CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new BaseComponent(cPtr, cMemoryOwn);
  }

  public BaseComponent(IntPtr cPtr, bool cMemoryOwn) {
    Init(cPtr, cMemoryOwn, false);
  }

  public static HandleRef getCPtr(BaseComponent obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BaseComponent() {
    lock (this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        ReleaseProxy(swigCPtr.Handle);
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
    }
  }

  internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.BaseComponent_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal static IntPtr GetDynamicType(IntPtr cPtr) {
    IntPtr ret = NoesisGUI_PINVOKE.BaseComponent_GetDynamicType(cPtr);
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal static void AddReference(IntPtr cPtr) {
    NoesisGUI_PINVOKE.BaseComponent_AddReference(cPtr);
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  internal static void Release(IntPtr cPtr) {
    NoesisGUI_PINVOKE.BaseComponent_Release(cPtr);
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }


  internal static IntPtr Extend(string typeName) {
    IntPtr nativeType = NoesisGUI_PINVOKE.Extend_BaseComponent(Marshal.StringToHGlobalAnsi(typeName));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return nativeType;
  }
}

}

