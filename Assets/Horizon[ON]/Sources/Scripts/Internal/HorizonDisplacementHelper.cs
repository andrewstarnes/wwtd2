﻿using UnityEngine;
using System.Collections;

namespace Horizon {
	//[ExecuteInEditMode]
	public class HorizonDisplacementHelper {// : MonoBehaviour {
		static float texel_step=1.0f; // texel resolution (decrease to make it more precise) for searching world y bound
		static float bounds_percentage_offset=2.0f; // percentage y bound offset (default - 2% of maximum height displacement)

	//	public bool Make;
	//	void Update() {
	//		if (Make) {
	//			Make=false;
	//			HorizONGetMaxHeight.DisplaceMesh(gameObject);
	//			//HorizONGetMaxHeight.AdjustBounds(gameObject);
	//		}
	//	}

		private static Texture2D heightMap;
		private static Texture2D maskMap;
		private static float parallaxValue;
		private static Vector4 mapScaleOffset;
		private static Vector4 baseMapScaleOffset;
		private static Vector4 blendColorMap1ScaleOffset;
		private static Vector4 blendColorMap2ScaleOffset;
		private static Vector4 blendColorMap3ScaleOffset;
		private static bool _LAYERCOUNT_TWO;
		private static bool _LAYERCOUNT_THREE;
		private static bool _LAYERCOUNT_FOUR;
		private static float _LocalSpace;

		private static bool PER_VERTEX_FLAG;
		private static float VertexColorA;
		private static float _ReduceByVertexAlpha;
		private static float texCoordX;
		private static float texCoordY;
		private static float _ReduceByUVBorder;
		private static float _ReduceByUVBorderLength;

		public static void AdjustBounds(GameObject gameObject) {
			if (HorizonDisplacementHelper.GetProps(gameObject)) {
				Vector2 objCenterXZ;
				objCenterXZ.x=gameObject.transform.position.x;
				objCenterXZ.y=gameObject.transform.position.z;
				Bounds bounds=gameObject.GetComponent<Renderer>().bounds;
				Vector2 uvMin=HorizonDisplacementHelper.getUVs(objCenterXZ, new Vector2(bounds.min.x, bounds.min.z));
				Vector2 uvMax=HorizonDisplacementHelper.getUVs(objCenterXZ, new Vector2(bounds.max.x, bounds.max.z));
				float stepX=HorizonDisplacementHelper.texel_step/heightMap.width;
				float stepZ=HorizonDisplacementHelper.texel_step/heightMap.height;
				float maxY=0;
				Vector2 uv;
				HorizonDisplacementHelper.PER_VERTEX_FLAG=false; // sampling UV grid inside world xz bounds
				for(uv.x=uvMin.x; uv.x<=uvMax.x; uv.x+=stepX) {
					for(uv.y=uvMin.y; uv.y<=uvMax.y; uv.y+=stepZ) {
						float sampleY=HorizonDisplacementHelper.disp(uv);
						if (sampleY>maxY) {
							maxY=sampleY;
						}
					}
				}
				maxY+=(parallaxValue*0.01f) * HorizonDisplacementHelper.bounds_percentage_offset;
				gameObject.transform.localScale=new Vector3(gameObject.transform.localScale.x, maxY, gameObject.transform.localScale.z);
			}

		}

		public static void DisplaceMesh(GameObject gameObject) {
			if (HorizonDisplacementHelper.GetProps(gameObject)) {
				Vector2 objCenterXZ;
				objCenterXZ.x=gameObject.transform.position.x;
				objCenterXZ.y=gameObject.transform.position.z;
				Mesh mesh=gameObject.GetComponent<MeshFilter>().mesh;
				Vector3[] vertices=mesh.vertices;
				Vector2[] uvs=mesh.uv;
				Color[] colors=mesh.colors;
				HorizonDisplacementHelper.PER_VERTEX_FLAG=true; // sampling UV by vertex world xz position
				HorizonDisplacementHelper.texCoordX=0.5f;
				HorizonDisplacementHelper.texCoordY=0.5f;
				HorizonDisplacementHelper.VertexColorA=1;
				for(int i=0; i<vertices.Length; i++) {
					if (colors!=null && i<colors.Length) {
						HorizonDisplacementHelper.VertexColorA=colors[i].a;
					}
					if (uvs!=null && i<uvs.Length) {
						HorizonDisplacementHelper.texCoordX=uvs[i].x;
						HorizonDisplacementHelper.texCoordY=uvs[i].y;
					}
					Vector3 vertex=vertices[i];
					Vector3 wPos=gameObject.transform.TransformPoint(vertex);
					Vector2 worldPosXZ=new Vector2(wPos.x, wPos.z);
					Vector2 uv=HorizonDisplacementHelper.getUVs(objCenterXZ, worldPosXZ);
					wPos.y=HorizonDisplacementHelper.disp(uv);
					vertex=gameObject.transform.InverseTransformPoint(wPos);
					vertices[i]=vertex;
				}
				mesh.vertices=vertices;
			}
			
		}

