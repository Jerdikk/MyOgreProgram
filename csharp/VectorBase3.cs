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

public class VectorBase3 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal VectorBase3(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VectorBase3 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VectorBase3() {
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
          OgrePINVOKE.delete_VectorBase3(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public float x {
    set {
      OgrePINVOKE.VectorBase3_x_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = OgrePINVOKE.VectorBase3_x_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float y {
    set {
      OgrePINVOKE.VectorBase3_y_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = OgrePINVOKE.VectorBase3_y_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public float z {
    set {
      OgrePINVOKE.VectorBase3_z_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      float ret = OgrePINVOKE.VectorBase3_z_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_float ptr() {
    global::System.IntPtr cPtr = OgrePINVOKE.VectorBase3_ptr__SWIG_0(swigCPtr);
    SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 crossProduct(Vector3 rkVector) {
    Vector3 ret = new Vector3(OgrePINVOKE.VectorBase3_crossProduct(swigCPtr, Vector3.getCPtr(rkVector)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 perpendicular() {
    Vector3 ret = new Vector3(OgrePINVOKE.VectorBase3_perpendicular(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float absDotProduct(VectorBase3 vec) {
    float ret = OgrePINVOKE.VectorBase3_absDotProduct(swigCPtr, VectorBase3.getCPtr(vec));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 midPoint(Vector3 vec) {
    Vector3 ret = new Vector3(OgrePINVOKE.VectorBase3_midPoint(swigCPtr, Vector3.getCPtr(vec)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 randomDeviant(Radian angle, Vector3 up) {
    Vector3 ret = new Vector3(OgrePINVOKE.VectorBase3_randomDeviant__SWIG_0(swigCPtr, Radian.getCPtr(angle), Vector3.getCPtr(up)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 randomDeviant(Radian angle) {
    Vector3 ret = new Vector3(OgrePINVOKE.VectorBase3_randomDeviant__SWIG_1(swigCPtr, Radian.getCPtr(angle)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Quaternion getRotationTo(Vector3 dest, Vector3 fallbackAxis) {
    Quaternion ret = new Quaternion(OgrePINVOKE.VectorBase3_getRotationTo__SWIG_0(swigCPtr, Vector3.getCPtr(dest), Vector3.getCPtr(fallbackAxis)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Quaternion getRotationTo(Vector3 dest) {
    Quaternion ret = new Quaternion(OgrePINVOKE.VectorBase3_getRotationTo__SWIG_1(swigCPtr, Vector3.getCPtr(dest)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool positionCloses(Vector3 rhs, float tolerance) {
    bool ret = OgrePINVOKE.VectorBase3_positionCloses__SWIG_0(swigCPtr, Vector3.getCPtr(rhs), tolerance);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool positionCloses(Vector3 rhs) {
    bool ret = OgrePINVOKE.VectorBase3_positionCloses__SWIG_1(swigCPtr, Vector3.getCPtr(rhs));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool directionEquals(Vector3 rhs, Radian tolerance) {
    bool ret = OgrePINVOKE.VectorBase3_directionEquals(swigCPtr, Vector3.getCPtr(rhs), Radian.getCPtr(tolerance));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector3 primaryAxis() {
    Vector3 ret = new Vector3(OgrePINVOKE.VectorBase3_primaryAxis(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
