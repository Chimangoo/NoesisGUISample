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

public class Int16KeyFrameCollection : FreezableCollection {
  internal new static Int16KeyFrameCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Int16KeyFrameCollection(cPtr, cMemoryOwn);
  }

  internal Int16KeyFrameCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Int16KeyFrameCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected Int16KeyFrameCollection() {
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.Int16KeyFrameCollection_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

