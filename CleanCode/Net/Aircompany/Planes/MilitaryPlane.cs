﻿using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        public MilitaryType Type;

        public MilitaryPlane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity, MilitaryType type)
            : base(model, maxSpeed, maxFlightDistance, maxLoadCapacity)
        {
            Type = type;
        }

        public override bool Equals(object obj)
        {
            return obj is MilitaryPlane plane && base.Equals(obj) && Type == plane.Type;
        }

        public override int GetHashCode()
        {
            var hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            return hashCode;
        }

        public MilitaryType PlaneTypeIs() => Type;

        public override string ToString() => base.ToString().Replace("}", ", type=" + Type + '}');
    }
}
