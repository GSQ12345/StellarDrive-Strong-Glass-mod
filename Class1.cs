using MelonLoader;
using Planets.Terrain.Meshes;
using Planets.Terrain.Meshes.Colliders;
using Ships.Interface.Values;
using Ships.Parts.Common.Model;
using Ships.Physics.Collision;
using UnityEngine;

[assembly: MelonInfo(typeof(Unbreakable_Glass.Class1), "Strong Glass", "1.0.0", "GSQ123")]
[assembly: MelonGame(null, null)]

namespace Unbreakable_Glass
{
    public class Class1 : MelonMod
    {

        
        public override void OnInitializeMelon()
        {
            HullConstants.GlassHardness = 100f;
        }
    }
}