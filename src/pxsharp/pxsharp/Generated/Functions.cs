// File generated by ApiGen on 2013-12-17 15:11:31

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace PxSharp { 
    using PxU8 = System.Byte;
    using PxI8 = System.SByte;
    using PxU16 = System.UInt16;
    using PxI16 = System.Int16;
    using PxU32 = System.UInt32;
    using PxI32 = System.Int32;
    using PxU64 = System.UInt64;
    using PxI64 = System.Int64;
    using PxF32 = System.Single;
    using PxF64 = System.Double;
    using PxReal = System.Single;
    using PxExtended = System.Double;
    
    public static partial class Px {
        public static PxFoundation CreateFoundation (PxErrorCallback callback) { 
            return PInvoke.Px_CreateFoundation(callback);
        }
        public static PxFoundation GetFoundation () { 
            return PInvoke.Px_GetFoundation();
        }
        public static bool InitExtensions (PxPhysics physics) { 
            return PInvoke.Px_InitExtensions(physics);
        }
        public static void RegisterArticulations (PxPhysics physics) { 
            PInvoke.Px_RegisterArticulations(physics);
        }
        public static void RegisterCloth (PxPhysics physics) { 
            PInvoke.Px_RegisterCloth(physics);
        }
        public static void RegisterHeightFields (PxPhysics physics) { 
            PInvoke.Px_RegisterHeightFields(physics);
        }
        public static void RegisterParticles (PxPhysics physics) { 
            PInvoke.Px_RegisterParticles(physics);
        }
        public static void RegisterUnifiedHeightFields (PxPhysics physics) { 
            PInvoke.Px_RegisterUnifiedHeightFields(physics);
        }
        public static void CloseExtensions () { 
            PInvoke.Px_CloseExtensions();
        }
        public static IntPtr CreateCooking (PxFoundation foundation, PxCookingParams cookingParams) { 
            return PInvoke.Px_CreateCooking(foundation, cookingParams);
        }
        public static PxPhysics CreatePhysics (PxFoundation foundation, PxTolerancesScale ts) { 
            return PInvoke.Px_CreatePhysics(foundation, ts);
        }
        public static PxPhysics CreateBasePhysics (PxFoundation foundation, PxTolerancesScale ts) { 
            return PInvoke.Px_CreateBasePhysics(foundation, ts);
        }
        public static PxRigidStatic CreatePlane (PxPhysics physics, PxPlane plane, PxMaterial material) { 
            return PInvoke.Px_CreatePlane(physics, plane, material);
        }
        public static PxRigidDynamic CreateDynamic (PxPhysics physics, PxTransform transform, PxGeometry geometry, PxMaterial material, PxReal density, PxTransform offset) { 
            return PInvoke.Px_CreateDynamic(physics, transform, geometry, material, density, offset);
        }
        public static PxRigidDynamic CloneDynamic (PxPhysics physics, PxTransform transform, PxRigidDynamic dynamic) { 
            return PInvoke.Px_CloneDynamic(physics, transform, dynamic);
        }
        public static PxRigidStatic CreateStatic (PxPhysics physics, PxTransform transform, PxGeometry geometry, PxMaterial material, PxTransform offset) { 
            return PInvoke.Px_CreateStatic(physics, transform, geometry, material, offset);
        }
        public static PxRigidStatic CloneStatic (PxPhysics physics, PxTransform transform, PxRigidStatic dynamic) { 
            return PInvoke.Px_CloneStatic(physics, transform, dynamic);
        }
        public static PxFixedJoint FixedJointCreate (PxPhysics physics, PxRigidActor actor0, PxTransform localFrame0, PxRigidActor actor1, PxTransform localFrame1) { 
            return PInvoke.Px_FixedJointCreate(physics, actor0, localFrame0, actor1, localFrame1);
        }
        public static PxSphericalJoint SphericalJointCreate (PxPhysics physics, PxRigidActor actor0, PxTransform localFrame0, PxRigidActor actor1, PxTransform localFrame1) { 
            return PInvoke.Px_SphericalJointCreate(physics, actor0, localFrame0, actor1, localFrame1);
        }
        public static PxDistanceJoint DistanceJointCreate (PxPhysics physics, PxRigidActor actor0, PxTransform localFrame0, PxRigidActor actor1, PxTransform localFrame1) { 
            return PInvoke.Px_DistanceJointCreate(physics, actor0, localFrame0, actor1, localFrame1);
        }
        public static PxPrismaticJoint PrismaticJointCreate (PxPhysics physics, PxRigidActor actor0, PxTransform localFrame0, PxRigidActor actor1, PxTransform localFrame1) { 
            return PInvoke.Px_PrismaticJointCreate(physics, actor0, localFrame0, actor1, localFrame1);
        }
        public static PxRevoluteJoint RevoluteJointCreate (PxPhysics physics, PxRigidActor actor0, PxTransform localFrame0, PxRigidActor actor1, PxTransform localFrame1) { 
            return PInvoke.Px_RevoluteJointCreate(physics, actor0, localFrame0, actor1, localFrame1);
        }
        public static PxD6Joint D6JointCreate (PxPhysics physics, PxRigidActor actor0, PxTransform localFrame0, PxRigidActor actor1, PxTransform localFrame1) { 
            return PInvoke.Px_D6JointCreate(physics, actor0, localFrame0, actor1, localFrame1);
        }
        public static bool FilterObjectIsTrigger (PxFilterObjectAttributes attr) { 
            return PInvoke.Px_FilterObjectIsTrigger(attr);
        }
        public static bool FilterObjectIsKinematic (PxFilterObjectAttributes attr) { 
            return PInvoke.Px_FilterObjectIsKinematic(attr);
        }
        public static PxFilterObjectType GetFilterObjectType (PxFilterObjectAttributes attr) { 
            return PInvoke.Px_GetFilterObjectType(attr);
        }
        public static void GetFilterOps (ref PxFilterOp op0, ref PxFilterOp op1, ref PxFilterOp op2) { 
            PInvoke.Px_GetFilterOps(ref op0, ref op1, ref op2);
        }
        public static void SetFilterOps (PxFilterOp op0, PxFilterOp op1, PxFilterOp op2) { 
            PInvoke.Px_SetFilterOps(op0, op1, op2);
        }
        public static bool GetFilterBool () { 
            return PInvoke.Px_GetFilterBool();
        }
        public static void SetFilterBool (bool value) { 
            PInvoke.Px_SetFilterBool(value);
        }
        public static void GetFilterConstants (ref PxGroupsMask c0, ref PxGroupsMask c1) { 
            PInvoke.Px_GetFilterConstants(ref c0, ref c1);
        }
        public static void SetFilterConstants (PxGroupsMask c0, PxGroupsMask c1) { 
            PInvoke.Px_SetFilterConstants(c0, c1);
        }
        public static void SetGroup (PxRigidActor actor, PxU16 group) { 
            PInvoke.Px_SetGroup(actor, group);
        }
        public static PxU16 GetGroup (PxRigidActor actor) { 
            return PInvoke.Px_GetGroup(actor);
        }
        public static void SetGroupCollision (PxU16 group0, PxU16 group1, bool enable) { 
            PInvoke.Px_SetGroupCollision(group0, group1, enable);
        }
        public static bool GetGroupCollision (PxU16 group0, PxU16 group1) { 
            return PInvoke.Px_GetGroupCollision(group0, group1);
        }
        public static void SetGroupMask (PxRigidActor actor, PxGroupsMask mask) { 
            PInvoke.Px_SetGroupMask(actor, mask);
        }
        public static PxGroupsMask GetGroupMask (PxRigidActor actor) { 
            return PInvoke.Px_GetGroupMask(actor);
        }
        public static PxU32 GetValue (PxCookingValue value) { 
            return PInvoke.Px_GetValue(value);
        }
        public static PxU32 GetGaussMapVertexLimitForPlatform (PxPlatform platform) { 
            return PInvoke.Px_GetGaussMapVertexLimitForPlatform(platform);
        }
        public static IntPtr DefaultCpuDispatcherCreate (PxU32 numThreads) { 
            return PInvoke.Px_DefaultCpuDispatcherCreate(numThreads);
        }
        public static PxControllerManager CreateControllerManager (PxScene scene) { 
            return PInvoke.Px_CreateControllerManager(scene);
        }
        public static bool InitVehicleSDK (PxPhysics physics) { 
            return PInvoke.Px_InitVehicleSDK(physics);
        }
        public static void CloseVehicleSDK () { 
            PInvoke.Px_CloseVehicleSDK();
        }
        public static void VehicleSetBasisVectors (PxVec3 up, PxVec3 forward) { 
            PInvoke.Px_VehicleSetBasisVectors(up, forward);
        }
        public static void VehicleSetUpdateMode (PxVehicleUpdateMode mode) { 
            PInvoke.Px_VehicleSetUpdateMode(mode);
        }
    }
    public static partial class PxRigidbodyExt {
        public static void AddForceAtLocalPos (PxRigidBody rigidbody, PxVec3 force, PxVec3 pos, PxForceMode forceMode, bool wakeup) { 
            PInvoke.PxRigidbodyExt_AddForceAtLocalPos(rigidbody, force, pos, forceMode, wakeup);
        }
        public static void AddForceAtPos (PxRigidBody rigidbody, PxVec3 force, PxVec3 pos, PxForceMode forceMode, bool wakeup) { 
            PInvoke.PxRigidbodyExt_AddForceAtPos(rigidbody, force, pos, forceMode, wakeup);
        }
        public static void AddLocalForceAtLocalPos (PxRigidBody rigidbody, PxVec3 force, PxVec3 pos, PxForceMode forceMode, bool wakeup) { 
            PInvoke.PxRigidbodyExt_AddLocalForceAtLocalPos(rigidbody, force, pos, forceMode, wakeup);
        }
        public static void AddLocalForceAtPos (PxRigidBody rigidbody, PxVec3 force, PxVec3 pos, PxForceMode forceMode, bool wakeup) { 
            PInvoke.PxRigidbodyExt_AddLocalForceAtPos(rigidbody, force, pos, forceMode, wakeup);
        }
        public static void ComputeLinearAngularImpulse (PxRigidBody rigidbody, PxTransform globalPose, PxVec3 point, PxVec3 impulse, PxReal invMassScale, PxReal invInertiaScale, ref PxVec3 linearImpulse, ref PxVec3 angularImpulse) { 
            PInvoke.PxRigidbodyExt_ComputeLinearAngularImpulse(rigidbody, globalPose, point, impulse, invMassScale, invInertiaScale, ref linearImpulse, ref angularImpulse);
        }
        public static void ComputeVelocityDeltaFromImpulse (PxRigidBody rigidbody, PxTransform globalPose, PxVec3 point, PxVec3 impulse, PxReal invMassScale, PxReal invInertiaScale, ref PxVec3 deltaLinearVelocity, ref PxVec3 deltaAngularVelocity) { 
            PInvoke.PxRigidbodyExt_ComputeVelocityDeltaFromImpulse(rigidbody, globalPose, point, impulse, invMassScale, invInertiaScale, ref deltaLinearVelocity, ref deltaAngularVelocity);
        }
        public static PxVec3 GetVelocityAtPos (PxRigidBody rigidbody, PxVec3 pos) { 
            return PInvoke.PxRigidbodyExt_GetVelocityAtPos(rigidbody, pos);
        }
        public static PxVec3 GetVelocityAtOffset (PxRigidBody rigidbody, PxVec3 pos) { 
            return PInvoke.PxRigidbodyExt_GetVelocityAtOffset(rigidbody, pos);
        }
        public static PxVec3 GetLocalVelocityAtLocalPos (PxRigidBody rigidbody, PxVec3 pos) { 
            return PInvoke.PxRigidbodyExt_GetLocalVelocityAtLocalPos(rigidbody, pos);
        }
        public static bool SetMassAndUpdateInertia (PxRigidBody rigidbody, PxReal mass, PxVec3 massLocalPose) { 
            return PInvoke.PxRigidbodyExt_SetMassAndUpdateInertia(rigidbody, mass, massLocalPose);
        }
        public static bool UpdateMassAndInertia (PxRigidBody rigidbody, PxReal density, PxVec3 massLocalPose) { 
            return PInvoke.PxRigidbodyExt_UpdateMassAndInertia(rigidbody, density, massLocalPose);
        }
    }
    public static partial class Pxs {
        public static PxsScratchBlock AllocScratchBlock (PxU32 size) { 
            return PInvoke.Pxs_AllocScratchBlock(size);
        }
        public static void ReleaseScratchBlock (PxsScratchBlock block) { 
            PInvoke.Pxs_ReleaseScratchBlock(block);
        }
        public static PxU32 ExtractContacts (ref PxContactPair pair, PxsContactPairPointBuffer buffer) { 
            return PInvoke.Pxs_ExtractContacts(ref pair, buffer);
        }
    }
    public static partial class PxShapeExt {
        public static PxTransform GetGlobalPose (PxShape shape, PxRigidActor actor) { 
            return PInvoke.PxShapeExt_GetGlobalPose(shape, actor);
        }
        public static PxBounds3 GetWorldBounds (PxShape shape, PxRigidActor actor, float inflation) { 
            return PInvoke.PxShapeExt_GetWorldBounds(shape, actor, inflation);
        }
        public static bool Overlap (PxShape shape, PxRigidActor actor, PxGeometry otherGeometry, PxTransform otherGeometryPose) { 
            return PInvoke.PxShapeExt_Overlap(shape, actor, otherGeometry, otherGeometryPose);
        }
        public static bool Sweep (PxShape shape, PxRigidActor actor, PxVec3 unitDir, PxReal distance, PxGeometry otherGeometry, PxTransform otherGeometryPose, ref PxSweepHit hit, PxHitFlag hitFlags) { 
            return PInvoke.PxShapeExt_Sweep(shape, actor, unitDir, distance, otherGeometry, otherGeometryPose, ref hit, hitFlags);
        }
    }
    public static partial class PxVisualDebuggerExt {
        public static PxVisualDebuggerConnectionFlag GetAllConnectionFlags () { 
            return PInvoke.PxVisualDebuggerExt_GetAllConnectionFlags();
        }
        public static PxVisualDebuggerConnectionFlag GetDefaultConnectionFlags () { 
            return PInvoke.PxVisualDebuggerExt_GetDefaultConnectionFlags();
        }
        public static IntPtr CreateConnection0 (IntPtr manager, string hostIp, PxI32 port, PxU32 timeout, PxVisualDebuggerConnectionFlag flags) { 
            return PInvoke.PxVisualDebuggerExt_CreateConnection0(manager, hostIp, port, timeout, flags);
        }
        public static IntPtr CreateConnection1 (IntPtr manager, string filename, PxVisualDebuggerConnectionFlag flags) { 
            return PInvoke.PxVisualDebuggerExt_CreateConnection1(manager, filename, flags);
        }
    }
}
