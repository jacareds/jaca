using UnityEngine;
using UnityEngine.SceneManagement;
using ScorePublic;
using CameraShakePublic;

public class Menu : MonoBehaviour 
{

    // Use this for initialization

    private bool jogar;

	// Update is called once per frame
	void Update ()
	{
        if (jogar)
		{
            SceneManager.LoadScene("Cena1");
			//Score.CV = 0;	

			TetrisBlock.fallTime = 1;
		}
	}


    public void IniciarJogo(bool ativado)
	{
		jogar = ativado;
	}

	public void Reiniciar()
    {
		SceneManager.LoadScene("Cena1");
		Score.CV = 0;
		TetrisBlock.fallTime = 1;
	}

	public void Retornar()
	{
        SceneManager.LoadScene("menu");
		Score.CV = 0;
		TetrisBlock.fallTime = 1;
	}

	public void Sair()
	{
		Application.Quit();
	}

}
