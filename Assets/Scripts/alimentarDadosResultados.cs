using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class alimentarDadosResultados : MonoBehaviour {
	public Text mesReferencia, altitudeAtual, latitudeAtual, longitudeAtual;

	//Calculo da temperaturas média
	public Text temperaturaCalculada;
	//Calcula da temperatura máxima
	public Text temperaturaCalculadaMax;

	// Use this for initialization
	void Start () {
		SetarDados ();
	}

	public void SetarDados(){
		string armazenaMes = calcularTemperatura.Instance.mesAtual;//para coletar o mês atual em calcularTemperatura.cs
		mesReferencia.text = armazenaMes;//para setar o dado coletados

		/*Setar os valores de altitude, latitude e longitude*/
		altitudeAtual.text = calcularTemperatura.Instance.altitude.ToString();//conversão de float para string através do ToString().
		latitudeAtual.text = calcularTemperatura.Instance.latitude.ToString ();
		longitudeAtual.text = calcularTemperatura.Instance.longitude.ToString ();

		if (armazenaMes == "Janeiro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultJaneiro.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultJaneiroMax.ToString ();
		} else if (armazenaMes == "Fevereiro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultFevereiro.ToString();
		} else if (armazenaMes == "Março") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultMarco.ToString();
		} else if (armazenaMes == "Abril") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultAbril.ToString();
		} else if (armazenaMes == "Maio") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultMaio.ToString();
		} else if (armazenaMes == "Junho") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultJunho.ToString();
		} else if (armazenaMes == "Julho") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultJulho.ToString();
		} else if (armazenaMes == "Agosto") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultAgosto.ToString();
		} else if (armazenaMes == "Setembro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultSetembro.ToString();
		} else if (armazenaMes == "Outubro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultOutubro.ToString();
		} else if (armazenaMes == "Novembro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultNovembro.ToString();
		} else if (armazenaMes == "Dezembro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultDezembro.ToString();
		}
	}

}
