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

public class ConfigFile : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ConfigFile(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ConfigFile obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ConfigFile() {
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
          OgrePINVOKE.delete_ConfigFile(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ConfigFile() : this(OgrePINVOKE.new_ConfigFile(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadDirect(string filename, string separators, bool trimWhitespace) {
    OgrePINVOKE.ConfigFile_loadDirect__SWIG_0(swigCPtr, filename, separators, trimWhitespace);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadDirect(string filename, string separators) {
    OgrePINVOKE.ConfigFile_loadDirect__SWIG_1(swigCPtr, filename, separators);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadDirect(string filename) {
    OgrePINVOKE.ConfigFile_loadDirect__SWIG_2(swigCPtr, filename);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadFromResourceSystem(string filename, string resourceGroup, string separators, bool trimWhitespace) {
    OgrePINVOKE.ConfigFile_loadFromResourceSystem__SWIG_0(swigCPtr, filename, resourceGroup, separators, trimWhitespace);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadFromResourceSystem(string filename, string resourceGroup, string separators) {
    OgrePINVOKE.ConfigFile_loadFromResourceSystem__SWIG_1(swigCPtr, filename, resourceGroup, separators);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadFromResourceSystem(string filename, string resourceGroup) {
    OgrePINVOKE.ConfigFile_loadFromResourceSystem__SWIG_2(swigCPtr, filename, resourceGroup);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getSetting(string key, string section, string defaultValue) {
    string ret = OgrePINVOKE.ConfigFile_getSetting__SWIG_0(swigCPtr, key, section, defaultValue);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getSetting(string key, string section) {
    string ret = OgrePINVOKE.ConfigFile_getSetting__SWIG_1(swigCPtr, key, section);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getSetting(string key) {
    string ret = OgrePINVOKE.ConfigFile_getSetting__SWIG_2(swigCPtr, key);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringList getMultiSetting(string key, string section) {
    StringList ret = new StringList(OgrePINVOKE.ConfigFile_getMultiSetting__SWIG_0(swigCPtr, key, section), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringList getMultiSetting(string key) {
    StringList ret = new StringList(OgrePINVOKE.ConfigFile_getMultiSetting__SWIG_1(swigCPtr, key), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SettingsBySectionMap getSettingsBySection() {
    SettingsBySectionMap ret = new SettingsBySectionMap(OgrePINVOKE.ConfigFile_getSettingsBySection(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__multimapT_std__string_std__string_t getSettings(string section) {
    SWIGTYPE_p_std__multimapT_std__string_std__string_t ret = new SWIGTYPE_p_std__multimapT_std__string_std__string_t(OgrePINVOKE.ConfigFile_getSettings__SWIG_0(swigCPtr, section), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__multimapT_std__string_std__string_t getSettings() {
    SWIGTYPE_p_std__multimapT_std__string_std__string_t ret = new SWIGTYPE_p_std__multimapT_std__string_std__string_t(OgrePINVOKE.ConfigFile_getSettings__SWIG_1(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clear() {
    OgrePINVOKE.ConfigFile_clear(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}