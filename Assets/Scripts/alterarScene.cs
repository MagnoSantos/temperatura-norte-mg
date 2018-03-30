using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class alterarScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	//Função para alterar a cena a partir do clique do usuario
	public void AlterarScene(string nomeScene){
		SceneManager.LoadScene (nomeScene);
	}
}
