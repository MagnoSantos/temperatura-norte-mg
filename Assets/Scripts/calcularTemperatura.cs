using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//para habilitar a opção de User Interface , exemplo: botões, input fields, entre outros. 
using UnityEngine.SceneManagement;//para alterar as cenas dentro das funções

public class calcularTemperatura : MonoBehaviour {
	/*Lista contendo os meses*/
	List<string> listaMeses = new List<string> () {"", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", 
		"Setembro", "Outubro", "Novembro", "Dezembro"};
	public string mesAtual;//para coletar o mês atual

	public Dropdown comboboxMes;//combobox contendo os meses de janeiro a dezembro 
	public InputField latitudeInformada, longitudeInformada, altitudeInformada;//para coletar as informações digitadas pelo usuário
	float altitude, latitude, longitude;//para armazenar os dados informados
	private float valorBeta0, valorBeta1, valorBeta2, valorBeta3;//para armazenar o beta0, beta1, beta2, beta3 específico de cada mês

	/*Resultados por mes de referência*/
	public float resultJaneiro, resultFevereiro, resultMarco, resultAbril, resultMaio, resultJunho, resultJulho, resultAgosto, 
	resultSetembro, resultOutubro, resultNovembro, resultDezembro;

	/*'Nativo do ambiente de desenvolvimento': é acessada sempre que a classe se inicia.*/
	void Start () {
		//Chamamento da função PopularLista.
		PopularLista ();
	}

	//Função para popular a lista com os mêses de janeiro até dezembro.
	private void PopularLista(){		
		comboboxMes.AddOptions (listaMeses);//adicionar no combobox automaticamente
	}

	//Função para selecionar o mês atual, selecionado pelo usuário
	public void SelecionarMesAtual(int index){
		mesAtual = listaMeses [index];
	}

	//Função para gerar resultados com base na altitude, latitude e longitude, e armazenamento do resultado por mÊs em result
	public void GeraResultados(){
		altitude = float.Parse(altitudeInformada.text);
		latitude = float.Parse(latitudeInformada.text); 
		longitude = float.Parse(longitudeInformada.text);

		if (mesAtual == "Janeiro") {
			ArmazenarDadosJaneiro ();
			resultJaneiro = (valorBeta0 + valorBeta1 + valorBeta2 + valorBeta3);
			SceneManager.LoadScene ("temperaturaResultados");
		}
	}

	/*Funções para armazenamento de dados dos betas do mês de janeiro até dezembro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosJaneiro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 22.46191789f;
		valorBeta1 = -0.00562171f;
		valorBeta2 = 0.353965152f;
		valorBeta3 = -0.26789465f;
	}

}
