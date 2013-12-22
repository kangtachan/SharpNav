﻿#region License
/**
 * Copyright (c) 2013 Robert Rouhani <robert.rouhani@gmail.com> and other contributors (see CONTRIBUTORS file).
 * Licensed under the MIT License - https://raw.github.com/Robmaister/SharpNav/master/LICENSE
 */
#endregion

using System;
using System.Collections.Generic;
using SharpNav.Geometry;

#if MONOGAME || XNA
using Microsoft.Xna.Framework;
#elif OPENTK
using OpenTK;
#elif SHARPDX
using SharpDX;
#endif

namespace SharpNav
{
	///<summary>
	///Class variables will store NavMesh and NavMeshDetail data for pathfinding purposes
	/// </summary>
	public class NavMeshCreateParams
	{
		//NavMesh Attributes
		//Used to create base navigation graph
		public Vector3[] verts;
		public int vertCount;
		public NavMesh.Polygon[] polys;
		public int[] polyFlags; //user assigned
		public AreaFlags[] polyAreas;
		public int polyCount;
		public int numVertsPerPoly;

		//NavMeshDetail Attributes
		//Contains height detail
		public NavMeshDetail.MeshInfo[] detailMeshes;
		public Vector3[] detailVerts;
		public int detailVertsCount;
		public NavMeshDetail.TrisInfo[] detailTris;
		public int detailTriCount;

		//Off-Mesh Connection Attributes (OPTIONAL)
		public Vector3[] offMeshConVerts; //(endpoint A, endpoint B)
		public float[] offMeshConRadii;
		public int[] offMeshConFlags;
		public int[] offMeshConAreas;
		public int[] offMeshConDir; //0 = travel only in one direction, 1 = bidirectional
		public uint[] offMeshConUserID;
		public int offMeshConCount;

		//Tile Attributes
		public uint userId;
		public int tileX;
		public int tileY;
		public int tileLayer;
		public BBox3 bounds;

		//General Configuration Atttributes
		public float walkableHeight;
		public float walkableRadius;
		public float walkableClimb;
		public float cellSize;
		public float cellHeight;

		//Bounding volume tree
		public bool buildBvTree;
	}
}