using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //初始化管理器
        AddManagers();
        DontDestroyOnLoad(this.gameObject);
    }

    public void InitGui()
    {
        GameObject gameObject = IO.Gui;
        if (gameObject == null)
        {
            GameObject original = Util.LoadPrefab(Const.PanelPrefabDir + "MainUI.prefab");
            gameObject = Instantiate(original) as GameObject;
            gameObject.name = "MainUI";
        }

    }


    // Update is called once per frame
    void Update()
    {

    }

    private void AddManagers()
    {
        Util.Add<PanelManager>(this.gameObject);
        Util.Add<DialogManager>(this.gameObject);
        Util.Add<MusicManager>(this.gameObject);
    }
}
