using System;

namespace ClrDebug.Native
{
    public static class CorGuids
    {
        public static readonly Guid ICorDebug = new Guid(0x3D6F5F61,0x7538,0x11D3,0x8D,0x5B,0x00,0x10,0x4B,0x35,0xE7,0xEF);

        public static readonly Guid ICorDebug2 = new Guid(0xECCCCF2E,0xB286,0x4B3E,0xA9,0x83,0x86,0x0A,0x87,0x93,0xD1,0x05);

        public static readonly Guid ICorDebugAppDomain = new Guid(0x3D6F5F63,0x7538,0x11D3,0x8D,0x5B,0x00,0x10,0x4B,0x35,0xE7,0xEF);

        public static readonly Guid ICorDebugAppDomain2 = new Guid(0x096E81D5,0xECDA,0x4202,0x83,0xF5,0xC6,0x59,0x80,0xA9,0xEF,0x75);

        public static readonly Guid ICorDebugAppDomain3 = new Guid(0x8CB96A16,0xB588,0x42E2,0xB7,0x1C,0xDD,0x84,0x9F,0xC2,0xEC,0xCC);

        public static readonly Guid ICorDebugAppDomain4 = new Guid(0xFB99CC40,0x83BE,0x4724,0xAB,0x3B,0x76,0x8E,0x79,0x6E,0xBA,0xC2);

        public static readonly Guid ICorDebugAppDomainEnum = new Guid(0x63CA1B24,0x4359,0x4883,0xBD,0x57,0x13,0xF8,0x15,0xF5,0x87,0x44);

        public static readonly Guid ICorDebugArrayValue = new Guid(0x0405B0DF,0xA660,0x11D2,0xBD,0x02,0x00,0x00,0xF8,0x08,0x49,0xBD);

        public static readonly Guid ICorDebugAssembly = new Guid(0xDF59507C,0xD47A,0x459E,0xBC,0xE2,0x64,0x27,0xEA,0xC8,0xFD,0x06);

        public static readonly Guid ICorDebugAssembly2 = new Guid(0x426D1F9E,0x6DD4,0x44C8,0xAE,0xC7,0x26,0xCD,0xBA,0xF4,0xE3,0x98);

        public static readonly Guid ICorDebugAssembly3 = new Guid(0x76361AB2,0x8C86,0x4FE9,0x96,0xF2,0xF7,0x3D,0x88,0x43,0x57,0x0A);

        public static readonly Guid ICorDebugAssemblyEnum = new Guid(0x4A2A1EC9,0x85EC,0x4BFB,0x9F,0x15,0xA8,0x9F,0xDF,0xE0,0xFE,0x83);

        public static readonly Guid ICorDebugBlockingObjectEnum = new Guid(0x976A6278,0x134A,0x4A81,0x81,0xA3,0x8F,0x27,0x79,0x43,0xF4,0xC3);

