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

public class Archive : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Archive(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Archive obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Archive() {
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
          OgrePINVOKE.delete_Archive(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string getName() {
    string ret = OgrePINVOKE.Archive_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool isCaseSensitive() {
    bool ret = OgrePINVOKE.Archive_isCaseSensitive(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void load() {
    OgrePINVOKE.Archive_load(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void unload() {
    OgrePINVOKE.Archive_unload(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool isReadOnly() {
    bool ret = OgrePINVOKE.Archive_isReadOnly(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DataStreamPtr open(string filename, bool readOnly) {
    DataStreamPtr ret = new DataStreamPtr(OgrePINVOKE.Archive_open__SWIG_0(swigCPtr, filename, readOnly), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DataStreamPtr open(string filename) {
    DataStreamPtr ret = new DataStreamPtr(OgrePINVOKE.Archive_open__SWIG_1(swigCPtr, filename), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DataStreamPtr create(string filename) {
    DataStreamPtr ret = new DataStreamPtr(OgrePINVOKE.Archive_create(swigCPtr, filename), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void remove(string filename) {
    OgrePINVOKE.Archive_remove(swigCPtr, filename);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual StringListPtr list(bool recursive, bool dirs) {
    StringListPtr ret = new StringListPtr(OgrePINVOKE.Archive_list__SWIG_0(swigCPtr, recursive, dirs), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual StringListPtr list(bool recursive) {
    StringListPtr ret = new StringListPtr(OgrePINVOKE.Archive_list__SWIG_1(swigCPtr, recursive), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual StringListPtr list() {
    StringListPtr ret = new StringListPtr(OgrePINVOKE.Archive_list__SWIG_2(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t listFileInfo(bool recursive, bool dirs) {
    SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t(OgrePINVOKE.Archive_listFileInfo__SWIG_0(swigCPtr, recursive, dirs), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t listFileInfo(bool recursive) {
    SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t(OgrePINVOKE.Archive_listFileInfo__SWIG_1(swigCPtr, recursive), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t listFileInfo() {
    SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t(OgrePINVOKE.Archive_listFileInfo__SWIG_2(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual StringListPtr find(string pattern, bool recursive, bool dirs) {
    StringListPtr ret = new StringListPtr(OgrePINVOKE.Archive_find__SWIG_0(swigCPtr, pattern, recursive, dirs), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual StringListPtr find(string pattern, bool recursive) {
    StringListPtr ret = new StringListPtr(OgrePINVOKE.Archive_find__SWIG_1(swigCPtr, pattern, recursive), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual StringListPtr find(string pattern) {
    StringListPtr ret = new StringListPtr(OgrePINVOKE.Archive_find__SWIG_2(swigCPtr, pattern), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool exists(string filename) {
    bool ret = OgrePINVOKE.Archive_exists(swigCPtr, filename);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_time_t getModifiedTime(string filename) {
    SWIGTYPE_p_time_t ret = new SWIGTYPE_p_time_t(OgrePINVOKE.Archive_getModifiedTime(swigCPtr, filename), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t findFileInfo(string pattern, bool recursive, bool dirs) {
    SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t(OgrePINVOKE.Archive_findFileInfo__SWIG_0(swigCPtr, pattern, recursive, dirs), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t findFileInfo(string pattern, bool recursive) {
    SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t(OgrePINVOKE.Archive_findFileInfo__SWIG_1(swigCPtr, pattern, recursive), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t findFileInfo(string pattern) {
    SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t ret = new SWIGTYPE_p_Ogre__SharedPtrT_std__vectorT_Ogre__FileInfo_t_t(OgrePINVOKE.Archive_findFileInfo__SWIG_2(swigCPtr, pattern), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getType() {
    string ret = OgrePINVOKE.Archive_getType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
