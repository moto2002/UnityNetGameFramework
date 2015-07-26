using UnityEngine;
using System.Collections;

public class IO : MonoBehaviour {

    private static GameObject _manager;
    private static GameManager _gameManager;
    private static PanelManager _panelManager;
    private static DialogManager _dialogManager;
    private static MusicManager _musicManager;

    private static UIContainer _uiContainer;

    public static GameObject Manager
    {
        get
        {
            if (IO._manager==null)
            {
                IO._manager = GameObject.FindWithTag("GameManager");
            }

            return IO._manager;
        }
    }


    public static GameManager GameManager
    {
        get
        {
            if (IO._gameManager == null)
            {
                IO._gameManager = IO.Manager.GetComponent<GameManager>();
            }

            return IO._gameManager;
        }
    }

    public static PanelManager PanelManager
    {
        get
        {
            if (IO._panelManager==null)
            {
                IO._panelManager = IO.Manager.GetComponent<PanelManager>();
            }

            return IO._panelManager;
        }
    }

    public static DialogManager DialogManager
    {
        get
        {
            if (IO._dialogManager == null)
            {
                IO._dialogManager = IO.Manager.GetComponent<DialogManager>();
            }

            return IO.DialogManager;
        }
    }

    public static MusicManager MusicManager
    {
        get
        {
            if (IO._musicManager == null)
            {
                IO._musicManager = IO.Manager.GetComponent<MusicManager>();
            }

            return IO._musicManager;
        }
    }

    public static GameObject Gui
    {
        get
        {
            return GameObject.FindWithTag("GUI");
        }
    }

    public static UIContainer UIContainer
    {
        get
        {
            if (IO._uiContainer==null)
            {
                IO._uiContainer = IO.Gui.GetComponent<UIContainer>();
            }

            return IO._uiContainer;
        }
    }
}
