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

public class Viewport : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Viewport(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Viewport obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Viewport() {
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
          OgrePINVOKE.delete_Viewport(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public class Listener : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Listener(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Listener obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Listener() {
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
            OgrePINVOKE.delete_Viewport_Listener(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
      }
    }
  
    public void viewportCameraChanged(Viewport viewport) {
      if (SwigDerivedClassHasMethod("viewportCameraChanged", swigMethodTypes0)) OgrePINVOKE.Viewport_Listener_viewportCameraChangedSwigExplicitListener(swigCPtr, Viewport.getCPtr(viewport)); else OgrePINVOKE.Viewport_Listener_viewportCameraChanged(swigCPtr, Viewport.getCPtr(viewport));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public void viewportDimensionsChanged(Viewport viewport) {
      if (SwigDerivedClassHasMethod("viewportDimensionsChanged", swigMethodTypes1)) OgrePINVOKE.Viewport_Listener_viewportDimensionsChangedSwigExplicitListener(swigCPtr, Viewport.getCPtr(viewport)); else OgrePINVOKE.Viewport_Listener_viewportDimensionsChanged(swigCPtr, Viewport.getCPtr(viewport));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public void viewportDestroyed(Viewport viewport) {
      if (SwigDerivedClassHasMethod("viewportDestroyed", swigMethodTypes2)) OgrePINVOKE.Viewport_Listener_viewportDestroyedSwigExplicitListener(swigCPtr, Viewport.getCPtr(viewport)); else OgrePINVOKE.Viewport_Listener_viewportDestroyed(swigCPtr, Viewport.getCPtr(viewport));
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Listener() : this(OgrePINVOKE.new_Viewport_Listener(), true) {
      if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
      SwigDirectorConnect();
    }
  
    private void SwigDirectorConnect() {
      if (SwigDerivedClassHasMethod("viewportCameraChanged", swigMethodTypes0))
        swigDelegate0 = new SwigDelegateListener_0(SwigDirectorMethodviewportCameraChanged);
      if (SwigDerivedClassHasMethod("viewportDimensionsChanged", swigMethodTypes1))
        swigDelegate1 = new SwigDelegateListener_1(SwigDirectorMethodviewportDimensionsChanged);
      if (SwigDerivedClassHasMethod("viewportDestroyed", swigMethodTypes2))
        swigDelegate2 = new SwigDelegateListener_2(SwigDirectorMethodviewportDestroyed);
      OgrePINVOKE.Viewport_Listener_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2);
    }
  
    private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
      global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
      bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(Listener));
      return hasDerivedMethod;
    }
  
    private void SwigDirectorMethodviewportCameraChanged(global::System.IntPtr viewport) {
      viewportCameraChanged((viewport == global::System.IntPtr.Zero) ? null : new Viewport(viewport, false));
    }
  
    private void SwigDirectorMethodviewportDimensionsChanged(global::System.IntPtr viewport) {
      viewportDimensionsChanged((viewport == global::System.IntPtr.Zero) ? null : new Viewport(viewport, false));
    }
  
    private void SwigDirectorMethodviewportDestroyed(global::System.IntPtr viewport) {
      viewportDestroyed((viewport == global::System.IntPtr.Zero) ? null : new Viewport(viewport, false));
    }
  
    public delegate void SwigDelegateListener_0(global::System.IntPtr viewport);
    public delegate void SwigDelegateListener_1(global::System.IntPtr viewport);
    public delegate void SwigDelegateListener_2(global::System.IntPtr viewport);
  
    private SwigDelegateListener_0 swigDelegate0;
    private SwigDelegateListener_1 swigDelegate1;
    private SwigDelegateListener_2 swigDelegate2;
  
    private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(Viewport) };
    private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(Viewport) };
    private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(Viewport) };
  }

  public Viewport(Camera camera, RenderTarget target, float left, float top, float width, float height, int ZOrder) : this(OgrePINVOKE.new_Viewport(Camera.getCPtr(camera), RenderTarget.getCPtr(target), left, top, width, height, ZOrder), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _updateDimensions() {
    OgrePINVOKE.Viewport__updateDimensions(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void update() {
    OgrePINVOKE.Viewport_update(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear(uint buffers, ColourValue colour, float depth, ushort stencil) {
    OgrePINVOKE.Viewport_clear__SWIG_0(swigCPtr, buffers, ColourValue.getCPtr(colour), depth, stencil);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear(uint buffers, ColourValue colour, float depth) {
    OgrePINVOKE.Viewport_clear__SWIG_1(swigCPtr, buffers, ColourValue.getCPtr(colour), depth);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear(uint buffers, ColourValue colour) {
    OgrePINVOKE.Viewport_clear__SWIG_2(swigCPtr, buffers, ColourValue.getCPtr(colour));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear(uint buffers) {
    OgrePINVOKE.Viewport_clear__SWIG_3(swigCPtr, buffers);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void clear() {
    OgrePINVOKE.Viewport_clear__SWIG_4(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public RenderTarget getTarget() {
    global::System.IntPtr cPtr = OgrePINVOKE.Viewport_getTarget(swigCPtr);
    RenderTarget ret = (cPtr == global::System.IntPtr.Zero) ? null : new RenderTarget(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Camera getCamera() {
    global::System.IntPtr cPtr = OgrePINVOKE.Viewport_getCamera(swigCPtr);
    Camera ret = (cPtr == global::System.IntPtr.Zero) ? null : new Camera(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCamera(Camera cam) {
    OgrePINVOKE.Viewport_setCamera(swigCPtr, Camera.getCPtr(cam));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public int getZOrder() {
    int ret = OgrePINVOKE.Viewport_getZOrder(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getLeft() {
    float ret = OgrePINVOKE.Viewport_getLeft(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getTop() {
    float ret = OgrePINVOKE.Viewport_getTop(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getWidth() {
    float ret = OgrePINVOKE.Viewport_getWidth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getHeight() {
    float ret = OgrePINVOKE.Viewport_getHeight(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getActualLeft() {
    int ret = OgrePINVOKE.Viewport_getActualLeft(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getActualTop() {
    int ret = OgrePINVOKE.Viewport_getActualTop(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getActualWidth() {
    int ret = OgrePINVOKE.Viewport_getActualWidth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getActualHeight() {
    int ret = OgrePINVOKE.Viewport_getActualHeight(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDimensions(float left, float top, float width, float height) {
    OgrePINVOKE.Viewport_setDimensions(swigCPtr, left, top, width, height);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setBackgroundColour(ColourValue colour) {
    OgrePINVOKE.Viewport_setBackgroundColour(swigCPtr, ColourValue.getCPtr(colour));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourValue getBackgroundColour() {
    ColourValue ret = new ColourValue(OgrePINVOKE.Viewport_getBackgroundColour(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDepthClear(float depth) {
    OgrePINVOKE.Viewport_setDepthClear(swigCPtr, depth);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getDepthClear() {
    float ret = OgrePINVOKE.Viewport_getDepthClear(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setClearEveryFrame(bool clear, uint buffers) {
    OgrePINVOKE.Viewport_setClearEveryFrame__SWIG_0(swigCPtr, clear, buffers);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setClearEveryFrame(bool clear) {
    OgrePINVOKE.Viewport_setClearEveryFrame__SWIG_1(swigCPtr, clear);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getClearEveryFrame() {
    bool ret = OgrePINVOKE.Viewport_getClearEveryFrame(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getClearBuffers() {
    uint ret = OgrePINVOKE.Viewport_getClearBuffers(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setAutoUpdated(bool autoupdate) {
    OgrePINVOKE.Viewport_setAutoUpdated(swigCPtr, autoupdate);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isAutoUpdated() {
    bool ret = OgrePINVOKE.Viewport_isAutoUpdated(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMaterialScheme(string schemeName) {
    OgrePINVOKE.Viewport_setMaterialScheme(swigCPtr, schemeName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getMaterialScheme() {
    string ret = OgrePINVOKE.Viewport_getMaterialScheme(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_Ogre__TRectT_int_t getActualDimensions() {
    SWIGTYPE_p_Ogre__TRectT_int_t ret = new SWIGTYPE_p_Ogre__TRectT_int_t(OgrePINVOKE.Viewport_getActualDimensions(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool _isUpdated() {
    bool ret = OgrePINVOKE.Viewport__isUpdated(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _clearUpdatedFlag() {
    OgrePINVOKE.Viewport__clearUpdatedFlag(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint _getNumRenderedFaces() {
    uint ret = OgrePINVOKE.Viewport__getNumRenderedFaces(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint _getNumRenderedBatches() {
    uint ret = OgrePINVOKE.Viewport__getNumRenderedBatches(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setOverlaysEnabled(bool enabled) {
    OgrePINVOKE.Viewport_setOverlaysEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getOverlaysEnabled() {
    bool ret = OgrePINVOKE.Viewport_getOverlaysEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setSkiesEnabled(bool enabled) {
    OgrePINVOKE.Viewport_setSkiesEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getSkiesEnabled() {
    bool ret = OgrePINVOKE.Viewport_getSkiesEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setShadowsEnabled(bool enabled) {
    OgrePINVOKE.Viewport_setShadowsEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getShadowsEnabled() {
    bool ret = OgrePINVOKE.Viewport_getShadowsEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setVisibilityMask(uint mask) {
    OgrePINVOKE.Viewport_setVisibilityMask(swigCPtr, mask);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getVisibilityMask() {
    uint ret = OgrePINVOKE.Viewport_getVisibilityMask(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addListener(Viewport.Listener l) {
    OgrePINVOKE.Viewport_addListener(swigCPtr, Viewport.Listener.getCPtr(l));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeListener(Viewport.Listener l) {
    OgrePINVOKE.Viewport_removeListener(swigCPtr, Viewport.Listener.getCPtr(l));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDrawBuffer(ColourBufferType colourBuffer) {
    OgrePINVOKE.Viewport_setDrawBuffer(swigCPtr, (int)colourBuffer);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ColourBufferType getDrawBuffer() {
    ColourBufferType ret = (ColourBufferType)OgrePINVOKE.Viewport_getDrawBuffer(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}