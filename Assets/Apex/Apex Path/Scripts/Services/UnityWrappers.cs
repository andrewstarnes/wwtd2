﻿

//------------------------------------------------------------------------------
// <auto-generated>
// These Unity wrappers are auto-generated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591
using System;
using UnityEngine;

namespace Apex.Services
{
    public interface IPhysics
    {
        UnityEngine.Vector3 gravity
        {
            get;
            set;
        }

        float bounceThreshold
        {
            get;
            set;
        }
        int solverIterationCount
        {
            get;
            set;
        }

	    bool CheckSphere(UnityEngine.Vector3 position, float radius, int layerMask);

	    bool CheckSphere(UnityEngine.Vector3 position, float radius);

	    bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layermask);

	    bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius);

	    void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2, bool ignore);

	    void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2);

	    void IgnoreLayerCollision(int layer1, int layer2, bool ignore);

	    void IgnoreLayerCollision(int layer1, int layer2);

	    bool GetIgnoreLayerCollision(int layer1, int layer2);

	    bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance);

	    bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);

	    bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask);

	    bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance);

	    bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo);

	    bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask);

	    bool Raycast(UnityEngine.Ray ray, float distance);

	    bool Raycast(UnityEngine.Ray ray);

	    bool Raycast(UnityEngine.Ray ray, float distance, int layerMask);

	    bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float distance);

	    bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo);

	    bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask);

	    UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float distance);

	    UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray);

	    UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float distance, int layerMask);

	    UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layermask);

	    UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance);

	    UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);

	    bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end);

	    bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int layerMask);

	    bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo);

	    bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo, int layerMask);

	    UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask);

	    UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius);

	    bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float distance);

	    bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction);

	    bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float distance, int layerMask);

	    bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance);

	    bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo);

	    bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask);

	    bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance);

	    bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo);

	    bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask);

	    bool SphereCast(UnityEngine.Ray ray, float radius, float distance);

	    bool SphereCast(UnityEngine.Ray ray, float radius);

	    bool SphereCast(UnityEngine.Ray ray, float radius, float distance, int layerMask);

	    bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float distance);

	    bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo);

	    bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask);

	    UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float distance, int layermask);

	    UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float distance);

	    UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction);

	    UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float distance);

	    UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction);

	    UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float distance, int layerMask);

	    UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float distance);

	    UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius);

	    UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float distance, int layerMask);

    }

    public sealed class PhysicsWrapper : IPhysics
    {
        public UnityEngine.Vector3 gravity
        {
            get { return Physics.gravity; }
            set { Physics.gravity = value; }
        }

        public float bounceThreshold
        {
            get { return Physics.bounceThreshold; }
            set { Physics.bounceThreshold = value; }
        }
        public int solverIterationCount
        {
            get { return Physics.solverIterationCount; }
            set { Physics.solverIterationCount = value; }
        }

	    public bool CheckSphere(UnityEngine.Vector3 position, float radius, int layerMask)
        {
            return Physics.CheckSphere(position, radius, layerMask);
        }

	    public bool CheckSphere(UnityEngine.Vector3 position, float radius)
        {
            return Physics.CheckSphere(position, radius);
        }

	    public bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius, int layermask)
        {
            return Physics.CheckCapsule(start, end, radius, layermask);
        }

	    public bool CheckCapsule(UnityEngine.Vector3 start, UnityEngine.Vector3 end, float radius)
        {
            return Physics.CheckCapsule(start, end, radius);
        }

	    public void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2, bool ignore)
        {
            Physics.IgnoreCollision(collider1, collider2, ignore);
        }

	    public void IgnoreCollision(UnityEngine.Collider collider1, UnityEngine.Collider collider2)
        {
            Physics.IgnoreCollision(collider1, collider2);
        }

	    public void IgnoreLayerCollision(int layer1, int layer2, bool ignore)
        {
            Physics.IgnoreLayerCollision(layer1, layer2, ignore);
        }

	    public void IgnoreLayerCollision(int layer1, int layer2)
        {
            Physics.IgnoreLayerCollision(layer1, layer2);
        }

	    public bool GetIgnoreLayerCollision(int layer1, int layer2)
        {
            return Physics.GetIgnoreLayerCollision(layer1, layer2);
        }

	    public bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance)
        {
            return Physics.Raycast(origin, direction, distance);
        }

	    public bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
        {
            return Physics.Raycast(origin, direction);
        }

	    public bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layerMask)
        {
            return Physics.Raycast(origin, direction, distance, layerMask);
        }

	    public bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance)
        {
            return Physics.Raycast(origin, direction, out hitInfo, distance);
        }

	    public bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
        {
            return Physics.Raycast(origin, direction, out hitInfo);
        }

	    public bool Raycast(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask)
        {
            return Physics.Raycast(origin, direction, out hitInfo, distance, layerMask);
        }

	    public bool Raycast(UnityEngine.Ray ray, float distance)
        {
            return Physics.Raycast(ray, distance);
        }

	    public bool Raycast(UnityEngine.Ray ray)
        {
            return Physics.Raycast(ray);
        }

	    public bool Raycast(UnityEngine.Ray ray, float distance, int layerMask)
        {
            return Physics.Raycast(ray, distance, layerMask);
        }

	    public bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float distance)
        {
            return Physics.Raycast(ray, out hitInfo, distance);
        }

	    public bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo)
        {
            return Physics.Raycast(ray, out hitInfo);
        }

	    public bool Raycast(UnityEngine.Ray ray, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask)
        {
            return Physics.Raycast(ray, out hitInfo, distance, layerMask);
        }

	    public UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float distance)
        {
            return Physics.RaycastAll(ray, distance);
        }

	    public UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray)
        {
            return Physics.RaycastAll(ray);
        }

	    public UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Ray ray, float distance, int layerMask)
        {
            return Physics.RaycastAll(ray, distance, layerMask);
        }

	    public UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance, int layermask)
        {
            return Physics.RaycastAll(origin, direction, distance, layermask);
        }

	    public UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction, float distance)
        {
            return Physics.RaycastAll(origin, direction, distance);
        }

	    public UnityEngine.RaycastHit[] RaycastAll(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)
        {
            return Physics.RaycastAll(origin, direction);
        }

	    public bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
        {
            return Physics.Linecast(start, end);
        }

	    public bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, int layerMask)
        {
            return Physics.Linecast(start, end, layerMask);
        }

	    public bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo)
        {
            return Physics.Linecast(start, end, out hitInfo);
        }

	    public bool Linecast(UnityEngine.Vector3 start, UnityEngine.Vector3 end, out UnityEngine.RaycastHit hitInfo, int layerMask)
        {
            return Physics.Linecast(start, end, out hitInfo, layerMask);
        }

	    public UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius, int layerMask)
        {
            return Physics.OverlapSphere(position, radius, layerMask);
        }

	    public UnityEngine.Collider[] OverlapSphere(UnityEngine.Vector3 position, float radius)
        {
            return Physics.OverlapSphere(position, radius);
        }

	    public bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float distance)
        {
            return Physics.CapsuleCast(point1, point2, radius, direction, distance);
        }

	    public bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction)
        {
            return Physics.CapsuleCast(point1, point2, radius, direction);
        }

	    public bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float distance, int layerMask)
        {
            return Physics.CapsuleCast(point1, point2, radius, direction, distance, layerMask);
        }

	    public bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance)
        {
            return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, distance);
        }

	    public bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
        {
            return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo);
        }

	    public bool CapsuleCast(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask)
        {
            return Physics.CapsuleCast(point1, point2, radius, direction, out hitInfo, distance, layerMask);
        }

	    public bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance)
        {
            return Physics.SphereCast(origin, radius, direction, out hitInfo, distance);
        }

	    public bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo)
        {
            return Physics.SphereCast(origin, radius, direction, out hitInfo);
        }

	    public bool SphereCast(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask)
        {
            return Physics.SphereCast(origin, radius, direction, out hitInfo, distance, layerMask);
        }

	    public bool SphereCast(UnityEngine.Ray ray, float radius, float distance)
        {
            return Physics.SphereCast(ray, radius, distance);
        }

	    public bool SphereCast(UnityEngine.Ray ray, float radius)
        {
            return Physics.SphereCast(ray, radius);
        }

	    public bool SphereCast(UnityEngine.Ray ray, float radius, float distance, int layerMask)
        {
            return Physics.SphereCast(ray, radius, distance, layerMask);
        }

	    public bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float distance)
        {
            return Physics.SphereCast(ray, radius, out hitInfo, distance);
        }

	    public bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo)
        {
            return Physics.SphereCast(ray, radius, out hitInfo);
        }

	    public bool SphereCast(UnityEngine.Ray ray, float radius, out UnityEngine.RaycastHit hitInfo, float distance, int layerMask)
        {
            return Physics.SphereCast(ray, radius, out hitInfo, distance, layerMask);
        }

	    public UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float distance, int layermask)
        {
            return Physics.CapsuleCastAll(point1, point2, radius, direction, distance, layermask);
        }

	    public UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction, float distance)
        {
            return Physics.CapsuleCastAll(point1, point2, radius, direction, distance);
        }

	    public UnityEngine.RaycastHit[] CapsuleCastAll(UnityEngine.Vector3 point1, UnityEngine.Vector3 point2, float radius, UnityEngine.Vector3 direction)
        {
            return Physics.CapsuleCastAll(point1, point2, radius, direction);
        }

	    public UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float distance)
        {
            return Physics.SphereCastAll(origin, radius, direction, distance);
        }

	    public UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction)
        {
            return Physics.SphereCastAll(origin, radius, direction);
        }

	    public UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Vector3 origin, float radius, UnityEngine.Vector3 direction, float distance, int layerMask)
        {
            return Physics.SphereCastAll(origin, radius, direction, distance, layerMask);
        }

	    public UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float distance)
        {
            return Physics.SphereCastAll(ray, radius, distance);
        }

	    public UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius)
        {
            return Physics.SphereCastAll(ray, radius);
        }

	    public UnityEngine.RaycastHit[] SphereCastAll(UnityEngine.Ray ray, float radius, float distance, int layerMask)
        {
            return Physics.SphereCastAll(ray, radius, distance, layerMask);
        }

    }
    public interface ILayerMask
    {
        int value
        {
            get;
            set;
        }
	    System.String LayerToName(int layer);

	    int NameToLayer(System.String layerName);

	    int GetMask(System.String[] layerNames);

    }

    public sealed class LayerMaskWrapper : ILayerMask
    {
        private LayerMask _actual;
        public int value
        {
            get { return _actual.value; }
            set { _actual.value = value; }
        }
	    public System.String LayerToName(int layer)
        {
            return LayerMask.LayerToName(layer);
        }

	    public int NameToLayer(System.String layerName)
        {
            return LayerMask.NameToLayer(layerName);
        }

	    public int GetMask(System.String[] layerNames)
        {
            return LayerMask.GetMask(layerNames);
        }

    }
    public interface ITime
    {
        float time
        {
            get;
        }
        float timeSinceLevelLoad
        {
            get;
        }
        float deltaTime
        {
            get;
        }
        float fixedTime
        {
            get;
        }
        float unscaledTime
        {
            get;
        }
        float unscaledDeltaTime
        {
            get;
        }
        float fixedDeltaTime
        {
            get;
            set;
        }
        float maximumDeltaTime
        {
            get;
            set;
        }
        float smoothDeltaTime
        {
            get;
        }
        float timeScale
        {
            get;
            set;
        }
        int frameCount
        {
            get;
        }
        int renderedFrameCount
        {
            get;
        }
        float realtimeSinceStartup
        {
            get;
        }
        int captureFramerate
        {
            get;
            set;
        }
    }

    public sealed class TimeWrapper : ITime
    {
        public float time
        {
            get { return Time.time; }
        }
        public float timeSinceLevelLoad
        {
            get { return Time.timeSinceLevelLoad; }
        }
        public float deltaTime
        {
            get { return Time.deltaTime; }
        }
        public float fixedTime
        {
            get { return Time.fixedTime; }
        }
        public float unscaledTime
        {
            get { return Time.unscaledTime; }
        }
        public float unscaledDeltaTime
        {
            get { return Time.unscaledDeltaTime; }
        }
        public float fixedDeltaTime
        {
            get { return Time.fixedDeltaTime; }
            set { Time.fixedDeltaTime = value; }
        }
        public float maximumDeltaTime
        {
            get { return Time.maximumDeltaTime; }
            set { Time.maximumDeltaTime = value; }
        }
        public float smoothDeltaTime
        {
            get { return Time.smoothDeltaTime; }
        }
        public float timeScale
        {
            get { return Time.timeScale; }
            set { Time.timeScale = value; }
        }
        public int frameCount
        {
            get { return Time.frameCount; }
        }
        public int renderedFrameCount
        {
            get { return Time.renderedFrameCount; }
        }
        public float realtimeSinceStartup
        {
            get { return Time.realtimeSinceStartup; }
        }
        public int captureFramerate
        {
            get { return Time.captureFramerate; }
            set { Time.captureFramerate = value; }
        }
    }
    public interface IDebug
    {
        bool developerConsoleVisible
        {
            get;
            set;
        }
        bool isDebugBuild
        {
            get;
        }
	    void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration, bool depthTest);

	    void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration);

	    void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color);

	    void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end);

	    void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, float duration);

	    void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color);

	    void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir);

	    void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, float duration, bool depthTest);

	    void Break();

	    void DebugBreak();

	    void Log(System.Object message);

	    void Log(System.Object message, UnityEngine.Object context);

	    void LogError(System.Object message);

	    void LogError(System.Object message, UnityEngine.Object context);

	    void ClearDeveloperConsole();

	    void LogException(System.Exception exception);

	    void LogException(System.Exception exception, UnityEngine.Object context);

	    void LogWarning(System.Object message);

	    void LogWarning(System.Object message, UnityEngine.Object context);

    }

    public sealed class DebugWrapper : IDebug
    {
        public bool developerConsoleVisible
        {
            get { return Debug.developerConsoleVisible; }
            set { Debug.developerConsoleVisible = value; }
        }
        public bool isDebugBuild
        {
            get { return Debug.isDebugBuild; }
        }
	    public void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration, bool depthTest)
        {
            Debug.DrawLine(start, end, color, duration, depthTest);
        }

	    public void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration)
        {
            Debug.DrawLine(start, end, color, duration);
        }

	    public void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color)
        {
            Debug.DrawLine(start, end, color);
        }

	    public void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
        {
            Debug.DrawLine(start, end);
        }

	    public void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, float duration)
        {
            Debug.DrawRay(start, dir, color, duration);
        }

	    public void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color)
        {
            Debug.DrawRay(start, dir, color);
        }

	    public void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir)
        {
            Debug.DrawRay(start, dir);
        }

	    public void DrawRay(UnityEngine.Vector3 start, UnityEngine.Vector3 dir, UnityEngine.Color color, float duration, bool depthTest)
        {
            Debug.DrawRay(start, dir, color, duration, depthTest);
        }

	    public void Break()
        {
            Debug.Break();
        }

	    public void DebugBreak()
        {
            Debug.DebugBreak();
        }

	    public void Log(System.Object message)
        {
            Debug.Log(message);
        }

	    public void Log(System.Object message, UnityEngine.Object context)
        {
            Debug.Log(message, context);
        }

	    public void LogError(System.Object message)
        {
            Debug.LogError(message);
        }

	    public void LogError(System.Object message, UnityEngine.Object context)
        {
            Debug.LogError(message, context);
        }

	    public void ClearDeveloperConsole()
        {
            Debug.ClearDeveloperConsole();
        }

	    public void LogException(System.Exception exception)
        {
            Debug.LogException(exception);
        }

	    public void LogException(System.Exception exception, UnityEngine.Object context)
        {
            Debug.LogException(exception, context);
        }

	    public void LogWarning(System.Object message)
        {
            Debug.LogWarning(message);
        }

	    public void LogWarning(System.Object message, UnityEngine.Object context)
        {
            Debug.LogWarning(message, context);
        }
    }
}