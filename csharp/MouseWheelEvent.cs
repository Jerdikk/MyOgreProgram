//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace org.ogre {

public class MouseWheelEvent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MouseWheelEvent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MouseWheelEvent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MouseWheelEvent() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          BitesPINVOKE.delete_MouseWheelEvent(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int type {
    set {
      BitesPINVOKE.MouseWheelEvent_type_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = BitesPINVOKE.MouseWheelEvent_type_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int y {
    set {
      BitesPINVOKE.MouseWheelEvent_y_set(swigCPtr, value);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      int ret = BitesPINVOKE.MouseWheelEvent_y_get(swigCPtr);
      if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MouseWheelEvent() : this(BitesPINVOKE.new_MouseWheelEvent(), true) {
    if (BitesPINVOKE.SWIGPendingException.Pending) throw BitesPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
