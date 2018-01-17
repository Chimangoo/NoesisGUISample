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

public class KeyGesture : InputGesture {
  internal new static KeyGesture CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new KeyGesture(cPtr, cMemoryOwn);
  }

  internal KeyGesture(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(KeyGesture obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public KeyGesture() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_KeyGesture__SWIG_0();
  }

  public KeyGesture(Key key, ModifierKeys modifiers) : this(NoesisGUI_PINVOKE.new_KeyGesture__SWIG_1((int)key, (uint)modifiers), true) {
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  public KeyGesture(Key key) : this(NoesisGUI_PINVOKE.new_KeyGesture__SWIG_2((int)key), true) {
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  public Key Key {
    get {
      Key ret = (Key)NoesisGUI_PINVOKE.KeyGesture_Key_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public ModifierKeys Modifiers {
    get {
      ModifierKeys ret = (ModifierKeys)NoesisGUI_PINVOKE.KeyGesture_Modifiers_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string DisplayString {
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.KeyGesture_DisplayString_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      NoesisGUI_PINVOKE.FreeString(strPtr);
      return str;
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.KeyGesture_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

