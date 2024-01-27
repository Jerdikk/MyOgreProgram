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

public class RenderSystemCapabilities : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RenderSystemCapabilities(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RenderSystemCapabilities obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RenderSystemCapabilities() {
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
          OgrePINVOKE.delete_RenderSystemCapabilities(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public RenderSystemCapabilities() : this(OgrePINVOKE.new_RenderSystemCapabilities(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDriverVersion(DriverVersion version) {
    OgrePINVOKE.RenderSystemCapabilities_setDriverVersion(swigCPtr, DriverVersion.getCPtr(version));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void parseDriverVersionFromString(string versionString) {
    OgrePINVOKE.RenderSystemCapabilities_parseDriverVersionFromString(swigCPtr, versionString);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public DriverVersion getDriverVersion() {
    DriverVersion ret = new DriverVersion(OgrePINVOKE.RenderSystemCapabilities_getDriverVersion(swigCPtr), true);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GPUVendor getVendor() {
    GPUVendor ret = (GPUVendor)OgrePINVOKE.RenderSystemCapabilities_getVendor(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setVendor(GPUVendor v) {
    OgrePINVOKE.RenderSystemCapabilities_setVendor(swigCPtr, (int)v);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void parseVendorFromString(string vendorString) {
    OgrePINVOKE.RenderSystemCapabilities_parseVendorFromString(swigCPtr, vendorString);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public static GPUVendor vendorFromString(string vendorString) {
    GPUVendor ret = (GPUVendor)OgrePINVOKE.RenderSystemCapabilities_vendorFromString(vendorString);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string vendorToString(GPUVendor v) {
    string ret = OgrePINVOKE.RenderSystemCapabilities_vendorToString((int)v);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isDriverOlderThanVersion(DriverVersion v) {
    bool ret = OgrePINVOKE.RenderSystemCapabilities_isDriverOlderThanVersion(swigCPtr, DriverVersion.getCPtr(v));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNumTextureUnits(ushort num) {
    OgrePINVOKE.RenderSystemCapabilities_setNumTextureUnits(swigCPtr, num);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setStencilBufferBitDepth(ushort num) {
    OgrePINVOKE.RenderSystemCapabilities_setStencilBufferBitDepth(swigCPtr, num);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setNumMultiRenderTargets(ushort num) {
    OgrePINVOKE.RenderSystemCapabilities_setNumMultiRenderTargets(swigCPtr, num);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setNumVertexAttributes(ushort num) {
    OgrePINVOKE.RenderSystemCapabilities_setNumVertexAttributes(swigCPtr, num);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getNumVertexAttributes() {
    ushort ret = OgrePINVOKE.RenderSystemCapabilities_getNumVertexAttributes(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumTextureUnits() {
    ushort ret = OgrePINVOKE.RenderSystemCapabilities_getNumTextureUnits(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getStencilBufferBitDepth() {
    ushort ret = OgrePINVOKE.RenderSystemCapabilities_getStencilBufferBitDepth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getNumMultiRenderTargets() {
    ushort ret = OgrePINVOKE.RenderSystemCapabilities_getNumMultiRenderTargets(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isCapabilityRenderSystemSpecific(SWIGTYPE_Ogre__Capabilities c) {
    bool ret = OgrePINVOKE.RenderSystemCapabilities_isCapabilityRenderSystemSpecific(swigCPtr, (int)c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setCapability(SWIGTYPE_Ogre__Capabilities c) {
    OgrePINVOKE.RenderSystemCapabilities_setCapability(swigCPtr, (int)c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void unsetCapability(SWIGTYPE_Ogre__Capabilities c) {
    OgrePINVOKE.RenderSystemCapabilities_unsetCapability(swigCPtr, (int)c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool hasCapability(SWIGTYPE_Ogre__Capabilities c) {
    bool ret = OgrePINVOKE.RenderSystemCapabilities_hasCapability(swigCPtr, (int)c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void addShaderProfile(string profile) {
    OgrePINVOKE.RenderSystemCapabilities_addShaderProfile(swigCPtr, profile);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeShaderProfile(string profile) {
    OgrePINVOKE.RenderSystemCapabilities_removeShaderProfile(swigCPtr, profile);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isShaderProfileSupported(string profile) {
    bool ret = OgrePINVOKE.RenderSystemCapabilities_isShaderProfileSupported(swigCPtr, profile);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__setT_std__string_t getSupportedShaderProfiles() {
    SWIGTYPE_p_std__setT_std__string_t ret = new SWIGTYPE_p_std__setT_std__string_t(OgrePINVOKE.RenderSystemCapabilities_getSupportedShaderProfiles(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort getConstantFloatCount(GpuProgramType programType) {
    ushort ret = OgrePINVOKE.RenderSystemCapabilities_getConstantFloatCount(swigCPtr, (int)programType);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDeviceName(string name) {
    OgrePINVOKE.RenderSystemCapabilities_setDeviceName(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getDeviceName() {
    string ret = OgrePINVOKE.RenderSystemCapabilities_getDeviceName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setVertexProgramConstantFloatCount(ushort c) {
    OgrePINVOKE.RenderSystemCapabilities_setVertexProgramConstantFloatCount(swigCPtr, c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setGeometryProgramConstantFloatCount(ushort c) {
    OgrePINVOKE.RenderSystemCapabilities_setGeometryProgramConstantFloatCount(swigCPtr, c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setFragmentProgramConstantFloatCount(ushort c) {
    OgrePINVOKE.RenderSystemCapabilities_setFragmentProgramConstantFloatCount(swigCPtr, c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setMaxPointSize(float s) {
    OgrePINVOKE.RenderSystemCapabilities_setMaxPointSize(swigCPtr, s);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMaxPointSize() {
    float ret = OgrePINVOKE.RenderSystemCapabilities_getMaxPointSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNonPOW2TexturesLimited(bool l) {
    OgrePINVOKE.RenderSystemCapabilities_setNonPOW2TexturesLimited(swigCPtr, l);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getNonPOW2TexturesLimited() {
    bool ret = OgrePINVOKE.RenderSystemCapabilities_getNonPOW2TexturesLimited(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setMaxSupportedAnisotropy(float s) {
    OgrePINVOKE.RenderSystemCapabilities_setMaxSupportedAnisotropy(swigCPtr, s);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public float getMaxSupportedAnisotropy() {
    float ret = OgrePINVOKE.RenderSystemCapabilities_getMaxSupportedAnisotropy(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNumVertexTextureUnits(ushort n) {
    OgrePINVOKE.RenderSystemCapabilities_setNumVertexTextureUnits(swigCPtr, n);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getNumVertexTextureUnits() {
    ushort ret = OgrePINVOKE.RenderSystemCapabilities_getNumVertexTextureUnits(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGeometryProgramNumOutputVertices(int numOutputVertices) {
    OgrePINVOKE.RenderSystemCapabilities_setGeometryProgramNumOutputVertices(swigCPtr, numOutputVertices);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public int getGeometryProgramNumOutputVertices() {
    int ret = OgrePINVOKE.RenderSystemCapabilities_getGeometryProgramNumOutputVertices(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getRenderSystemName() {
    string ret = OgrePINVOKE.RenderSystemCapabilities_getRenderSystemName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setRenderSystemName(string rs) {
    OgrePINVOKE.RenderSystemCapabilities_setRenderSystemName(swigCPtr, rs);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setCategoryRelevant(CapabilitiesCategory cat, bool relevant) {
    OgrePINVOKE.RenderSystemCapabilities_setCategoryRelevant(swigCPtr, (int)cat, relevant);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isCategoryRelevant(CapabilitiesCategory cat) {
    bool ret = OgrePINVOKE.RenderSystemCapabilities_isCategoryRelevant(swigCPtr, (int)cat);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void log(Log pLog) {
    OgrePINVOKE.RenderSystemCapabilities_log(swigCPtr, Log.getCPtr(pLog));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setComputeProgramConstantFloatCount(ushort c) {
    OgrePINVOKE.RenderSystemCapabilities_setComputeProgramConstantFloatCount(swigCPtr, c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTessellationDomainProgramConstantFloatCount(ushort c) {
    OgrePINVOKE.RenderSystemCapabilities_setTessellationDomainProgramConstantFloatCount(swigCPtr, c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setTessellationHullProgramConstantFloatCount(ushort c) {
    OgrePINVOKE.RenderSystemCapabilities_setTessellationHullProgramConstantFloatCount(swigCPtr, c);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
