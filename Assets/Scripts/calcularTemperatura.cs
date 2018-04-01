using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//para habilitar a opção de User Interface , exemplo: botões, input fields, entre outros. 
using UnityEngine.SceneManagement;//para alterar as cenas dentro das funções

public class calcularTemperatura : MonoBehaviour {
	/*Parar criar uma instância dessa classe em outras classes*/
	public static calcularTemperatura Instance;

	void Awake(){
		Instance = this;
	}

	/*Lista contendo os meses*/
	List<string> listaMeses = new List<string> () {"", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", 
		"Setembro", "Outubro", "Novembro", "Dezembro"};
	public string mesAtual;//para coletar o mês atual

	public Dropdown comboboxMes;//combobox contendo os meses de janeiro a dezembro 
	public InputField latitudeInformada, longitudeInformada, altitudeInformada;//para coletar as informações digitadas pelo usuário
	public float altitude, latitude, longitude;//para armazenar os dados informados
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
		/*Armazenar altitude, latitude e longitude digitada*/
		altitude = float.Parse(altitudeInformada.text);
		latitude = float.Parse(latitudeInformada.text); 
		longitude = float.Parse(longitudeInformada.text);

		if (mesAtual == "Janeiro") {
			//Chamamento da função armazenar dados para puxar os dados dos betas correspondentes
			ArmazenarDadosJaneiro ();
			resultJaneiro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Fevereiro") {
			ArmazenarDadosFevereiro();
			resultFevereiro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Março") {
			ArmazenarDadosMarco();
			resultMarco = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Abril") {
			ArmazenarDadosAbril ();
			resultAbril = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Maio") {
			ArmazenarDadosMaio ();
			resultMaio = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Junho") {
			ArmazenarDadosJunho ();
			resultJunho = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Julho") {
			ArmazenarDadosJulho();
			resultJulho = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Agosto") {
			ArmazenarDadosAgosto ();
			resultJaneiro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Setembro") {
			ArmazenarDadosSetembro ();
			resultSetembro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Outubro") {
			ArmazenarDadosOutubro ();
			resultOutubro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Novembro") {
			ArmazenarDadosNovembro();
			resultNovembro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Dezembro") {
			ArmazenarDadosDezembro ();
			resultNovembro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));
			SceneManager.LoadScene ("temperaturaResultados");
		} 
	}

	/*Funções para armazenamento de dados dos betas do mês de janeiro até dezembro*/

	/*Janeiro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosJaneiro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 22.46191789f;
		valorBeta1 = -0.00562171f;
		valorBeta2 = 0.353965152f;
		valorBeta3 = -0.26789465f;
	}

	/*Fevereiro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosFevereiro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 25.07632831f;
		valorBeta1 = -0.0060443f;
		valorBeta2 = 0.258814574f;
		valorBeta3 = -0.18529663f;
	}

	/*Marco*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosMarco(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 27.56645226f;
		valorBeta1 = -0.005750053f;
		valorBeta2 = 0.352410032f;
		valorBeta3 = -0.151371178f;
	}

	/*Abril*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosAbril(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 24.24019904f;
		valorBeta1 = -0.005571899f;
		valorBeta2 = 0.602462578f;
		valorBeta3 = -0.303233746f;
	}

	/*Maio*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosMaio(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 27.75671717f;
		valorBeta1 = -0.004946614f;
		valorBeta2 = 0.914390594f;
		valorBeta3 = -0.291344813f;
	}

	/*junho*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosJunho(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 25.148073f;
		valorBeta1 = -0.004748071f;
		valorBeta2 = 0.955234457f;
		valorBeta3 = -0.333046848f;
	}

	/*Julho*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosJulho(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 20.80173596f;
		valorBeta1 = -0.005209672f;
		valorBeta2 = 0.879422538f;
		valorBeta3 = -0.407199019f;
	}

	/*Agosto*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosAgosto(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 14.38906179f;
		valorBeta1 = -0.00608358f;
		valorBeta2 = 0.734081364f;
		valorBeta3 = -0.537748469f;
	}

	/*Setembro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosSetembro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 11.68365906f;
		valorBeta1 = -0.006794593f;
		valorBeta2 = 0.742665898f;
		valorBeta3 = -0.66198122f;
	}

	/*Outubro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosOutubro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 15.81996905f;
		valorBeta1 = -0.00696548f;
		valorBeta2 = 0.687634743f;
		valorBeta3 = -0.577690088f;
	}

	/*Novembro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosNovembro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 21.255375f;
		valorBeta1 = -0.005974951f;
		valorBeta2 = 0.509715874f;
		valorBeta3 = -0.353573454f;
	}

	/*Dezembro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosDezembro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 25.44085612f;
		valorBeta1 = -0.005509049f;
		valorBeta2 = 0.351973746f;
		valorBeta3 = -0.190853002f;
	}

}
