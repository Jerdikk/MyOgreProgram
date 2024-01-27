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

public class DefaultHardwareBufferManagerBase : HardwareBufferManagerBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal DefaultHardwareBufferManagerBase(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.DefaultHardwareBufferManagerBase_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DefaultHardwareBufferManagerBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_DefaultHardwareBufferManagerBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public DefaultHardwareBufferManagerBase() : this(OgrePINVOKE.new_DefaultHardwareBufferManagerBase(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override HardwareVertexBufferPtr createVertexBuffer(uint vertexSize, uint numVerts, byte usage, bool useShadowBuffer) {
    HardwareVertexBufferPtr ret = new HardwareVertexBufferPtr(OgrePINVOKE.DefaultHardwareBufferManagerBase_createVertexBuffer__SWIG_0(swigCPtr, vertexSize, numVerts, usage, useShadowBuffer), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override HardwareVertexBufferPtr createVertexBuffer(uint vertexSize, uint numVerts, byte usage) {
    HardwareVertexBufferPtr ret = new HardwareVertexBufferPtr(OgrePINVOKE.DefaultHardwareBufferManagerBase_createVertexBuffer__SWIG_1(swigCPtr, vertexSize, numVerts, usage), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override HardwareIndexBufferPtr createIndexBuffer(HardwareIndexBuffer.IndexType itype, uint numIndexes, byte usage, bool useShadowBuffer) {
    HardwareIndexBufferPtr ret = new HardwareIndexBufferPtr(OgrePINVOKE.DefaultHardwareBufferManagerBase_createIndexBuffer__SWIG_0(swigCPtr, (int)itype, numIndexes, usage, useShadowBuffer), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override HardwareIndexBufferPtr createIndexBuffer(HardwareIndexBuffer.IndexType itype, uint numIndexes, byte usage) {
    HardwareIndexBufferPtr ret = new HardwareIndexBufferPtr(OgrePINVOKE.DefaultHardwareBufferManagerBase_createIndexBuffer__SWIG_1(swigCPtr, (int)itype, numIndexes, usage), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override HardwareBufferPtr createUniformBuffer(uint sizeBytes, HardwareBufferUsage arg1, bool arg2) {
    HardwareBufferPtr ret = new HardwareBufferPtr(OgrePINVOKE.DefaultHardwareBufferManagerBase_createUniformBuffer__SWIG_0(swigCPtr, sizeBytes, (int)arg1, arg2), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override HardwareBufferPtr createUniformBuffer(uint sizeBytes, HardwareBufferUsage arg1) {
    HardwareBufferPtr ret = new HardwareBufferPtr(OgrePINVOKE.DefaultHardwareBufferManagerBase_createUniformBuffer__SWIG_1(swigCPtr, sizeBytes, (int)arg1), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override HardwareBufferPtr createUniformBuffer(uint sizeBytes) {
    HardwareBufferPtr ret = new HardwareBufferPtr(OgrePINVOKE.DefaultHardwareBufferManagerBase_createUniformBuffer__SWIG_2(swigCPtr, sizeBytes), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}