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

public class SGScriptTranslator : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SGScriptTranslator(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SGScriptTranslator obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SGScriptTranslator() {
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
          RTShaderPINVOKE.delete_SGScriptTranslator(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SGScriptTranslator() : this(RTShaderPINVOKE.new_SGScriptTranslator(), true) {
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public void translate(ScriptCompiler compiler, SWIGTYPE_p_Ogre__SharedPtrT_Ogre__AbstractNode_t node) {
    RTShaderPINVOKE.SGScriptTranslator_translate(swigCPtr, ScriptCompiler.getCPtr(compiler), SWIGTYPE_p_Ogre__SharedPtrT_Ogre__AbstractNode_t.getCPtr(node));
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SubRenderState getGeneratedSubRenderState(string typeName) {
    global::System.IntPtr cPtr = RTShaderPINVOKE.SGScriptTranslator_getGeneratedSubRenderState(swigCPtr, typeName);
    SubRenderState ret = (cPtr == global::System.IntPtr.Zero) ? null : new SubRenderState(cPtr, false);
    if (RTShaderPINVOKE.SWIGPendingException.Pending) throw RTShaderPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
