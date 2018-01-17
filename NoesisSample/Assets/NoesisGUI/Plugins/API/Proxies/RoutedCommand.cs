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

public class RoutedCommand : BaseComponent {
  internal new static RoutedCommand CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new RoutedCommand(cPtr, cMemoryOwn);
  }

  internal RoutedCommand(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(RoutedCommand obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected RoutedCommand() {
  }

  public bool CanExecute(object param, UIElement target) {
    bool ret = NoesisGUI_PINVOKE.RoutedCommand_CanExecute__SWIG_0(swigCPtr, Noesis.Extend.GetInstanceHandle(param), UIElement.getCPtr(target));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Execute(object param, UIElement target) {
    NoesisGUI_PINVOKE.RoutedCommand_Execute__SWIG_0(swigCPtr, Noesis.Extend.GetInstanceHandle(param), UIElement.getCPtr(target));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetName() {
    IntPtr strPtr = NoesisGUI_PINVOKE.RoutedCommand_GetName(swigCPtr);
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
    return str;
  }

  public bool CanExecute(object param) {
    bool ret = NoesisGUI_PINVOKE.RoutedCommand_CanExecute__SWIG_1(swigCPtr, Noesis.Extend.GetInstanceHandle(param));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Execute(object param) {
    NoesisGUI_PINVOKE.RoutedCommand_Execute__SWIG_1(swigCPtr, Noesis.Extend.GetInstanceHandle(param));
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
  }

  public InputGestureCollection InputGestures {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RoutedCommand_InputGestures_get(swigCPtr);
      if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
      return (InputGestureCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.RoutedCommand_GetStaticType();
    if (NoesisGUI_PINVOKE.SWIGPendingException.Pending) throw NoesisGUI_PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

