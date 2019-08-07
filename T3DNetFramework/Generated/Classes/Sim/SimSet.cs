using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Gui;
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class SimSet : SimObject {



        public SimSet(bool pRegister = false)
            : base(pRegister) {
        }

        public SimSet(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public SimSet(string pName)
            : this(pName, false) {
        }

        public SimSet(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public SimSet(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public SimSet(SimObject pObj)
            : base(pObj) {
        }

        public SimSet(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct AcceptsAsChild__Args
                {

				   internal IntPtr obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _AcceptsAsChild(IntPtr _this, IntPtr obj);
                internal delegate bool _AcceptsAsChild(IntPtr _this, AcceptsAsChild__Args args);
                private static _AcceptsAsChild _AcceptsAsChildFunc;
                internal static _AcceptsAsChild AcceptsAsChild() {
                    if (_AcceptsAsChildFunc == null) {
                        _AcceptsAsChildFunc =
                            (_AcceptsAsChild)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_acceptsAsChild"), typeof(_AcceptsAsChild));
                    }

                    return _AcceptsAsChildFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Sort__Args
                {

				   internal string callbackFunction;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Sort(IntPtr _this, string callbackFunction);
                internal delegate void _Sort(IntPtr _this, Sort__Args args);
                private static _Sort _SortFunc;
                internal static _Sort Sort() {
                    if (_SortFunc == null) {
                        _SortFunc =
                            (_Sort)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_sort"), typeof(_Sort));
                    }

                    return _SortFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct PushToBack__Args
                {

				   internal IntPtr obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _PushToBack(IntPtr _this, IntPtr obj);
                internal delegate void _PushToBack(IntPtr _this, PushToBack__Args args);
                private static _PushToBack _PushToBackFunc;
                internal static _PushToBack PushToBack() {
                    if (_PushToBackFunc == null) {
                        _PushToBackFunc =
                            (_PushToBack)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_pushToBack"), typeof(_PushToBack));
                    }

                    return _PushToBackFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct BringToFront__Args
                {

				   internal IntPtr obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _BringToFront(IntPtr _this, IntPtr obj);
                internal delegate void _BringToFront(IntPtr _this, BringToFront__Args args);
                private static _BringToFront _BringToFrontFunc;
                internal static _BringToFront BringToFront() {
                    if (_BringToFrontFunc == null) {
                        _BringToFrontFunc =
                            (_BringToFront)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_bringToFront"), typeof(_BringToFront));
                    }

                    return _BringToFrontFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct FindObjectByInternalName__Args
                {

				   internal string internalName;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool searchChildren;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _FindObjectByInternalName(IntPtr _this, string internalName, [MarshalAs(UnmanagedType.I1)]bool searchChildren);
                internal delegate IntPtr _FindObjectByInternalName(IntPtr _this, FindObjectByInternalName__Args args);
                private static _FindObjectByInternalName _FindObjectByInternalNameFunc;
                internal static _FindObjectByInternalName FindObjectByInternalName() {
                    if (_FindObjectByInternalNameFunc == null) {
                        _FindObjectByInternalNameFunc =
                            (_FindObjectByInternalName)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_findObjectByInternalName"), typeof(_FindObjectByInternalName));
                    }

                    return _FindObjectByInternalNameFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct IsMember__Args
                {

				   internal IntPtr obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _IsMember(IntPtr _this, IntPtr obj);
                internal delegate bool _IsMember(IntPtr _this, IsMember__Args args);
                private static _IsMember _IsMemberFunc;
                internal static _IsMember IsMember() {
                    if (_IsMemberFunc == null) {
                        _IsMemberFunc =
                            (_IsMember)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_isMember"), typeof(_IsMember));
                    }

                    return _IsMemberFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetObjectIndex__Args
                {

				   internal IntPtr obj;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetObjectIndex(IntPtr _this, IntPtr obj);
                internal delegate int _GetObjectIndex(IntPtr _this, GetObjectIndex__Args args);
                private static _GetObjectIndex _GetObjectIndexFunc;
                internal static _GetObjectIndex GetObjectIndex() {
                    if (_GetObjectIndexFunc == null) {
                        _GetObjectIndexFunc =
                            (_GetObjectIndex)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_getObjectIndex"), typeof(_GetObjectIndex));
                    }

                    return _GetObjectIndexFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetObject__Args
                {

				   internal uint index;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetObject(IntPtr _this, uint index);
                internal delegate IntPtr _GetObject(IntPtr _this, GetObject__Args args);
                private static _GetObject _GetObjectFunc;
                internal static _GetObject GetObject() {
                    if (_GetObjectFunc == null) {
                        _GetObjectFunc =
                            (_GetObject)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_getObject"), typeof(_GetObject));
                    }

                    return _GetObjectFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetFullCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetFullCount(IntPtr _this);
                internal delegate int _GetFullCount(IntPtr _this, GetFullCount__Args args);
                private static _GetFullCount _GetFullCountFunc;
                internal static _GetFullCount GetFullCount() {
                    if (_GetFullCountFunc == null) {
                        _GetFullCountFunc =
                            (_GetFullCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_getFullCount"), typeof(_GetFullCount));
                    }

                    return _GetFullCountFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCountRecursive__Args
                {

				   internal IntPtr set;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate uint _GetCountRecursive(IntPtr set);
                internal delegate uint _GetCountRecursive(GetCountRecursive__Args args);
                private static _GetCountRecursive _GetCountRecursiveFunc;
                internal static _GetCountRecursive GetCountRecursive() {
                    if (_GetCountRecursiveFunc == null) {
                        _GetCountRecursiveFunc =
                            (_GetCountRecursive)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_getCountRecursive"), typeof(_GetCountRecursive));
                    }

                    return _GetCountRecursiveFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetCount__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate int _GetCount(IntPtr _this);
                internal delegate int _GetCount(IntPtr _this, GetCount__Args args);
                private static _GetCount _GetCountFunc;
                internal static _GetCount GetCount() {
                    if (_GetCountFunc == null) {
                        _GetCountFunc =
                            (_GetCount)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_getCount"), typeof(_GetCount));
                    }

                    return _GetCountFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ReorderChild__Args
                {

				   internal IntPtr child1;

				   internal IntPtr child2;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ReorderChild(IntPtr _this, IntPtr child1, IntPtr child2);
                internal delegate void _ReorderChild(IntPtr _this, ReorderChild__Args args);
                private static _ReorderChild _ReorderChildFunc;
                internal static _ReorderChild ReorderChild() {
                    if (_ReorderChildFunc == null) {
                        _ReorderChildFunc =
                            (_ReorderChild)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_reorderChild"), typeof(_ReorderChild));
                    }

                    return _ReorderChildFunc;
                }


                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                internal delegate void _CallOnChildrenNoRecurse(IntPtr _this, ref StringVector.InternalStruct args);
                private static _CallOnChildrenNoRecurse _CallOnChildrenNoRecurseFunc;
                internal static _CallOnChildrenNoRecurse CallOnChildrenNoRecurse() {
                    if (_CallOnChildrenNoRecurseFunc == null) {
                        _CallOnChildrenNoRecurseFunc =
                            (_CallOnChildrenNoRecurse)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_callOnChildrenNoRecurse"), typeof(_CallOnChildrenNoRecurse));
                    }

                    return _CallOnChildrenNoRecurseFunc;
                }


                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                internal delegate void _CallOnChildren(IntPtr _this, ref StringVector.InternalStruct args);
                private static _CallOnChildren _CallOnChildrenFunc;
                internal static _CallOnChildren CallOnChildren() {
                    if (_CallOnChildrenFunc == null) {
                        _CallOnChildrenFunc =
                            (_CallOnChildren)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_callOnChildren"), typeof(_CallOnChildren));
                    }

                    return _CallOnChildrenFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetRandom__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetRandom(IntPtr _this);
                internal delegate IntPtr _GetRandom(IntPtr _this, GetRandom__Args args);
                private static _GetRandom _GetRandomFunc;
                internal static _GetRandom GetRandom() {
                    if (_GetRandomFunc == null) {
                        _GetRandomFunc =
                            (_GetRandom)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_getRandom"), typeof(_GetRandom));
                    }

                    return _GetRandomFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct DeleteAllObjects__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _DeleteAllObjects(IntPtr _this);
                internal delegate void _DeleteAllObjects(IntPtr _this, DeleteAllObjects__Args args);
                private static _DeleteAllObjects _DeleteAllObjectsFunc;
                internal static _DeleteAllObjects DeleteAllObjects() {
                    if (_DeleteAllObjectsFunc == null) {
                        _DeleteAllObjectsFunc =
                            (_DeleteAllObjects)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_deleteAllObjects"), typeof(_DeleteAllObjects));
                    }

                    return _DeleteAllObjectsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Clear__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _Clear(IntPtr _this);
                internal delegate void _Clear(IntPtr _this, Clear__Args args);
                private static _Clear _ClearFunc;
                internal static _Clear Clear() {
                    if (_ClearFunc == null) {
                        _ClearFunc =
                            (_Clear)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_clear"), typeof(_Clear));
                    }

                    return _ClearFunc;
                }


                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                internal delegate void _Remove(IntPtr _this, ref StringVector.InternalStruct args);
                private static _Remove _RemoveFunc;
                internal static _Remove Remove() {
                    if (_RemoveFunc == null) {
                        _RemoveFunc =
                            (_Remove)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_remove"), typeof(_Remove));
                    }

                    return _RemoveFunc;
                }


                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                internal delegate void _Add(IntPtr _this, ref StringVector.InternalStruct args);
                private static _Add _AddFunc;
                internal static _Add Add() {
                    if (_AddFunc == null) {
                        _AddFunc =
                            (_Add)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_add"), typeof(_Add));
                    }

                    return _AddFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct ListObjects__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _ListObjects(IntPtr _this);
                internal delegate void _ListObjects(IntPtr _this, ListObjects__Args args);
                private static _ListObjects _ListObjectsFunc;
                internal static _ListObjects ListObjects() {
                    if (_ListObjectsFunc == null) {
                        _ListObjectsFunc =
                            (_ListObjects)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_listObjects"), typeof(_ListObjects));
                    }

                    return _ListObjectsFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnObjectRemoved__Args
                {

				   internal IntPtr _object;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnObjectRemoved(IntPtr _this, IntPtr _object);
                internal delegate void _OnObjectRemoved(IntPtr _this, OnObjectRemoved__Args args);
                private static _OnObjectRemoved _OnObjectRemovedFunc;
                internal static _OnObjectRemoved OnObjectRemoved() {
                    if (_OnObjectRemovedFunc == null) {
                        _OnObjectRemovedFunc =
                            (_OnObjectRemoved)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbSimSet_onObjectRemoved"), typeof(_OnObjectRemoved));
                    }

                    return _OnObjectRemovedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnObjectAdded__Args
                {

				   internal IntPtr _object;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnObjectAdded(IntPtr _this, IntPtr _object);
                internal delegate void _OnObjectAdded(IntPtr _this, OnObjectAdded__Args args);
                private static _OnObjectAdded _OnObjectAddedFunc;
                internal static _OnObjectAdded OnObjectAdded() {
                    if (_OnObjectAddedFunc == null) {
                        _OnObjectAddedFunc =
                            (_OnObjectAdded)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbSimSet_onObjectAdded"), typeof(_OnObjectAdded));
                    }

                    return _OnObjectAddedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct StaticGetType__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _StaticGetType();
                internal delegate IntPtr _StaticGetType(StaticGetType__Args args);
                private static _StaticGetType _StaticGetTypeFunc;
                internal static _StaticGetType StaticGetType() {
                    if (_StaticGetTypeFunc == null) {
                        _StaticGetTypeFunc =
                            (_StaticGetType)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_staticGetType"), typeof(_StaticGetType));
                    }

                    return _StaticGetTypeFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct Create__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _Create();
                internal delegate IntPtr _Create(Create__Args args);
                private static _Create _CreateFunc;
                internal static _Create Create() {
                    if (_CreateFunc == null) {
                        _CreateFunc =
                            (_Create)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnSimSet_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public bool AcceptsAsChild(SimObject obj) {

                                          InternalUnsafeMethods.AcceptsAsChild__Args _args = new InternalUnsafeMethods.AcceptsAsChild__Args() {
                        obj = obj.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.AcceptsAsChild()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void Sort(string callbackFunction) {

                                          InternalUnsafeMethods.Sort__Args _args = new InternalUnsafeMethods.Sort__Args() {
                        callbackFunction = callbackFunction,
                     };
                     InternalUnsafeMethods.Sort()(ObjectPtr, _args);

                  }



                  public void PushToBack(SimObject obj) {

                                          InternalUnsafeMethods.PushToBack__Args _args = new InternalUnsafeMethods.PushToBack__Args() {
                        obj = obj.ObjectPtr,
                     };
                     InternalUnsafeMethods.PushToBack()(ObjectPtr, _args);

                  }



                  public void BringToFront(SimObject obj) {

                                          InternalUnsafeMethods.BringToFront__Args _args = new InternalUnsafeMethods.BringToFront__Args() {
                        obj = obj.ObjectPtr,
                     };
                     InternalUnsafeMethods.BringToFront()(ObjectPtr, _args);

                  }



                  public SimObject FindObjectByInternalName(string internalName, bool searchChildren = false) {

                                                               InternalUnsafeMethods.FindObjectByInternalName__Args _args = new InternalUnsafeMethods.FindObjectByInternalName__Args() {
                        internalName = internalName,
                        searchChildren = searchChildren,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.FindObjectByInternalName()(ObjectPtr, _args);

                     return new SimObject(_engineResult);
                  }



                  public bool IsMember(SimObject obj) {

                                          InternalUnsafeMethods.IsMember__Args _args = new InternalUnsafeMethods.IsMember__Args() {
                        obj = obj.ObjectPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.IsMember()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public int GetObjectIndex(SimObject obj) {

                                          InternalUnsafeMethods.GetObjectIndex__Args _args = new InternalUnsafeMethods.GetObjectIndex__Args() {
                        obj = obj.ObjectPtr,
                     };
                     int _engineResult = InternalUnsafeMethods.GetObjectIndex()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public SimObject GetObject(uint index) {

                                          InternalUnsafeMethods.GetObject__Args _args = new InternalUnsafeMethods.GetObject__Args() {
                        index = index,
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetObject()(ObjectPtr, _args);

                     return new SimObject(_engineResult);
                  }



                  public int GetFullCount() {

                     InternalUnsafeMethods.GetFullCount__Args _args = new InternalUnsafeMethods.GetFullCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetFullCount()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static uint GetCountRecursive(SimSet set) {

                     InternalUnsafeMethods.GetCountRecursive__Args _args = new InternalUnsafeMethods.GetCountRecursive__Args() {
                        set = set.ObjectPtr,
                     };
                     uint _engineResult = InternalUnsafeMethods.GetCountRecursive()(_args);


                     return _engineResult;
                  }



                  public int GetCount() {

                     InternalUnsafeMethods.GetCount__Args _args = new InternalUnsafeMethods.GetCount__Args() {
                     };
                     int _engineResult = InternalUnsafeMethods.GetCount()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void ReorderChild(SimObject child1, SimObject child2) {

                                                               InternalUnsafeMethods.ReorderChild__Args _args = new InternalUnsafeMethods.ReorderChild__Args() {
                        child1 = child1.ObjectPtr,
                        child2 = child2.ObjectPtr,
                     };
                     InternalUnsafeMethods.ReorderChild()(ObjectPtr, _args);

                  }


								public void CallOnChildrenNoRecurse(params string[] args) {
						List<string> _argList = new List<string>() {"", ""};
						_argList.AddRange(args);

						StringVector nativeVecArgs = new StringVector {
							ElementCount = (uint)_argList.Count,
							Array = _argList.ToArray(),
							ArraySize = (uint)_argList.Count
						};
						nativeVecArgs.Alloc();
						InternalUnsafeMethods.CallOnChildrenNoRecurse()(ObjectPtr, ref nativeVecArgs.internalStruct);
						nativeVecArgs.Free();

					}

								public void CallOnChildren(params string[] args) {
						List<string> _argList = new List<string>() {"", ""};
						_argList.AddRange(args);

						StringVector nativeVecArgs = new StringVector {
							ElementCount = (uint)_argList.Count,
							Array = _argList.ToArray(),
							ArraySize = (uint)_argList.Count
						};
						nativeVecArgs.Alloc();
						InternalUnsafeMethods.CallOnChildren()(ObjectPtr, ref nativeVecArgs.internalStruct);
						nativeVecArgs.Free();

					}


                  public SimObject GetRandom() {

                     InternalUnsafeMethods.GetRandom__Args _args = new InternalUnsafeMethods.GetRandom__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetRandom()(ObjectPtr, _args);

                     return new SimObject(_engineResult);
                  }



                  public void DeleteAllObjects() {

                     InternalUnsafeMethods.DeleteAllObjects__Args _args = new InternalUnsafeMethods.DeleteAllObjects__Args() {
                     };
                     InternalUnsafeMethods.DeleteAllObjects()(ObjectPtr, _args);

                  }



                  public void Clear() {

                     InternalUnsafeMethods.Clear__Args _args = new InternalUnsafeMethods.Clear__Args() {
                     };
                     InternalUnsafeMethods.Clear()(ObjectPtr, _args);

                  }


								public void Remove(params string[] args) {
						List<string> _argList = new List<string>() {"", ""};
						_argList.AddRange(args);

						StringVector nativeVecArgs = new StringVector {
							ElementCount = (uint)_argList.Count,
							Array = _argList.ToArray(),
							ArraySize = (uint)_argList.Count
						};
						nativeVecArgs.Alloc();
						InternalUnsafeMethods.Remove()(ObjectPtr, ref nativeVecArgs.internalStruct);
						nativeVecArgs.Free();

					}

								public void Add(params string[] args) {
						List<string> _argList = new List<string>() {"", ""};
						_argList.AddRange(args);

						StringVector nativeVecArgs = new StringVector {
							ElementCount = (uint)_argList.Count,
							Array = _argList.ToArray(),
							ArraySize = (uint)_argList.Count
						};
						nativeVecArgs.Alloc();
						InternalUnsafeMethods.Add()(ObjectPtr, ref nativeVecArgs.internalStruct);
						nativeVecArgs.Free();

					}


                  public void ListObjects() {

                     InternalUnsafeMethods.ListObjects__Args _args = new InternalUnsafeMethods.ListObjects__Args() {
                     };
                     InternalUnsafeMethods.ListObjects()(ObjectPtr, _args);

                  }



                  public void OnObjectRemoved(SimObject _object) {

                                          InternalUnsafeMethods.OnObjectRemoved__Args _args = new InternalUnsafeMethods.OnObjectRemoved__Args() {
                        _object = _object.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnObjectRemoved()(ObjectPtr, _args);

                  }



                  public void OnObjectAdded(SimObject _object) {

                                          InternalUnsafeMethods.OnObjectAdded__Args _args = new InternalUnsafeMethods.OnObjectAdded__Args() {
                        _object = _object.ObjectPtr,
                     };
                     InternalUnsafeMethods.OnObjectAdded()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
