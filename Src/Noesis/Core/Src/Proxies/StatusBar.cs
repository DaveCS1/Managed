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

public class StatusBar : ItemsControl {
  internal new static StatusBar CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new StatusBar(cPtr, cMemoryOwn);
  }

  internal StatusBar(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(StatusBar obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public StatusBar() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(StatusBar)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_StatusBar();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty SeparatorStyleKey {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.StatusBar_SeparatorStyleKey_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.StatusBar_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_StatusBar(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

