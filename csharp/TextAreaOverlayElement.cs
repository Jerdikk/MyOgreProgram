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

public class TextAreaOverlayElement : OverlayElement {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TextAreaOverlayElement(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgreOverlayPINVOKE.TextAreaOverlayElement_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TextAreaOverlayElement obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgreOverlayPINVOKE.delete_TextAreaOverlayElement(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public TextAreaOverlayElement(string name) : this(OgreOverlayPINVOKE.new_TextAreaOverlayElement(name), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void initialise() {
    OgreOverlayPINVOKE.TextAreaOverlayElement_initialise(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void _releaseManualHardwareResources() {
    OgreOverlayPINVOKE.TextAreaOverlayElement__releaseManualHardwareResources(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void _restoreManualHardwareResources() {
    OgreOverlayPINVOKE.TextAreaOverlayElement__restoreManualHardwareResources(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setCaption(string text) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setCaption(swigCPtr, text);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCharHeight(float height) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setCharHeight(swigCPtr, height);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getCharHeight() {
    float ret = OgreOverlayPINVOKE.TextAreaOverlayElement_getCharHeight(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSpaceWidth(float width) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setSpaceWidth(swigCPtr, width);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getSpaceWidth() {
    float ret = OgreOverlayPINVOKE.TextAreaOverlayElement_getSpaceWidth(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFontName(string font, string group) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setFontName__SWIG_0(swigCPtr, font, group);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFontName(string font) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setFontName__SWIG_1(swigCPtr, font);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public FontPtr getFont() {
    FontPtr ret = new FontPtr(OgreOverlayPINVOKE.TextAreaOverlayElement_getFont(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string getTypeName() {
    string ret = OgreOverlayPINVOKE.TextAreaOverlayElement_getTypeName(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MaterialPtr getMaterial() {
    MaterialPtr ret = new MaterialPtr(OgreOverlayPINVOKE.TextAreaOverlayElement_getMaterial(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void getRenderOperation(RenderOperation op) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_getRenderOperation(swigCPtr, RenderOperation.getCPtr(op));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void setColour(ColourValue col) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setColour(swigCPtr, ColourValue.getCPtr(col));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override ColourValue getColour() {
    ColourValue ret = new ColourValue(OgreOverlayPINVOKE.TextAreaOverlayElement_getColour(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setColourBottom(ColourValue col) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setColourBottom(swigCPtr, ColourValue.getCPtr(col));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourValue getColourBottom() {
    ColourValue ret = new ColourValue(OgreOverlayPINVOKE.TextAreaOverlayElement_getColourBottom(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setColourTop(ColourValue col) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setColourTop(swigCPtr, ColourValue.getCPtr(col));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourValue getColourTop() {
    ColourValue ret = new ColourValue(OgreOverlayPINVOKE.TextAreaOverlayElement_getColourTop(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAlignment(TextAreaOverlayElement.Alignment a) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setAlignment(swigCPtr, (int)a);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public TextAreaOverlayElement.Alignment getAlignment() {
    TextAreaOverlayElement.Alignment ret = (TextAreaOverlayElement.Alignment)OgreOverlayPINVOKE.TextAreaOverlayElement_getAlignment(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void setMetricsMode(GuiMetricsMode gmm) {
    OgreOverlayPINVOKE.TextAreaOverlayElement_setMetricsMode(swigCPtr, (int)gmm);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void _update() {
    OgreOverlayPINVOKE.TextAreaOverlayElement__update(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum Alignment {
    Left,
    Right,
    Center
  }

}

}
