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

public class ResourceGroupListener : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ResourceGroupListener(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResourceGroupListener obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ResourceGroupListener() {
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
          OgrePINVOKE.delete_ResourceGroupListener(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual void resourceGroupScriptingStarted(string groupName, uint scriptCount) {
    OgrePINVOKE.ResourceGroupListener_resourceGroupScriptingStarted(swigCPtr, groupName, scriptCount);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void scriptParseStarted(string scriptName, SWIGTYPE_p_bool skipThisScript) {
    OgrePINVOKE.ResourceGroupListener_scriptParseStarted(swigCPtr, scriptName, SWIGTYPE_p_bool.getCPtr(skipThisScript));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void scriptParseEnded(string scriptName, bool skipped) {
    OgrePINVOKE.ResourceGroupListener_scriptParseEnded(swigCPtr, scriptName, skipped);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceGroupScriptingEnded(string groupName) {
    OgrePINVOKE.ResourceGroupListener_resourceGroupScriptingEnded(swigCPtr, groupName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceGroupPrepareStarted(string groupName, uint resourceCount) {
    OgrePINVOKE.ResourceGroupListener_resourceGroupPrepareStarted(swigCPtr, groupName, resourceCount);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourcePrepareStarted(ResourcePtr resource) {
    OgrePINVOKE.ResourceGroupListener_resourcePrepareStarted(swigCPtr, ResourcePtr.getCPtr(resource));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourcePrepareEnded() {
    OgrePINVOKE.ResourceGroupListener_resourcePrepareEnded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceGroupPrepareEnded(string groupName) {
    OgrePINVOKE.ResourceGroupListener_resourceGroupPrepareEnded(swigCPtr, groupName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceGroupLoadStarted(string groupName, uint resourceCount) {
    OgrePINVOKE.ResourceGroupListener_resourceGroupLoadStarted(swigCPtr, groupName, resourceCount);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceLoadStarted(ResourcePtr resource) {
    OgrePINVOKE.ResourceGroupListener_resourceLoadStarted(swigCPtr, ResourcePtr.getCPtr(resource));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceLoadEnded() {
    OgrePINVOKE.ResourceGroupListener_resourceLoadEnded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void customStageStarted(string description) {
    OgrePINVOKE.ResourceGroupListener_customStageStarted(swigCPtr, description);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void customStageEnded() {
    OgrePINVOKE.ResourceGroupListener_customStageEnded(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceGroupLoadEnded(string groupName) {
    OgrePINVOKE.ResourceGroupListener_resourceGroupLoadEnded(swigCPtr, groupName);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceCreated(ResourcePtr resource) {
    OgrePINVOKE.ResourceGroupListener_resourceCreated(swigCPtr, ResourcePtr.getCPtr(resource));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void resourceRemove(ResourcePtr resource) {
    OgrePINVOKE.ResourceGroupListener_resourceRemove(swigCPtr, ResourcePtr.getCPtr(resource));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public ResourceGroupListener() : this(OgrePINVOKE.new_ResourceGroupListener(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}