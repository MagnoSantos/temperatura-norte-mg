iusing System.Collections;
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

	//Para armazenar o beta0, beta1, beta2, beta3 específico de cada mês, temperatura média
	private float valorBeta0, valorBeta1, valorBeta2, valorBeta3;

	//Para armazenar o beta0, beta1, beta2, beta3 específico de cada mês, temperatura máxima
	private float valorBeta0Max, valorBeta1Max, valorBeta2Max, valorBeta3Max;

	//Para armazenar o beta0, beta1, beta2, beta3 específico de cada mês, temperatura mínima
	private float valorBeta0Min, valorBeta1Min, valorBeta2Min, valorBeta3Min, valorBeta4Min;

	//Resultados por mes de referência, temperatura média
	public float resultJaneiro, resultFevereiro, resultMarco, resultAbril, resultMaio, resultJunho, resultJulho, resultAgosto, 
	resultSetembro, resultOutubro, resultNovembro, resultDezembro;

	//Resultado por mês de refência, temperatura máxima
	public float resultJaneiroMax, resultFevereiroMax, resultMarcoMax, resultAbrilMax, resultMaioMax, resultJunhoMax, 
	resultJulhoMax, resultAgostoMax, resultSetembroMax, resultOutubroMax, resultNovembroMax, resultDezembroMax;

	//Resultado por mês de refência, temperatura mínima
	public float resultJaneiroMin, resultFevereiroMin, resultMarcoMin, resultAbrilMin, resultMaioMin, resultJunhoMin, 
	resultJulhoMin, resultAgostoMin, resultSetembroMin, resultOutubroMin, resultNovembroMin, resultDezembroMin;

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
			//Chamamento da função armazenar dados para puxar os dados dos betas correspondentes, temperatura mínima
			ArmazenarDadosJaneiro ();
			resultJaneiro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosJaneiroMax();
			resultJaneiroMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosJaneiroMin();
			resultJaneiroMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Fevereiro") {
			ArmazenarDadosFevereiro();
			resultFevereiro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosFevereiroMax();
			resultFevereiroMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosFevereiroMin();
			resultFevereiroMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Março") {
			ArmazenarDadosMarco();
			resultMarco = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosMarcoMax();
			resultMarcoMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosMarcoMin();
			resultMarcoMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Abril") {
			ArmazenarDadosAbril ();
			resultAbril = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosAbrilMax();
			resultAbrilMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosAbrilMin();
			resultAbrilMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Maio") {
			ArmazenarDadosMaio ();
			resultMaio = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosMaioMax();
			resultMaioMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosMaioMin();
			resultMaioMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Junho") {
			ArmazenarDadosJunho ();
			resultJunho = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosJunhoMax();
			resultJunhoMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosJunhoMin();
			resultJunhoMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Julho") {
			ArmazenarDadosJulho();
			resultJulho = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosJulhoMax();
			resultJulhoMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosJulhoMin();
			resultJulhoMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Agosto") {
			ArmazenarDadosAgosto ();
			resultJaneiro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosAgostoMax();
			resultAgostoMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosAgostoMin();
			resultAgostoMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Setembro") {
			ArmazenarDadosSetembro ();
			resultSetembro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosSetembroMax();
			resultSetembroMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosSetembroMin();
			resultSetembroMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Outubro") {
			ArmazenarDadosOutubro ();
			resultOutubro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosOutubroMax();
			resultOutubroMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosOutubroMin();
			resultOutubroMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Novembro") {
			ArmazenarDadosNovembro();
			resultNovembro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosNovembroMax();
			resultNovembroMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosNovembroMin();
			resultNovembroMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} else if (mesAtual == "Dezembro") {
			ArmazenarDadosDezembro ();
			resultNovembro = (valorBeta0 + (altitude * valorBeta1) + (latitude * valorBeta2) + (longitude * valorBeta3));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura máximo
			ArmazenarDadosDezembroMax();
			resultDezembroMax = (valorBeta0Max + (altitude * valorBeta1Max) + (latitude * valorBeta2Max) + (longitude * valorBeta3Max));

			//Chamamento da função armazenar dados max para puxar os dados dos betas de temperatura mínima
			ArmazenarDadosJaneiroMin();
			resultDezembroMin = (valorBeta0Min + (altitude * valorBeta1Min) + (latitude * valorBeta2Min) + (longitude * valorBeta3Min));

			SceneManager.LoadScene ("temperaturaResultados");
		} 
	}

	/*Funções para armazenamento de dados dos betas do mês de janeiro até dezembro*/
	/*Janeiro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosJaneiro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 24.4911451550632f;
		valorBeta1 = -0.005610300726464f;
		valorBeta2 = 0.2711196801556f;
		valorBeta3 = -0,188431608200246f;
	}

	/*Fevereiro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosFevereiro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 25.1282396706392f;
		valorBeta1 = -0.006049900961338f;
		valorBeta2 = 0.255992493646269f;
		valorBeta3 = -0.183138233239153f;
	}

	/*Marco*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosMarco(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 27.7837171004622f;
		valorBeta1 = -0.005785779112775f;
		valorBeta2 = 0.342527381075753f;
		valorBeta3 = -0.143342900383917f;
	}

	/*Abril*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosAbril(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 24.3513052185253f;
		valorBeta1 = -0.005587859848834f;
		valorBeta2 = 0.591725979261353f;
		valorBeta3 = -0.296835399949706f;
	}

	/*Maio*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosMaio(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 27.8532493865317f;
		valorBeta1 = -0.00496029346883f;
		valorBeta2 = 0.91808458560569f;
		valorBeta3 = -0.2908966550688f;
	}

	/*junho*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosJunho(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 25.1704918397638f;
		valorBeta1 = -0.004755349361377f;
		valorBeta2 = 0.96354533082198f;
		valorBeta3 = -0.336006015920775f;
	}

	/*Julho*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosJulho(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 20.835277832534f;
		valorBeta1 = -0.005191462884089f;
		valorBeta2 = 0.888089645699864f;
		valorBeta3 = -0.409510080727543f;
	}

	/*Agosto*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosAgosto(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 14.4715629804863f;
		valorBeta1 = -0.006124993261633f;
		valorBeta2 = 0.736162295422085f;
		valorBeta3 = -0.537532226197881f;
	}

	/*Setembro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosSetembro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 11.3711194319772f;
		valorBeta1 = -0.006789111785379f;
		valorBeta2 = 0.74971204354751f;
		valorBeta3 = -0.671575913292143f;
	}

	/*Outubro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosOutubro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 15.8569513982846f;
		valorBeta1 = -0.006969744772108f;
		valorBeta2 = 0.687210062033433f;
		valorBeta3 = -0.576763265338939f;
	}

	/*Novembro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosNovembro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 21.090552100174f;
		valorBeta1 = -0.005950311214409f;
		valorBeta2 = 0.504892568937374f;
		valorBeta3 = -0.354905843372933f;
	}

	/*Dezembro*/
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosDezembro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 25.0021589978483f;
		valorBeta1 = -0.005554583270082f;
		valorBeta2 = 0.328108435786612f;
		valorBeta3 = -0.19217200206138f;
	}

	/*------------------------------------------------------------------------------------------
	 * Temperatura máxima - Valor dos Betas
	 * ----------------------------------------------------------------------------------------- */

	/*Janeiro*/
	public void ArmazenarDadosJaneiroMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 33.1208115172211f;
		valorBeta1Max = -0.007362177914991f;
		valorBeta2Max = 0.175502386966031f;
		valorBeta3Max = -0.11856331570667f;
	}

	/*Fevereiro*/
	public void ArmazenarDadosFevereiroMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 36.1635327f;
		valorBeta1Max = -0.007972218f;
		valorBeta2Max = 0.132452022f;
		valorBeta3Max = -0.058564867f;
	}

	/*Marco*/
	public void ArmazenarDadosMarcoMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 36.29254477f;
		valorBeta1Max = -0.007613588f;
		valorBeta2Max = 0.275362568f;
		valorBeta3Max = -0.091305625f;
	}

	/*Abril*/
	public void ArmazenarDadosAbrilMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 27.37511952f;
		valorBeta1Max = -0.00765797f;
		valorBeta2Max = 0.529744842f;
		valorBeta3Max = -0.379436414f;
	}

	/*Maio*/
	public void ArmazenarDadosMaioMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 27.55116201f;
		valorBeta1Max = -0.007578018f;
		valorBeta2Max = 0.839542936f;
		valorBeta3Max = -0.462051703f;
	}

	/*junho*/
	public void ArmazenarDadosJunhoMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 20.46213529f;
		valorBeta1Max = -0.007619279f;
		valorBeta2Max = 0.801587272f;
		valorBeta3Max = -0.587179471f;
	}

	/*Julho*/
	public void ArmazenarDadosJulhoMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 16.10235611f;
		valorBeta1Max = -0.008087393f;
		valorBeta2Max = 0.776106144f;
		valorBeta3Max = -0.683170751f;
	}

	/*Agosto*/
	public void ArmazenarDadosAgostoMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 10.79772614f;
		valorBeta1Max = -0.008275093f;
		valorBeta2Max = 0.6559176f;
		valorBeta3Max = -0.791847332f;
	}

	/*Setembro*/
	public void ArmazenarDadosSetembroMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 12.03544878f;
		valorBeta1Max = -0.008100769f;
		valorBeta2Max = 0.776355396f;
		valorBeta3Max = -0.850740201f;
	}

	/*Outubro*/
	public void ArmazenarDadosOutubroMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 18.16477662f;
		valorBeta1Max = -0.008525045f;
		valorBeta2Max = 0.651003698f;
		valorBeta3Max = -0.685721781f;
	}

	/*Novembro*/
	public void ArmazenarDadosNovembroMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 24.03443889f;
		valorBeta1Max = -0.007411541f;
		valorBeta2Max = 0.478235121f;
		valorBeta3Max = -0.432425356f;
	}

	/*Dezembro*/
	public void ArmazenarDadosDezembroMax(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Max = 32.6563255f;
		valorBeta1Max = -0.00688869f;
		valorBeta2Max = 0.282249656f;
		valorBeta3Max = -0.149999022f;
	}

	/*------------------------------------------------------------------------------------------
	 * Temperatura mínima - Valor dos Betas
	 * ----------------------------------------------------------------------------------------- */

	/*Janeiro*/
	public void ArmazenarDadosJaneiroMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 19.9617432579737f;
		valorBeta1Min = -0.004171252159549f;
		valorBeta2Min = 0.334243580340433f;
		valorBeta3Min = -0.190873407284751f;
	}

	/*Fevereiro*/
	public void ArmazenarDadosFevereiroMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 20.6199686927442f;
		valorBeta1Min = -0.004173508926329f;
		valorBeta2Min = 0.4388755411734f;
		valorBeta3Min = -0.215926638384238f;
	}

	/*Marco*/
	public void ArmazenarDadosMarcoMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 23.5609040043777f;
		valorBeta1Min = -0.004171857079899f;
		valorBeta1Min = 0.458153753787953f;
		valorBeta3Min = -0.155783575778481f;
	}

	/*Abril*/
	public void ArmazenarDadosAbrilMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 24.4248896018465f;
		valorBeta1Min = -0.003849298431485f;
		valorBeta2Min = 0.659750523091796f;
		valorBeta3Min = -0.186267553030254f;
	}

	/*Maio*/
	public void ArmazenarDadosMaioMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 28.0191471988831f;
		valorBeta1Min = -0.002798371088785f;
		valorBeta1Min = 0.912741189815817f;
		valorBeta3Min = -0.133245695647267f;
	}

	/*junho*/
	public void ArmazenarDadosJunhoMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 29.2133948282952f;
		valorBeta1Min = -0.002070977698143f;
		valorBeta1Min = 0.99491381948262f;
		valorBeta3Min = -0.085982985136374f;
	}

	/*Julho*/
	public void ArmazenarDadosJulhoMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 27.5563964001505f;
		valorBeta1Min = -0.002125547099813f;
		valorBeta1Min = 0.970345400671575f;
		valorBeta3Min = -0.104439899472489f;
	}

	/*Agosto*/
	public void ArmazenarDadosAgostoMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 21.5035290605081f;
		valorBeta1Min = -0.003044536258635f;
		valorBeta1Min = 0.91816048052471f;
		valorBeta3Min = -0.253885357451786f;
	}

	/*Setembro*/
	public void ArmazenarDadosSetembroMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 15.0681089444019f;
		valorBeta1Min = -0.004814215866621f;
		valorBeta1Min = 0.737095730196585f;
		valorBeta3Min = -0.413738620891601f;
	}

	/*Outubro*/
	public void ArmazenarDadosOutubroMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 15.6193819323463f;
		valorBeta1Min = -0.005533102109703f;
		valorBeta1Min = 0.627605934090551f;
		valorBeta3Min = -0.411796458761225f;
	}

	/*Novembro*/
	public void ArmazenarDadosNovembroMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 21.1506653254822f;
		valorBeta1Min = -0.004849051948237f;;
		valorBeta1Min = 0.543745370701188f;
		valorBeta3Min = -0.251275159240125f;
	}

	/*Dezembro*/
	public void ArmazenarDadosDezembroMin(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0Min = 21.5359877837715f;
		valorBeta1Max = -0.004333280341804f;
		valorBeta1Min = 0.400617980200132f;
		valorBeta3Min = -0.183458972216966f;
	}
}
