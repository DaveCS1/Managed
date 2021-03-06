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

public class DragEventArgs : RoutedEventArgs {
  private HandleRef swigCPtr;

  internal DragEventArgs(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(DragEventArgs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~DragEventArgs() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NoesisGUI_PINVOKE.delete_DragEventArgs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal static new void InvokeHandler(Delegate handler, IntPtr sender, IntPtr args) {
    DragEventHandler handler_ = (DragEventHandler)handler;
    if (handler_ != null) {
      handler_(Extend.GetProxy(sender, false), new DragEventArgs(args, false));
    }
  }

  public IDataObject Data {
    get { return new DataObject(GetDataHelper()); }
  }

  public DragDropKeyStates KeyStates {
    get { return GetKeyStatesHelper(); }
  }

  public DragDropEffects AllowedEffects {
    get { return GetAllowedEffectsHelper(); }
  }

  public DragDropEffects Effects {
    get { return GetEffectsHelper(); }
    set { SetEffectsHelper(value); }
  }

  public Point GetPosition(UIElement relativeTo) {
    IntPtr ret = NoesisGUI_PINVOKE.DragEventArgs_GetPosition(swigCPtr, UIElement.getCPtr(relativeTo));
    if (ret != IntPtr.Zero) {
      return Marshal.PtrToStructure<Point>(ret);
    }
    else {
      return new Point();
    }
  }

  private object GetDataHelper() {
    IntPtr cPtr = NoesisGUI_PINVOKE.DragEventArgs_GetDataHelper(swigCPtr);
    return Noesis.Extend.GetProxy(cPtr, false);
  }

  private DragDropKeyStates GetKeyStatesHelper() {
    DragDropKeyStates ret = (DragDropKeyStates)NoesisGUI_PINVOKE.DragEventArgs_GetKeyStatesHelper(swigCPtr);
    return ret;
  }

  private DragDropEffects GetAllowedEffectsHelper() {
    DragDropEffects ret = (DragDropEffects)NoesisGUI_PINVOKE.DragEventArgs_GetAllowedEffectsHelper(swigCPtr);
    return ret;
  }

  private DragDropEffects GetEffectsHelper() {
    DragDropEffects ret = (DragDropEffects)NoesisGUI_PINVOKE.DragEventArgs_GetEffectsHelper(swigCPtr);
    return ret;
  }

  private void SetEffectsHelper(DragDropEffects value) {
    NoesisGUI_PINVOKE.DragEventArgs_SetEffectsHelper(swigCPtr, (int)value);
  }

}

}

