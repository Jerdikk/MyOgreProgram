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

public class StringInterfacePtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StringInterfacePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StringInterfacePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StringInterfacePtr() {
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
          OgrePINVOKE.delete_StringInterfacePtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public StringInterfacePtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_StringInterfacePtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringInterfacePtr() : this(OgrePINVOKE.new_StringInterfacePtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringInterfacePtr(StringInterfacePtr r) : this(OgrePINVOKE.new_StringInterfacePtr__SWIG_2(StringInterfacePtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public StringInterface __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.StringInterfacePtr___deref__(swigCPtr);
    StringInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new StringInterface(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ParamDictionary getParamDictionary() {
    global::System.IntPtr cPtr = OgrePINVOKE.StringInterfacePtr_getParamDictionary__SWIG_0(swigCPtr);
    ParamDictionary ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParamDictionary(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringList getParameters() {
    StringList ret = new StringList(OgrePINVOKE.StringInterfacePtr_getParameters(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParameter(string name, string value) {
    bool ret = OgrePINVOKE.StringInterfacePtr_setParameter(swigCPtr, name, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParameterList(NameValueMap paramList) {
    OgrePINVOKE.StringInterfacePtr_setParameterList(swigCPtr, NameValueMap.getCPtr(paramList));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getParameter(string name) {
    string ret = OgrePINVOKE.StringInterfacePtr_getParameter(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyParametersTo(StringInterface dest) {
    OgrePINVOKE.StringInterfacePtr_copyParametersTo(swigCPtr, StringInterface.getCPtr(dest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void cleanupDictionary() {
    OgrePINVOKE.StringInterfacePtr_cleanupDictionary(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}