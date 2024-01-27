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

public class TexturePtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TexturePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TexturePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TexturePtr() {
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
          OgrePINVOKE.delete_TexturePtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public TexturePtr(SWIGTYPE_p_std__nullptr_t arg0) : this(OgrePINVOKE.new_TexturePtr__SWIG_0(SWIGTYPE_p_std__nullptr_t.getCPtr(arg0)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TexturePtr() : this(OgrePINVOKE.new_TexturePtr__SWIG_1(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TexturePtr(TexturePtr r) : this(OgrePINVOKE.new_TexturePtr__SWIG_2(TexturePtr.getCPtr(r)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public Texture __deref__() {
    global::System.IntPtr cPtr = OgrePINVOKE.TexturePtr___deref__(swigCPtr);
    Texture ret = (cPtr == global::System.IntPtr.Zero) ? null : new Texture(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setTextureType(TextureType ttype) {
    OgrePINVOKE.TexturePtr_setTextureType(swigCPtr, (int)ttype);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public TextureType getTextureType() {
    TextureType ret = (TextureType)OgrePINVOKE.TexturePtr_getTextureType(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getNumMipmaps() {
    uint ret = OgrePINVOKE.TexturePtr_getNumMipmaps(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setNumMipmaps(uint num) {
    OgrePINVOKE.TexturePtr_setNumMipmaps(swigCPtr, num);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool getMipmapsHardwareGenerated() {
    bool ret = OgrePINVOKE.TexturePtr_getMipmapsHardwareGenerated(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getGamma() {
    float ret = OgrePINVOKE.TexturePtr_getGamma(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setGamma(float g) {
    OgrePINVOKE.TexturePtr_setGamma(swigCPtr, g);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setHardwareGammaEnabled(bool enabled) {
    OgrePINVOKE.TexturePtr_setHardwareGammaEnabled(swigCPtr, enabled);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isHardwareGammaEnabled() {
    bool ret = OgrePINVOKE.TexturePtr_isHardwareGammaEnabled(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFSAA(uint fsaa, string fsaaHint) {
    OgrePINVOKE.TexturePtr_setFSAA(swigCPtr, fsaa, fsaaHint);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getFSAA() {
    uint ret = OgrePINVOKE.TexturePtr_getFSAA(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getFSAAHint() {
    string ret = OgrePINVOKE.TexturePtr_getFSAAHint(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getHeight() {
    uint ret = OgrePINVOKE.TexturePtr_getHeight(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getWidth() {
    uint ret = OgrePINVOKE.TexturePtr_getWidth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getDepth() {
    uint ret = OgrePINVOKE.TexturePtr_getDepth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getSrcHeight() {
    uint ret = OgrePINVOKE.TexturePtr_getSrcHeight(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getSrcWidth() {
    uint ret = OgrePINVOKE.TexturePtr_getSrcWidth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getSrcDepth() {
    uint ret = OgrePINVOKE.TexturePtr_getSrcDepth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setHeight(uint h) {
    OgrePINVOKE.TexturePtr_setHeight(swigCPtr, h);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setWidth(uint w) {
    OgrePINVOKE.TexturePtr_setWidth(swigCPtr, w);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setDepth(uint d) {
    OgrePINVOKE.TexturePtr_setDepth(swigCPtr, d);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public int getUsage() {
    int ret = OgrePINVOKE.TexturePtr_getUsage(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setUsage(int u) {
    OgrePINVOKE.TexturePtr_setUsage(swigCPtr, u);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void createInternalResources() {
    OgrePINVOKE.TexturePtr_createInternalResources(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void copyToTexture(TexturePtr target) {
    OgrePINVOKE.TexturePtr_copyToTexture(swigCPtr, TexturePtr.getCPtr(target));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadImage(Image img) {
    OgrePINVOKE.TexturePtr_loadImage(swigCPtr, Image.getCPtr(img));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadRawData(DataStreamPtr stream, ushort uWidth, ushort uHeight, PixelFormat eFormat) {
    OgrePINVOKE.TexturePtr_loadRawData(swigCPtr, DataStreamPtr.getCPtr(stream), uWidth, uHeight, (int)eFormat);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _loadImages(SWIGTYPE_p_std__vectorT_Ogre__Image_const_p_t images) {
    OgrePINVOKE.TexturePtr__loadImages(swigCPtr, SWIGTYPE_p_std__vectorT_Ogre__Image_const_p_t.getCPtr(images));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public PixelFormat getFormat() {
    PixelFormat ret = (PixelFormat)OgrePINVOKE.TexturePtr_getFormat(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PixelFormat getDesiredFormat() {
    PixelFormat ret = (PixelFormat)OgrePINVOKE.TexturePtr_getDesiredFormat(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public PixelFormat getSrcFormat() {
    PixelFormat ret = (PixelFormat)OgrePINVOKE.TexturePtr_getSrcFormat(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setFormat(PixelFormat pf) {
    OgrePINVOKE.TexturePtr_setFormat(swigCPtr, (int)pf);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool hasAlpha() {
    bool ret = OgrePINVOKE.TexturePtr_hasAlpha(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDesiredIntegerBitDepth(ushort bits) {
    OgrePINVOKE.TexturePtr_setDesiredIntegerBitDepth(swigCPtr, bits);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getDesiredIntegerBitDepth() {
    ushort ret = OgrePINVOKE.TexturePtr_getDesiredIntegerBitDepth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDesiredFloatBitDepth(ushort bits) {
    OgrePINVOKE.TexturePtr_setDesiredFloatBitDepth(swigCPtr, bits);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ushort getDesiredFloatBitDepth() {
    ushort ret = OgrePINVOKE.TexturePtr_getDesiredFloatBitDepth(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setDesiredBitDepths(ushort integerBits, ushort floatBits) {
    OgrePINVOKE.TexturePtr_setDesiredBitDepths(swigCPtr, integerBits, floatBits);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getNumFaces() {
    uint ret = OgrePINVOKE.TexturePtr_getNumFaces(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwarePixelBufferPtr getBuffer(uint face, uint mipmap) {
    HardwarePixelBufferPtr ret = new HardwarePixelBufferPtr(OgrePINVOKE.TexturePtr_getBuffer__SWIG_0(swigCPtr, face, mipmap), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwarePixelBufferPtr getBuffer(uint face) {
    HardwarePixelBufferPtr ret = new HardwarePixelBufferPtr(OgrePINVOKE.TexturePtr_getBuffer__SWIG_1(swigCPtr, face), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HardwarePixelBufferPtr getBuffer() {
    HardwarePixelBufferPtr ret = new HardwarePixelBufferPtr(OgrePINVOKE.TexturePtr_getBuffer__SWIG_2(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void convertToImage(Image destImage, bool includeMipMaps) {
    OgrePINVOKE.TexturePtr_convertToImage__SWIG_0(swigCPtr, Image.getCPtr(destImage), includeMipMaps);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void convertToImage(Image destImage) {
    OgrePINVOKE.TexturePtr_convertToImage__SWIG_1(swigCPtr, Image.getCPtr(destImage));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void getCustomAttribute(string name, global::System.IntPtr pData) {
    OgrePINVOKE.TexturePtr_getCustomAttribute__SWIG_0(swigCPtr, name, pData);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getCustomAttribute(string name) {
    uint ret = OgrePINVOKE.TexturePtr_getCustomAttribute__SWIG_1(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void createShaderAccessPoint(uint bindPoint, TextureAccess access, int mipmapLevel, int textureArrayIndex, PixelFormat format) {
    OgrePINVOKE.TexturePtr_createShaderAccessPoint__SWIG_0(swigCPtr, bindPoint, (int)access, mipmapLevel, textureArrayIndex, (int)format);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void createShaderAccessPoint(uint bindPoint, TextureAccess access, int mipmapLevel, int textureArrayIndex) {
    OgrePINVOKE.TexturePtr_createShaderAccessPoint__SWIG_1(swigCPtr, bindPoint, (int)access, mipmapLevel, textureArrayIndex);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void createShaderAccessPoint(uint bindPoint, TextureAccess access, int mipmapLevel) {
    OgrePINVOKE.TexturePtr_createShaderAccessPoint__SWIG_2(swigCPtr, bindPoint, (int)access, mipmapLevel);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void createShaderAccessPoint(uint bindPoint, TextureAccess access) {
    OgrePINVOKE.TexturePtr_createShaderAccessPoint__SWIG_3(swigCPtr, bindPoint, (int)access);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void createShaderAccessPoint(uint bindPoint) {
    OgrePINVOKE.TexturePtr_createShaderAccessPoint__SWIG_4(swigCPtr, bindPoint);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void setLayerNames(StringList names) {
    OgrePINVOKE.TexturePtr_setLayerNames(swigCPtr, StringList.getCPtr(names));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepare(bool backgroundThread) {
    OgrePINVOKE.TexturePtr_prepare__SWIG_0(swigCPtr, backgroundThread);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void prepare() {
    OgrePINVOKE.TexturePtr_prepare__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load(bool backgroundThread) {
    OgrePINVOKE.TexturePtr_load__SWIG_0(swigCPtr, backgroundThread);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void load() {
    OgrePINVOKE.TexturePtr_load__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload(Resource.LoadingFlags flags) {
    OgrePINVOKE.TexturePtr_reload__SWIG_0(swigCPtr, (int)flags);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void reload() {
    OgrePINVOKE.TexturePtr_reload__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isReloadable() {
    bool ret = OgrePINVOKE.TexturePtr_isReloadable(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isManuallyLoaded() {
    bool ret = OgrePINVOKE.TexturePtr_isManuallyLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void unload() {
    OgrePINVOKE.TexturePtr_unload(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getSize() {
    uint ret = OgrePINVOKE.TexturePtr_getSize(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void touch() {
    OgrePINVOKE.TexturePtr_touch(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getName() {
    string ret = OgrePINVOKE.TexturePtr_getName(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getHandle() {
    uint ret = OgrePINVOKE.TexturePtr_getHandle(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isPrepared() {
    bool ret = OgrePINVOKE.TexturePtr_isPrepared(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoaded() {
    bool ret = OgrePINVOKE.TexturePtr_isLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isLoading() {
    bool ret = OgrePINVOKE.TexturePtr_isLoading(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Resource.LoadingState getLoadingState() {
    Resource.LoadingState ret = (Resource.LoadingState)OgrePINVOKE.TexturePtr_getLoadingState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isBackgroundLoaded() {
    bool ret = OgrePINVOKE.TexturePtr_isBackgroundLoaded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setBackgroundLoaded(bool bl) {
    OgrePINVOKE.TexturePtr_setBackgroundLoaded(swigCPtr, bl);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void escalateLoading() {
    OgrePINVOKE.TexturePtr_escalateLoading(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void addListener(Resource.Listener lis) {
    OgrePINVOKE.TexturePtr_addListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void removeListener(Resource.Listener lis) {
    OgrePINVOKE.TexturePtr_removeListener(swigCPtr, Resource.Listener.getCPtr(lis));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getGroup() {
    string ret = OgrePINVOKE.TexturePtr_getGroup(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void changeGroupOwnership(string newGroup) {
    OgrePINVOKE.TexturePtr_changeGroupOwnership(swigCPtr, newGroup);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ResourceManager getCreator() {
    global::System.IntPtr cPtr = OgrePINVOKE.TexturePtr_getCreator(swigCPtr);
    ResourceManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new ResourceManager(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string getOrigin() {
    string ret = OgrePINVOKE.TexturePtr_getOrigin(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _notifyOrigin(string origin) {
    OgrePINVOKE.TexturePtr__notifyOrigin(swigCPtr, origin);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getStateCount() {
    uint ret = OgrePINVOKE.TexturePtr_getStateCount(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void _dirtyState() {
    OgrePINVOKE.TexturePtr__dirtyState(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireLoadingComplete(bool unused) {
    OgrePINVOKE.TexturePtr__fireLoadingComplete__SWIG_0(swigCPtr, unused);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireLoadingComplete() {
    OgrePINVOKE.TexturePtr__fireLoadingComplete__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _firePreparingComplete(bool unused) {
    OgrePINVOKE.TexturePtr__firePreparingComplete__SWIG_0(swigCPtr, unused);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _firePreparingComplete() {
    OgrePINVOKE.TexturePtr__firePreparingComplete__SWIG_1(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void _fireUnloadingComplete() {
    OgrePINVOKE.TexturePtr__fireUnloadingComplete(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ParamDictionary getParamDictionary() {
    global::System.IntPtr cPtr = OgrePINVOKE.TexturePtr_getParamDictionary__SWIG_0(swigCPtr);
    ParamDictionary ret = (cPtr == global::System.IntPtr.Zero) ? null : new ParamDictionary(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StringList getParameters() {
    StringList ret = new StringList(OgrePINVOKE.TexturePtr_getParameters(swigCPtr), false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool setParameter(string name, string value) {
    bool ret = OgrePINVOKE.TexturePtr_setParameter(swigCPtr, name, value);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setParameterList(NameValueMap paramList) {
    OgrePINVOKE.TexturePtr_setParameterList(swigCPtr, NameValueMap.getCPtr(paramList));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public string getParameter(string name) {
    string ret = OgrePINVOKE.TexturePtr_getParameter(swigCPtr, name);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void copyParametersTo(StringInterface dest) {
    OgrePINVOKE.TexturePtr_copyParametersTo(swigCPtr, StringInterface.getCPtr(dest));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public void cleanupDictionary() {
    OgrePINVOKE.TexturePtr_cleanupDictionary(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
