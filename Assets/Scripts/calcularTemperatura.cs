using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//para habilitar a opção de User Interface , exemplo: botões, input fields, entre outros. 

public class calcularTemperatura : MonoBehaviour {
	/*Lista contendo os meses*/
	List<string> listaMeses = new List<string> () {"", "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", 
		"Setembro", "Outubro", "Novembro", "Dezembro"};
	public string mesAtual;

	public Dropdown comboboxMes;//combobox contendo os meses de janeiro a dezembro 
	public InputField latitudeInformada, longitudeInformada, altitudeInformada;//para coletar as informações digitadas pelo usuário
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

	public void SelecionarMesAtual(int index){
		mesAtual = listaMeses [index];
	}

	//Função para armazenamento de dados dos betas do mês de janeiro.
	//Informações importantes: a função possui encapsulamento privado e não possui retorno
	public void ArmazenarDadosJaneiro(){		
		//Atribuindo os betas do mês correspondente
		valorBeta0 = 22.46191789f;
		valorBeta1 = -0.00562171f;
		valorBeta2 = 0.353965152f;
		valorBeta3 = -0.26789465f;
	}
}
