using UnityEngine;
using System.Collections;

public class Root : MonoBehaviour
{
    void Start()
    {
		if (Constants.isWin != -1) {
			PanelMgr.instance.OpenPanel<WinPanel> ("", Constants.isWin);
		} else {
			PanelMgr.instance.OpenPanel<TitlePanel> ("");
		}
    }
}