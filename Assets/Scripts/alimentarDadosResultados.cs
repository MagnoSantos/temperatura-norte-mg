using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class alimentarDadosResultados : MonoBehaviour {
	public Text mesReferencia, altitudeAtual, latitudeAtual, longitudeAtual;

	/*Temperaturas*/
	public Text temperaturaCalculada;

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
		} else if (armazenaMes == "Fevereiro") {
			
		} else if (armazenaMes == "Março") {

		} else if (armazenaMes == "Abril") {

		} else if (armazenaMes == "Maio") {

		} else if (armazenaMes == "Junho") {

		} else if (armazenaMes == "Julho") {

		} else if (armazenaMes == "Agosto") {

		} else if (armazenaMes == "Setembro") {

		} else if (armazenaMes == "Outubro") {

		} else if (armazenaMes == "Novembro") {

		} else if (armazenaMes == "Dezembro") {

		}
	}

}
