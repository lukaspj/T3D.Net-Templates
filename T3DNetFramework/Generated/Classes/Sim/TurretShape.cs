using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
using T3DNetFramework.Generated.Structs.Math;
using T3DNetFramework.Interop;
using T3DNetFramework.Engine;
using T3DNetFramework.Engine.Util;
using T3DNetFramework.Generated.Classes.Global;
using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Classes.Sim.Net;
using T3DNetFramework.Generated.Enums.Global;
using T3DNetFramework.Generated.Enums.Reflection;
using T3DNetFramework.Generated.Structs.Global;
using T3DNetFramework.Generated.Structs.Gui;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class TurretShape : Item {



        public TurretShape(bool pRegister = false)
            : base(pRegister) {
        }

        public TurretShape(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public TurretShape(string pName)
            : this(pName, false) {
        }

        public TurretShape(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public TurretShape(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public TurretShape(SimObject pObj)
            : base(pObj) {
        }

        public TurretShape(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct DoRespawn__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _DoRespawn(IntPtr _this);
                internal delegate bool _DoRespawn(IntPtr _this, DoRespawn__Args args);
                private static _DoRespawn _DoRespawnFunc;
                internal static _DoRespawn DoRespawn() {
                    if (_DoRespawnFunc == null) {
                        _DoRespawnFunc =
                            (_DoRespawn)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTurretShape_doRespawn"), typeof(_DoRespawn));
                    }

                    return _DoRespawnFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetTurretEulerRotation__Args
                {

				   internal IntPtr rot;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetTurretEulerRotation(IntPtr _this, IntPtr rot);
                internal delegate void _SetTurretEulerRotation(IntPtr _this, SetTurretEulerRotation__Args args);
                private static _SetTurretEulerRotation _SetTurretEulerRotationFunc;
                internal static _SetTurretEulerRotation SetTurretEulerRotation() {
                    if (_SetTurretEulerRotationFunc == null) {
                        _SetTurretEulerRotationFunc =
                            (_SetTurretEulerRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTurretShape_setTurretEulerRotation"), typeof(_SetTurretEulerRotation));
                    }

                    return _SetTurretEulerRotationFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetTurretEulerRotation__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate Point3F.InternalStruct _GetTurretEulerRotation(IntPtr _this);
                internal delegate Point3F.InternalStruct _GetTurretEulerRotation(IntPtr _this, GetTurretEulerRotation__Args args);
                private static _GetTurretEulerRotation _GetTurretEulerRotationFunc;
                internal static _GetTurretEulerRotation GetTurretEulerRotation() {
                    if (_GetTurretEulerRotationFunc == null) {
                        _GetTurretEulerRotationFunc =
                            (_GetTurretEulerRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTurretShape_getTurretEulerRotation"), typeof(_GetTurretEulerRotation));
                    }

                    return _GetTurretEulerRotationFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetState__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate IntPtr _GetState(IntPtr _this);
                internal delegate IntPtr _GetState(IntPtr _this, GetState__Args args);
                private static _GetState _GetStateFunc;
                internal static _GetState GetState() {
                    if (_GetStateFunc == null) {
                        _GetStateFunc =
                            (_GetState)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTurretShape_getState"), typeof(_GetState));
                    }

                    return _GetStateFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetAllowManualFire__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool allow;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetAllowManualFire(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool allow);
                internal delegate void _SetAllowManualFire(IntPtr _this, SetAllowManualFire__Args args);
                private static _SetAllowManualFire _SetAllowManualFireFunc;
                internal static _SetAllowManualFire SetAllowManualFire() {
                    if (_SetAllowManualFireFunc == null) {
                        _SetAllowManualFireFunc =
                            (_SetAllowManualFire)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTurretShape_setAllowManualFire"), typeof(_SetAllowManualFire));
                    }

                    return _SetAllowManualFireFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAllowManualFire__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetAllowManualFire(IntPtr _this);
                internal delegate bool _GetAllowManualFire(IntPtr _this, GetAllowManualFire__Args args);
                private static _GetAllowManualFire _GetAllowManualFireFunc;
                internal static _GetAllowManualFire GetAllowManualFire() {
                    if (_GetAllowManualFireFunc == null) {
                        _GetAllowManualFireFunc =
                            (_GetAllowManualFire)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTurretShape_getAllowManualFire"), typeof(_GetAllowManualFire));
                    }

                    return _GetAllowManualFireFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct SetAllowManualRotation__Args
                {
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool allow;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _SetAllowManualRotation(IntPtr _this, [MarshalAs(UnmanagedType.I1)]bool allow);
                internal delegate void _SetAllowManualRotation(IntPtr _this, SetAllowManualRotation__Args args);
                private static _SetAllowManualRotation _SetAllowManualRotationFunc;
                internal static _SetAllowManualRotation SetAllowManualRotation() {
                    if (_SetAllowManualRotationFunc == null) {
                        _SetAllowManualRotationFunc =
                            (_SetAllowManualRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTurretShape_setAllowManualRotation"), typeof(_SetAllowManualRotation));
                    }

                    return _SetAllowManualRotationFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetAllowManualRotation__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _GetAllowManualRotation(IntPtr _this);
                internal delegate bool _GetAllowManualRotation(IntPtr _this, GetAllowManualRotation__Args args);
                private static _GetAllowManualRotation _GetAllowManualRotationFunc;
                internal static _GetAllowManualRotation GetAllowManualRotation() {
                    if (_GetAllowManualRotationFunc == null) {
                        _GetAllowManualRotationFunc =
                            (_GetAllowManualRotation)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnTurretShape_getAllowManualRotation"), typeof(_GetAllowManualRotation));
                    }

                    return _GetAllowManualRotationFunc;
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
                                    "fnTurretShape_staticGetType"), typeof(_StaticGetType));
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
                                    "fnTurretShape_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public bool DoRespawn() {

                     InternalUnsafeMethods.DoRespawn__Args _args = new InternalUnsafeMethods.DoRespawn__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.DoRespawn()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetTurretEulerRotation(Point3F rot) {

                     rot.Alloc();                     InternalUnsafeMethods.SetTurretEulerRotation__Args _args = new InternalUnsafeMethods.SetTurretEulerRotation__Args() {
                        rot = rot.internalStructPtr,
                     };
                     InternalUnsafeMethods.SetTurretEulerRotation()(ObjectPtr, _args);
                                          rot.Free();
                  }



                  public Point3F GetTurretEulerRotation() {

                     InternalUnsafeMethods.GetTurretEulerRotation__Args _args = new InternalUnsafeMethods.GetTurretEulerRotation__Args() {
                     };
                     Point3F.InternalStruct _engineResult = InternalUnsafeMethods.GetTurretEulerRotation()(ObjectPtr, _args);

                     return new Point3F(_engineResult);
                  }



                  public string GetState() {

                     InternalUnsafeMethods.GetState__Args _args = new InternalUnsafeMethods.GetState__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.GetState()(ObjectPtr, _args);

                     return StringMarshal.IntPtrToUtf8String(_engineResult);
                  }



                  public void SetAllowManualFire(bool allow) {

                                          InternalUnsafeMethods.SetAllowManualFire__Args _args = new InternalUnsafeMethods.SetAllowManualFire__Args() {
                        allow = allow,
                     };
                     InternalUnsafeMethods.SetAllowManualFire()(ObjectPtr, _args);

                  }



                  public bool GetAllowManualFire() {

                     InternalUnsafeMethods.GetAllowManualFire__Args _args = new InternalUnsafeMethods.GetAllowManualFire__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.GetAllowManualFire()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public void SetAllowManualRotation(bool allow) {

                                          InternalUnsafeMethods.SetAllowManualRotation__Args _args = new InternalUnsafeMethods.SetAllowManualRotation__Args() {
                        allow = allow,
                     };
                     InternalUnsafeMethods.SetAllowManualRotation()(ObjectPtr, _args);

                  }



                  public bool GetAllowManualRotation() {

                     InternalUnsafeMethods.GetAllowManualRotation__Args _args = new InternalUnsafeMethods.GetAllowManualRotation__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.GetAllowManualRotation()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool Respawn {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("respawn"));
            set => SetFieldValue("respawn", GenericMarshal.ToString(value));
        }


    }
}
