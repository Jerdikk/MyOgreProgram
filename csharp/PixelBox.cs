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

public class PixelBox : Box {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PixelBox(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.PixelBox_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PixelBox obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_PixelBox(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public PixelBox() : this(OgrePINVOKE.new_PixelBox__SWIG_0(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public PixelBox(Box extents, PixelFormat pixelFormat, global::System.IntPtr pixelData) : this(OgrePINVOKE.new_PixelBox__SWIG_1(Box.getCPtr(extents), (int)pixelFormat, pixelData), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public PixelBox(Box extents, PixelFormat pixelFormat) : this(OgrePINVOKE.new_PixelBox__SWIG_2(Box.getCPtr(extents), (int)pixelFormat), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public PixelBox(uint width, uint height, uint depth, PixelFormat pixelFormat, global::System.IntPtr pixelData) : this(OgrePINVOKE.new_PixelBox__SWIG_3(width, height, depth, (int)pixelFormat, pixelData), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public PixelBox(uint width, uint height, uint depth, PixelFormat pixelFormat) : this(OgrePINVOKE.new_PixelBox__SWIG_4(width, height, depth, (int)pixelFormat), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_unsigned_char data {
    set {
      OgrePINVOKE.PixelBox_data_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = OgrePINVOKE.PixelBox_data_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint rowPitch {
    set {
      OgrePINVOKE.PixelBox_rowPitch_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.PixelBox_rowPitch_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint slicePitch {
    set {
      OgrePINVOKE.PixelBox_slicePitch_set(swigCPtr, value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      uint ret = OgrePINVOKE.PixelBox_slicePitch_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public PixelFormat format {
    set {
      OgrePINVOKE.PixelBox_format_set(swigCPtr, (int)value);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      PixelFormat ret = (PixelFormat)OgrePINVOKE.PixelBox_format_get(swigCPtr);
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void setConsecutive() {
    OgrePINVOKE.PixelBox_setConsecutive(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getRowSkip() {
    uint ret = OgrePINVOKE.PixelBox_getRowSkip(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getSliceSkip() {
    uint ret = OgrePINVOKE.PixelBox_getSliceSkip(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isConsecutive() {
    bool ret = OgrePINVOKE.PixelBox_isConsecutive(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getConsecutiveSize() {
    uint ret = OgrePINVOKE.PixelBox_getConsecutiveSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PixelBox getSubVolume(Box def, bool resetOrigin) {
    PixelBox ret = new PixelBox(OgrePINVOKE.PixelBox_getSubVolume__SWIG_0(swigCPtr, Box.getCPtr(def), resetOrigin), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PixelBox getSubVolume(Box def) {
    PixelBox ret = new PixelBox(OgrePINVOKE.PixelBox_getSubVolume__SWIG_1(swigCPtr, Box.getCPtr(def)), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned_char getTopLeftFrontPixelPtr() {
    global::System.IntPtr cPtr = OgrePINVOKE.PixelBox_getTopLeftFrontPixelPtr(swigCPtr);
    SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ColourValue getColourAt(uint x, uint y, uint z) {
    ColourValue ret = new ColourValue(OgrePINVOKE.PixelBox_getColourAt(swigCPtr, x, y, z), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setColourAt(ColourValue cv, uint x, uint y, uint z) {
    OgrePINVOKE.PixelBox_setColourAt(swigCPtr, ColourValue.getCPtr(cv), x, y, z);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public global::System.IntPtr getData() {
    global::System.IntPtr ret = OgrePINVOKE.PixelBox_getData(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