		public static bool GetProps(GameObject gameObject) {
			if ( !(gameObject && gameObject.GetComponent<Renderer>() && gameObject.GetComponent<Renderer>().sharedMaterial && gameObject.GetComponent<MeshFilter>() && gameObject.GetComponent<MeshFilter>().sharedMesh) ) return false;

			Material mat=gameObject.GetComponent<Renderer>().sharedMaterial;
			if (mat==null) return false;

			HorizonDisplacementHelper.heightMap=null;
			HorizonDisplacementHelper.maskMap=null;
			HorizonDisplacementHelper.parallaxValue=0;
			HorizonDisplacementHelper.mapScaleOffset=Vector4.zero;
			HorizonDisplacementHelper.baseMapScaleOffset=Vector4.zero;
			HorizonDisplacementHelper.blendColorMap1ScaleOffset=Vector4.zero;
			HorizonDisplacementHelper.blendColorMap2ScaleOffset=Vector4.zero;
			HorizonDisplacementHelper.blendColorMap3ScaleOffset=Vector4.zero;
			if (mat.HasProperty("_ParallaxMap")) HorizonDisplacementHelper.heightMap=mat.GetTexture("_ParallaxMap") as Texture2D;
			if (mat.HasProperty("_Parallax")) HorizonDisplacementHelper.parallaxValue=mat.GetFloat("_Parallax");
			if (mat.HasProperty("_LocalSpace")) HorizonDisplacementHelper._LocalSpace=mat.GetFloat("_LocalSpace");
			if (mat.HasProperty("_MapScaleOffset")) HorizonDisplacementHelper.mapScaleOffset=mat.GetVector("_MapScaleOffset");
			if (mat.HasProperty("_BaseColormap")) HorizonDisplacementHelper.baseMapScaleOffset=new Vector4(mat.GetTextureScale("_BaseColormap").x, mat.GetTextureScale("_BaseColormap").y, mat.GetTextureOffset("_BaseColormap").x, mat.GetTextureOffset("_BaseColormap").y);
			if (mat.HasProperty("_BlendColorMap1")) HorizonDisplacementHelper.blendColorMap1ScaleOffset=new Vector4(mat.GetTextureScale("_BlendColorMap1").x, mat.GetTextureScale("_BlendColorMap1").y, mat.GetTextureOffset("_BlendColorMap1").x, mat.GetTextureOffset("_BlendColorMap1").y);
			if (mat.HasProperty("_BlendColormap2")) HorizonDisplacementHelper.blendColorMap2ScaleOffset=new Vector4(mat.GetTextureScale("_BlendColormap2").x, mat.GetTextureScale("_BlendColormap2").y, mat.GetTextureOffset("_BlendColormap2").x, mat.GetTextureOffset("_BlendColormap2").y);
			if (mat.HasProperty("_BlendColormap3")) HorizonDisplacementHelper.blendColorMap3ScaleOffset=new Vector4(mat.GetTextureScale("_BlendColormap3").x, mat.GetTextureScale("_BlendColormap3").y, mat.GetTextureOffset("_BlendColormap3").x, mat.GetTextureOffset("_BlendColormap3").y);
			//Debug.Log (HorizONGetMaxHeight.baseMapScaleOffset + " " + HorizONGetMaxHeight.blendColorMap1ScaleOffset + " " + HorizONGetMaxHeight.blendColorMap2ScaleOffset + " " + HorizONGetMaxHeight.blendColorMap3ScaleOffset);
			if (mat.HasProperty("_MaskRBlend1GBlend2BBlend3AWater")) HorizonDisplacementHelper.maskMap=mat.GetTexture("_MaskRBlend1GBlend2BBlend3AWater") as Texture2D;
			if (HorizonDisplacementHelper.heightMap != null && HorizonDisplacementHelper.maskMap != null && mat.HasProperty ("_Parallax") && mat.HasProperty ("_LayerCount")) {
				HorizonDisplacementHelper._LAYERCOUNT_TWO=Mathf.Abs(mat.GetFloat("_LayerCount")-1)<0.001;
				HorizonDisplacementHelper._LAYERCOUNT_THREE=Mathf.Abs(mat.GetFloat("_LayerCount")-2)<0.001;
				HorizonDisplacementHelper._LAYERCOUNT_FOUR=Mathf.Abs(mat.GetFloat("_LayerCount")-3)<0.001;
				HorizonDisplacementHelper._ReduceByVertexAlpha=mat.GetFloat("_ReduceByVertexAlpha");
				HorizonDisplacementHelper._ReduceByUVBorder=mat.GetFloat("_ReduceByUVBorder");
				HorizonDisplacementHelper._ReduceByUVBorderLength=mat.GetFloat("_ReduceByUVBorderLength");

				return true;
			}
			return false;
		}

		static Vector2 TRANSFORM_TEX(Vector2 uv_in, Vector4 scaleOffset) {
			Vector2 uv_out;
			uv_out.x = uv_in.x * scaleOffset.x + scaleOffset.z;
			uv_out.y = uv_in.y * scaleOffset.y + scaleOffset.w;
			return uv_out;
		}

