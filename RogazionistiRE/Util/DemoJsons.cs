namespace RogazionistiRE.Util;

public class DemoJsons {
	public static string LOGIN_JSON = """
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.RANDOM_PARENT_TOKEN_1",
  "mastercom_token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.RANDOM_PARENT_TOKEN_2",
  "mastercom_id": "scuola-demo-01",
  "nome": "GIULIA",
  "cognome": "ROSSI",
  "id_utente": 900001,
  "studenti": [
    {
      "id": 676767,
      "id_scuola": "scuola-demo-01",
      "nome": "CARLETTUCCINO ROSSI",
      "foto": "https://example.com/foto/marco.jpg",
      "anno_corrente": "2025_2026",
      "anni": [
        {
          "id": "2024_2025",
          "classe": "1A",
          "indirizzo": "LICEO SCIENTIFICO",
          "descrizione": "2024/2025",
          "servizi": {
            "agenda": true,
            "assenze": true,
            "compiti": true,
            "voti": true,
            "pagelle": true
          }
        },
        {
          "id": "2025_2026",
          "classe": "2A",
          "indirizzo": "LICEO SCIENTIFICO",
          "descrizione": "2025/2026",
          "servizi": {
            "agenda": true,
            "assenze": true,
            "compiti": true,
            "voti": true,
            "pagelle": true
          }
        }
      ],
      "scuola": {
        "mastercom_id": "scuola-demo-01",
        "nome": "Liceo Scientifico Demo",
        "provincia": "MI",
        "comune": "MILANO",
        "tipo": "LICEO SCIENTIFICO"
      },
      "locale": "IT",
      "valuta": "EUR"
    }
  ],
  "language": "it",
  "url_scuola": "https://demo.registroelettronico.com"
}
""";
	#region CARLETTUCCINO ROSSI
	public static string CARLETTUCCINO_INFO_JSON = """
{
	"periodi_scolastici": [
		{
			"periodo": "trimestre",
			"numero": 1,
			"data_inizio": "2025-09-10T01:01:01",
			"data_fine": "2025-12-12T23:59:59"
		},
		{
			"periodo": "pentamestre",
			"numero": 2,
			"data_inizio": "2025-12-13T00:01:01",
			"data_fine": "2026-06-06T23:59:58"
		}
	],
	"periodo_corrente": {
		"periodo": "pentamestre",
		"numero": 2,
		"data_inizio": "2025-12-13T00:01:01",
		"data_fine": "2026-06-06T23:59:58"
	},
	"scuola": "SCUOLA NON SO",
	"voti_pesati": "NO",
	"media_voti": "SI",
	"servizi": {
		"agenda": true,
		"alternanza": false,
		"annotazioni": true,
		"argomenti": true,
		"assenze": true,
		"assenze_dad": false,
		"colloqui_individuali": true,
		"colloqui_generali": true,
		"compiti": true,
		"elenco_professori": true,
		"mense": false,
		"messaggi": false,
		"note": true,
		"presa_visione_note": false,
		"orario": true,
		"pagamenti": false,
		"pagelle": true,
		"storico": true,
		"voti": true,
		"presa_visione_voti": false,
		"elezioni": false,
		"documenti": true,
		"servizi_giornalieri": false,
		"materiale_didattico": false,
		"verifiche": false,
		"portale_iscrizioni": false,
		"competenze": false,
		"comunicazioni": true,
		"messaggi_inviati": false,
		"cambio_password": true,
		"recupero_password": false,
		"banner": false,
		"notizie": true,
		"videomeeting": true,
		"note_tutor": true,
		"colloqui": true
	},
	"richiesta_colloqui_individuali": false,
	"prenotazione_entrate_attiva": false,
	"prenotazione_uscite_attiva": false,
	"prenotazione_entrate_orario_limite": "0",
	"prenotazione_uscite_orario_limite": "0",
	"indirizzo": "MY INDIRIZZO BLAH BLAH"
}
""";

