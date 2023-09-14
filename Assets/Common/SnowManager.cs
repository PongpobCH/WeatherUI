using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowManager : MonoBehaviour
{
    public ParticleSystem snow;
    public ParticleSystemShapeType boxShape = ParticleSystemShapeType.Box;
    public Vector3 boxSize = new Vector3( 20f, 20f ,1f );
    public Vector3 boxSize2 = new Vector3(); 

    public Vector3 boxSize3 = new Vector3();
    public void LowerSnow()
    {
        snow = GetComponent<ParticleSystem>();
        
        var shape = snow.shape;
        shape.shapeType = boxShape; 
        shape.box = boxSize; 
    }

    public void NormalSnow()
    {
        snow = GetComponent<ParticleSystem>();
        
        var shape = snow.shape;
        shape.shapeType = boxShape; 
        shape.box = boxSize2;
    }
    public void HeavySnow()

    {
        snow = GetComponent<ParticleSystem>();
        
        var shape = snow.shape;
        shape.shapeType = boxShape; 
        shape.box = boxSize3;

    }


}
