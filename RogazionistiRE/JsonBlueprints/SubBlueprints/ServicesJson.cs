using System.Text.Json.Serialization;

namespace RogazionistiRE.JsonBlueprints.SubBlueprints;

public class ServicesJson {
    [JsonPropertyName("agenda")]               public bool Agenda                { get; set; }
    [JsonPropertyName("alternanza")]           public bool WorkBasedLearning     { get; set; }
    [JsonPropertyName("annotazioni")]          public bool Annotations           { get; set; }
    [JsonPropertyName("argomenti")]            public bool Topics                { get; set; }
    [JsonPropertyName("assenze")]              public bool Absences              { get; set; }
    [JsonPropertyName("assenze_dad")]          public bool RemoteAbsences        { get; set; }
    [JsonPropertyName("colloqui_individuali")] public bool IndividualMeetings    { get; set; }
    [JsonPropertyName("colloqui_generali")]    public bool GeneralMeetings       { get; set; }
    [JsonPropertyName("compiti")]              public bool Homework              { get; set; }
    [JsonPropertyName("elenco_professori")]    public bool TeachersList          { get; set; }
    [JsonPropertyName("mense")]                public bool Canteens              { get; set; }
    [JsonPropertyName("messaggi")]             public bool Messages              { get; set; }
    [JsonPropertyName("note")]                 public bool Notes                 { get; set; }
    [JsonPropertyName("presa_visione_note")]   public bool NotesAcknowledgement  { get; set; }
    [JsonPropertyName("orario")]               public bool Timetable             { get; set; }
    [JsonPropertyName("pagamenti")]            public bool Payments              { get; set; }
    [JsonPropertyName("pagelle")]              public bool ReportCards           { get; set; }
    [JsonPropertyName("storico")]              public bool History               { get; set; }
    [JsonPropertyName("voti")]                 public bool Grades                { get; set; }
    [JsonPropertyName("presa_visione_voti")]   public bool GradesAcknowledgement { get; set; }
    [JsonPropertyName("elezioni")]             public bool Elections             { get; set; }
    [JsonPropertyName("documenti")]            public bool Documents             { get; set; }
    [JsonPropertyName("servizi_giornalieri")]  public bool DailyServices         { get; set; }
    [JsonPropertyName("materiale_didattico")]  public bool TeachingMaterials     { get; set; }
    [JsonPropertyName("verifiche")]            public bool Tests                 { get; set; }
    [JsonPropertyName("portale_iscrizioni")]   public bool EnrollmentPortal      { get; set; }
    [JsonPropertyName("competenze")]           public bool Skills                { get; set; }
    [JsonPropertyName("comunicazioni")]        public bool Communications        { get; set; }
    [JsonPropertyName("messaggi_inviati")]     public bool SentMessages          { get; set; }
    [JsonPropertyName("cambio_password")]      public bool ChangePassword        { get; set; }
    [JsonPropertyName("recupero_password")]    public bool PasswordRecovery      { get; set; }
    [JsonPropertyName("banner")]               public bool Banner                { get; set; }
    [JsonPropertyName("notizie")]              public bool News                  { get; set; }
    [JsonPropertyName("videomeeting")]         public bool VideoMeetings         { get; set; }
    [JsonPropertyName("note_tutor")]           public bool TutorNotes            { get; set; }
    [JsonPropertyName("colloqui")]             public bool Meetings              { get; set; }
}

