using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Util : MonoBehaviour
{
    public static T Add<T>(GameObject go) where T : Component
    {
        if (go != null)
        {
            T[] components = go.GetComponents<T>();
            for (int i = 0; i < components.Length; i++)
            {
                if (components[i] != null)
                {
                    Destroy(components[i]);
                }
            }
            return go.AddComponent<T>();
        }

        return default(T);
    }

    public static T Add<T>(Transform go) where T : Component
    {
        return Add<T>(go.gameObject);
    }

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
        if (go != null)
        {
            Destroy(go);
        }
    }

    public static void SafeDestroy(Transform go)
    {
        if (go != null)
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

    //加载实例化封装
    public static GameObject LoadPrefab(string path)
    {
        return Resource.LoadPrefab(path);
    }

    public static string LoadText(string path)
    {
        return Util.LoadTextFile(path, ".txt");
    }

    public static string LoadXml(string path)
    {
        return Util.LoadTextFile(path, ".xml");
    }

    public static string LoadTextFile(string path, string text)
    {
        return Resource.LoadTextFile(path, text);
    }

    public static Texture2D LoadTexture(string path)
    {
        return Resource.LoadTexture(path);
    }

    public static Dictionary<string, string> TextDic = new Dictionary<string, string>();

    public static string GetTextFromConfig(string id)
    {
        try
        {
            return TextDic[id];
        }
        catch (Exception)
        {
            return id;
        }
    }


}












































































































