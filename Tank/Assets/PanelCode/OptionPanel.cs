using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class OptionPanel : PanelBase
{

    private Button startBtn;
    private Button closeBtn;
    private Dropdown dropdown1;
    private Dropdown dropdown2;
	private Dropdown dropdown3;

    #region 生命周期
    public override void Init(params object[] args)
    {
        base.Init(args);
        skinPath = "OptionPanel";
        layer = PanelLayer.Panel;
    }

    public override void OnShowing()
    {
        base.OnShowing();
        Transform skinTrans = skin.transform;
        //开始按钮
        startBtn = skinTrans.Find("StartBtn").GetComponent<Button>();
        startBtn.onClick.AddListener(OnStartClick);
        //关闭按钮
        closeBtn = skinTrans.Find("CloseBtn").GetComponent<Button>();
        closeBtn.onClick.AddListener(OnCloseClick);
        //数量下拉框
        dropdown1 = skinTrans.Find("Dropdown1").GetComponent<Dropdown>();
        dropdown2 = skinTrans.Find("Dropdown2").GetComponent<Dropdown>();
		dropdown3 = skinTrans.Find("Dropdown3").GetComponent<Dropdown>();
        List<Dropdown.OptionData> modeOptions = new List<Dropdown.OptionData>();
        foreach (string option in Constants.modeOptions)
        {
            modeOptions.Add(new Dropdown.OptionData(option));
        }
        dropdown3.options = modeOptions;

    }
    #endregion

    public void OnStartClick()
    {
        PanelMgr.instance.ClosePanel("TitlePanel");
        int n1 = dropdown1.value + 1;
        int n2 = dropdown2.value + 1;
        int mode = dropdown3.value;
        
        Battle.instance.StartTwoCampBattle(n1, n2, mode);
        Close();
    }

    public void OnCloseClick()
    {
        Close();
    }
}