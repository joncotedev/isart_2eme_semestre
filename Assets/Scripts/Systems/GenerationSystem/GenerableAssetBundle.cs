using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GenerationSystem/GenerableAssetBundle")]
public class GenerableAssetBundle : ScriptableObject
{
    #region Variables

    [SerializeField]
    private List<GenerableAssetData> generableAssetList = new List<GenerableAssetData>();

    [System.Serializable]
    public class GenerableAssetData
    {
        [SerializeField]
        private GenerableAsset generableAsset;

        [SerializeField]
        private float weight;

        [SerializeField]
        private int count;
    }

    #endregion
}