        public static readonly Guid ICorDebugBoxValue = new Guid(0xCC7BCAFC,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugBreakpoint = new Guid(0xCC7BCAE8,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugBreakpointEnum = new Guid(0xCC7BCB03,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugChain = new Guid(0xCC7BCAEE,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugChainEnum = new Guid(0xCC7BCB08,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugClass = new Guid(0xCC7BCAF5,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugClass2 = new Guid(0xB008EA8D,0x7AB1,0x43F7,0xBB,0x20,0xFB,0xB5,0xA0,0x40,0x38,0xAE);

        public static readonly Guid ICorDebugCode = new Guid(0xCC7BCAF4,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugCode2 = new Guid(0x5F696509,0x452F,0x4436,0xA3,0xFE,0x4D,0x11,0xFE,0x7E,0x23,0x47);

        public static readonly Guid ICorDebugCode3 = new Guid(0xD13D3E88,0xE1F2,0x4020,0xAA,0x1D,0x3D,0x16,0x2D,0xCB,0xE9,0x66);

        public static readonly Guid ICorDebugCode4 = new Guid(0x18221FA4,0x20CB,0x40FA,0xB1,0x9D,0x9F,0x91,0xC4,0xFA,0x8C,0x14);

        public static readonly Guid ICorDebugCodeEnum = new Guid(0x55E96461,0x9645,0x45E4,0xA2,0xFF,0x03,0x67,0x87,0x7A,0xBC,0xDE);

        public static readonly Guid ICorDebugComObjectValue = new Guid(0x5F69C5E5,0x3E12,0x42DF,0xB3,0x71,0xF9,0xD7,0x61,0xD6,0xEE,0x24);

        public static readonly Guid ICorDebugContext = new Guid(0xCC7BCB00,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugController = new Guid(0x3D6F5F62,0x7538,0x11D3,0x8D,0x5B,0x00,0x10,0x4B,0x35,0xE7,0xEF);

        public static readonly Guid ICorDebugDataTarget = new Guid(0xFE06DC28,0x49FB,0x4636,0xA4,0xA3,0xE8,0x0D,0xB4,0xAE,0x11,0x6C);

        public static readonly Guid ICorDebugDataTarget2 = new Guid(0x2EB364DA,0x605B,0x4E8D,0xB3,0x33,0x33,0x94,0xC4,0x82,0x8D,0x41);

        public static readonly Guid ICorDebugDataTarget3 = new Guid(0xD05E60C3,0x848C,0x4E7D,0x89,0x4E,0x62,0x33,0x20,0xFF,0x6A,0xFA);

        public static readonly Guid ICorDebugDataTarget4 = new Guid(0xE799DC06,0xE099,0x4713,0xBD,0xD9,0x90,0x6D,0x3C,0xC0,0x2C,0xF2);

        public static readonly Guid ICorDebugDebugEvent = new Guid(0x41BD395D,0xDE99,0x48F1,0xBF,0x7A,0xCC,0x0F,0x44,0xA6,0xD2,0x81);

        public static readonly Guid ICorDebugDelegateObjectValue = new Guid(0x3AF70CC7,0x6047,0x47F6,0xA5,0xC5,0x09,0x0A,0x1A,0x62,0x26,0x38);

        public static readonly Guid ICorDebugEditAndContinueErrorInfo = new Guid(0x8D600D41,0xF4F6,0x4CB3,0xB7,0xEC,0x7B,0xD1,0x64,0x94,0x40,0x36);

        public static readonly Guid ICorDebugEditAndContinueSnapshot = new Guid(0x6DC3FA01,0xD7CB,0x11D2,0x8A,0x95,0x00,0x80,0xC7,0x92,0xE5,0xD8);

        public static readonly Guid ICorDebugEnum = new Guid(0xCC7BCB01,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugErrorInfoEnum = new Guid(0xF0E18809,0x72B5,0x11D2,0x97,0x6F,0x00,0xA0,0xC9,0xB4,0xD5,0x0C);

        public static readonly Guid ICorDebugEval = new Guid(0xCC7BCAF6,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugEval2 = new Guid(0xFB0D9CE7,0xBE66,0x4683,0x9D,0x32,0xA4,0x2A,0x04,0xE2,0xFD,0x91);

        public static readonly Guid ICorDebugExceptionDebugEvent = new Guid(0xAF79EC94,0x4752,0x419C,0xA6,0x26,0x5F,0xB1,0xCC,0x1A,0x5A,0xB7);

        public static readonly Guid ICorDebugExceptionObjectCallStackEnum = new Guid(0xED775530,0x4DC4,0x41F7,0x86,0xD0,0x9E,0x2D,0xEF,0x7D,0xFC,0x66);

        public static readonly Guid ICorDebugExceptionObjectValue = new Guid(0xAE4CA65D,0x59DD,0x42A2,0x83,0xA5,0x57,0xE8,0xA0,0x8D,0x87,0x19);

        public static readonly Guid ICorDebugFrame = new Guid(0xCC7BCAEF,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugFrameEnum = new Guid(0xCC7BCB07,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugFunction = new Guid(0xCC7BCAF3,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugFunction2 = new Guid(0xEF0C490B,0x94C3,0x4E4D,0xB6,0x29,0xDD,0xC1,0x34,0xC5,0x32,0xD8);

        public static readonly Guid ICorDebugFunction3 = new Guid(0x09B70F28,0xE465,0x482D,0x99,0xE0,0x81,0xA1,0x65,0xEB,0x05,0x32);

        public static readonly Guid ICorDebugFunction4 = new Guid(0x72965963,0x34FD,0x46E9,0x94,0x34,0xB8,0x17,0xFE,0x6E,0x7F,0x43);

        public static readonly Guid ICorDebugFunctionBreakpoint = new Guid(0xCC7BCAE9,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugGCReferenceEnum = new Guid(0x7F3C24D3,0x7E1D,0x4245,0xAC,0x3A,0xF7,0x2F,0x88,0x59,0xC8,0x0C);

        public static readonly Guid ICorDebugGenericValue = new Guid(0xCC7BCAF8,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugGuidToTypeEnum = new Guid(0x6164D242,0x1015,0x4BD6,0x8C,0xBE,0xD0,0xDB,0xD4,0xB8,0x27,0x5A);

        public static readonly Guid ICorDebugHandleValue = new Guid(0x029596E8,0x276B,0x46A1,0x98,0x21,0x73,0x2E,0x96,0xBB,0xB0,0x0B);

        public static readonly Guid ICorDebugHeapEnum = new Guid(0x76D7DAB8,0xD044,0x11DF,0x9A,0x15,0x7E,0x29,0xDF,0xD7,0x20,0x85);

        public static readonly Guid ICorDebugHeapSegmentEnum = new Guid(0xA2FA0F8E,0xD045,0x11DF,0xAC,0x8E,0xCE,0x2A,0xDF,0xD7,0x20,0x85);

        public static readonly Guid ICorDebugHeapValue = new Guid(0xCC7BCAFA,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugHeapValue2 = new Guid(0xE3AC4D6C,0x9CB7,0x43E6,0x96,0xCC,0xB2,0x15,0x40,0xE5,0x08,0x3C);

        public static readonly Guid ICorDebugHeapValue3 = new Guid(0xA69ACAD8,0x2374,0x46E9,0x9F,0xF8,0xB1,0xF1,0x41,0x20,0xD2,0x96);

        public static readonly Guid ICorDebugILCode = new Guid(0x598D46C2,0xC877,0x42A7,0x89,0xD2,0x3D,0x0C,0x7F,0x1C,0x12,0x64);

        public static readonly Guid ICorDebugILCode2 = new Guid(0x46586093,0xD3F5,0x4DB6,0xAC,0xDB,0x95,0x5B,0xCE,0x22,0x8C,0x15);

        public static readonly Guid ICorDebugILFrame = new Guid(0x03E26311,0x4F76,0x11D3,0x88,0xC6,0x00,0x60,0x97,0x94,0x54,0x18);

        public static readonly Guid ICorDebugILFrame2 = new Guid(0x5D88A994,0x6C30,0x479B,0x89,0x0F,0xBC,0xEF,0x88,0xB1,0x29,0xA5);

        public static readonly Guid ICorDebugILFrame3 = new Guid(0x9A9E2ED6,0x04DF,0x4FE0,0xBB,0x50,0xCA,0xB6,0x41,0x26,0xAD,0x24);

        public static readonly Guid ICorDebugILFrame4 = new Guid(0xAD914A30,0xC6D1,0x4AC5,0x9C,0x5E,0x57,0x7F,0x3B,0xAA,0x8A,0x45);

        public static readonly Guid ICorDebugInstanceFieldSymbol = new Guid(0xA074096B,0x3ADC,0x4485,0x81,0xDA,0x68,0xC7,0xA4,0xEA,0x52,0xDB);

        public static readonly Guid ICorDebugInternalFrame = new Guid(0xB92CC7F7,0x9D2D,0x45C4,0xBC,0x2B,0x62,0x1F,0xCC,0x9D,0xFB,0xF4);

        public static readonly Guid ICorDebugInternalFrame2 = new Guid(0xC0815BDC,0xCFAB,0x447E,0xA7,0x79,0xC1,0x16,0xB4,0x54,0xEB,0x5B);

        public static readonly Guid ICorDebugLoadedModule = new Guid(0x817F343A,0x6630,0x4578,0x96,0xC5,0xD1,0x1B,0xC0,0xEC,0x5E,0xE2);

        public static readonly Guid ICorDebugManagedCallback = new Guid(0x3D6F5F60,0x7538,0x11D3,0x8D,0x5B,0x00,0x10,0x4B,0x35,0xE7,0xEF);

        public static readonly Guid ICorDebugManagedCallback2 = new Guid(0x250E5EEA,0xDB5C,0x4C76,0xB6,0xF3,0x8C,0x46,0xF1,0x2E,0x32,0x03);

        public static readonly Guid ICorDebugManagedCallback3 = new Guid(0x264EA0FC,0x2591,0x49AA,0x86,0x8E,0x83,0x5E,0x65,0x15,0x32,0x3F);

        public static readonly Guid ICorDebugManagedCallback4 = new Guid(0x322911AE,0x16A5,0x49BA,0x84,0xA3,0xED,0x69,0x67,0x81,0x38,0xA3);

        public static readonly Guid ICorDebugMDA = new Guid(0xCC726F2F,0x1DB7,0x459B,0xB0,0xEC,0x05,0xF0,0x1D,0x84,0x1B,0x42);

        public static readonly Guid ICorDebugMemoryBuffer = new Guid(0x677888B3,0xD160,0x4B8C,0xA7,0x3B,0xD7,0x9E,0x6A,0xAA,0x1D,0x13);

        public static readonly Guid ICorDebugMergedAssemblyRecord = new Guid(0xFAA8637B,0x3BBE,0x4671,0x8E,0x26,0x3B,0x59,0x87,0x5B,0x92,0x2A);

        public static readonly Guid ICorDebugMetaDataLocator = new Guid(0x7CEF8BA9,0x2EF7,0x42BF,0x97,0x3F,0x41,0x71,0x47,0x4F,0x87,0xD9);

        public static readonly Guid ICorDebugModule = new Guid(0xDBA2D8C1,0xE5C5,0x4069,0x8C,0x13,0x10,0xA7,0xC6,0xAB,0xF4,0x3D);

        public static readonly Guid ICorDebugModule2 = new Guid(0x7FCC5FB5,0x49C0,0x41DE,0x99,0x38,0x3B,0x88,0xB5,0xB9,0xAD,0xD7);

        public static readonly Guid ICorDebugModule3 = new Guid(0x86F012BF,0xFF15,0x4372,0xBD,0x30,0xB6,0xF1,0x1C,0xAA,0xE1,0xDD);

        public static readonly Guid ICorDebugModuleBreakpoint = new Guid(0xCC7BCAEA,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugModuleDebugEvent = new Guid(0x51A15E8D,0x9FFF,0x4864,0x9B,0x87,0xF4,0xFB,0xDE,0xA7,0x47,0xA2);

        public static readonly Guid ICorDebugModuleEnum = new Guid(0xCC7BCB09,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugMutableDataTarget = new Guid(0xA1B8A756,0x3CB6,0x4CCB,0x97,0x9F,0x3D,0xF9,0x99,0x67,0x3A,0x59);

        public static readonly Guid ICorDebugNativeFrame = new Guid(0x03E26314,0x4F76,0x11D3,0x88,0xC6,0x00,0x60,0x97,0x94,0x54,0x18);

        public static readonly Guid ICorDebugNativeFrame2 = new Guid(0x35389FF1,0x3684,0x4C55,0xA2,0xEE,0x21,0x0F,0x26,0xC6,0x0E,0x5E);

        public static readonly Guid ICorDebugObjectEnum = new Guid(0xCC7BCB02,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugObjectValue = new Guid(0x18AD3D6E,0xB7D2,0x11D2,0xBD,0x04,0x00,0x00,0xF8,0x08,0x49,0xBD);

        public static readonly Guid ICorDebugObjectValue2 = new Guid(0x49E4A320,0x4A9B,0x4ECA,0xB1,0x05,0x22,0x9F,0xB7,0xD5,0x00,0x9F);

        public static readonly Guid ICorDebugProcess = new Guid(0x3D6F5F64,0x7538,0x11D3,0x8D,0x5B,0x00,0x10,0x4B,0x35,0xE7,0xEF);

        public static readonly Guid ICorDebugProcess2 = new Guid(0xAD1B3588,0x0EF0,0x4744,0xA4,0x96,0xAA,0x09,0xA9,0xF8,0x03,0x71);

        public static readonly Guid ICorDebugProcess3 = new Guid(0x2EE06488,0xC0D4,0x42B1,0xB2,0x6D,0xF3,0x79,0x5E,0xF6,0x06,0xFB);

        public static readonly Guid ICorDebugProcess5 = new Guid(0x21E9D9C0,0xFCB8,0x11DF,0x8C,0xFF,0x08,0x00,0x20,0x0C,0x9A,0x66);

        public static readonly Guid ICorDebugProcess6 = new Guid(0x11588775,0x7205,0x4CEB,0xA4,0x1A,0x93,0x75,0x3C,0x31,0x53,0xE9);

        public static readonly Guid ICorDebugProcess7 = new Guid(0x9B2C54E4,0x119F,0x4D6F,0xB4,0x02,0x52,0x76,0x03,0x26,0x6D,0x69);

        public static readonly Guid ICorDebugProcess8 = new Guid(0x2E6F28C1,0x85EB,0x4141,0x80,0xAD,0x0A,0x90,0x94,0x4B,0x96,0x39);

        public static readonly Guid ICorDebugProcess10 = new Guid(0x8F378F6F,0x1017,0x4461,0x98,0x90,0xEC,0xF6,0x4C,0x54,0x07,0x9F);

        public static readonly Guid ICorDebugProcessEnum = new Guid(0xCC7BCB05,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugReferenceValue = new Guid(0xCC7BCAF9,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugRegisterSet = new Guid(0xCC7BCB0B,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugRegisterSet2 = new Guid(0x6DC7BA3F,0x89BA,0x4459,0x9E,0xC1,0x9D,0x60,0x93,0x7B,0x46,0x8D);

        public static readonly Guid ICorDebugRemote = new Guid(0xD5EBB8E2,0x7BBE,0x4C1D,0x98,0xA6,0xA3,0xC0,0x4C,0xBD,0xEF,0x64);

        public static readonly Guid ICorDebugRemoteTarget = new Guid(0xC3ED8383,0x5A49,0x4CF5,0xB4,0xB7,0x01,0x86,0x4D,0x9E,0x58,0x2D);

        public static readonly Guid ICorDebugRuntimeUnwindableFrame = new Guid(0x879CAC0A,0x4A53,0x4668,0xB8,0xE3,0xCB,0x84,0x73,0xCB,0x18,0x7F);

        public static readonly Guid ICorDebugStackWalk = new Guid(0xA0647DE9,0x55DE,0x4816,0x92,0x9C,0x38,0x52,0x71,0xC6,0x4C,0xF7);

        public static readonly Guid ICorDebugStaticFieldSymbol = new Guid(0xCBF9DA63,0xF68D,0x4BBB,0xA2,0x1C,0x15,0xA4,0x5E,0xAA,0xDF,0x5B);

        public static readonly Guid ICorDebugStepper = new Guid(0xCC7BCAEC,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugStepper2 = new Guid(0xC5B6E9C3,0xE7D1,0x4A8E,0x87,0x3B,0x7F,0x04,0x7F,0x07,0x06,0xF7);

        public static readonly Guid ICorDebugStepperEnum = new Guid(0xCC7BCB04,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugStringValue = new Guid(0xCC7BCAFD,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugSymbolProvider = new Guid(0x3948A999,0xFD8A,0x4C38,0xA7,0x08,0x8A,0x71,0xE9,0xB0,0x4D,0xBB);

        public static readonly Guid ICorDebugSymbolProvider2 = new Guid(0xF9801807,0x4764,0x4330,0x9E,0x67,0x4F,0x68,0x50,0x94,0x16,0x5E);

        public static readonly Guid ICorDebugThread = new Guid(0x938C6D66,0x7FB6,0x4F69,0xB3,0x89,0x42,0x5B,0x89,0x87,0x32,0x9B);

        public static readonly Guid ICorDebugThread2 = new Guid(0x2BD956D9,0x7B07,0x4BEF,0x8A,0x98,0x12,0xAA,0x86,0x24,0x17,0xC5);

        public static readonly Guid ICorDebugThread3 = new Guid(0xF8544EC3,0x5E4E,0x46C7,0x8D,0x3E,0xA5,0x2B,0x84,0x05,0xB1,0xF5);

        public static readonly Guid ICorDebugThread4 = new Guid(0x1A1F204B,0x1C66,0x4637,0x82,0x3F,0x3E,0xE6,0xC7,0x44,0xA6,0x9C);

        public static readonly Guid ICorDebugThreadEnum = new Guid(0xCC7BCB06,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugType = new Guid(0xD613F0BB,0xACE1,0x4C19,0xBD,0x72,0xE4,0xC0,0x8D,0x5D,0xA7,0xF5);

        public static readonly Guid ICorDebugType2 = new Guid(0xE6E91D79,0x693D,0x48BC,0xB4,0x17,0x82,0x84,0xB4,0xF1,0x0F,0xB5);

        public static readonly Guid ICorDebugTypeEnum = new Guid(0x10F27499,0x9DF2,0x43CE,0x83,0x33,0xA3,0x21,0xD7,0xC9,0x9C,0xB4);

        public static readonly Guid ICorDebugUnmanagedCallback = new Guid(0x5263E909,0x8CB5,0x11D3,0xBD,0x2F,0x00,0x00,0xF8,0x08,0x49,0xBD);

        public static readonly Guid ICorDebugValue = new Guid(0xCC7BCAF7,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugValue2 = new Guid(0x5E0B54E7,0xD88A,0x4626,0x94,0x20,0xA6,0x91,0xE0,0xA7,0x8B,0x49);

        public static readonly Guid ICorDebugValue3 = new Guid(0x565005FC,0x0F8A,0x4F3E,0x9E,0xDB,0x83,0x10,0x2B,0x15,0x65,0x95);

        public static readonly Guid ICorDebugValueBreakpoint = new Guid(0xCC7BCAEB,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugValueEnum = new Guid(0xCC7BCB0A,0x8A68,0x11D2,0x98,0x3C,0x00,0x00,0xF8,0x08,0x34,0x2D);

        public static readonly Guid ICorDebugVariableHome = new Guid(0x50847B8D,0xF43F,0x41B0,0x92,0x4C,0x63,0x83,0xA5,0xF2,0x27,0x8B);

        public static readonly Guid ICorDebugVariableHomeEnum = new Guid(0xE76B7A57,0x4F7A,0x4309,0x85,0xA7,0x5D,0x91,0x8C,0x3D,0xEA,0xF7);

        public static readonly Guid ICorDebugVariableSymbol = new Guid(0x707E8932,0x1163,0x48D9,0x8A,0x93,0xF5,0xB1,0xF4,0x80,0xFB,0xB7);

        public static readonly Guid ICorDebugVirtualUnwinder = new Guid(0xF69126B7,0xC787,0x4F6B,0xAE,0x96,0xA5,0x69,0x78,0x6F,0xC6,0x70);

        public static readonly Guid IUnknown = new Guid(0x00000000,0x0000,0x0000,0xC0,0x00,0x00,0x00,0x00,0x00,0x00,0x46);

        public static readonly Guid IMetadataImport = new Guid(0x7DAC8207,0xD3AE,0x4C75,0x9B,0x67,0x92,0x80,0x1A,0x49,0x7D,0x44);
    }
}