	public static string CARLETTUCCINO_SUBJECTS_JSON = """
[
	{
		"id": 1000071,
		"descrizione": "DISEGNO E STORIA DELL'ARTE",
		"nome_materia_sito": "DISEGNO E STORIA DELL'ARTE",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000154,
				"nome": "NONSOCOMECHIAMARLO",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000133,
		"descrizione": "EDUCAZIONE CIVICA",
		"nome_materia_sito": "ED. CIVICA",
		"ordinamento": 999,
		"professori": [
			{
				"id": 3000158,
				"nome": "NONSOCOMECHIAMARLO2",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			},
			{
				"id": 3000146,
				"nome": "",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000219,
				"nome": "LATINIENTS",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000150,
				"nome": "CAPO",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000152,
				"nome": "SCENZE PLOF",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000154,
				"nome": "NONSOCOMECHIAMARLO",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000220,
				"nome": "PROFEDELE",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000162,
				"nome": "RIUNIZIONE PROF",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000163,
				"nome": "PROF MATE",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000230,
				"nome": "INGLISH",
				"ordinamento": 0,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000152,
				"nome": "SCENZE PLOF",
				"ordinamento": 999,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			},
			{
				"id": 3000162,
				"nome": "RIUNIZIONE PROF",
				"ordinamento": 999,
				"titolo": "Docente tecnico/pratico",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000073,
		"descrizione": "FISICA",
		"nome_materia_sito": "FISICA",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000163,
				"nome": "PROF MATE",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000075,
		"descrizione": "INFORMATICA",
		"nome_materia_sito": "INFORMATICA",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000162,
				"nome": "RIUNIZIONE PROF",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			},
			{
				"id": 3000162,
				"nome": "RIUNIZIONE PROF",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000076,
		"descrizione": "INGLESE",
		"nome_materia_sito": "INGLESE",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000230,
				"nome": "INGLISH",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000078,
		"descrizione": "ITALIANO",
		"nome_materia_sito": "ITALIANO",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000219,
				"nome": "LATINIENTS",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000081,
		"descrizione": "MATEMATICA",
		"nome_materia_sito": "MATEMATICA",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000163,
				"nome": "PROF MATE",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000084,
		"descrizione": "RELIGIONE",
		"nome_materia_sito": "RELIGIONE",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000146,
				"nome": "SIGNOR MESSI",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000086,
		"descrizione": "SCIENZE",
		"nome_materia_sito": "SCIENZE",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000152,
				"nome": "SCENZE PLOF",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			},
			{
				"id": 3000152,
				"nome": "SCENZE PLOF",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000088,
		"descrizione": "SCIENZE MOTORIE E SPORTIVE",
		"nome_materia_sito": "SCIENZE MOTORIE E SPORTIVE",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000158,
				"nome": "NONSOCOMECHIAMARLO2",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000090,
		"descrizione": "SPAGNOLO",
		"nome_materia_sito": "SPAGNOLO",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000220,
				"nome": "PROFEDELE",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	},
	{
		"id": 1000094,
		"descrizione": "STORIA E GEOGRAFIA",
		"nome_materia_sito": "STORIA E GEOGRAFIA",
		"ordinamento": 0,
		"professori": [
			{
				"id": 3000150,
				"nome": "CAPO",
				"ordinamento": 0,
				"titolo": "Docente",
				"visualizza_colloqui": true
			}
		]
	}
]
""";
    public static string CARLETTUCCINO_GRADES_JSON = """
[
	{
		"id_voto": 1222555,
		"id_materia": 1000071,
		"data": "2025-11-19T12:00:00+01:00",
		"simbolo": "7.5",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "DISEGNO E STORIA DELL'ARTE",
		"sottotitolo": "Scritto",
		"dettaglio": "Esercizio \"canone egizio\"",
		"voto_numerico": 7.5,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1222555/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1222486,
		"id_materia": 1000086,
		"data": "2025-11-19T12:00:00+01:00",
		"simbolo": "5",
		"colore_simbolo": "#FF0000",
		"novita": false,
		"titolo": "SCIENZE",
		"sottotitolo": "Pratico",
		"dettaglio": "Relazione molto superficiale, priva di misure e riferimenti per validare i risultati. Chi vuole può ripetere la relazione mercoledì prossimo e la valutazione verrà sostituita.",
		"voto_numerico": 5.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1222486/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1222423,
		"id_materia": 1000073,
		"data": "2025-11-18T12:00:00+01:00",
		"simbolo": "10",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "FISICA",
		"sottotitolo": "Scritto",
		"dettaglio": "Verifica sugli errori di misura e le cifre significative",
		"voto_numerico": 10.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1222423/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1221912,
		"id_materia": 1000088,
		"data": "2025-11-13T12:00:00+01:00",
		"simbolo": "6.5",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "SCIENZE MOTORIE E SPORTIVE",
		"sottotitolo": "Pratico",
		"dettaglio": "Circuito su elementi della pallavolo.",
		"voto_numerico": 6.5,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1221912/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1221760,
		"id_materia": 1000086,
		"data": "2025-11-12T12:00:00+01:00",
		"simbolo": "8",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "SCIENZE",
		"sottotitolo": "Pratico",
		"dettaglio": "",
		"voto_numerico": 8.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1221760/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1221286,
		"id_materia": 1000073,
		"data": "2025-11-07T12:00:00+01:00",
		"simbolo": "8",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "FISICA",
		"sottotitolo": "Orale",
		"dettaglio": "Interrogazione fisica",
		"voto_numerico": 8.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1221286/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1221473,
		"id_materia": 1000094,
		"data": "2025-11-06T12:00:00+01:00",
		"simbolo": "8-",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "STORIA E GEOGRAFIA",
		"sottotitolo": "Orale",
		"dettaglio": "",
		"voto_numerico": 7.75,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1221473/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220988,
		"id_materia": 1000086,
		"data": "2025-11-03T12:00:00+01:00",
		"simbolo": "8",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "SCIENZE",
		"sottotitolo": "Orale",
		"dettaglio": "",
		"voto_numerico": 8.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220988/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220562,
		"id_materia": 1000090,
		"data": "2025-10-30T12:00:00+01:00",
		"simbolo": "9",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "SPAGNOLO",
		"sottotitolo": "Orale",
		"dettaglio": "Interrogazione España",
		"voto_numerico": 9.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220562/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220465,
		"id_materia": 1000086,
		"data": "2025-10-29T12:00:00+01:00",
		"simbolo": "7.5",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "SCIENZE",
		"sottotitolo": "Pratico",
		"dettaglio": "",
		"voto_numerico": 7.5,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220465/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220382,
		"id_materia": 1000133,
		"data": "2025-10-28T12:00:00+01:00",
		"simbolo": "9",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "EDUCAZIONE CIVICA",
		"sottotitolo": "Orale",
		"dettaglio": "Corso del 8 e 28 ottobre: ed. Digitale e utilizzo di excel per fini statistici",
		"voto_numerico": 9.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220382/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220370,
		"id_materia": 1000081,
		"data": "2025-10-28T12:00:00+01:00",
		"simbolo": "10",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "MATEMATICA",
		"sottotitolo": "Orale",
		"dettaglio": "Verifica matematica: esercizi di teoria",
		"voto_numerico": 10.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220370/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220358,
		"id_materia": 1000081,
		"data": "2025-10-28T12:00:00+01:00",
		"simbolo": "10",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "MATEMATICA",
		"sottotitolo": "Scritto",
		"dettaglio": "Verifica matematica calcolo letterale: espressioni",
		"voto_numerico": 10.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220358/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220589,
		"id_materia": 1000084,
		"data": "2025-10-27T12:00:00+01:00",
		"simbolo": "DISC",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "RELIGIONE",
		"sottotitolo": "Orale",
		"dettaglio": "",
		"voto_numerico": 7.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220589/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1221001,
		"id_materia": 1000078,
		"data": "2025-10-24T12:00:00+02:00",
		"simbolo": "7.5",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "ITALIANO",
		"sottotitolo": "Scritto",
		"dettaglio": "Tema",
		"voto_numerico": 7.5,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1221001/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1219953,
		"id_materia": 1000086,
		"data": "2025-10-22T12:00:00+02:00",
		"simbolo": "7",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "SCIENZE",
		"sottotitolo": "Pratico",
		"dettaglio": "Voto esperienza",
		"voto_numerico": 7.0,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1219953/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220055,
		"id_materia": 1000133,
		"data": "2025-10-21T12:00:00+02:00",
		"simbolo": "7.5",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "EDUCAZIONE CIVICA",
		"sottotitolo": "Orale",
		"dettaglio": "",
		"voto_numerico": 7.5,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220055/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1220178,
		"id_materia": 1000090,
		"data": "2025-10-16T12:00:00+02:00",
		"simbolo": "9+",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "SPAGNOLO",
		"sottotitolo": "Scritto",
		"dettaglio": "Verifica ud 0-1",
		"voto_numerico": 9.25,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1220178/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	},
	{
		"id_voto": 1219665,
		"id_materia": 1000078,
		"data": "2025-10-16T12:00:00+02:00",
		"simbolo": "7.5",
		"colore_simbolo": "#22BB00",
		"novita": false,
		"titolo": "ITALIANO",
		"sottotitolo": "Orale",
		"dettaglio": "",
		"voto_numerico": 7.5,
		"struttura_competenza": null,
		"note_competenza": null,
		"descrizione_peso": null,
		"valore_peso": null,
		"voto_pesato": false,
		"dimensioni": [],
		"descrizione_competenza": null,
		"data_presa_visione": 0,
		"data_presa_visione_tradotta": "",
		"url_contenuto": "link123/1219665/",
		"presa_visione": false,
		"is_voto": false,
		"is_competenza": false
	}
]
""";
    public static string CARLETTUCCINO_HOMEWORK_JSON = """
[
	{
		"id_materia": 1000094,
		"data": "2025-11-19T12:45:01+01:00",
		"titolo": "Studiare pp. 165-171.",
		"sottotitolo": "STORIA E GEOGRAFIA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Studiare pp. 165-171."
	},
	{
		"id_materia": 1000071,
		"data": "2025-11-19T11:50:01+01:00",
		"titolo": "Consegnare elaborato sul canone egizio come da indicazioni fornite dal docente.",
		"sottotitolo": "DISEGNO E STORIA DELL&#039;ARTE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Consegnare elaborato sul canone egizio come da indicazioni fornite dal docente."
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-19T10:55:01+01:00",
		"titolo": "gramm: studiare da pag. 285 a 293 e fare es pag. 288,289,290",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "gramm: studiare da pag. 285 a 293 e fare es pag. 288,289,290"
	},
	{
		"id_materia": 1000086,
		"data": "2025-11-19T09:45:01+01:00",
		"titolo": "Presentare alla classe il lavoro sulla sezione aurea, preparare una relazione e una presentazione.",
		"sottotitolo": "SCIENZE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Presentare alla classe il lavoro sulla sezione aurea, preparare una relazione e una presentazione."
	},
	{
		"id_materia": 1000076,
		"data": "2025-11-18T08:50:01+01:00",
		"titolo": "grammar p 99 n 2, 5 6",
		"sottotitolo": "INGLESE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "grammar p 99 n 2, 5 6"
	},
	{
		"id_materia": 1000086,
		"data": "2025-11-17T12:45:01+01:00",
		"titolo": "Studiare fino a pag. 41. Ricopiare lo schema sulle leggi di Keplero (fronte), sistema solare (retro). Possibili interrogazioni.",
		"sottotitolo": "SCIENZE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Studiare fino a pag. 41. Ricopiare lo schema sulle leggi di Keplero (fronte), sistema solare (retro). Possibili interrogazioni."
	},
	{
		"id_materia": 1000094,
		"data": "2025-11-17T08:50:01+01:00",
		"titolo": "Riportare sul quaderno la cartina di p. 160 (con nomi e colori); rispondere sul quaderno alle domande di p. 161 nn. 1-2-3. Rispondere alle domande del brano di Tirteo (QR- code p. 161 in alto a sinistra).",
		"sottotitolo": "STORIA E GEOGRAFIA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Riportare sul quaderno la cartina di p. 160 (con nomi e colori); rispondere sul quaderno alle domande di p. 161 nn. 1-2-3. Rispondere alle domande del brano di Tirteo (QR- code p. 161 in alto a sinistra)."
	},
	{
		"id_materia": 1000090,
		"data": "2025-11-14T11:50:01+01:00",
		"titolo": "Studiare pag 33 e 35, es 7,8 pg 33, pag 35 n 13, pag 264 n 32",
		"sottotitolo": "SPAGNOLO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Studiare pag 33 e 35, es 7,8 pg 33, pag 35 n 13, pag 264 n 32"
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-14T09:45:01+01:00",
		"titolo": "portare anche libro di Baricco per lettura in classe",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "portare anche libro di Baricco per lettura in classe"
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-14T08:50:01+01:00",
		"titolo": "epica: finire leggere capitolo Tersite ( ultime due pagine) e fare es 17 pag. 184",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "epica: finire leggere capitolo Tersite ( ultime due pagine) e fare es 17 pag. 184"
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-13T12:45:01+01:00",
		"titolo": "studiare NARRATIVA da PAG 196 A 205 E APPUNTI",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "studiare NARRATIVA da PAG 196 A 205 E APPUNTI"
	},
	{
		"id_materia": 1000081,
		"data": "2025-11-13T11:50:01+01:00",
		"titolo": "MATEMATICA : STUDIARE e SCHEMATIZZARE da pag. 426 a pag. 430 + pag. 187",
		"sottotitolo": "MATEMATICA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "MATEMATICA : STUDIARE e SCHEMATIZZARE da pag. 426 a pag. 430 + pag. 187"
	},
	{
		"id_materia": 1000094,
		"data": "2025-11-13T08:50:01+01:00",
		"titolo": "Studiare pp. 158-163.",
		"sottotitolo": "STORIA E GEOGRAFIA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Studiare pp. 158-163."
	},
	{
		"id_materia": 1000090,
		"data": "2025-11-13T07:55:01+01:00",
		"titolo": "Pag 274 e 275 n 5, 7, 8",
		"sottotitolo": "SPAGNOLO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Pag 274 e 275 n 5, 7, 8"
	},
	{
		"id_materia": 1000071,
		"data": "2025-11-12T11:50:01+01:00",
		"titolo": "Rivedere gli appunti del 10.11.25 e studiare da p.28 a p.35 compresa. Sono previste interrogazioni.",
		"sottotitolo": "DISEGNO E STORIA DELL&#039;ARTE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Rivedere gli appunti del 10.11.25 e studiare da p.28 a p.35 compresa. Sono previste interrogazioni."
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-12T10:55:01+01:00",
		"titolo": "italiano grammatica: studiare forme verbali ( vedi materiale classroom) e fare es pag 163,164,165",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "italiano grammatica: studiare forme verbali ( vedi materiale classroom) e fare es pag 163,164,165"
	},
	{
		"id_materia": 1000073,
		"data": "2025-11-12T08:50:01+01:00",
		"titolo": "fare scheda esercizi inviata via WhatsApp",
		"sottotitolo": "FISICA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "fare scheda esercizi inviata via WhatsApp"
	},
	{
		"id_materia": 1000076,
		"data": "2025-11-12T07:55:01+01:00",
		"titolo": "Portare grammar: ripassare 56, fare trad pag 57 , 59 n 26 28 .",
		"sottotitolo": "INGLESE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Portare grammar: ripassare 56, fare trad pag 57 , 59 n 26 28 ."
	},
	{
		"id_materia": 1000076,
		"data": "2025-11-11T08:50:01+01:00",
		"titolo": "both s writing 37 n.10, leggere 34 e fare es 5, pp. 198 numeri 6 e 7",
		"sottotitolo": "INGLESE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "both s writing 37 n.10, leggere 34 e fare es 5, pp. 198 numeri 6 e 7"
	},
	{
		"id_materia": 1000086,
		"data": "2025-11-10T12:45:01+01:00",
		"titolo": "Riprodurre la struttura dettagliata del Sole su un foglio A4 con le relative descrizioni. Studiare fino a pag. 21, possibili interrogazioni.",
		"sottotitolo": "SCIENZE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Riprodurre la struttura dettagliata del Sole su un foglio A4 con le relative descrizioni. Studiare fino a pag. 21, possibili interrogazioni."
	},
	{
		"id_materia": 1000094,
		"data": "2025-11-10T08:50:01+01:00",
		"titolo": "Studiare pp. 145-148.",
		"sottotitolo": "STORIA E GEOGRAFIA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Studiare pp. 145-148."
	},
	{
		"id_materia": 1000094,
		"data": "2025-11-10T08:50:01+01:00",
		"titolo": "Rispondere alle domande nn. 1-2-3 p. 149",
		"sottotitolo": "STORIA E GEOGRAFIA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Rispondere alle domande nn. 1-2-3 p. 149"
	},
	{
		"id_materia": 1000075,
		"data": "2025-11-07T12:45:01+01:00",
		"titolo": "Eseguire esercitazione n.1 presente su classroom",
		"sottotitolo": "INFORMATICA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Eseguire esercitazione n.1 presente su classroom"
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-07T08:50:01+01:00",
		"titolo": "studiare bene i verbi perch&eacute; li chiedo a tutti",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "studiare bene i verbi perch&eacute; li chiedo a tutti"
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-07T08:50:01+01:00",
		"titolo": "grammatica. studiare appunti e fare es pag. 196,197 e 198",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "grammatica. studiare appunti e fare es pag. 196,197 e 198"
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-07T08:50:01+01:00",
		"titolo": "epica: es 19 pag.180",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "epica: es 19 pag.180"
	},
	{
		"id_materia": 1000081,
		"data": "2025-11-07T07:55:01+01:00",
		"titolo": "MATEMATICA: STUDIARE e SCHEMTIZZARE da pag. 512 a pag. 515 + es. da pag. 526 n. 13, 18, 37, 41, 43, 51, 52, 57, 72, 74, 81",
		"sottotitolo": "MATEMATICA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "MATEMATICA: STUDIARE e SCHEMTIZZARE da pag. 512 a pag. 515 + es. da pag. 526 n. 13, 18, 37, 41, 43, 51, 52, 57, 72, 74, 81"
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-06T12:45:01+01:00",
		"titolo": "epica: leggere libro Baricco capitoletto di Criseide da pag. 15 a 20",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "epica: leggere libro Baricco capitoletto di Criseide da pag. 15 a 20"
	},
	{
		"id_materia": 1000081,
		"data": "2025-11-06T11:50:01+01:00",
		"titolo": "MATEMATICA: STUDIARE e SCHEMATIZZA pag. 426-427 (le funzioni: definizioni) + pag. 186-187 (relazioni: definizioni) + pag. 151-152 (quantificatori: definizioni e utilizzo)",
		"sottotitolo": "MATEMATICA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "MATEMATICA: STUDIARE e SCHEMATIZZA pag. 426-427 (le funzioni: definizioni) + pag. 186-187 (relazioni: definizioni) + pag. 151-152 (quantificatori: definizioni e utilizzo)"
	},
	{
		"id_materia": 1000090,
		"data": "2025-11-06T07:55:01+01:00",
		"titolo": "Studiare pag 32, es da 1 a 4 pag 32, , pag 261 tutta (tranne 16)",
		"sottotitolo": "SPAGNOLO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Studiare pag 32, es da 1 a 4 pag 32, , pag 261 tutta (tranne 16)"
	},
	{
		"id_materia": 1000094,
		"data": "2025-11-05T12:45:01+01:00",
		"titolo": "Studiare pp. 140-144. Riportare sul quaderno la cartina p. 141. Lavora con le fonti: scansionare il QR-code p. 143 leggere il brano &quot;La scoperta delle rovine di Troia&quot; e rispondere alla domande sul quaderno.",
		"sottotitolo": "STORIA E GEOGRAFIA",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Studiare pp. 140-144. Riportare sul quaderno la cartina p. 141. Lavora con le fonti: scansionare il QR-code p. 143 leggere il brano &quot;La scoperta delle rovine di Troia&quot; e rispondere alla domande sul quaderno."
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-05T10:55:01+01:00",
		"titolo": "interrogazione Tian e Zanin",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "interrogazione Tian e Zanin"
	},
	{
		"id_materia": 1000078,
		"data": "2025-11-05T10:55:01+01:00",
		"titolo": "grammatica: STUDIARE BENE tutti i modi e i tempi verbali e le voci dei verbi irregolari segnate in classe da pag. 189 a pag. 194",
		"sottotitolo": "ITALIANO",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "grammatica: STUDIARE BENE tutti i modi e i tempi verbali e le voci dei verbi irregolari segnate in classe da pag. 189 a pag. 194"
	},
	{
		"id_materia": 1000086,
		"data": "2025-11-05T09:45:01+01:00",
		"titolo": "Ricopiare ordinata la spirale di Fibonacci su un foglio a quadretti formato A4. Fare una breve ricerca in internet per capire come tale spirale disegna la natura. Cominciare a preparare la relazione di laboratorio.",
		"sottotitolo": "SCIENZE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Ricopiare ordinata la spirale di Fibonacci su un foglio a quadretti formato A4. Fare una breve ricerca in internet per capire come tale spirale disegna la natura. Cominciare a preparare la relazione di laboratorio."
	},
	{
		"id_materia": 1000076,
		"data": "2025-11-05T07:55:01+01:00",
		"titolo": "Finire 195 e fare 197 BOTH S",
		"sottotitolo": "INGLESE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Finire 195 e fare 197 BOTH S"
	},
	{
		"id_materia": 1000076,
		"data": "2025-11-04T08:50:01+01:00",
		"titolo": "both s p 35 n 8, pp 194 e 195(tranne numeri 6 7 8)",
		"sottotitolo": "INGLESE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "both s p 35 n 8, pp 194 e 195(tranne numeri 6 7 8)"
	},
	{
		"id_materia": 1000086,
		"data": "2025-11-03T12:45:01+01:00",
		"titolo": "Rifare il il diagramma H-R su un foglio da disegno. Dietro al foglio descrivere l&#039;evoluzione di una stella. Il lavoro va consegnato e sar&agrave; valutato. Possibili interrogazioni (sono accettati i volontari).",
		"sottotitolo": "SCIENZE",
		"dettaglio": "",
		"novita": false,
		"descrizione": "",
		"modulo": "",
		"assegnazioni": "Rifare il il diagramma H-R su un foglio da disegno. Dietro al foglio descrivere l&#039;evoluzione di una stella. Il lavoro va consegnato e sar&agrave; valutato. Possibili interrogazioni (sono accettati i volontari)."
	}
]
""";
    public static string CARLETTUCCINO_AGENDA_JSON = """
[
	{
		"id": 10980,
		"id_materia": null,
		"novita": true,
		"data": "2026-02-26T07:55:01+01:00",
		"data_fine": "2026-02-26T08:50:01+01:00",
		"titolo": "VERIFICA DI SPAGNOLO",
		"sottotitolo": "Comprensione del testo",
		"dettaglio": ""
	},
	{
		"id": 10985,
		"id_materia": null,
		"novita": true,
		"data": "2026-02-23T00:01:01+01:00",
		"data_fine": "2026-02-23T23:59:01+01:00",
		"titolo": "READING AND WRITING TEST",
		"sottotitolo": "",
		"dettaglio": ""
	},
	{
		"id": 10977,
		"id_materia": null,
		"novita": true,
		"data": "2026-02-06T08:00:00+01:00",
		"data_fine": "2026-02-06T15:31:01+01:00",
		"titolo": "Verifica di recupero Matematica per gli insufficienti primo periodo",
		"sottotitolo": "Matematica: Ostellari, Piovan, Sciortino, Tian.",
		"dettaglio": ""
	},
	{
		"id": 10408,
		"id_materia": null,
		"novita": false,
		"data": "2025-12-19T08:00:00+01:00",
		"data_fine": "2025-12-19T08:50:01+01:00",
		"titolo": "verifica di Teoria (durata 1 ora)",
		"sottotitolo": "voto di teoria: intervalli numerici, funzioni e grafici",
		"dettaglio": ""
	},
	{
		"id": 489,
		"id_materia": null,
		"novita": false,
		"data": "2025-12-15T09:15:00+01:00",
		"data_fine": "2025-12-15T10:50:00+01:00",
		"titolo": "PROTOCOLLO SCUOLA SICURA",
		"sottotitolo": "In teatro tutte le classi per cerimonia di consegna del Certificato &quot;Scuola Sicura FIDAE&quot;.\r\nPresenti molte autorit&agrave;",
		"dettaglio": ""
	},
	{
		"id": 10763,
		"id_materia": null,
		"novita": false,
		"data": "2025-12-12T13:12:01+01:00",
		"data_fine": "2025-12-12T13:12:01+01:00",
		"titolo": "tema in classe",
		"sottotitolo": "2h, vocabolario e foglio protocollo",
		"dettaglio": ""
	},
	{
		"id": 10765,
		"id_materia": null,
		"novita": false,
		"data": "2025-12-05T12:45:01+01:00",
		"data_fine": "2025-12-05T13:40:01+01:00",
		"titolo": "VERIFICA INFORMATICA",
		"sottotitolo": "Costruire un elaborato su word seguendo le indicazioni date",
		"dettaglio": ""
	},
	{
		"id": 10636,
		"id_materia": null,
		"novita": false,
		"data": "2025-11-26T00:01:00+01:00",
		"data_fine": "2025-11-26T23:59:01+01:00",
		"titolo": "compito di italiano",
		"sottotitolo": "grammatica: compito scritto sui nomi e sui verbi 1 h",
		"dettaglio": ""
	},
	{
		"id": 10679,
		"id_materia": null,
		"novita": false,
		"data": "2025-11-25T09:45:01+01:00",
		"data_fine": "2025-11-25T11:50:01+01:00",
		"titolo": "VERIFICA INFORMATICA",
		"sottotitolo": "Architettura del pc (Capitolo 3 del libro)",
		"dettaglio": ""
	},
	{
		"id": 10674,
		"id_materia": null,
		"novita": false,
		"data": "2025-11-20T07:55:01+01:00",
		"data_fine": "2025-11-20T08:50:01+01:00",
		"titolo": "VERIFICA DI SPAGNOLO",
		"sottotitolo": "Lessico: descrizione fisica e del carattere\r\nGrammatica: verbi regolari al presente e verbi riflessivi,  interrogativi, femminile, dimostrativi",
		"dettaglio": ""
	},
	{
		"id": 10676,
		"id_materia": null,
		"novita": false,
		"data": "2025-11-19T00:01:00+01:00",
		"data_fine": "2025-11-19T23:59:01+01:00",
		"titolo": "VERIFICA U 1 E 2",
		"sottotitolo": "Both sides u 1 e 2 : Vocaboli (18 22 30 34) e grammatica (184 185- 192 193) ; la grammatica &egrave; anche sul grammar (capitoli fatti in classe della U 4 E 7)",
		"dettaglio": ""
	},
	{
		"id": 10650,
		"id_materia": null,
		"novita": false,
		"data": "2025-11-18T11:50:01+01:00",
		"data_fine": "2025-11-18T13:40:01+01:00",
		"titolo": "Verifica di fisica",
		"sottotitolo": "Errori di misura e cifre significative: teoria + esercizi",
		"dettaglio": ""
	},
	{
		"id": 10634,
		"id_materia": null,
		"novita": false,
		"data": "2025-11-11T11:50:00+01:00",
		"data_fine": "2025-11-11T13:40:01+01:00",
		"titolo": "Verifica Bis di matematica FACOLTATIVA",
		"sottotitolo": "Espressioni di calcolo letterale",
		"dettaglio": ""
	},
	{
		"id": 10612,
		"id_materia": null,
		"novita": false,
		"data": "2025-11-06T08:50:00+01:00",
		"data_fine": "2025-11-06T09:45:01+01:00",
		"titolo": "Verifica di Geostoria",
		"sottotitolo": "Capitolo 3 \r\nCapitolo 4 (I Fenici)\r\nCapitolo &quot;L&#039;uomo sulla Terra&quot;.",
		"dettaglio": ""
	},
	{
		"id": 10406,
		"id_materia": null,
		"novita": false,
		"data": "2025-10-28T11:50:00+01:00",
		"data_fine": "2025-10-28T13:30:01+01:00",
		"titolo": "verifica di matematica: esercizi + teoria",
		"sottotitolo": "Esercizi: espressioni sul calcolo letterale (prodotti notevoli compresi). TEORIA : divisione tra polinomi, MCD e mcm tra monomi, segni di potenze di binomi,  esercizi sui prodotti notevoli particolari (trovare l&#039;elemento mancante per completare un prodotto notevole (quadrato di binomio, somma per differenza) e identificarlo)",
		"dettaglio": ""
	},
	{
		"id": 10211,
		"id_materia": null,
		"novita": false,
		"data": "2025-09-19T00:01:00+02:00",
		"data_fine": "2025-09-19T23:59:01+02:00",
		"titolo": "prova di ingresso di italiano valutata",
		"sottotitolo": "analisi e comprensione del testo e riassunto\r\nportare foglio protocollo",
		"dettaglio": ""
	},
	{
		"id": 10136,
		"id_materia": null,
		"novita": false,
		"data": "2025-09-16T11:50:01+02:00",
		"data_fine": "2025-09-16T13:30:01+02:00",
		"titolo": "1L - TEST INGRESSO MATEMATICA - VALUTATO",
		"sottotitolo": "Espressioni numeriche;   Calcolare il valore numerico di un&#039;espressione letterale; Valore Assoluto (o Modulo).",
		"dettaglio": ""
	}
]
""";
    public static string CARLETTUCCINO_LESSONS_JSON = """
[
	{
		"id_materia": 1000088,
		"data": "2025-11-06T10:55:02+01:00",
		"titolo": "SCIENZE MOTORIE E SPORTIVE",
		"sottotitolo": "",
		"dettaglio": "Spiegazione e schema alla lavagna sul regolamento e gesti tecnici della pallavolo.\r\nAll’aperto: giochi di squadra.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000088,
		"data": "2025-11-06T09:45:02+01:00",
		"titolo": "SCIENZE MOTORIE E SPORTIVE",
		"sottotitolo": "",
		"dettaglio": "Supplenza: laboratorio disegno a matita",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000094,
		"data": "2025-11-06T08:50:02+01:00",
		"titolo": "STORIA E GEOGRAFIA",
		"sottotitolo": "",
		"dettaglio": "Verifica di geostoria.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000090,
		"data": "2025-11-06T07:55:02+01:00",
		"titolo": "SPAGNOLO",
		"sottotitolo": "",
		"dettaglio": "Ripasso per la verifica.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000094,
		"data": "2025-11-05T12:45:02+01:00",
		"titolo": "STORIA E GEOGRAFIA",
		"sottotitolo": "",
		"dettaglio": "Ripasso per la verifica.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000071,
		"data": "2025-11-05T11:50:02+01:00",
		"titolo": "DISEGNO E STORIA DELL'ARTE",
		"sottotitolo": "",
		"dettaglio": "Laboratorio disegno a matita",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000073,
		"data": "2025-11-05T08:50:03+01:00",
		"titolo": "FISICA",
		"sottotitolo": "FISICA",
		"dettaglio": "esercizi per la verifica + ripasso teoria",
		"novita": false,
		"modulo": "FISICA"
	},
	{
		"id_materia": 1000081,
		"data": "2025-11-04T11:50:02+01:00",
		"titolo": "MATEMATICA",
		"sottotitolo": "MATEMATICA",
		"dettaglio": "spiegato raccoglimento totale e parziale",
		"novita": false,
		"modulo": "MATEMATICA"
	},
	{
		"id_materia": 1000075,
		"data": "2025-11-04T09:45:02+01:00",
		"titolo": "INFORMATICA",
		"sottotitolo": "Informatica",
		"dettaglio": "Memorie di massa",
		"novita": false,
		"modulo": "Informatica"
	},
	{
		"id_materia": 1000086,
		"data": "2025-11-04T07:55:02+01:00",
		"titolo": "SCIENZE",
		"sottotitolo": "",
		"dettaglio": "Nascita sistema solare e struttura del Sole",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000071,
		"data": "2025-11-03T11:50:02+01:00",
		"titolo": "DISEGNO E STORIA DELL'ARTE",
		"sottotitolo": "",
		"dettaglio": "Laboratorio di disegno",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000081,
		"data": "2025-11-03T09:45:02+01:00",
		"titolo": "MATEMATICA",
		"sottotitolo": "MATEMATICA",
		"dettaglio": "introdotto il nuovo argomento: le scomposizioni di polinomi",
		"novita": false,
		"modulo": "MATEMATICA"
	},
	{
		"id_materia": 1000094,
		"data": "2025-11-03T08:50:02+01:00",
		"titolo": "STORIA E GEOGRAFIA",
		"sottotitolo": "",
		"dettaglio": "La civiltà micenea.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000084,
		"data": "2025-11-03T07:55:01+01:00",
		"titolo": "RELIGIONE",
		"sottotitolo": "",
		"dettaglio": "Che cos'è la felicità?  Esiste?",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000075,
		"data": "2025-10-31T12:45:02+01:00",
		"titolo": "INFORMATICA",
		"sottotitolo": "Informatica",
		"dettaglio": "Introduzione a word (caratteri e font, colori e allineamento)",
		"novita": false,
		"modulo": "Informatica"
	},
	{
		"id_materia": 1000090,
		"data": "2025-10-31T11:50:02+01:00",
		"titolo": "SPAGNOLO",
		"sottotitolo": "Spagnolo",
		"dettaglio": "Verbi regolari al presente e riflessivi",
		"novita": false,
		"modulo": "Spagnolo"
	},
	{
		"id_materia": 1000078,
		"data": "2025-10-31T09:45:02+01:00",
		"titolo": "ITALIANO",
		"sottotitolo": "",
		"dettaglio": "esercizi pag. 174, introduzione  a Tersite",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000078,
		"data": "2025-10-31T08:50:02+01:00",
		"titolo": "ITALIANO",
		"sottotitolo": "",
		"dettaglio": "interrogazione, correzione esercizi, gli aggettivi",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000081,
		"data": "2025-10-31T07:55:02+01:00",
		"titolo": "MATEMATICA",
		"sottotitolo": "MATEMATICA e FISICA",
		"dettaglio": "rivisto il Triangolo di Tartaglia + iniziato la propagazione degli errori",
		"novita": false,
		"modulo": "MATEMATICA e FISICA"
	},
	{
		"id_materia": 1000081,
		"data": "2025-10-30T11:50:02+01:00",
		"titolo": "MATEMATICA",
		"sottotitolo": "MATEMATICA",
		"dettaglio": "corretto esercizi per casa sugli intervalli numerici + spiegato quantificatori e connettivi logici e loro utilizzo + rispiegato le relazioni",
		"novita": false,
		"modulo": "MATEMATICA"
	},
	{
		"id_materia": 1000088,
		"data": "2025-10-30T10:55:01+01:00",
		"titolo": "SCIENZE MOTORIE E SPORTIVE",
		"sottotitolo": "",
		"dettaglio": "Partita pallavolo.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000088,
		"data": "2025-10-30T09:45:01+01:00",
		"titolo": "SCIENZE MOTORIE E SPORTIVE",
		"sottotitolo": "",
		"dettaglio": "Esercizi individuali con la palla . Esercizi sulla precisione del palleggio. La battuta dal basso con direzione controllata nelle varie zone.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000094,
		"data": "2025-10-30T08:50:02+01:00",
		"titolo": "STORIA E GEOGRAFIA",
		"sottotitolo": "",
		"dettaglio": "I cretesi e la civiltà minoica.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000090,
		"data": "2025-10-30T07:55:02+01:00",
		"titolo": "SPAGNOLO",
		"sottotitolo": "Spagnolo",
		"dettaglio": "Correzione compiti per casa",
		"novita": false,
		"modulo": "Spagnolo"
	},
	{
		"id_materia": 1000094,
		"data": "2025-10-29T12:45:02+01:00",
		"titolo": "STORIA E GEOGRAFIA",
		"sottotitolo": "",
		"dettaglio": "Introduzione alla civiltà minoica e micenea.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000071,
		"data": "2025-10-29T11:50:02+01:00",
		"titolo": "DISEGNO E STORIA DELL'ARTE",
		"sottotitolo": "",
		"dettaglio": "L’antico Egitto, da P. 26 a P.32",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000078,
		"data": "2025-10-29T10:55:02+01:00",
		"titolo": "ITALIANO",
		"sottotitolo": "",
		"dettaglio": "interrogazione e analisi dei tempi verbali",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000086,
		"data": "2025-10-29T09:45:02+01:00",
		"titolo": "SCIENZE",
		"sottotitolo": "",
		"dettaglio": "Sezione aurea e sequenza di Fibonacci",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000073,
		"data": "2025-10-29T08:50:02+01:00",
		"titolo": "FISICA",
		"sottotitolo": "fisica",
		"dettaglio": "spiegato il concetto di precisione e accuratezza + scrittura di misure singole e serie di misurazioni",
		"novita": false,
		"modulo": "fisica"
	},
	{
		"id_materia": 1000081,
		"data": "2025-10-28T11:50:02+01:00",
		"titolo": "MATEMATICA",
		"sottotitolo": "MATEMATICA",
		"dettaglio": "verifica 2 ore",
		"novita": false,
		"modulo": "MATEMATICA"
	},
	{
		"id_materia": 1000075,
		"data": "2025-10-28T09:45:02+01:00",
		"titolo": "INFORMATICA",
		"sottotitolo": "Informatica",
		"dettaglio": "Memoria centrale in un computer",
		"novita": false,
		"modulo": "Informatica"
	},
	{
		"id_materia": 1000086,
		"data": "2025-10-27T12:45:02+01:00",
		"titolo": "SCIENZE",
		"sottotitolo": "",
		"dettaglio": "Diagramma  H-R",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000071,
		"data": "2025-10-27T11:50:02+01:00",
		"titolo": "DISEGNO E STORIA DELL'ARTE",
		"sottotitolo": "",
		"dettaglio": "Le antiche civiltà: Sumeri, Babilonesi, Assiri, Persiani.\r\nAppunti redatti in classe e trattati alla LIM con interventi degli studenti.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000081,
		"data": "2025-10-27T09:45:02+01:00",
		"titolo": "MATEMATICA",
		"sottotitolo": "MATEMATICA",
		"dettaglio": "ripasso espressioni per la verifica di domani",
		"novita": false,
		"modulo": "MATEMATICA"
	},
	{
		"id_materia": 1000084,
		"data": "2025-10-27T07:55:01+01:00",
		"titolo": "RELIGIONE",
		"sottotitolo": "",
		"dettaglio": "Confronto in classe sui lavori dei ragazzi sul Bullismo e successivamente sulla domanda \" Che cos'è la Religione e che cosa è per voi?",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000075,
		"data": "2025-10-24T12:45:02+02:00",
		"titolo": "INFORMATICA",
		"sottotitolo": "Informatica",
		"dettaglio": "Introduzione a suite Office",
		"novita": false,
		"modulo": "Informatica"
	},
	{
		"id_materia": 1000090,
		"data": "2025-10-24T11:50:03+02:00",
		"titolo": "SPAGNOLO",
		"sottotitolo": "Spagnolo",
		"dettaglio": "Lessico: stati fisici e d'animo. Verbi estar e tener",
		"novita": false,
		"modulo": "Spagnolo"
	},
	{
		"id_materia": 1000073,
		"data": "2025-10-24T10:55:02+02:00",
		"titolo": "FISICA",
		"sottotitolo": "fisica",
		"dettaglio": "interrogazioni programmate",
		"novita": false,
		"modulo": "fisica"
	},
	{
		"id_materia": 1000078,
		"data": "2025-10-24T08:50:02+02:00",
		"titolo": "ITALIANO",
		"sottotitolo": "",
		"dettaglio": "tema in classe, 2 h",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000081,
		"data": "2025-10-24T07:55:02+02:00",
		"titolo": "MATEMATICA",
		"sottotitolo": "matematica",
		"dettaglio": "interrogazioni programmate",
		"novita": false,
		"modulo": "matematica"
	},
	{
		"id_materia": 1000081,
		"data": "2025-10-23T11:50:02+02:00",
		"titolo": "MATEMATICA",
		"sottotitolo": "Matematica",
		"dettaglio": "Corretto esercizi per casa e visto come si fa l'unione tra intervalli numerici",
		"novita": false,
		"modulo": "Matematica"
	},
	{
		"id_materia": 1000088,
		"data": "2025-10-23T10:55:01+02:00",
		"titolo": "SCIENZE MOTORIE E SPORTIVE",
		"sottotitolo": "",
		"dettaglio": "Potenziamento pallavolo: fondamentali di gioco e schemi.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000088,
		"data": "2025-10-23T09:45:03+02:00",
		"titolo": "SCIENZE MOTORIE E SPORTIVE",
		"sottotitolo": "",
		"dettaglio": "Riscaldamento: andature coordinative. Esercizi di tonificazione muscolare a coppie . \r\nPotenziamento pallavolo: fondamentali di gioco e schemi.",
		"novita": false,
		"modulo": ""
	},
	{
		"id_materia": 1000094,
		"data": "2025-10-23T08:50:02+02:00",
		"titolo": "STORIA E GEOGRAFIA",
		"sottotitolo": "",
		"dettaglio": "Le migrazioni e il pianeta terra.",
		"novita": false,
		"modulo": ""
	}
]
""";
    public static string CARLETTUCCINO_ANNOTATIONS_JSON = """
[
	{
		"id_materia": 1000078,
		"data": "2025-11-21T12:00:00+01:00",
		"simbolo": "+",
		"descrizione_simbolo": "Annotazione positiva",
		"colore_simbolo": "#0000FF",
		"novita": false,
		"titolo": "ITALIANO",
		"sottotitolo": "ITALISA",
		"dettaglio": ""
	},
	{
		"id_materia": 1000086,
		"data": "2025-09-24T12:00:00+02:00",
		"simbolo": "+",
		"descrizione_simbolo": "Annotazione positiva",
		"colore_simbolo": "#0000FF",
		"novita": false,
		"titolo": "SCIENZE",
		"sottotitolo": "SCENZE",
		"dettaglio": ""
	}
]
""";
    public static string CARLETTUCCINO_COMUNICATION_THREAD_JSON = """
[
	{
		"id": "1362_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-27T15:52:26+01:00",
		"titolo": "Viaggio Istruzione a Parigi 9-14 febbraio 2026",
		"sottotitolo": "PRINCIPAL BOY",
		"mittente": {
			"id_mittente": null,
			"cognome": "PRINCIPAL BOY",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-27T17:33:56+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1365
	},
	{
		"id": "1354_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-26T14:06:45+01:00",
		"titolo": "Corso di recupero di scienze classe 1 Liceo",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-26T14:44:40+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1357
	},
	{
		"id": "1353_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-26T12:53:16+01:00",
		"titolo": "Incontro in Teatro per spiegazione Musei",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-26T13:03:44+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1356
	},
	{
		"id": "1352_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-26T11:21:51+01:00",
		"titolo": "uscita didattica",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-26T11:53:48+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1355
	},
	{
		"id": "1348_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-23T09:16:38+01:00",
		"titolo": "Circolare 60 - Sportello Psicologico",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-23T11:36:45+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1351
	},
	{
		"id": "1345_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-22T14:01:40+01:00",
		"titolo": "Weekend neve",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-22T14:50:17+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1348
	},
	{
		"id": "1340_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-15T10:28:27+01:00",
		"titolo": "Circolare 57 - Uscita didattica Biennio",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-15T10:47:18+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1343
	},
	{
		"id": "1338_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-14T09:05:04+01:00",
		"titolo": "INDICAZIONI WEEKEND NEVE",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-14T10:08:42+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1341
	},
	{
		"id": "1337_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-13T14:35:48+01:00",
		"titolo": "viaggio Parigi",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-13T14:50:14+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1340
	},
	{
		"id": "1334_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-12T12:41:09+01:00",
		"titolo": "54 - Circolare iscrizioni 2026-2027",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-12T12:51:47+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1337
	},
	{
		"id": "1332_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-12T08:32:51+01:00",
		"titolo": "Circolare 43 - 53 SPORTELLO BULLISMO",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-12T09:01:42+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1335
	},
	{
		"id": "1323_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2026-01-05T11:22:44+01:00",
		"titolo": "Inizio Corsi di recupero dal 7 gennaio 2026",
		"sottotitolo": "PRINCIPAL BOY",
		"mittente": {
			"id_mittente": null,
			"cognome": "PRINCIPAL BOY",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2026-01-16T13:07:38+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1326
	},
	{
		"id": "1316_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-22T12:10:24+01:00",
		"titolo": "VACANZA STUDIO",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-22T13:38:49+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1319
	},
	{
		"id": "1315_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-22T11:10:00+01:00",
		"titolo": "Circolare 52 - CORSI DI RECUPERO",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-22T11:21:01+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1318
	},
	{
		"id": "1312_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-22T10:45:09+01:00",
		"titolo": "Circolare 41-51 Auguri di Natale",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-22T10:53:53+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1315
	},
	{
		"id": "1311_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-22T08:46:46+01:00",
		"titolo": "USCITA ANTICIPATA",
		"sottotitolo": "SEGRETERIA GIRL 2",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL 2",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-22T10:54:29+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1314
	},
	{
		"id": "1289_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-18T08:12:49+01:00",
		"titolo": "Circolare 48 - Programma Viaggio a Parigi",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-18T10:43:41+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1292
	},
	{
		"id": "1280_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-15T12:42:05+01:00",
		"titolo": "Documento di valutazione",
		"sottotitolo": "SEGRETERIA GIRL 2",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL 2",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-15T12:55:29+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1283
	},
	{
		"id": "1275_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-11T11:30:42+01:00",
		"titolo": "Evento Scuola Sicura lunedì 15 dicembre ore 9.15",
		"sottotitolo": "PRINCIPAL BOY",
		"mittente": {
			"id_mittente": null,
			"cognome": "PRINCIPAL BOY",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-11T11:41:33+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1278
	},
	{
		"id": "1274_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-09T09:49:17+01:00",
		"titolo": "Circolare 47 - Chiusura Trimestre - Pagella - Colloqui Pomeridiani",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-09T10:07:35+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1277
	},
	{
		"id": "1266_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-04T12:04:39+01:00",
		"titolo": "VACANZA STUDIO",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-04T12:40:30+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1269
	},
	{
		"id": "1257_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-12-02T10:17:26+01:00",
		"titolo": "weekend in montagna",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-12-02T10:50:47+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1260
	},
	{
		"id": "1245_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-26T14:28:15+01:00",
		"titolo": "Entrata Posticipata 1 Liceo",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-26T14:38:55+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1248
	},
	{
		"id": "1240_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-25T12:36:30+01:00",
		"titolo": "viaggio a Parigi",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-25T13:31:24+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1243
	},
	{
		"id": "1236_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-24T12:14:55+01:00",
		"titolo": "Circolare weekend in montagna",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-24T12:23:07+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1239
	},
	{
		"id": "1235_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-24T12:10:26+01:00",
		"titolo": "Circolare 44 - Pubblicazione documenti ufficiali",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-24T12:23:12+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1238
	},
	{
		"id": "1222_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-20T13:00:35+01:00",
		"titolo": "cambio data verifica di grammatica",
		"sottotitolo": "ITALIAN PROFS",
		"mittente": {
			"id_mittente": null,
			"cognome": "ITALIAN PROFS",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-20T13:42:07+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1225
	},
	{
		"id": "1217_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-17T15:34:36+01:00",
		"titolo": "Evento Protocollo SCUOLA SICURA 15 dicembre 2025",
		"sottotitolo": "PRINCIPAL BOY",
		"mittente": {
			"id_mittente": null,
			"cognome": "PRINCIPAL BOY",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-17T15:45:19+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 2,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1220
	},
	{
		"id": "1208_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-14T11:38:43+01:00",
		"titolo": "Circolare 34 - 40 Vacanza Studio - Chiarimenti",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-14T11:56:22+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1211
	},
	{
		"id": "1201_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-13T09:43:02+01:00",
		"titolo": "Circolare 34 - 40 - Vacanza Studio Chiarimenti",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-13T16:44:27+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1204
	},
	{
		"id": "1196_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-11T07:45:11+01:00",
		"titolo": "GIORNALINO SCOLASTICO",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-11T07:56:18+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1199
	},
	{
		"id": "1195_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-10T08:45:16+01:00",
		"titolo": "INCONTRO PER VACANZA STUDIO",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-10T09:41:07+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1198
	},
	{
		"id": "1183_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-04T08:57:59+01:00",
		"titolo": "Circolare 31 -33 Plebiscito",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-04T09:10:45+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1186
	},
	{
		"id": "1181_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-03T14:03:07+01:00",
		"titolo": "LABORATORIO TEATRALE",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-03T14:34:09+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1184
	},
	{
		"id": "1179_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-11-03T09:16:30+01:00",
		"titolo": "Circolare VACANZA STUDIO",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-11-03T09:41:21+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1182
	},
	{
		"id": "1174_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-30T09:13:39+01:00",
		"titolo": "Circolare 31 - Inadempienza Regolamento",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-30T09:51:44+01:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1177
	},
	{
		"id": "1160_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-24T09:07:43+02:00",
		"titolo": "Circolare 28 - Rappresentanti Eletti",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-24T10:15:06+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1163
	},
	{
		"id": "1158_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-24T08:27:02+02:00",
		"titolo": "Circolare 26 - 27  Acquisto T-shirt e Felpa",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-24T08:48:32+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1161
	},
	{
		"id": "1136_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-20T09:29:23+02:00",
		"titolo": "Circolare 24 - Laboratorio Arti Sceniche",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-20T10:46:51+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1139
	},
	{
		"id": "1125_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-17T13:36:16+02:00",
		"titolo": "Colloqui con i docenti",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-17T13:53:59+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1128
	},
	{
		"id": "1118_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-15T08:18:33+02:00",
		"titolo": "Incontro Genitori Secondaria 2 grado",
		"sottotitolo": "PRINCIPAL BOY",
		"mittente": {
			"id_mittente": null,
			"cognome": "PRINCIPAL BOY",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-15T08:41:57+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1121
	},
	{
		"id": "1116_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-13T15:59:35+02:00",
		"titolo": "adozione libro",
		"sottotitolo": "ITALIAN PROFS",
		"mittente": {
			"id_mittente": null,
			"cognome": "ITALIAN PROFS",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-13T16:10:54+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1119
	},
	{
		"id": "1105_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-09T07:46:22+02:00",
		"titolo": "Assemblea Famiglie martedì 14 ottobre ore 18.00",
		"sottotitolo": "PRINCIPAL BOY",
		"mittente": {
			"id_mittente": null,
			"cognome": "PRINCIPAL BOY",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-09T08:17:29+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1108
	},
	{
		"id": "1102_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-08T09:24:29+02:00",
		"titolo": "Circolare 17 - Ed. Civica c/o il Cinema",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-08T10:51:23+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1105
	},
	{
		"id": "1101_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-08T08:25:38+02:00",
		"titolo": "Viaggio di Istruzione a Parigi",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-08T09:03:38+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1104
	},
	{
		"id": "1078_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-06T12:28:35+02:00",
		"titolo": "18 - Elezioni Rappresentanti di Classe",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-06T12:55:25+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1081
	},
	{
		"id": "1074_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-04T08:35:08+02:00",
		"titolo": "Lettorato di inglese",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-04T18:53:51+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1077
	},
	{
		"id": "1073_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-03T11:49:20+02:00",
		"titolo": "Viaggio di istruzione a Parigi",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-03T11:59:40+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1076
	},
	{
		"id": "1071_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-02T12:36:20+02:00",
		"titolo": "Circolare 16 - Colloqui docenti",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-02T12:48:36+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1074
	},
	{
		"id": "1068_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-01T10:55:58+02:00",
		"titolo": "Circolare 14 e 16 Voto comportamento",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-01T12:29:26+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1071
	},
	{
		"id": "1066_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-10-01T10:40:17+02:00",
		"titolo": "Circolare 14 e 16  Voto comportamento",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-10-01T12:29:18+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1069
	},
	{
		"id": "1059_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-24T13:49:43+02:00",
		"titolo": "CIRCOLARE LETTORATO INGLESE",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-24T14:02:54+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1062
	},
	{
		"id": "1051_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-22T12:32:51+02:00",
		"titolo": "Circolare 9 - RTS Matematica",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-22T13:35:15+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1054
	},
	{
		"id": "1050_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-22T09:17:47+02:00",
		"titolo": "Circolare 8 - Viaggio di istruzione a Parigi",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-22T09:28:43+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1053
	},
	{
		"id": "1047_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-19T13:22:59+02:00",
		"titolo": "pellegrinaggio a Roma",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-19T13:52:35+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1050
	},
	{
		"id": "1045_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-18T08:39:53+02:00",
		"titolo": "Circolare 7 - Indicazioni Regolamento per sanzioni cellulare",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-18T12:08:02+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1048
	},
	{
		"id": "1040_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-16T10:19:26+02:00",
		"titolo": "PELLEGRINAGGIO A ROMA",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-16T10:32:22+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1043
	},
	{
		"id": "1039_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-15T14:02:54+02:00",
		"titolo": "INIZIO SERVIZIO MENSA",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-15T18:01:36+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 0,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1042
	},
	{
		"id": "1036_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-15T09:30:29+02:00",
		"titolo": "Circolare 4 - USO CELLULARE",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-15T18:01:50+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1039
	},
	{
		"id": "1034_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-12T10:46:58+02:00",
		"titolo": "Circolare 3 - Merende e Varie",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-12T23:40:14+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 1,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1037
	},
	{
		"id": "1032_ver_2",
		"id_materia": -1,
		"novita": false,
		"data": "2025-09-08T12:46:21+02:00",
		"titolo": "orario A.S. 2025-26",
		"sottotitolo": "SEGRETERIA GIRL",
		"mittente": {
			"id_mittente": null,
			"cognome": "SEGRETERIA GIRL",
			"nome": ""
		},
		"presa_visione": -1,
		"da_leggere": false,
		"data_lettura": "2025-09-11T21:16:37+02:00",
		"data_presa_visione": null,
		"sottoscrizione": -1,
		"allegati": 2,
		"tipo_messaggio": "NORMALE",
		"destinatari_concatenati": "",
		"conferma_lettura": false,
		"id_messaggio": 1035
	}
]
""";
    public static string CARLETTUCCINO_COMUNICATION_USER_JSON = """
[
	{
		"id": "3000168@amministratore",
		"id_utente": "3000168",
		"descrizione": "segret (Ammin.)",
		"ordinamento": 0,
		"gruppo": "Amministratori"
	},
	{
		"id": "3000222@amministratore",
		"id_utente": "3000222",
		"descrizione": "seget (Ammin.)",
		"ordinamento": 1,
		"gruppo": "Amministratori"
	},
	{
		"id": "3000250@amministratore",
		"id_utente": "3000250",
		"descrizione": "sugrut (Ammin.)",
		"ordinamento": 2,
		"gruppo": "Amministratori"
	},
	{
		"id": "3000146@docente",
		"id_utente": "3000146",
		"descrizione": "abc (Doc.)",
		"ordinamento": 3,
		"gruppo": "Professori"
	},
	{
		"id": "3000219@docente",
		"id_utente": "3000219",
		"descrizione": "ab (Doc.)",
		"ordinamento": 4,
		"gruppo": "Professori"
	},
	{
		"id": "3000150@docente",
		"id_utente": "3000150",
		"descrizione": "asdasd (Doc.)",
		"ordinamento": 5,
		"gruppo": "Professori"
	},
	{
		"id": "3000152@docente",
		"id_utente": "3000152",
		"descrizione": "asdasd (Doc.)",
		"ordinamento": 6,
		"gruppo": "Professori"
	},
	{
		"id": "3000154@docente",
		"id_utente": "3000154",
		"descrizione": "asdasd (Doc.)",
		"ordinamento": 7,
		"gruppo": "Professori"
	},
	{
		"id": "3000158@docente",
		"id_utente": "3000158",
		"descrizione": "asdasd (Doc.)",
		"ordinamento": 8,
		"gruppo": "Professori"
	},
	{
		"id": "3000220@docente",
		"id_utente": "3000220",
		"descrizione": "asddas (Doc.)",
		"ordinamento": 9,
		"gruppo": "Professori"
	},
	{
		"id": "3000162@docente",
		"id_utente": "3000162",
		"descrizione": "asdasd (Doc.)",
		"ordinamento": 10,
		"gruppo": "Professori"
	},
	{
		"id": "3000163@docente",
		"id_utente": "3000163",
		"descrizione": "asdasd (Doc.)",
		"ordinamento": 11,
		"gruppo": "Professori"
	},
	{
		"id": "3000230@docente",
		"id_utente": "3000230",
		"descrizione": "asdads (Doc.)",
		"ordinamento": 12,
		"gruppo": "Professori"
	}
]
""";
    public static string CARLETTUCCINO_REPORT_CARD_JSON = """
[
	{
		"novita": false,
		"data": "2025-12-11T14:48:57+01:00",
		"titolo": "Pagella Fine 1° Trimestre",
		"sottotitolo": "",
		"dettaglio": "\n\n\n\n\n<div id='main-pagella-container'>\n        \n        \n        <div class='materia-container materia-1'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Disegno E Storia Dell&#039;Arte\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    \n    <div class='voto dati-pagella col-1'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>sette</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0:55\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-2'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Ed. Civica\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n                <div class='voto dati-pagella'>\n    <div class='valore-voto'>otto</div>\n</div>\n\n            \n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-3'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Fisica\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Scritto</h6>\n        <div class='valore-voto'>nove</div>\n    </div>\n    \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>dieci</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-4'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Informatica\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Scritto</h6>\n        <div class='valore-voto'>nove</div>\n    </div>\n    \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>nove</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-5'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Inglese\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Scritto</h6>\n        <div class='valore-voto'>dieci</div>\n    </div>\n    \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>dieci</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0:55\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-6'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Italiano\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Scritto</h6>\n        <div class='valore-voto'>otto</div>\n    </div>\n    \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>otto</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-7'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Matematica\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Scritto</h6>\n        <div class='valore-voto'>dieci</div>\n    </div>\n    \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>nove</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0:55\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-8'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Religione\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    \n    <div class='voto dati-pagella col-1'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>Discreto</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0:55\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-9'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Scienze\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Scritto</h6>\n        <div class='valore-voto'>otto</div>\n    </div>\n    \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>otto</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0:55\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-10'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Scienze Motorie E Sportive\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n                <div class='voto dati-pagella'>\n    <div class='valore-voto'>sex</div>\n</div>\n\n            \n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-11'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Spagnolo\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Scritto</h6>\n        <div class='valore-voto'>nove</div>\n    </div>\n    \n    \n    <div class='voto dati-pagella col-2'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>otto</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-12'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Storia E Geografia\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n            \n                \n    \n    \n    <div class='voto dati-pagella col-1'>\n        <h6>Orale</h6>\n        <div class='valore-voto'>sette</div>\n    </div>\n    \n    \n\n\n            \n            </div>\n            \n<div class='materia-riga'>\n    Ore assenza: 0:55\n</div>\n\n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        <div class='materia-container materia-13'>\n\n            <div class='materia-header'>\n                <div class='materia-title'>\n                Comportamento\n                </div>\n\n            </div>\n            <div class='materia-main'>\n            \n                <div class='voto dati-pagella'>\n    <div class='valore-voto'>dieci</div>\n</div>\n\n            \n            \n            </div>\n            \n            \n    \n\n            \n        </div>\n        <div class='separator'></div>\n        \n        \n<div class='campi-liberi media-campi-liberi'>\n<h5>Valutazione intermedia</h5>\n\n<div class='materia-riga even  last '>\n\n        <h4>COMUNICAZIONI </h4>\n\n        Il processo degli apprendimenti risulta autonomo, con delle conoscenze ottime e delle capacit&agrave; consolidate; ha acquisito competenze avanzate. La situazione complessiva &egrave;  eccellente e si consiglia di continuare nell&#039;impegno scolastico.\n\n\n</div>\n<div class='separator'></div>\n\n\n</div>\n\n\n</div>\n\n\n\n<div class='materia-riga piede'>\n    E&#039; necessario scaricare il file allegato sottostante per la visione completa della pagella.\n</div>\n\n\n",
		"allegati": [
			{
				"descrizione": "CARLETTUCCINO - Pagella 1Â° periodo 2025-2026.pdf",
				"allegato": "carlu.com/pagella.html"
			}
		],
		"template": "personalizzato_report"
	}
]
""";
    public static string CARLETTUCCINO_ABSENCES_JSON = """
[
	{
		"id": 1076748,
		"novita": false,
		"data": "2025-12-11T00:00:00+01:00",
		"simbolo": "A",
		"titolo": "Assenza del 11-12-2025",
		"colore_simbolo": "#00CC00",
		"sottotitolo": null,
		"giustificabile": false,
		"giustificata": "SI",
		"dettaglio": null,
		"tipo_assenza": "assenza",
		"motivazione": "",
		"prenotazione": false
	},
	{
		"id": 1076614,
		"novita": false,
		"data": "2025-12-05T00:00:00+01:00",
		"simbolo": "U",
		"titolo": "Uscita anticipata del 05-12-2025 ore 12:11",
		"colore_simbolo": "#00CC00",
		"sottotitolo": null,
		"giustificabile": false,
		"giustificata": "SI",
		"dettaglio": null,
		"tipo_assenza": "assenza",
		"motivazione": "",
		"prenotazione": false
	},
	{
		"id": 1076131,
		"novita": false,
		"data": "2025-11-24T00:00:00+01:00",
		"simbolo": "A",
		"titolo": "Assenza del 24-11-2025",
		"colore_simbolo": "#00CC00",
		"sottotitolo": null,
		"giustificabile": false,
		"giustificata": "SI",
		"dettaglio": null,
		"tipo_assenza": "assenza",
		"motivazione": "",
		"prenotazione": false
	}
]
""";
    #endregion
}