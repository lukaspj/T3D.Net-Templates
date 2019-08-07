using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using T3DNetFramework.Generated.Classes.Reflection;
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
using T3DNetFramework.Generated.Structs.Math;

namespace T3DNetFramework.Generated.Classes.Sim {

    public unsafe class GuiInspectorEntityGroup : GuiInspectorGroup {



        public GuiInspectorEntityGroup(bool pRegister = false)
            : base(pRegister) {
        }

        public GuiInspectorEntityGroup(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public GuiInspectorEntityGroup(string pName)
            : this(pName, false) {
        }

        public GuiInspectorEntityGroup(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public GuiInspectorEntityGroup(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public GuiInspectorEntityGroup(SimObject pObj)
            : base(pObj) {
        }

        public GuiInspectorEntityGroup(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



                [StructLayout(LayoutKind.Sequential)]
                internal struct RemoveDynamicField__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _RemoveDynamicField(IntPtr _this);
                internal delegate void _RemoveDynamicField(IntPtr _this, RemoveDynamicField__Args args);
                private static _RemoveDynamicField _RemoveDynamicFieldFunc;
                internal static _RemoveDynamicField RemoveDynamicField() {
                    if (_RemoveDynamicFieldFunc == null) {
                        _RemoveDynamicFieldFunc =
                            (_RemoveDynamicField)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInspectorEntityGroup_removeDynamicField"), typeof(_RemoveDynamicField));
                    }

                    return _RemoveDynamicFieldFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct AddDynamicField__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

                //internal delegate void _AddDynamicField(IntPtr _this);
                internal delegate void _AddDynamicField(IntPtr _this, AddDynamicField__Args args);
                private static _AddDynamicField _AddDynamicFieldFunc;
                internal static _AddDynamicField AddDynamicField() {
                    if (_AddDynamicFieldFunc == null) {
                        _AddDynamicFieldFunc =
                            (_AddDynamicField)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInspectorEntityGroup_addDynamicField"), typeof(_AddDynamicField));
                    }

                    return _AddDynamicFieldFunc;
                }



                [StructLayout(LayoutKind.Sequential)]
                internal struct InspectGroup__Args
                {
                }

                [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
                [return: MarshalAs(UnmanagedType.I1)]
                //internal delegate bool _InspectGroup(IntPtr _this);
                internal delegate bool _InspectGroup(IntPtr _this, InspectGroup__Args args);
                private static _InspectGroup _InspectGroupFunc;
                internal static _InspectGroup InspectGroup() {
                    if (_InspectGroupFunc == null) {
                        _InspectGroupFunc =
                            (_InspectGroup)Marshal.GetDelegateForFunctionPointer(
                                Torque3D.DllLoadUtils.GetProcAddress(
                                    Torque3D.Torque3DLibHandle,
                                    "fnGuiInspectorEntityGroup_inspectGroup"), typeof(_InspectGroup));
                    }

                    return _InspectGroupFunc;
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
                                    "fnGuiInspectorEntityGroup_staticGetType"), typeof(_StaticGetType));
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
                                    "fnGuiInspectorEntityGroup_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public void RemoveDynamicField() {

                     InternalUnsafeMethods.RemoveDynamicField__Args _args = new InternalUnsafeMethods.RemoveDynamicField__Args() {
                     };
                     InternalUnsafeMethods.RemoveDynamicField()(ObjectPtr, _args);

                  }



                  public void AddDynamicField() {

                     InternalUnsafeMethods.AddDynamicField__Args _args = new InternalUnsafeMethods.AddDynamicField__Args() {
                     };
                     InternalUnsafeMethods.AddDynamicField()(ObjectPtr, _args);

                  }



                  public bool InspectGroup() {

                     InternalUnsafeMethods.InspectGroup__Args _args = new InternalUnsafeMethods.InspectGroup__Args() {
                     };
                     bool _engineResult = InternalUnsafeMethods.InspectGroup()(ObjectPtr, _args);

                     return _engineResult;
                  }



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






    }
}
