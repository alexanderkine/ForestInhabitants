﻿using System.Collections.Generic;

namespace ForestInhabitants.ForestObjects
{
    public abstract class ForestObject
    {
        public Coordinates Place;
        public abstract bool CanMove { get; }

        protected ForestObject(Coordinates place)
        {
            Place = place;
        }

        protected ForestObject(params int[] coordinates)
        {
            Place = new Coordinates(coordinates[0],coordinates[1]);
        }
        protected ForestObject(){}

        public abstract bool CanEnter(ref Inhabitant inhabitant, ref List<List<ForestObject>> map, Coordinates place);

        public abstract ForestObject CoordinateObject(Coordinates coordinates);
    }
}
