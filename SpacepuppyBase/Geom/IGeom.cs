﻿using UnityEngine;
using System.Collections.Generic;

namespace com.spacepuppy.Geom
{
    public interface IGeom
    {

        AxisInterval Project(Vector3 axis);
        Bounds GetBounds();
        Sphere GetBoundingSphere();

        bool Contains(Vector3 pos);
        bool Intersects(IGeom geom);
        bool Intersects(Bounds bounds);

    }

    public interface IPhysicsGeom : IGeom
    {

        bool TestOverlap(int layerMask);
        IEnumerable<Collider> Overlap(int layerMask);
        bool Cast(Vector3 direction, out RaycastHit hitinfo, float distance, int layerMask);
        IEnumerable<RaycastHit> CastAll(Vector3 direction, float distance, int layerMask);

    }

}
