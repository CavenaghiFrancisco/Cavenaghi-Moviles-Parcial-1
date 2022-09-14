using UnityEngine;

public class ControlDireccion : MonoBehaviour 
{
	public enum TipoInput {AWSD, Arrows}
	public TipoInput InputAct = TipoInput.AWSD;

	[SerializeField] private Joystick j1;
	[SerializeField] private Joystick j2;

	float Giro = 0;
	
	public bool Habilitado = true;
	CarController carController;
		
	//---------------------------------------------------------//
	
	// Use this for initialization
	void Start () 
	{
		carController = GetComponent<CarController>();
	}
	
	// Update is called once per frame
	void Update () 
	{
#if !UNITY_ANDROID
		switch (InputAct)
		{
			case TipoInput.AWSD:
				if (Habilitado)
				{
					if (Input.GetKey(KeyCode.A))
					{
						Giro = -1;
					}
					else if (Input.GetKey(KeyCode.D))
					{
						Giro = 1;
					}
					else
					{
						Giro = 0;
					}
				}
				break;
			case TipoInput.Arrows:
				if (Habilitado)
				{
					if (Input.GetKey(KeyCode.LeftArrow))
					{
						Giro = -1;
					}
					else if (Input.GetKey(KeyCode.RightArrow))
					{
						Giro = 1;
					}
					else
					{
						Giro = 0;
					}
				}
				break;
		}
	#endif
	#if UNITY_ANDROID
		switch(InputAct)
		{
			case TipoInput.AWSD:
				if (j1.Horizontal > 0)
				{
					Giro = 1;
				}
				else if (j1.Horizontal < 0)
				{
					Giro = -1;
				}
				else
				{
					Giro = 0;
				}
				break;
			case TipoInput.Arrows:
				if (j2.Horizontal > 0)
				{
					Giro = 1;
				}
				else if (j2.Horizontal < 0)
				{
					Giro = -1;
				}
				else
				{
					Giro = 0;
				}
				break;
		}
	#endif


		Debug.Log(j1.Horizontal);

		carController.SetGiro(Giro);
	}

	public float GetGiro()
	{
		return Giro;
	}
	
}
