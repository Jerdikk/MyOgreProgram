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

public class OverlayManager : ScriptLoader {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal OverlayManager(global::System.IntPtr cPtr, bool cMemoryOwn) : base(OgreOverlayPINVOKE.OverlayManager_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OverlayManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          OgreOverlayPINVOKE.delete_OverlayManager(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public OverlayManager() : this(OgreOverlayPINVOKE.new_OverlayManager(), true) {
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _releaseManualHardwareResources() {
    OgreOverlayPINVOKE.OverlayManager__releaseManualHardwareResources(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _restoreManualHardwareResources() {
    OgreOverlayPINVOKE.OverlayManager__restoreManualHardwareResources(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override StringList getScriptPatterns() {
    StringList ret = new StringList(OgreOverlayPINVOKE.OverlayManager_getScriptPatterns(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void parseScript(DataStreamPtr stream, string groupName) {
    OgreOverlayPINVOKE.OverlayManager_parseScript(swigCPtr, DataStreamPtr.getCPtr(stream), groupName);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public override float getLoadingOrder() {
    float ret = OgreOverlayPINVOKE.OverlayManager_getLoadingOrder(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addOverlay(Overlay overlay) {
    OgreOverlayPINVOKE.OverlayManager_addOverlay(swigCPtr, Overlay.getCPtr(overlay));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public Overlay create(string name) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_create(swigCPtr, name);
    Overlay ret = (cPtr == global::System.IntPtr.Zero) ? null : new Overlay(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Overlay getByName(string name) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_getByName(swigCPtr, name);
    Overlay ret = (cPtr == global::System.IntPtr.Zero) ? null : new Overlay(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void destroy(string name) {
    OgreOverlayPINVOKE.OverlayManager_destroy__SWIG_0(swigCPtr, name);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroy(Overlay overlay) {
    OgreOverlayPINVOKE.OverlayManager_destroy__SWIG_1(swigCPtr, Overlay.getCPtr(overlay));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroyAll() {
    OgreOverlayPINVOKE.OverlayManager_destroyAll(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void _queueOverlaysForRendering(Camera cam, RenderQueue pQueue, Viewport vp) {
    OgreOverlayPINVOKE.OverlayManager__queueOverlaysForRendering(swigCPtr, Camera.getCPtr(cam), RenderQueue.getCPtr(pQueue), Viewport.getCPtr(vp));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getViewportHeight() {
    int ret = OgreOverlayPINVOKE.OverlayManager_getViewportHeight(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getViewportWidth() {
    int ret = OgreOverlayPINVOKE.OverlayManager_getViewportWidth(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getViewportAspectRatio() {
    float ret = OgreOverlayPINVOKE.OverlayManager_getViewportAspectRatio(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setPixelRatio(float ratio) {
    OgreOverlayPINVOKE.OverlayManager_setPixelRatio(swigCPtr, ratio);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public float getPixelRatio() {
    float ret = OgreOverlayPINVOKE.OverlayManager_getPixelRatio(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement createOverlayElement(string typeName, string instanceName, bool arg2) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_createOverlayElement__SWIG_0(swigCPtr, typeName, instanceName, arg2);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement createOverlayElement(string typeName, string instanceName) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_createOverlayElement__SWIG_1(swigCPtr, typeName, instanceName);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement getOverlayElement(string name, bool arg1) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_getOverlayElement__SWIG_0(swigCPtr, name, arg1);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement getOverlayElement(string name) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_getOverlayElement__SWIG_1(swigCPtr, name);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasOverlayElement(string name, bool arg1) {
    bool ret = OgreOverlayPINVOKE.OverlayManager_hasOverlayElement__SWIG_0(swigCPtr, name, arg1);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool hasOverlayElement(string name) {
    bool ret = OgreOverlayPINVOKE.OverlayManager_hasOverlayElement__SWIG_1(swigCPtr, name);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void destroyOverlayElement(string instanceName, bool arg1) {
    OgreOverlayPINVOKE.OverlayManager_destroyOverlayElement__SWIG_0(swigCPtr, instanceName, arg1);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroyOverlayElement(string instanceName) {
    OgreOverlayPINVOKE.OverlayManager_destroyOverlayElement__SWIG_1(swigCPtr, instanceName);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroyOverlayElement(OverlayElement pInstance, bool arg1) {
    OgreOverlayPINVOKE.OverlayManager_destroyOverlayElement__SWIG_2(swigCPtr, OverlayElement.getCPtr(pInstance), arg1);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroyOverlayElement(OverlayElement pInstance) {
    OgreOverlayPINVOKE.OverlayManager_destroyOverlayElement__SWIG_3(swigCPtr, OverlayElement.getCPtr(pInstance));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroyAllOverlayElements(bool arg0) {
    OgreOverlayPINVOKE.OverlayManager_destroyAllOverlayElements__SWIG_0(swigCPtr, arg0);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void destroyAllOverlayElements() {
    OgreOverlayPINVOKE.OverlayManager_destroyAllOverlayElements__SWIG_1(swigCPtr);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public void addOverlayElementFactory(OverlayElementFactory elemFactory) {
    OgreOverlayPINVOKE.OverlayManager_addOverlayElementFactory(swigCPtr, OverlayElementFactory.getCPtr(elemFactory));
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__mapT_std__string_Ogre__OverlayElementFactory_p_std__lessT_std__string_t_t getOverlayElementFactoryMap() {
    SWIGTYPE_p_std__mapT_std__string_Ogre__OverlayElementFactory_p_std__lessT_std__string_t_t ret = new SWIGTYPE_p_std__mapT_std__string_Ogre__OverlayElementFactory_p_std__lessT_std__string_t_t(OgreOverlayPINVOKE.OverlayManager_getOverlayElementFactoryMap(swigCPtr), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement createOverlayElementFromTemplate(string templateName, string typeName, string instanceName, bool arg3) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_createOverlayElementFromTemplate__SWIG_0(swigCPtr, templateName, typeName, instanceName, arg3);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement createOverlayElementFromTemplate(string templateName, string typeName, string instanceName) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_createOverlayElementFromTemplate__SWIG_1(swigCPtr, templateName, typeName, instanceName);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement cloneOverlayElementFromTemplate(string templateName, string instanceName) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_cloneOverlayElementFromTemplate(swigCPtr, templateName, instanceName);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OverlayElement createOverlayElementFromFactory(string typeName, string instanceName) {
    global::System.IntPtr cPtr = OgreOverlayPINVOKE.OverlayManager_createOverlayElementFromFactory(swigCPtr, typeName, instanceName);
    OverlayElement ret = (cPtr == global::System.IntPtr.Zero) ? null : new OverlayElement(cPtr, false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static OverlayManager getSingleton() {
    OverlayManager ret = new OverlayManager(OgreOverlayPINVOKE.OverlayManager_getSingleton(), false);
    if (OgreOverlayPINVOKE.SWIGPendingException.Pending) throw OgreOverlayPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
