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

public class VisibleObjectsBoundsInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VisibleObjectsBoundsInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VisibleObjectsBoundsInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VisibleObjectsBoundsInfo() {
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
          OgrePINVOKE.delete_VisibleObjectsBoundsInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public AxisAlignedBox aabb {
    set {
      OgrePINVOKE.VisibleObjectsBoundsInfo_aabb_set(swigCPtr, AxisAlignedBox.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.VisibleObjectsBoundsInfo_aabb_get(swigCPtr);
      AxisAlignedBox ret = (cPtr == global::System.IntPtr.Zero) ? null : new AxisAlignedBox(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public AxisAlignedBox receiverAabb {
    set {
      OgrePINVOKE.VisibleObjectsBoundsInfo_receiverAabb_set(swigCPtr, AxisAlignedBox.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.VisibleObjectsBoundsInfo_receiverAabb_get(swigCPtr);
      AxisAlignedBox ret = (cPtr == global::System.IntPtr.Zero) ? null : new AxisAlignedBox(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float minDistance {
    set {
      OgrePINVOKE.VisibleObjectsBoundsInfo_minDistance_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = OgrePINVOKE.VisibleObjectsBoundsInfo_minDistance_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float maxDistance {
    set {
      OgrePINVOKE.VisibleObjectsBoundsInfo_maxDistance_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = OgrePINVOKE.VisibleObjectsBoundsInfo_maxDistance_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float minDistanceInFrustum {
    set {
      OgrePINVOKE.VisibleObjectsBoundsInfo_minDistanceInFrustum_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = OgrePINVOKE.VisibleObjectsBoundsInfo_minDistanceInFrustum_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float maxDistanceInFrustum {
    set {
      OgrePINVOKE.VisibleObjectsBoundsInfo_maxDistanceInFrustum_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = OgrePINVOKE.VisibleObjectsBoundsInfo_maxDistanceInFrustum_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public VisibleObjectsBoundsInfo() : this(OgrePINVOKE.new_VisibleObjectsBoundsInfo(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reset() {
    OgrePINVOKE.VisibleObjectsBoundsInfo_reset(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void merge(AxisAlignedBox boxBounds, Sphere sphereBounds, Camera cam, bool receiver) {
    OgrePINVOKE.VisibleObjectsBoundsInfo_merge__SWIG_0(swigCPtr, AxisAlignedBox.getCPtr(boxBounds), Sphere.getCPtr(sphereBounds), Camera.getCPtr(cam), receiver);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void merge(AxisAlignedBox boxBounds, Sphere sphereBounds, Camera cam) {
    OgrePINVOKE.VisibleObjectsBoundsInfo_merge__SWIG_1(swigCPtr, AxisAlignedBox.getCPtr(boxBounds), Sphere.getCPtr(sphereBounds), Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void mergeNonRenderedButInFrustum(AxisAlignedBox boxBounds, Sphere sphereBounds, Camera cam) {
    OgrePINVOKE.VisibleObjectsBoundsInfo_mergeNonRenderedButInFrustum(swigCPtr, AxisAlignedBox.getCPtr(boxBounds), Sphere.getCPtr(sphereBounds), Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
