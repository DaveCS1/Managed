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

public class RadioButton : ToggleButton {
  internal new static RadioButton CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new RadioButton(cPtr, cMemoryOwn);
  }

  internal RadioButton(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(RadioButton obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public RadioButton() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(RadioButton)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_RadioButton();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public static DependencyProperty GroupNameProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RadioButton_GroupNameProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public string GroupName {
    set {
      NoesisGUI_PINVOKE.RadioButton_GroupName_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.RadioButton_GroupName_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.RadioButton_GetStaticType();
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_RadioButton(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

