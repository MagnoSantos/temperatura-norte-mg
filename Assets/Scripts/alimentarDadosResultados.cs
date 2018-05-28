using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class alimentarDadosResultados : MonoBehaviour {
	public Text mesReferencia, altitudeAtual, latitudeAtual, longitudeAtual;

	//Calculo da temperaturas média
	public Text temperaturaCalculada;
	//Calculo da temperatura máxima
	public Text temperaturaCalculadaMax;
	//Calculo da temperatura minima
	public Text temperatucaCalculadaMin;

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
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultJaneiroMin.ToString ();
		} else if (armazenaMes == "Fevereiro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultFevereiro.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultFevereiroMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultFevereiroMin.ToString ();
		} else if (armazenaMes == "Março") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultMarco.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultMarcoMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultMarcoMin.ToString ();
		} else if (armazenaMes == "Abril") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultAbril.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultAbrilMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultAbrilMin.ToString ();
		} else if (armazenaMes == "Maio") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultMaio.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultMaioMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultMaioMin.ToString ();
		} else if (armazenaMes == "Junho") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultJunho.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultJunhoMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultJunhoMin.ToString ();
		} else if (armazenaMes == "Julho") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultJulho.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultJulhoMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultJulhoMin.ToString ();
		} else if (armazenaMes == "Agosto") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultAgosto.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultAgostoMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultAgostoMin.ToString ();
		} else if (armazenaMes == "Setembro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultSetembro.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultSetembroMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultSetembroMin.ToString ();
		} else if (armazenaMes == "Outubro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultOutubro.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultOutubroMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultOutubroMin.ToString ();
		} else if (armazenaMes == "Novembro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultNovembro.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultNovembroMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultNovembroMin.ToString ();
		} else if (armazenaMes == "Dezembro") {
			temperaturaCalculada.text = calcularTemperatura.Instance.resultDezembro.ToString();
			temperaturaCalculadaMax.text = calcularTemperatura.Instance.resultDezembroMax.ToString ();
			temperatucaCalculadaMin.text = calcularTemperatura.Instance.resultDezembroMin.ToString ();
		}
	}

}
