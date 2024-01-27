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

public class MovableObjectMap : global::System.IDisposable 
    , global::System.Collections.Generic.IDictionary<string, MovableObject>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MovableObjectMap(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MovableObjectMap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MovableObjectMap() {
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
          OgrePINVOKE.delete_MovableObjectMap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }


  public MovableObject this[string key] {
    get {
      return getitem(key);
    }

    set {
      setitem(key, value);
    }
  }

  public bool TryGetValue(string key, out MovableObject value) {
    if (this.ContainsKey(key)) {
      value = this[key];
      return true;
    }
    value = default(MovableObject);
    return false;
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public global::System.Collections.Generic.ICollection<string> Keys {
    get {
      global::System.Collections.Generic.ICollection<string> keys = new global::System.Collections.Generic.List<string>();
      int size = this.Count;
      if (size > 0) {
        global::System.IntPtr iter = create_iterator_begin();
        for (int i = 0; i < size; i++) {
          keys.Add(get_next_key(iter));
        }
        destroy_iterator(iter);
      }
      return keys;
    }
  }

  public global::System.Collections.Generic.ICollection<MovableObject> Values {
    get {
      global::System.Collections.Generic.ICollection<MovableObject> vals = new global::System.Collections.Generic.List<MovableObject>();
      foreach (global::System.Collections.Generic.KeyValuePair<string, MovableObject> pair in this) {
        vals.Add(pair.Value);
      }
      return vals;
    }
  }

  public void Add(global::System.Collections.Generic.KeyValuePair<string, MovableObject> item) {
    Add(item.Key, item.Value);
  }

  public bool Remove(global::System.Collections.Generic.KeyValuePair<string, MovableObject> item) {
    if (Contains(item)) {
      return Remove(item.Key);
    } else {
      return false;
    }
  }

  public bool Contains(global::System.Collections.Generic.KeyValuePair<string, MovableObject> item) {
    if (this[item.Key] == item.Value) {
      return true;
    } else {
      return false;
    }
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, MovableObject>[] array) {
    CopyTo(array, 0);
  }

  public void CopyTo(global::System.Collections.Generic.KeyValuePair<string, MovableObject>[] array, int arrayIndex) {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (arrayIndex+this.Count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");

    global::System.Collections.Generic.IList<string> keyList = new global::System.Collections.Generic.List<string>(this.Keys);
    for (int i = 0; i < keyList.Count; i++) {
      string currentKey = keyList[i];
      array.SetValue(new global::System.Collections.Generic.KeyValuePair<string, MovableObject>(currentKey, this[currentKey]), arrayIndex+i);
    }
  }

  global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, MovableObject>> global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, MovableObject>>.GetEnumerator() {
    return new MovableObjectMapEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new MovableObjectMapEnumerator(this);
  }

  public MovableObjectMapEnumerator GetEnumerator() {
    return new MovableObjectMapEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class MovableObjectMapEnumerator : global::System.Collections.IEnumerator,
      global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, MovableObject>>
  {
    private MovableObjectMap collectionRef;
    private global::System.Collections.Generic.IList<string> keyCollection;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public MovableObjectMapEnumerator(MovableObjectMap collection) {
      collectionRef = collection;
      keyCollection = new global::System.Collections.Generic.List<string>(collection.Keys);
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public global::System.Collections.Generic.KeyValuePair<string, MovableObject> Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (global::System.Collections.Generic.KeyValuePair<string, MovableObject>)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        string currentKey = keyCollection[currentIndex];
        currentObject = new global::System.Collections.Generic.KeyValuePair<string, MovableObject>(currentKey, collectionRef[currentKey]);
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
      currentIndex = -1;
      currentObject = null;
    }
  }


  public MovableObjectMap() : this(OgrePINVOKE.new_MovableObjectMap__SWIG_0(), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public MovableObjectMap(MovableObjectMap other) : this(OgrePINVOKE.new_MovableObjectMap__SWIG_1(MovableObjectMap.getCPtr(other)), true) {
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = OgrePINVOKE.MovableObjectMap_size(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool empty() {
    bool ret = OgrePINVOKE.MovableObjectMap_empty(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Clear() {
    OgrePINVOKE.MovableObjectMap_Clear(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  private MovableObject getitem(string key) {
    global::System.IntPtr cPtr = OgrePINVOKE.MovableObjectMap_getitem(swigCPtr, key);
    MovableObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new MovableObject(cPtr, false);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(string key, MovableObject x) {
    OgrePINVOKE.MovableObjectMap_setitem(swigCPtr, key, MovableObject.getCPtr(x));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool ContainsKey(string key) {
    bool ret = OgrePINVOKE.MovableObjectMap_ContainsKey(swigCPtr, key);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Add(string key, MovableObject value) {
    OgrePINVOKE.MovableObjectMap_Add(swigCPtr, key, MovableObject.getCPtr(value));
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Remove(string key) {
    bool ret = OgrePINVOKE.MovableObjectMap_Remove(swigCPtr, key);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private global::System.IntPtr create_iterator_begin() {
    global::System.IntPtr ret = OgrePINVOKE.MovableObjectMap_create_iterator_begin(swigCPtr);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string get_next_key(global::System.IntPtr swigiterator) {
    string ret = OgrePINVOKE.MovableObjectMap_get_next_key(swigCPtr, swigiterator);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void destroy_iterator(global::System.IntPtr swigiterator) {
    OgrePINVOKE.MovableObjectMap_destroy_iterator(swigCPtr, swigiterator);
    if (OgrePINVOKE.SWIGPendingException.Pending) throw OgrePINVOKE.SWIGPendingException.Retrieve();
  }

}

}
