using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationSystem : MonoBehaviour
{
    #region Variable

    public static GenerationSystem Instance { get; private set; }

    #endregion

    #region Messages

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    #endregion

    #region Methods

    private List<GenerableAsset> Generate(GenerableAssetBundle data)
    {
        List<GenerableAsset> newData = new List<GenerableAsset>();

        return newData;
    }

    #endregion
}
