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

    public unsafe class PrecipitationData : GameBaseData {



        public PrecipitationData(bool pRegister = false)
            : base(pRegister) {
        }

        public PrecipitationData(string pName, bool pRegister)
            : this(false) {
            Name = pName;
            if (pRegister) {
                RegisterObject();
            }
        }

        public PrecipitationData(string pName)
            : this(pName, false) {
        }

        public PrecipitationData(string pName, string pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(Engine.Sim.FindObject<SimObject>(pParent));
        }

        public PrecipitationData(string pName, SimObject pParent, bool pRegister = false)
            : this(pName, pRegister) {
            CopyFrom(pParent);
        }

        public PrecipitationData(SimObject pObj)
            : base(pObj) {
        }

        public PrecipitationData(IntPtr pObj)
            : base(pObj) {
        }


		protected override void CreateObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Create()(new InternalUnsafeMethods.Create__Args());
		}







        #region UnsafeNativeMethods
        new internal struct InternalUnsafeMethods {



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
                                    "fnPrecipitationData_staticGetType"), typeof(_StaticGetType));
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
                                    "fnPrecipitationData_create"), typeof(_Create));
                    }

                    return _CreateFunc;
                }

        }
        #endregion



                  public static EngineTypeInfo StaticGetType() {
                     InternalUnsafeMethods.StaticGetType__Args _args = new InternalUnsafeMethods.StaticGetType__Args() {
                     };
                     IntPtr _engineResult = InternalUnsafeMethods.StaticGetType()(_args);

                     return new EngineTypeInfo(_engineResult);
                  }






        public SFXTrack SoundProfile {
            get => GenericMarshal.StringTo<SFXTrack>(GetFieldValue("soundProfile"));
            set => SetFieldValue("soundProfile", GenericMarshal.ToString(value));
        }


        public string DropTexture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("dropTexture"));
            set => SetFieldValue("dropTexture", GenericMarshal.ToString(value));
        }


        public string DropShader {
            get => GenericMarshal.StringTo<string>(GetFieldValue("dropShader"));
            set => SetFieldValue("dropShader", GenericMarshal.ToString(value));
        }


        public string SplashTexture {
            get => GenericMarshal.StringTo<string>(GetFieldValue("splashTexture"));
            set => SetFieldValue("splashTexture", GenericMarshal.ToString(value));
        }


        public string SplashShader {
            get => GenericMarshal.StringTo<string>(GetFieldValue("splashShader"));
            set => SetFieldValue("splashShader", GenericMarshal.ToString(value));
        }


        public int DropsPerSide {
            get => GenericMarshal.StringTo<int>(GetFieldValue("dropsPerSide"));
            set => SetFieldValue("dropsPerSide", GenericMarshal.ToString(value));
        }


        public int SplashesPerSide {
            get => GenericMarshal.StringTo<int>(GetFieldValue("splashesPerSide"));
            set => SetFieldValue("splashesPerSide", GenericMarshal.ToString(value));
        }


    }
}