		static float Displace(Vector2 uv) {
			Vector2 uvs;

			float texel_offX = 0.5f * (1.0f/HorizonDisplacementHelper.heightMap.width);
			float texel_offY = 0.5f * (1.0f/HorizonDisplacementHelper.heightMap.height);
			uvs = HorizonDisplacementHelper.TRANSFORM_TEX (uv, HorizonDisplacementHelper.blendColorMap1ScaleOffset);
			uvs.x -= texel_offX;
			uvs.y -= texel_offY;
			float dispVals_r=HorizonDisplacementHelper.heightMap.GetPixelBilinear(uvs.x, uvs.y).r;

			uvs = HorizonDisplacementHelper.TRANSFORM_TEX (uv, HorizonDisplacementHelper.blendColorMap2ScaleOffset);
			uvs.x -= texel_offX;
			uvs.y -= texel_offY;
			float dispVals_g = HorizonDisplacementHelper.heightMap.GetPixelBilinear (uvs.x, uvs.y).g;

			uvs = HorizonDisplacementHelper.TRANSFORM_TEX (uv, HorizonDisplacementHelper.blendColorMap3ScaleOffset);
			uvs.x -= texel_offX;
			uvs.y -= texel_offY;
			float dispVals_b = HorizonDisplacementHelper.heightMap.GetPixelBilinear (uvs.x, uvs.y).b;

			uvs = HorizonDisplacementHelper.TRANSFORM_TEX (uv, HorizonDisplacementHelper.baseMapScaleOffset);
			uvs.x -= texel_offX;
			uvs.y -= texel_offY;
			float dispVals_a = HorizonDisplacementHelper.heightMap.GetPixelBilinear (uvs.x, uvs.y).a;

			texel_offX = 0.5f * (1.0f/HorizonDisplacementHelper.maskMap.width);
			texel_offY = 0.5f * (1.0f/HorizonDisplacementHelper.maskMap.height);
			uv.x -= texel_offX;
			uv.y -= texel_offY;
			Color blendVal = HorizonDisplacementHelper.maskMap.GetPixelBilinear(uv.x, uv.y);

			float dispValue=dispVals_a;
			if (HorizonDisplacementHelper._LAYERCOUNT_TWO || HorizonDisplacementHelper._LAYERCOUNT_THREE || HorizonDisplacementHelper._LAYERCOUNT_FOUR) {
				dispValue=Mathf.Lerp(dispValue, dispVals_r, blendVal.r);
			}
			if (HorizonDisplacementHelper._LAYERCOUNT_THREE || HorizonDisplacementHelper._LAYERCOUNT_FOUR) {
				dispValue=Mathf.Lerp(dispValue, dispVals_g, blendVal.g);
			}
			if (HorizonDisplacementHelper._LAYERCOUNT_FOUR) {
				dispValue=Mathf.Lerp(dispValue, dispVals_b, blendVal.b);
			}
			return dispValue;
		}
		
		static float disp (Vector2 uv) {

			// extrusion height measured in world scale
			float yScale = 1;//_World2Object[1][1]*unity_Scale.w;
			
			float d = HorizonDisplacementHelper.Displace (uv) * HorizonDisplacementHelper.parallaxValue * yScale;
			if (HorizonDisplacementHelper.PER_VERTEX_FLAG) {
				// vertex color A reduction
				d*=Mathf.Lerp(1, HorizonDisplacementHelper.VertexColorA, HorizonDisplacementHelper._ReduceByVertexAlpha);
				//#ifdef USE_UVS_FOR_DISPLACEMENT_BLEND
				Vector2 UVreduction;
				UVreduction.x = Mathf.Abs((HorizonDisplacementHelper.texCoordX - 0.5f) * 2);
				UVreduction.y = Mathf.Abs((HorizonDisplacementHelper.texCoordY - 0.5f) * 2);
				float UVreductionFct = 1 - Mathf.Clamp01 ((Mathf.Max(UVreduction.x, UVreduction.y) - HorizonDisplacementHelper._ReduceByUVBorderLength) / (1 - HorizonDisplacementHelper._ReduceByUVBorderLength));
				d *= Mathf.Lerp (1, UVreductionFct, HorizonDisplacementHelper._ReduceByUVBorder);
			}
			return d;
		}

		private static Vector2 getUVs(Vector2 objCenterXZ, Vector2 worldPosXZ) {
			Vector2 uv;
			uv.x=(-HorizonDisplacementHelper._LocalSpace*objCenterXZ.x + worldPosXZ.x + HorizonDisplacementHelper.mapScaleOffset.z)/HorizonDisplacementHelper.mapScaleOffset.x;
			uv.y=(-HorizonDisplacementHelper._LocalSpace*objCenterXZ.y + worldPosXZ.y + HorizonDisplacementHelper.mapScaleOffset.w)/HorizonDisplacementHelper.mapScaleOffset.y;
			return uv;
		}

	}
}