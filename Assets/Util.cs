using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class Util : MonoBehaviour
{
    public static Uri AppContentDataUri
    {
        get
        {
            string dataPath = Application.dataPath;
            if (Application.platform == RuntimePlatform.IPhonePlayer)
            {
                return new UriBuilder
                {
                    Scheme = "file",
                    Path = Path.Combine(dataPath, "Raw/")
                }.Uri;
            }

            if (Application.platform == RuntimePlatform.Android)
            {
                return new Uri("jar:file//" + dataPath + "!/assets/");
            }

            return new UriBuilder
            {
                Scheme = "file",
                Path = Path.Combine(dataPath, "StreaminAssets/")
            }.Uri;
        }
    }
	
    public static Uri AppPersistentDataUri
    {
        get
        {
            return new UriBuilder
            {
                Scheme = "file",
                Path = Application.persistentDataPath + "/"
            }.Uri;
        }
    }

    public static void SafeDestroy(GameObject go)
    {
        if (go!=null)
        {
            Destroy(go);
        }
    }

    public static void SafeDestroy(Transform go)
    {
        if (go!=null)
        {
            SafeDestroy(go.gameObject);
        }
    }

    public static void ClearMemory()
    {
        GC.Collect();
        // 清除未使用未加载的资源的内存占用
        Resources.UnloadUnusedAssets(); 
    }

}












































































































