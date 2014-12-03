using UnityEngine;
using System.Collections;
using VRWidgets;

public class ButtonDemoToggle : ButtonToggleBase 
{

  public ButtonDemoGraphics onGraphics;
  public ButtonDemoGraphics offGraphics;
  public ButtonDemoGraphics midGraphics;
  public ButtonDemoGraphics botGraphics;
  public GameObject Menu;
  public bool Visible;
  





   public void Show(bool status){
		Renderer[] renderers = Menu.GetComponentsInChildren<Renderer>();
		foreach (Renderer renderer in renderers)
		{
			renderer.enabled = status;
			Visible = status;
		}
	}


	void Start(){
		Show (false);

	}


	public override void ButtonTurnsOn()
  {
    TurnsOnGraphics();
	Show (true);
	
	}
	
	public override void ButtonTurnsOff()
  {
    TurnsOffGraphics();
	Show (false);

	
  }




  private void TurnsOnGraphics()
  {
    onGraphics.SetActive(true);
    offGraphics.SetActive(false);
    onGraphics.SetBloomGain(3.0f);
    midGraphics.SetBloomGain(10.0f);
    midGraphics.SetColor(new Color(0.0f, 0.05f, 0.05f, 1.0f));
    botGraphics.SetBloomGain(2.5f);
    botGraphics.SetColor(new Color(0.0f, 1.0f, 1.0f, 1.0f));
  }

  private void TurnsOffGraphics()
  {
    onGraphics.SetActive(false);
    offGraphics.SetActive(true);
    offGraphics.SetBloomGain(1.0f);
    midGraphics.SetBloomGain(1.0f);
    midGraphics.SetColor(new Color(0.0f, 0.05f, 0.05f, 0.25f));
    botGraphics.SetBloomGain(1.0f);
    botGraphics.SetColor(new Color(0.0f, 0.1f, 0.1f, 1.0f));
  }

  private void UpdateGraphics()
  {
    Vector3 position = GetPosition();
    onGraphics.transform.localPosition = position;
    offGraphics.transform.localPosition = position;
    Vector3 bot_position = position;
    bot_position.z = Mathf.Max(bot_position.z, onDistance);
    botGraphics.transform.localPosition = bot_position;
    Vector3 mid_position = position;
    mid_position.z = (position.z + bot_position.z) / 2.0f;
    midGraphics.transform.localPosition = mid_position;
  }

  public override void Awake()
  {
    base.Awake();
    TurnsOffGraphics();
  }

  public override void Update()
  {
    base.Update();
    UpdateGraphics();
  }
}
