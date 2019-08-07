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

    public unsafe class ShapeBaseData : GameBaseData {



        public ShapeBaseData(bool pRegister = false)
            : base(pRegister) {
        }

        public ShapeBaseData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public ShapeBaseData(string pName)
            : this(pName, false) {
        }

        public ShapeBaseData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public ShapeBaseData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public ShapeBaseData(SimObject pObj)
            : base(pObj) {
        }

        public ShapeBaseData(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct GetDeployTransform__Args
                {

				   internal IntPtr pos;

				   internal IntPtr normal;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate TransformF.InternalStruct _GetDeployTransform(IntPtr _this, IntPtr pos, IntPtr normal);
                internal delegate TransformF.InternalStruct _GetDeployTransform(IntPtr _this, GetDeployTransform__Args args);
                private static _GetDeployTransform _GetDeployTransformFunc;
                internal static _GetDeployTransform GetDeployTransform() {
                    if (_GetDeployTransformFunc == null) {
                        _GetDeployTransformFunc =
                            (_GetDeployTransform)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBaseData_getDeployTransform"), typeof(_GetDeployTransform));
                    }

                    return _GetDeployTransformFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct CheckDeployPos__Args
                {

				   internal IntPtr txfm;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _CheckDeployPos(IntPtr _this, IntPtr txfm);
                internal delegate bool _CheckDeployPos(IntPtr _this, CheckDeployPos__Args args);
                private static _CheckDeployPos _CheckDeployPosFunc;
                internal static _CheckDeployPos CheckDeployPos() {
                    if (_CheckDeployPosFunc == null) {
                        _CheckDeployPosFunc =
                            (_CheckDeployPos)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnShapeBaseData_checkDeployPos"), typeof(_CheckDeployPos));
                    }

                    return _CheckDeployPosFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnForceUncloak__Args
                {

				   internal IntPtr obj;

				   internal string reason;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnForceUncloak(IntPtr _this, IntPtr obj, string reason);
                internal delegate void _OnForceUncloak(IntPtr _this, OnForceUncloak__Args args);
                private static _OnForceUncloak _OnForceUncloakFunc;
                internal static _OnForceUncloak OnForceUncloak() {
                    if (_OnForceUncloakFunc == null) {
                        _OnForceUncloakFunc =
                            (_OnForceUncloak)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onForceUncloak"), typeof(_OnForceUncloak));
                    }

                    return _OnForceUncloakFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnEndSequence__Args
                {

				   internal IntPtr obj;

				   internal int slot;

				   internal string name;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnEndSequence(IntPtr _this, IntPtr obj, int slot, string name);
                internal delegate void _OnEndSequence(IntPtr _this, OnEndSequence__Args args);
                private static _OnEndSequence _OnEndSequenceFunc;
                internal static _OnEndSequence OnEndSequence() {
                    if (_OnEndSequenceFunc == null) {
                        _OnEndSequenceFunc =
                            (_OnEndSequence)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onEndSequence"), typeof(_OnEndSequence));
                    }

                    return _OnEndSequenceFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnTrigger__Args
                {

				   internal IntPtr obj;

				   internal int index;
				   [MarshalAs(UnmanagedType.I1)]
				   internal bool state;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnTrigger(IntPtr _this, IntPtr obj, int index, [MarshalAs(UnmanagedType.I1)]bool state);
                internal delegate void _OnTrigger(IntPtr _this, OnTrigger__Args args);
                private static _OnTrigger _OnTriggerFunc;
                internal static _OnTrigger OnTrigger() {
                    if (_OnTriggerFunc == null) {
                        _OnTriggerFunc =
                            (_OnTrigger)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onTrigger"), typeof(_OnTrigger));
                    }

                    return _OnTriggerFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDamage__Args
                {

				   internal IntPtr obj;

				   internal float delta;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDamage(IntPtr _this, IntPtr obj, float delta);
                internal delegate void _OnDamage(IntPtr _this, OnDamage__Args args);
                private static _OnDamage _OnDamageFunc;
                internal static _OnDamage OnDamage() {
                    if (_OnDamageFunc == null) {
                        _OnDamageFunc =
                            (_OnDamage)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onDamage"), typeof(_OnDamage));
                    }

                    return _OnDamageFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnCollision__Args
                {

				   internal IntPtr obj;

				   internal IntPtr collObj;

				   internal IntPtr vec;

				   internal float len;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnCollision(IntPtr _this, IntPtr obj, IntPtr collObj, IntPtr vec, float len);
                internal delegate void _OnCollision(IntPtr _this, OnCollision__Args args);
                private static _OnCollision _OnCollisionFunc;
                internal static _OnCollision OnCollision() {
                    if (_OnCollisionFunc == null) {
                        _OnCollisionFunc =
                            (_OnCollision)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onCollision"), typeof(_OnCollision));
                    }

                    return _OnCollisionFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnImpact__Args
                {

				   internal IntPtr obj;

				   internal IntPtr collObj;

				   internal IntPtr vec;

				   internal float len;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnImpact(IntPtr _this, IntPtr obj, IntPtr collObj, IntPtr vec, float len);
                internal delegate void _OnImpact(IntPtr _this, OnImpact__Args args);
                private static _OnImpact _OnImpactFunc;
                internal static _OnImpact OnImpact() {
                    if (_OnImpactFunc == null) {
                        _OnImpactFunc =
                            (_OnImpact)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onImpact"), typeof(_OnImpact));
                    }

                    return _OnImpactFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDestroyed__Args
                {

				   internal IntPtr obj;

				   internal string lastState;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDestroyed(IntPtr _this, IntPtr obj, string lastState);
                internal delegate void _OnDestroyed(IntPtr _this, OnDestroyed__Args args);
                private static _OnDestroyed _OnDestroyedFunc;
                internal static _OnDestroyed OnDestroyed() {
                    if (_OnDestroyedFunc == null) {
                        _OnDestroyedFunc =
                            (_OnDestroyed)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onDestroyed"), typeof(_OnDestroyed));
                    }

                    return _OnDestroyedFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnDisabled__Args
                {

				   internal IntPtr obj;

				   internal string lastState;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnDisabled(IntPtr _this, IntPtr obj, string lastState);
                internal delegate void _OnDisabled(IntPtr _this, OnDisabled__Args args);
                private static _OnDisabled _OnDisabledFunc;
                internal static _OnDisabled OnDisabled() {
                    if (_OnDisabledFunc == null) {
                        _OnDisabledFunc =
                            (_OnDisabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onDisabled"), typeof(_OnDisabled));
                    }

                    return _OnDisabledFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct OnEnabled__Args
                {

				   internal IntPtr obj;

				   internal string lastState;
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _OnEnabled(IntPtr _this, IntPtr obj, string lastState);
                internal delegate void _OnEnabled(IntPtr _this, OnEnabled__Args args);
                private static _OnEnabled _OnEnabledFunc;
                internal static _OnEnabled OnEnabled() {
                    if (_OnEnabledFunc == null) {
                        _OnEnabledFunc =
                            (_OnEnabled)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "cbShapeBaseData_onEnabled"), typeof(_OnEnabled));
                    }

                    return _OnEnabledFunc;
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
                                    "fnShapeBaseData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnShapeBaseData_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public TransformF GetDeployTransform(Point3F pos, Point3F normal) {

                     pos.Alloc();                     normal.Alloc();                     InternalUnsafeMethods.GetDeployTransform__Args _args = new InternalUnsafeMethods.GetDeployTransform__Args() {
                        pos = pos.internalStructPtr,
                        normal = normal.internalStructPtr,
                     };
                     TransformF.InternalStruct _engineResult = InternalUnsafeMethods.GetDeployTransform()(ObjectPtr, _args);
                                          pos.Free();                     normal.Free();
                     return new TransformF(_engineResult);
                  }



                  public bool CheckDeployPos(TransformF txfm) {

                     txfm.Alloc();                     InternalUnsafeMethods.CheckDeployPos__Args _args = new InternalUnsafeMethods.CheckDeployPos__Args() {
                        txfm = txfm.internalStructPtr,
                     };
                     bool _engineResult = InternalUnsafeMethods.CheckDeployPos()(ObjectPtr, _args);
                                          txfm.Free();
                     return _engineResult;
                  }



                  public void OnForceUncloak(ShapeBase obj, string reason) {

                                                               InternalUnsafeMethods.OnForceUncloak__Args _args = new InternalUnsafeMethods.OnForceUncloak__Args() {
                        obj = obj.ObjectPtr,
                        reason = reason,
                     };
                     InternalUnsafeMethods.OnForceUncloak()(ObjectPtr, _args);

                  }



                  public void OnEndSequence(ShapeBase obj, int slot, string name) {

                                                                                    InternalUnsafeMethods.OnEndSequence__Args _args = new InternalUnsafeMethods.OnEndSequence__Args() {
                        obj = obj.ObjectPtr,
                        slot = slot,
                        name = name,
                     };
                     InternalUnsafeMethods.OnEndSequence()(ObjectPtr, _args);

                  }



                  public void OnTrigger(ShapeBase obj, int index, bool state) {

                                                                                    InternalUnsafeMethods.OnTrigger__Args _args = new InternalUnsafeMethods.OnTrigger__Args() {
                        obj = obj.ObjectPtr,
                        index = index,
                        state = state,
                     };
                     InternalUnsafeMethods.OnTrigger()(ObjectPtr, _args);

                  }



                  public void OnDamage(ShapeBase obj, float delta) {

                                                               InternalUnsafeMethods.OnDamage__Args _args = new InternalUnsafeMethods.OnDamage__Args() {
                        obj = obj.ObjectPtr,
                        delta = delta,
                     };
                     InternalUnsafeMethods.OnDamage()(ObjectPtr, _args);

                  }



                  public void OnCollision(ShapeBase obj, SceneObject collObj, Point3F vec, float len) {

                                                               vec.Alloc();                                          InternalUnsafeMethods.OnCollision__Args _args = new InternalUnsafeMethods.OnCollision__Args() {
                        obj = obj.ObjectPtr,
                        collObj = collObj.ObjectPtr,
                        vec = vec.internalStructPtr,
                        len = len,
                     };
                     InternalUnsafeMethods.OnCollision()(ObjectPtr, _args);
                                                                                    vec.Free();
                  }



                  public void OnImpact(ShapeBase obj, SceneObject collObj, Point3F vec, float len) {

                                                               vec.Alloc();                                          InternalUnsafeMethods.OnImpact__Args _args = new InternalUnsafeMethods.OnImpact__Args() {
                        obj = obj.ObjectPtr,
                        collObj = collObj.ObjectPtr,
                        vec = vec.internalStructPtr,
                        len = len,
                     };
                     InternalUnsafeMethods.OnImpact()(ObjectPtr, _args);
                                                                                    vec.Free();
                  }



                  public void OnDestroyed(ShapeBase obj, string lastState) {

                                                               InternalUnsafeMethods.OnDestroyed__Args _args = new InternalUnsafeMethods.OnDestroyed__Args() {
                        obj = obj.ObjectPtr,
                        lastState = lastState,
                     };
                     InternalUnsafeMethods.OnDestroyed()(ObjectPtr, _args);

                  }



                  public void OnDisabled(ShapeBase obj, string lastState) {

                                                               InternalUnsafeMethods.OnDisabled__Args _args = new InternalUnsafeMethods.OnDisabled__Args() {
                        obj = obj.ObjectPtr,
                        lastState = lastState,
                     };
                     InternalUnsafeMethods.OnDisabled()(ObjectPtr, _args);

                  }



                  public void OnEnabled(ShapeBase obj, string lastState) {

                                                               InternalUnsafeMethods.OnEnabled__Args _args = new InternalUnsafeMethods.OnEnabled__Args() {
                        obj = obj.ObjectPtr,
                        lastState = lastState,
                     };
                     InternalUnsafeMethods.OnEnabled()(ObjectPtr, _args);

                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public bool ShadowEnable {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("shadowEnable"));
            set => SetFieldValue("shadowEnable", GenericMarshal.ToString(value));
        }


        public int ShadowSize {
            get => GenericMarshal.StringTo<int>(GetFieldValue("shadowSize"));
            set => SetFieldValue("shadowSize", GenericMarshal.ToString(value));
        }


        public float ShadowMaxVisibleDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shadowMaxVisibleDistance"));
            set => SetFieldValue("shadowMaxVisibleDistance", GenericMarshal.ToString(value));
        }


        public float ShadowProjectionDistance {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shadowProjectionDistance"));
            set => SetFieldValue("shadowProjectionDistance", GenericMarshal.ToString(value));
        }


        public float ShadowSphereAdjust {
            get => GenericMarshal.StringTo<float>(GetFieldValue("shadowSphereAdjust"));
            set => SetFieldValue("shadowSphereAdjust", GenericMarshal.ToString(value));
        }


        public string ShapeFile {
            get => GenericMarshal.StringTo<string>(GetFieldValue("shapeFile"));
            set => SetFieldValue("shapeFile", GenericMarshal.ToString(value));
        }


        public ExplosionData Explosion {
            get => GenericMarshal.StringTo<ExplosionData>(GetFieldValue("Explosion"));
            set => SetFieldValue("Explosion", GenericMarshal.ToString(value));
        }


        public ExplosionData UnderwaterExplosion {
            get => GenericMarshal.StringTo<ExplosionData>(GetFieldValue("underwaterExplosion"));
            set => SetFieldValue("underwaterExplosion", GenericMarshal.ToString(value));
        }


        public DebrisData Debris {
            get => GenericMarshal.StringTo<DebrisData>(GetFieldValue("Debris"));
            set => SetFieldValue("Debris", GenericMarshal.ToString(value));
        }


        public bool RenderWhenDestroyed {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("renderWhenDestroyed"));
            set => SetFieldValue("renderWhenDestroyed", GenericMarshal.ToString(value));
        }


        public string DebrisShapeName {
            get => GenericMarshal.StringTo<string>(GetFieldValue("debrisShapeName"));
            set => SetFieldValue("debrisShapeName", GenericMarshal.ToString(value));
        }


        public float Mass {
            get => GenericMarshal.StringTo<float>(GetFieldValue("mass"));
            set => SetFieldValue("mass", GenericMarshal.ToString(value));
        }


        public float Drag {
            get => GenericMarshal.StringTo<float>(GetFieldValue("drag"));
            set => SetFieldValue("drag", GenericMarshal.ToString(value));
        }


        public float Density {
            get => GenericMarshal.StringTo<float>(GetFieldValue("density"));
            set => SetFieldValue("density", GenericMarshal.ToString(value));
        }


        public float MaxEnergy {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxEnergy"));
            set => SetFieldValue("maxEnergy", GenericMarshal.ToString(value));
        }


        public float MaxDamage {
            get => GenericMarshal.StringTo<float>(GetFieldValue("maxDamage"));
            set => SetFieldValue("maxDamage", GenericMarshal.ToString(value));
        }


        public float DisabledLevel {
            get => GenericMarshal.StringTo<float>(GetFieldValue("disabledLevel"));
            set => SetFieldValue("disabledLevel", GenericMarshal.ToString(value));
        }


        public float DestroyedLevel {
            get => GenericMarshal.StringTo<float>(GetFieldValue("destroyedLevel"));
            set => SetFieldValue("destroyedLevel", GenericMarshal.ToString(value));
        }


        public float RepairRate {
            get => GenericMarshal.StringTo<float>(GetFieldValue("repairRate"));
            set => SetFieldValue("repairRate", GenericMarshal.ToString(value));
        }


        public bool InheritEnergyFromMount {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("inheritEnergyFromMount"));
            set => SetFieldValue("inheritEnergyFromMount", GenericMarshal.ToString(value));
        }


        public bool IsInvincible {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("isInvincible"));
            set => SetFieldValue("isInvincible", GenericMarshal.ToString(value));
        }


        public float CameraMaxDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraMaxDist"));
            set => SetFieldValue("cameraMaxDist", GenericMarshal.ToString(value));
        }


        public float CameraMinDist {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraMinDist"));
            set => SetFieldValue("cameraMinDist", GenericMarshal.ToString(value));
        }


        public float CameraDefaultFov {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraDefaultFov"));
            set => SetFieldValue("cameraDefaultFov", GenericMarshal.ToString(value));
        }


        public float CameraMinFov {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraMinFov"));
            set => SetFieldValue("cameraMinFov", GenericMarshal.ToString(value));
        }


        public float CameraMaxFov {
            get => GenericMarshal.StringTo<float>(GetFieldValue("cameraMaxFov"));
            set => SetFieldValue("cameraMaxFov", GenericMarshal.ToString(value));
        }


        public bool CameraCanBank {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("cameraCanBank"));
            set => SetFieldValue("cameraCanBank", GenericMarshal.ToString(value));
        }


        public bool MountedImagesBank {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("mountedImagesBank"));
            set => SetFieldValue("mountedImagesBank", GenericMarshal.ToString(value));
        }


        public bool FirstPersonOnly {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("firstPersonOnly"));
            set => SetFieldValue("firstPersonOnly", GenericMarshal.ToString(value));
        }


        public bool UseEyePoint {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("useEyePoint"));
            set => SetFieldValue("useEyePoint", GenericMarshal.ToString(value));
        }


        public bool ObserveThroughObject {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("observeThroughObject"));
            set => SetFieldValue("observeThroughObject", GenericMarshal.ToString(value));
        }


        public bool ComputeCRC {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("computeCRC"));
            set => SetFieldValue("computeCRC", GenericMarshal.ToString(value));
        }


        public string CubeReflectorDesc {
            get => GenericMarshal.StringTo<string>(GetFieldValue("cubeReflectorDesc"));
            set => SetFieldValue("cubeReflectorDesc", GenericMarshal.ToString(value));
        }


        public string RemapTextureTags {
            get => GenericMarshal.StringTo<string>(GetFieldValue("remapTextureTags"));
            set => SetFieldValue("remapTextureTags", GenericMarshal.ToString(value));
        }


        public bool SilentBBoxValidation {
            get => GenericMarshal.StringTo<bool>(GetFieldValue("silentBBoxValidation"));
            set => SetFieldValue("silentBBoxValidation", GenericMarshal.ToString(value));
        }


    }
}
