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
		mesReferencia.text = armazenaMes;//para setar o dado coletado

		/*Armazenar altitude, latitude, longitude*/
		string armazenaAltitude = calcularTemperatura.Instance.altitude;
		string armazenaLatitude = calcularTemperatura.Instance.latitude;
		string armazenaLongitude = calcularTemperatura.Instance.longitude;

		/*Setar os dados armazenados*/
		altitudeAtual.text = armazenaAltitude;
		latitudeAtual.text = armazenaLatitude;
		longitudeAtual.text = armazenaLongitude;


		if (armazenaMes == "Janeiro") {
			float armazenaResultado = calcularTemperatura.Instance.resultJaneiro;
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
