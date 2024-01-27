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

public class RibbonTrail : BillboardChain {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RibbonTrail(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgrePINVOKE.RibbonTrail_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RibbonTrail obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgrePINVOKE.delete_RibbonTrail(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public RibbonTrail(string name, uint maxElements, uint numberOfChains, bool useTextureCoords, bool useVertexColours) : this(OgrePINVOKE.new_RibbonTrail__SWIG_0(name, maxElements, numberOfChains, useTextureCoords, useVertexColours), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public RibbonTrail(string name, uint maxElements, uint numberOfChains, bool useTextureCoords) : this(OgrePINVOKE.new_RibbonTrail__SWIG_1(name, maxElements, numberOfChains, useTextureCoords), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public RibbonTrail(string name, uint maxElements, uint numberOfChains) : this(OgrePINVOKE.new_RibbonTrail__SWIG_2(name, maxElements, numberOfChains), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public RibbonTrail(string name, uint maxElements) : this(OgrePINVOKE.new_RibbonTrail__SWIG_3(name, maxElements), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public RibbonTrail(string name) : this(OgrePINVOKE.new_RibbonTrail__SWIG_4(name), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void addNode(Node n) {
    OgrePINVOKE.RibbonTrail_addNode(swigCPtr, Node.getCPtr(n));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void removeNode(Node n) {
    OgrePINVOKE.RibbonTrail_removeNode(swigCPtr, Node.getCPtr(n));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual uint getChainIndexForNode(Node n) {
    uint ret = OgrePINVOKE.RibbonTrail_getChainIndexForNode(swigCPtr, Node.getCPtr(n));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTrailLength(float len) {
    OgrePINVOKE.RibbonTrail_setTrailLength(swigCPtr, len);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getTrailLength() {
    float ret = OgrePINVOKE.RibbonTrail_getTrailLength(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void setMaxChainElements(uint maxElements) {
    OgrePINVOKE.RibbonTrail_setMaxChainElements(swigCPtr, maxElements);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setNumberOfChains(uint numChains) {
    OgrePINVOKE.RibbonTrail_setNumberOfChains(swigCPtr, numChains);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public override void clearChain(uint chainIndex) {
    OgrePINVOKE.RibbonTrail_clearChain(swigCPtr, chainIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setInitialColour(uint chainIndex, ColourValue col) {
    OgrePINVOKE.RibbonTrail_setInitialColour__SWIG_0(swigCPtr, chainIndex, ColourValue.getCPtr(col));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setInitialColour(uint chainIndex, float r, float g, float b, float a) {
    OgrePINVOKE.RibbonTrail_setInitialColour__SWIG_1(swigCPtr, chainIndex, r, g, b, a);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setInitialColour(uint chainIndex, float r, float g, float b) {
    OgrePINVOKE.RibbonTrail_setInitialColour__SWIG_2(swigCPtr, chainIndex, r, g, b);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourValue getInitialColour(uint chainIndex) {
    ColourValue ret = new ColourValue(OgrePINVOKE.RibbonTrail_getInitialColour(swigCPtr, chainIndex), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setColourChange(uint chainIndex, ColourValue valuePerSecond) {
    OgrePINVOKE.RibbonTrail_setColourChange__SWIG_0(swigCPtr, chainIndex, ColourValue.getCPtr(valuePerSecond));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void setInitialWidth(uint chainIndex, float width) {
    OgrePINVOKE.RibbonTrail_setInitialWidth(swigCPtr, chainIndex, width);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getInitialWidth(uint chainIndex) {
    float ret = OgrePINVOKE.RibbonTrail_getInitialWidth(swigCPtr, chainIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setWidthChange(uint chainIndex, float widthDeltaPerSecond) {
    OgrePINVOKE.RibbonTrail_setWidthChange(swigCPtr, chainIndex, widthDeltaPerSecond);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getWidthChange(uint chainIndex) {
    float ret = OgrePINVOKE.RibbonTrail_getWidthChange(swigCPtr, chainIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setColourChange(uint chainIndex, float r, float g, float b, float a) {
    OgrePINVOKE.RibbonTrail_setColourChange__SWIG_1(swigCPtr, chainIndex, r, g, b, a);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourValue getColourChange(uint chainIndex) {
    ColourValue ret = new ColourValue(OgrePINVOKE.RibbonTrail_getColourChange(swigCPtr, chainIndex), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void nodeUpdated(Node node) {
    OgrePINVOKE.RibbonTrail_nodeUpdated(swigCPtr, Node.getCPtr(node));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void nodeDestroyed(Node node) {
    OgrePINVOKE.RibbonTrail_nodeDestroyed(swigCPtr, Node.getCPtr(node));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void _timeUpdate(float time) {
    OgrePINVOKE.RibbonTrail__timeUpdate(swigCPtr, time);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getMovableType() {
    string ret = OgrePINVOKE.RibbonTrail_getMovableType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
