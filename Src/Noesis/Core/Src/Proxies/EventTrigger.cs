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

public class EventTrigger : TriggerBase {
  internal new static EventTrigger CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new EventTrigger(cPtr, cMemoryOwn);
  }

  internal EventTrigger(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(EventTrigger obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public EventTrigger() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_EventTrigger();
  }

  public TriggerActionCollection Actions {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.EventTrigger_Actions_get(swigCPtr);
      return (TriggerActionCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public RoutedEvent RoutedEvent {
    set {
      NoesisGUI_PINVOKE.EventTrigger_RoutedEvent_set(swigCPtr, RoutedEvent.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.EventTrigger_RoutedEvent_get(swigCPtr);
      return (RoutedEvent)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public string SourceName {
    set {
      NoesisGUI_PINVOKE.EventTrigger_SourceName_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.EventTrigger_SourceName_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  new internal static IntPtr GetStaticType() {
    IntPtr ret = NoesisGUI_PINVOKE.EventTrigger_GetStaticType();
    return ret;
  }

}

}

