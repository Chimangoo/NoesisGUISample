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

public class RectKeyFrame : Freezable {
  internal new static RectKeyFrame CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new RectKeyFrame(cPtr, cMemoryOwn);
  }

  internal RectKeyFrame(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(RectKeyFrame obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected RectKeyFrame() {
  }

  public static DependencyProperty KeyTimeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RectKeyFrame_KeyTimeProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ValueProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RectKeyFrame_ValueProperty_get();
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public KeyTime KeyTime {
    set {
      NoesisGUI_PINVOKE.RectKeyFrame_KeyTime_set(swigCPtr, ref value);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.RectKeyFrame_KeyTime_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<KeyTime>(ret);
      }
      else {
        return new KeyTime();
      }
    }

  }

  public Rect Value {
    set {
      NoesisGUI_PINVOKE.RectKeyFrame_Value_set(swigCPtr, ref value);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.RectKeyFrame_Value_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Rect>(ret);
      }
      else {
        return new Rect();
      }
    }

  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.RectKeyFrame_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

