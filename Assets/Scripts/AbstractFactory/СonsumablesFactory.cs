using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.AbstractFactory
{
    public class СonsumablesFactory : AbstractFactoryItem
    {
        Transform pointSpawn;
        public СonsumablesFactory(Transform spawnpoint)
        {
            pointSpawn = spawnpoint;
        }
        public override GameObject CreateBarrel()
        {
            var _barrelprefab = Resources.Load<GameObject>("Bar") as GameObject;
            var _barrel = Instantiate(_barrelprefab, pointSpawn.position, Quaternion.identity);
            return _barrel;
        }

        public override GameObject CreateFirstAidKit()
        {
            var _AidKitprefab = Resources.Load<GameObject>("FirstAidKit") as GameObject;
            var _firstAidKit = Instantiate(_AidKitprefab, pointSpawn.position, Quaternion.identity);
            return _firstAidKit;
        }
        public override GameObject CreateAmmoBox()
        {
            var _ammoBoxprefab = Resources.Load<GameObject>("AmmoBox") as GameObject;
            var _AmmoBox = Instantiate(_ammoBoxprefab, pointSpawn.position, Quaternion.identity);
            return _AmmoBox;
        }
    }
}
